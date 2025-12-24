using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace NhaKhoa.DAL
{
    public class ChuanDoanDAL
    {
        public List<Models.ChuanDoan> GetAll()
        {
            using (var ctx = new NhaKhoaContext())
            {
                return ctx.ChuanDoans
                          .Include(x => x.BenhNhan)
                          .Include(x => x.NhanVien)
                          .ToList();
            }
        }

        public List<Models.ChuanDoan> GetByMaBN(string maBN)
        {
            using (var ctx = new NhaKhoaContext())
            {
                return ctx.ChuanDoans
                          .Where(x => x.MaBN == maBN)
                          .OrderByDescending(x => x.NgayChuanDoan)
                          .ToList();
            }
        }

        public Models.ChuanDoan GetById(string maCD)
        {
            using (var ctx = new NhaKhoaContext())
            {
                return ctx.ChuanDoans
                          .Include(x => x.BenhNhan)
                          .Include(x => x.NhanVien)
                          .SingleOrDefault(x => x.MaCD == maCD);
            }
        }

        public string GetNewMaCD()
        {
            using (var ctx = new NhaKhoaContext())
            {
                var last = ctx.ChuanDoans
                              .Where(x => x.MaCD.StartsWith("CD"))
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

        public void Insert(Models.ChuanDoan cd)
        {
            using (var ctx = new NhaKhoaContext())
            {
                ctx.ChuanDoans.Add(cd);
                ctx.SaveChanges();
            }
        }

        public void Update(Models.ChuanDoan cd)
        {
            using (var ctx = new NhaKhoaContext())
            {
                ctx.Entry(cd).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void Delete(string maCD)
        {
            using (var ctx = new NhaKhoaContext())
            {
                var entity = ctx.ChuanDoans.SingleOrDefault(x => x.MaCD == maCD);
                if (entity == null) return;

                ctx.ChuanDoans.Remove(entity);
                ctx.SaveChanges();
            }
        }
    }
}
