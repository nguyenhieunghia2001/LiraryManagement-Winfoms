using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LiraryManagerment.Models
{
    public partial class heroku_c5dfe82f5ebcccfContext : DbContext
    {
        public heroku_c5dfe82f5ebcccfContext()
        {
        }

        public heroku_c5dfe82f5ebcccfContext(DbContextOptions<heroku_c5dfe82f5ebcccfContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chitietphieumuon> Chitietphieumuon { get; set; }
        public virtual DbSet<Chitietphieutra> Chitietphieutra { get; set; }
        public virtual DbSet<Chitietthanhlysach> Chitietthanhlysach { get; set; }
        public virtual DbSet<Docgia> Docgia { get; set; }
        public virtual DbSet<Loaisach> Loaisach { get; set; }
        public virtual DbSet<Matsach> Matsach { get; set; }
        public virtual DbSet<Nhanvien> Nhanvien { get; set; }
        public virtual DbSet<Phieumuon> Phieumuon { get; set; }
        public virtual DbSet<Phieuthutienphat> Phieuthutienphat { get; set; }
        public virtual DbSet<Phieutra> Phieutra { get; set; }
        public virtual DbSet<Sach> Sach { get; set; }
        public virtual DbSet<Thanhlysach> Thanhlysach { get; set; }
        public virtual DbSet<Tinhtrangsach> Tinhtrangsach { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=us-cdbr-east-05.cleardb.net;database=heroku_c5dfe82f5ebcccf;uid=bd4dc92e1131a3;pwd=36285360;convert zero datetime=True", x => x.ServerVersion("5.6.50-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chitietphieumuon>(entity =>
            {
                entity.ToTable("chitietphieumuon");

                entity.HasIndex(e => e.PhieuMuonId)
                    .HasName("fk_chitietphieumuon_phieumuon");

                entity.HasIndex(e => e.SachId)
                    .HasName("fk_chitietphieumuon_sach");

                entity.Property(e => e.Id).HasColumnType("int(10)");

                entity.Property(e => e.PhieuMuonId).HasColumnType("int(10)");

                entity.Property(e => e.SachId).HasColumnType("int(10)");

                entity.HasOne(d => d.PhieuMuon)
                    .WithMany(p => p.Chitietphieumuon)
                    .HasForeignKey(d => d.PhieuMuonId)
                    .HasConstraintName("fk_chitietphieumuon_phieumuon");

                entity.HasOne(d => d.Sach)
                    .WithMany(p => p.Chitietphieumuon)
                    .HasForeignKey(d => d.SachId)
                    .HasConstraintName("fk_chitietphieumuon_sach");
            });

            modelBuilder.Entity<Chitietphieutra>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SachId })
                    .HasName("PRIMARY");

                entity.ToTable("chitietphieutra");

                entity.HasIndex(e => e.SachId)
                    .HasName("fk_chitietphieutra_sach");

                entity.Property(e => e.Id).HasColumnType("int(10)");

                entity.Property(e => e.SachId).HasColumnType("int(10)");

                entity.Property(e => e.NgayMuon)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SoNgayMuon).HasColumnType("int(10)");

                entity.Property(e => e.TienPhat).HasColumnType("int(10)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Chitietphieutra)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_chitietphieutra_phieutra");

                entity.HasOne(d => d.Sach)
                    .WithMany(p => p.Chitietphieutra)
                    .HasForeignKey(d => d.SachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_chitietphieutra_sach");
            });

            modelBuilder.Entity<Chitietthanhlysach>(entity =>
            {
                entity.ToTable("chitietthanhlysach");

                entity.HasIndex(e => e.SachId)
                    .HasName("SachId")
                    .IsUnique();

                entity.HasIndex(e => e.ThanhLySachId)
                    .HasName("fk_chitietthanhlysach_thanhlysach");

                entity.Property(e => e.Id).HasColumnType("int(10)");

                entity.Property(e => e.SachId).HasColumnType("int(10)");

                entity.Property(e => e.ThanhLySachId).HasColumnType("int(10)");

                entity.HasOne(d => d.Sach)
                    .WithOne(p => p.Chitietthanhlysach)
                    .HasForeignKey<Chitietthanhlysach>(d => d.SachId)
                    .HasConstraintName("fk_chitietthanhlysach_sach");

                entity.HasOne(d => d.ThanhLySach)
                    .WithMany(p => p.Chitietthanhlysach)
                    .HasForeignKey(d => d.ThanhLySachId)
                    .HasConstraintName("fk_chitietthanhlysach_thanhlysach");
            });

            modelBuilder.Entity<Docgia>(entity =>
            {
                entity.ToTable("docgia");

                entity.HasIndex(e => e.NguoiLapTheId)
                    .HasName("fk_Docgia_nhanvien");

                entity.Property(e => e.Id).HasColumnType("int(10)");

                entity.Property(e => e.DaXoa)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.DiaChi)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HoTen)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LoaiDocGia)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NgayChinhSua)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.NgayLapThe)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.NguoiLapTheId).HasColumnType("int(10)");

                entity.Property(e => e.TaoMoi)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.TienNo).HasColumnType("int(10)");

                entity.HasOne(d => d.NguoiLapThe)
                    .WithMany(p => p.Docgia)
                    .HasForeignKey(d => d.NguoiLapTheId)
                    .HasConstraintName("fk_Docgia_nhanvien");
            });

            modelBuilder.Entity<Loaisach>(entity =>
            {
                entity.ToTable("loaisach");

                entity.Property(e => e.Id).HasColumnType("int(10)");

                entity.Property(e => e.KyHieu)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TenLoai)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Matsach>(entity =>
            {
                entity.HasKey(e => new { e.DocGiaId, e.SachId })
                    .HasName("PRIMARY");

                entity.ToTable("matsach");

                entity.HasIndex(e => e.NhanVienId)
                    .HasName("fk_matsach_nhanvien");

                entity.HasIndex(e => e.SachId)
                    .HasName("fk_matsach_sach");

                entity.Property(e => e.DocGiaId).HasColumnType("int(10)");

                entity.Property(e => e.SachId).HasColumnType("int(10)");

                entity.Property(e => e.DaXoa).HasColumnType("bit(1)");

                entity.Property(e => e.NgayChinhSua)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.NgayGhiNhan)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.NhanVienId).HasColumnType("int(10)");

                entity.Property(e => e.TaoMoi)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.TienPhat).HasColumnType("int(10)");

                entity.HasOne(d => d.DocGia)
                    .WithMany(p => p.Matsach)
                    .HasForeignKey(d => d.DocGiaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_matsach_docgia");

                entity.HasOne(d => d.NhanVien)
                    .WithMany(p => p.Matsach)
                    .HasForeignKey(d => d.NhanVienId)
                    .HasConstraintName("fk_matsach_nhanvien");

                entity.HasOne(d => d.Sach)
                    .WithMany(p => p.Matsach)
                    .HasForeignKey(d => d.SachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_matsach_sach");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.ToTable("nhanvien");

                entity.Property(e => e.Id).HasColumnType("int(10)");

                entity.Property(e => e.BangCap)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BoPhan)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChucVu)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DaXoa).HasColumnType("bit(1)");

                entity.Property(e => e.DiaChi)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DienThoai)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HoTen)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MatKhau)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NgayChinhSua)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TaoMoi)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.TenDangNhap)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Phieumuon>(entity =>
            {
                entity.ToTable("phieumuon");

                entity.HasIndex(e => e.DocGiaId)
                    .HasName("fk_phieumuon_docgia");

                entity.HasIndex(e => e.NhanVienId)
                    .HasName("fk_phieumuon_nhanvien");

                entity.Property(e => e.Id).HasColumnType("int(10)");

                entity.Property(e => e.DaXoa).HasColumnType("bit(1)");

                entity.Property(e => e.DocGiaId).HasColumnType("int(10)");

                entity.Property(e => e.DonGia).HasColumnType("int(10)");

                entity.Property(e => e.NgayChinhSua)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.NgayMuon)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.NhanVienId).HasColumnType("int(10)");

                entity.Property(e => e.SoLuong).HasColumnType("int(10)");

                entity.Property(e => e.TaoMoi)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.HasOne(d => d.DocGia)
                    .WithMany(p => p.Phieumuon)
                    .HasForeignKey(d => d.DocGiaId)
                    .HasConstraintName("fk_phieumuon_docgia");

                entity.HasOne(d => d.NhanVien)
                    .WithMany(p => p.Phieumuon)
                    .HasForeignKey(d => d.NhanVienId)
                    .HasConstraintName("fk_phieumuon_nhanvien");
            });

            modelBuilder.Entity<Phieuthutienphat>(entity =>
            {
                entity.ToTable("phieuthutienphat");

                entity.HasIndex(e => e.DocGiaId)
                    .HasName("fk_phieuthutienphat_docgia");

                entity.HasIndex(e => e.NguoiThu)
                    .HasName("fk_phieuthutienphat_nhanvien");

                entity.Property(e => e.Id).HasColumnType("int(10)");

                entity.Property(e => e.DaXoa).HasColumnType("bit(1)");

                entity.Property(e => e.DocGiaId).HasColumnType("int(10)");

                entity.Property(e => e.NgayChinhSua)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.NgayThu)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.NguoiThu).HasColumnType("int(10)");

                entity.Property(e => e.TaoMoi)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.TienThu).HasColumnType("int(10)");

                entity.HasOne(d => d.DocGia)
                    .WithMany(p => p.Phieuthutienphat)
                    .HasForeignKey(d => d.DocGiaId)
                    .HasConstraintName("fk_phieuthutienphat_docgia");

                entity.HasOne(d => d.NguoiThuNavigation)
                    .WithMany(p => p.Phieuthutienphat)
                    .HasForeignKey(d => d.NguoiThu)
                    .HasConstraintName("fk_phieuthutienphat_nhanvien");
            });

            modelBuilder.Entity<Phieutra>(entity =>
            {
                entity.ToTable("phieutra");

                entity.HasIndex(e => e.DocGiaId)
                    .HasName("fk_phieutra_docgia");

                entity.Property(e => e.Id).HasColumnType("int(10)");

                entity.Property(e => e.DaXoa).HasColumnType("bit(1)");

                entity.Property(e => e.DocGiaId).HasColumnType("int(10)");

                entity.Property(e => e.NgayChinhSua)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.NgayTra)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TaoMoi)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.HasOne(d => d.DocGia)
                    .WithMany(p => p.Phieutra)
                    .HasForeignKey(d => d.DocGiaId)
                    .HasConstraintName("fk_phieutra_docgia");
            });

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.ToTable("sach");

                entity.HasIndex(e => e.LoaiSachId)
                    .HasName("fk_sach_loaisach");

                entity.HasIndex(e => e.NguoiTiepNhanId)
                    .HasName("FK_sach_nhanvien");

                entity.HasIndex(e => e.TinhTrangId)
                    .HasName("fk_sach_tinhtransach");

                entity.Property(e => e.Id).HasColumnType("int(10)");

                entity.Property(e => e.DaXoa).HasColumnType("bit(1)");

                entity.Property(e => e.LoaiSachId).HasColumnType("int(10)");

                entity.Property(e => e.NamXb)
                    .HasColumnName("NamXB")
                    .HasColumnType("int(4)");

                entity.Property(e => e.NgayChinhSua)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.NguoiTiepNhanId).HasColumnType("int(10)");

                entity.Property(e => e.NhaXuatBan)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SoLuong).HasColumnType("int(10)");

                entity.Property(e => e.TacGia)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TaoMoi)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.TenSach)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TinhTrangId).HasColumnType("int(10)");

                entity.Property(e => e.TriGia).HasColumnType("int(10)");

                entity.HasOne(d => d.LoaiSach)
                    .WithMany(p => p.Sach)
                    .HasForeignKey(d => d.LoaiSachId)
                    .HasConstraintName("fk_sach_loaisach");

                entity.HasOne(d => d.NguoiTiepNhan)
                    .WithMany(p => p.Sach)
                    .HasForeignKey(d => d.NguoiTiepNhanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sach_nhanvien");

                entity.HasOne(d => d.TinhTrang)
                    .WithMany(p => p.Sach)
                    .HasForeignKey(d => d.TinhTrangId)
                    .HasConstraintName("fk_sach_tinhtransach");
            });

            modelBuilder.Entity<Thanhlysach>(entity =>
            {
                entity.ToTable("thanhlysach");

                entity.Property(e => e.Id).HasColumnType("int(10)");

                entity.Property(e => e.DaXoa).HasColumnType("bit(1)");

                entity.Property(e => e.IdNhanVien).HasColumnType("int(10)");

                entity.Property(e => e.LyDo)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NgayChinhSua)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.NgayThanhLy)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TaoMoi)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");
            });

            modelBuilder.Entity<Tinhtrangsach>(entity =>
            {
                entity.ToTable("tinhtrangsach");

                entity.Property(e => e.Id).HasColumnType("int(10)");

                entity.Property(e => e.Ten)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
