using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace NhaKhoa.DAL
{
    public class ChuanDoanDAL
    {
        public List<Models.ChanDoan> GetAll()
        {
            using (var ctx = new NhaKhoaContext())
            {
                // Không include navigation properties để tránh lỗi nếu FK chưa được config
                return ctx.ChanDoans.ToList();
            }
        }

        public List<Models.ChanDoan> GetByMaBN(string maBN)
        {
            using (var ctx = new NhaKhoaContext())
            {
                // Lấy qua LamSan vì ChanDoan không có MaBN trực tiếp
                return ctx.ChanDoans
                          .Where(x => x.MaLS != null && ctx.LamSans.Any(l => l.MaLS == x.MaLS && l.MaBN == maBN))
                          .ToList();
            }
        }

        public Models.ChanDoan GetById(string maCD)
        {
            using (var ctx = new NhaKhoaContext())
            {
                // Không include navigation properties để tránh lỗi
                return ctx.ChanDoans.SingleOrDefault(x => x.MaCD == maCD);
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
                ctx.ChanDoans.Add(cd);
                ctx.SaveChanges();
            }
        }

        public void Update(Models.ChanDoan cd)
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
                var entity = ctx.ChanDoans.SingleOrDefault(x => x.MaCD == maCD);
                if (entity == null) return;

                ctx.ChanDoans.Remove(entity);
                ctx.SaveChanges();
            }
        }
    }
}
