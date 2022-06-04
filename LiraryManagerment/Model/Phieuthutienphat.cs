using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LiraryManagerment.Models
{
    public partial class Phieuthutienphat
    {
        public int Id { get; set; }
        public int? DocGiaId { get; set; }
        public int? NguoiThu { get; set; }
        public int? TienThu { get; set; }
        public DateTime NgayThu { get; set; }
        public DateTime NgayChinhSua { get; set; }
        public ulong? TaoMoi { get; set; }
        public ulong? DaXoa { get; set; }

        public virtual Docgia DocGia { get; set; }
        public virtual Sach IdNavigation { get; set; }
        public virtual Nhanvien NguoiThuNavigation { get; set; }
    }
}
