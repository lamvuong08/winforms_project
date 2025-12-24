using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace NhaKhoa.DAL
{
    public class BenhNhanDAL
    {
        public List<Models.BenhNhan> GetAll()
        {
            using (var ctx = new NhaKhoaContext())
            {
                return ctx.BenhNhans.ToList();
            }
        }

        public Models.BenhNhan GetById(string maBN)
        {
            using (var ctx = new NhaKhoaContext())
            {
                return ctx.BenhNhans.SingleOrDefault(x => x.MaBN == maBN);
            }
        }

        public List<Models.BenhNhan> Search(string ma = "", string ten = "", string sdt = "")
        {
            using (var ctx = new NhaKhoaContext())
            {
                var query = ctx.BenhNhans.AsQueryable();

                if (!string.IsNullOrWhiteSpace(ma))
                    query = query.Where(x => x.MaBN.Contains(ma));

                if (!string.IsNullOrWhiteSpace(ten))
                    query = query.Where(x => x.TenBN.Contains(ten));

                if (!string.IsNullOrWhiteSpace(sdt))
                    query = query.Where(x => x.SDT.Contains(sdt));

                return query.ToList();
            }
        }

        public List<Models.BenhNhan> GetByTrangThai(string trangThai)
        {
            using (var ctx = new NhaKhoaContext())
            {
                // Giả sử có cột TrangThai trong DB, nếu không có thì bỏ hàm này
                return ctx.BenhNhans
                          .Where(x => x.LyDoKham.Contains(trangThai)) // Tạm thời dùng LyDoKham, bạn có thể thêm property TrangThai vào Model
                          .OrderBy(x => x.NgayKham)
                          .ToList();
            }
        }

        public string GetNewMaBN()
        {
            using (var ctx = new NhaKhoaContext())
            {
                var last = ctx.BenhNhans
                              .Where(x => x.MaBN.StartsWith("BN"))
                              .ToList();

                if (!last.Any()) return "BN001";

                int max = last
                    .Select(x =>
                    {
                        int n;
                        return int.TryParse(x.MaBN.Substring(2), out n) ? n : 0;
                    })
                    .Max();

                return "BN" + (max + 1).ToString("D3");
            }
        }

        public void Insert(Models.BenhNhan bn)
        {
            using (var ctx = new NhaKhoaContext())
            {
                ctx.BenhNhans.Add(bn);
                ctx.SaveChanges();
            }
        }

        public void Update(Models.BenhNhan bn)
        {
            using (var ctx = new NhaKhoaContext())
            {
                ctx.Entry(bn).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void Delete(string maBN)
        {
            using (var ctx = new NhaKhoaContext())
            {
                var entity = ctx.BenhNhans.SingleOrDefault(x => x.MaBN == maBN);
                if (entity == null) return;

                ctx.BenhNhans.Remove(entity);
                ctx.SaveChanges();
            }
        }
    }
}
