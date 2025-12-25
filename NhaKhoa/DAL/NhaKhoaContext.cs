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
        public DbSet<Models.ChanDoan> ChanDoans { get; set; }
        public DbSet<Models.DieuTri> DieuTris { get; set; }
        public DbSet<Models.LamSan> LamSans { get; set; }

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

            // Cấu hình ChanDoan - chỉ có MaCD, MaLS (NOT NULL), TenChuanDoan
            var chanDoanConfig = modelBuilder.Entity<Models.ChanDoan>();
            
            // MaLS là NOT NULL trong database (Foreign Key bắt buộc)
            chanDoanConfig.Property(c => c.MaLS).IsRequired();

            // Cấu hình foreign key relationship với LamSan (required)
            chanDoanConfig.HasRequired(c => c.Lamsan)
                .WithMany(l => l.Chandoans)
                .HasForeignKey(c => c.MaLS)
                .WillCascadeOnDelete(false);

            // Cấu hình DieuTri
            var dieuTriConfig = modelBuilder.Entity<Models.DieuTri>();
            
            // Các foreign keys là optional
            dieuTriConfig.Property(d => d.MaLS).IsOptional();
            dieuTriConfig.Property(d => d.MaCD).IsOptional();
            dieuTriConfig.Property(d => d.TenDieuTri).IsOptional();
            dieuTriConfig.Property(d => d.DonViTinh).IsOptional();
            dieuTriConfig.Property(d => d.DonGia).IsOptional();

            // Không config foreign key relationships nếu database không có constraints
            // Hoặc nếu cần thì bỏ comment các dòng dưới
            /*
            dieuTriConfig.HasOptional(d => d.Lamsan)
                .WithMany(l => l.Dieutris)
                .HasForeignKey(d => d.MaLS)
                .WillCascadeOnDelete(false);

            dieuTriConfig.HasOptional(d => d.Chandoan)
                .WithMany(c => c.Dieutris)
                .HasForeignKey(d => d.MaCD)
                .WillCascadeOnDelete(false);
            */
        }
    }
}
