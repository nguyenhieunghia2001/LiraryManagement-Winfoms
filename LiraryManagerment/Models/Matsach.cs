using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LiraryManagerment.Models
{
    public partial class Matsach
    {
        public int DocGiaId { get; set; }
        public int SachId { get; set; }
        public int? NhanVienId { get; set; }
        public int? TienPhat { get; set; }
        public DateTime NgayGhiNhan { get; set; }
        public DateTime NgayChinhSua { get; set; }
        public ulong? TaoMoi { get; set; }
        public ulong? DaXoa { get; set; }

        public virtual Docgia DocGia { get; set; }
        public virtual Nhanvien NhanVien { get; set; }
        public virtual Sach Sach { get; set; }
    }
}
