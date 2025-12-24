using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace NhaKhoa.DAL
{
    public class NhaKhoaContext : DbContext
    {
        // name=… phải trùng với name trong App.config
        public NhaKhoaContext() : base("name=QuanLyPhongKhamContext")
        {
        }

        // Dùng fully qualified name để tránh xung đột với namespace NhaKhoa.Thuoc, NhaKhoa.BenhNhan, NhaKhoa.NhanVien
        public DbSet<Models.Thuoc> Thuocs { get; set; }
        public DbSet<Models.BenhNhan> BenhNhans { get; set; }
        public DbSet<Models.NhanVien> NhanViens { get; set; }
        public DbSet<Models.HoaDon> HoaDons { get; set; }
        public DbSet<Models.VatLieu> VatLieus { get; set; }
        public DbSet<Models.Users> Users { get; set; }
        public DbSet<Models.Roles> Roles { get; set; }
        public DbSet<Models.UserRoles> UserRoles { get; set; }
        public DbSet<Models.ChuanDoan> ChuanDoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Định nghĩa composite key cho UserRoles (UserId + RoleId)
            modelBuilder.Entity<Models.UserRoles>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            // Cấu hình relationship giữa Users và UserRoles
            modelBuilder.Entity<Models.UserRoles>()
                .HasRequired(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId);

            // Cấu hình relationship giữa Roles và UserRoles
            modelBuilder.Entity<Models.UserRoles>()
                .HasRequired(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId);

            // Cấu hình decimal với precision và scale cho Thuoc
            modelBuilder.Entity<Models.Thuoc>()
                .Property(t => t.DonGia)
                .HasPrecision(18, 2);

            // Cấu hình decimal với precision và scale cho HoaDon
            modelBuilder.Entity<Models.HoaDon>()
                .Property(h => h.TongTien)
                .HasPrecision(18, 2);

            // Cấu hình decimal với precision và scale cho VatLieu
            modelBuilder.Entity<Models.VatLieu>()
                .Property(v => v.DonGia)
                .HasPrecision(18, 2);

            base.OnModelCreating(modelBuilder);
        }
    }
}
