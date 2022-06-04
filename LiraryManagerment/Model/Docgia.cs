using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LiraryManagerment.Models
{
    public partial class Docgia
    {
        public Docgia()
        {
            Matsach = new HashSet<Matsach>();
            Phieumuon = new HashSet<Phieumuon>();
            Phieuthutienphat = new HashSet<Phieuthutienphat>();
            Phieutra = new HashSet<Phieutra>();
        }

        public int Id { get; set; }
        public string LoaiDocGia { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public int? TienNo { get; set; }
        public DateTime NgayLapThe { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayChinhSua { get; set; }
        public ulong? TaoMoi { get; set; }
        public ulong? DaXoa { get; set; }
        public int? NguoiLapTheId { get; set; }

        public virtual Nhanvien NguoiLapThe { get; set; }
        public virtual ICollection<Matsach> Matsach { get; set; }
        public virtual ICollection<Phieumuon> Phieumuon { get; set; }
        public virtual ICollection<Phieuthutienphat> Phieuthutienphat { get; set; }
        public virtual ICollection<Phieutra> Phieutra { get; set; }
    }
}
