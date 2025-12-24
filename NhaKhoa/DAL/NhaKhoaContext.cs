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
            base.OnModelCreating(modelBuilder);

            // Cấu hình composite key cho UserRoles
            modelBuilder.Entity<Models.UserRoles>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            // Cấu hình foreign key relationships
            modelBuilder.Entity<Models.UserRoles>()
                .HasRequired(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Models.UserRoles>()
                .HasRequired(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId)
                .WillCascadeOnDelete(false);

            // Cấu hình mapping cho BenhNhan - đảm bảo TrangThai được map đúng
            modelBuilder.Entity<Models.BenhNhan>()
                .Property(b => b.TrangThai)
                .HasColumnName("TrangThai")
                .HasMaxLength(50)
                .IsOptional();
        }
    }
}
