using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LiraryManagerment.Models
{
    public partial class Sach
    {
        public Sach()
        {
            Chitietphieumuon = new HashSet<Chitietphieumuon>();
            Chitietphieutra = new HashSet<Chitietphieutra>();
            Matsach = new HashSet<Matsach>();
        }

        public int Id { get; set; }
        public string TacGia { get; set; }
        public string TenSach { get; set; }
        public int? SoLuong { get; set; }
        public int? NamXb { get; set; }
        public int? TriGia { get; set; }
        public int? LoaiSachId { get; set; }
        public int? TinhTrangId { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayChinhSua { get; set; }
        public ulong? TaoMoi { get; set; }
        public ulong? DaXoa { get; set; }

        public virtual Loaisach LoaiSach { get; set; }
        public virtual Tinhtrangsach TinhTrang { get; set; }
        public virtual Phieuthutienphat Phieuthutienphat { get; set; }
        public virtual ICollection<Chitietphieumuon> Chitietphieumuon { get; set; }
        public virtual ICollection<Chitietphieutra> Chitietphieutra { get; set; }
        public virtual ICollection<Matsach> Matsach { get; set; }
    }
}
