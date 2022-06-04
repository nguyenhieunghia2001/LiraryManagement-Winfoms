using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LiraryManagerment.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Docgia = new HashSet<Docgia>();
            Matsach = new HashSet<Matsach>();
            Phieumuon = new HashSet<Phieumuon>();
            Phieuthutienphat = new HashSet<Phieuthutienphat>();
            Sach = new HashSet<Sach>();
        }

        public int Id { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string BangCap { get; set; }
        public string BoPhan { get; set; }
        public string ChucVu { get; set; }
        public string DienThoai { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayChinhSua { get; set; }
        public ulong? TaoMoi { get; set; }
        public ulong? DaXoa { get; set; }

        public virtual Chitietthanhlysach Chitietthanhlysach { get; set; }
        public virtual ICollection<Docgia> Docgia { get; set; }
        public virtual ICollection<Matsach> Matsach { get; set; }
        public virtual ICollection<Phieumuon> Phieumuon { get; set; }
        public virtual ICollection<Phieuthutienphat> Phieuthutienphat { get; set; }
        public virtual ICollection<Sach> Sach { get; set; }
    }
}
