using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LiraryManagerment.Models
{
    public partial class Phieumuon
    {
        public Phieumuon()
        {
            Chitietphieumuon = new HashSet<Chitietphieumuon>();
        }

        public int Id { get; set; }
        public int? NhanVienId { get; set; }
        public int? DocGiaId { get; set; }
        public int? SoLuong { get; set; }
        public int? DonGia { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayChinhSua { get; set; }
        public ulong? TaoMoi { get; set; }
        public ulong? DaXoa { get; set; }

        public virtual Docgia DocGia { get; set; }
        public virtual Nhanvien NhanVien { get; set; }
        public virtual ICollection<Chitietphieumuon> Chitietphieumuon { get; set; }
    }
}
