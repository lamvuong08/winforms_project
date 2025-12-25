using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace NhaKhoa.DAL
{
    public class ChanDoanDAL
    {
        public List<Models.ChanDoan> GetAll()
        {
            using (var ctx = new NhaKhoaContext())
            {
                return ctx.ChanDoans.ToList();
            }
        }

        public Models.ChanDoan GetById(string maCD)
        {
            using (var ctx = new NhaKhoaContext())
            {
                return ctx.ChanDoans.SingleOrDefault(x => x.MaCD == maCD);
            }
        }

        public List<Models.ChanDoan> SearchByName(string ten)
        {
            using (var ctx = new NhaKhoaContext())
            {
                return ctx.ChanDoans
                          .Where(x => x.TenChuanDoan.Contains(ten))
                          .ToList();
            }
        }

        public string GetNewMaCD()
        {
            using (var ctx = new NhaKhoaContext())
            {
                var last = ctx.ChanDoans
                              .Where(x => x.MaCD != null && x.MaCD.StartsWith("CD"))
                              .ToList();

                if (!last.Any()) return "CD001";

                int max = last
                    .Select(x =>
                    {
                        int n;
                        return int.TryParse(x.MaCD.Substring(2), out n) ? n : 0;
                    })
                    .Max();

                return "CD" + (max + 1).ToString("D3");
            }
        }

        public void Insert(Models.ChanDoan cd)
        {
            using (var ctx = new NhaKhoaContext())
            {
                try
                {
                    // MaLS là required trong database, không được null
                    // Kiểm tra MaLS có tồn tại trong LAMSAN không
                    if (!string.IsNullOrWhiteSpace(cd.MaLS))
                    {
                        var lamSanExists = ctx.LamSans.Any(l => l.MaLS == cd.MaLS);
                        if (!lamSanExists)
                            throw new ArgumentException($"Mã lâm sàng {cd.MaLS} không tồn tại trong bảng LAMSAN");
                    }
                    
                    // Tạo một entity mới để tránh lỗi tracking
                    var newEntity = new Models.ChanDoan
                    {
                        MaCD = cd.MaCD,
                        TenChuanDoan = cd.TenChuanDoan,
                        MaLS = cd.MaLS // Phải có giá trị (NOT NULL)
                    };
                    
                    ctx.ChanDoans.Add(newEntity);
                    ctx.SaveChanges();
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                {
                    var innerEx = ex.InnerException?.InnerException;
                    string errorMsg = innerEx?.Message ?? ex.Message;
                    
                    // Kiểm tra lỗi foreign key constraint
                    if (errorMsg.Contains("FK_CHANDOAN_LAMSAN") || errorMsg.Contains("foreign key"))
                        throw new Exception($"Mã lâm sàng {cd.MaLS} không tồn tại trong bảng LAMSAN. Vui lòng kiểm tra lại.", ex);
                    
                    throw new Exception($"Lỗi khi thêm chẩn đoán: {errorMsg}", ex);
                }
            }
        }

        public void Update(Models.ChanDoan cd)
        {
            using (var ctx = new NhaKhoaContext())
            {
                try
                {
                    // Kiểm tra MaLS có tồn tại trong LAMSAN không
                    if (!string.IsNullOrWhiteSpace(cd.MaLS))
                    {
                        var lamSanExists = ctx.LamSans.Any(l => l.MaLS == cd.MaLS);
                        if (!lamSanExists)
                            throw new ArgumentException($"Mã lâm sàng {cd.MaLS} không tồn tại trong bảng LAMSAN");
                    }
                    
                    var existing = ctx.ChanDoans.SingleOrDefault(x => x.MaCD == cd.MaCD);
                    if (existing == null)
                        throw new ArgumentException($"Không tìm thấy chẩn đoán với mã {cd.MaCD}");

                    existing.TenChuanDoan = cd.TenChuanDoan;
                    existing.MaLS = cd.MaLS; // Phải có giá trị (NOT NULL)

                    ctx.SaveChanges();
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                {
                    var innerEx = ex.InnerException?.InnerException;
                    string errorMsg = innerEx?.Message ?? ex.Message;
                    
                    // Kiểm tra lỗi foreign key constraint
                    if (errorMsg.Contains("FK_CHANDOAN_LAMSAN") || errorMsg.Contains("foreign key"))
                        throw new Exception($"Mã lâm sàng {cd.MaLS} không tồn tại trong bảng LAMSAN. Vui lòng kiểm tra lại.", ex);
                    
                    throw new Exception($"Lỗi khi cập nhật chẩn đoán: {errorMsg}", ex);
                }
            }
        }

        public void Delete(string maCD)
        {
            using (var ctx = new NhaKhoaContext())
            {
                var entity = ctx.ChanDoans.SingleOrDefault(x => x.MaCD == maCD);
                if (entity == null) return;

                ctx.ChanDoans.Remove(entity);
                ctx.SaveChanges();
            }
        }
    }
}
