using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LiraryManagerment.Models
{
    public partial class Phieutra
    {
        public Phieutra()
        {
            Chitietphieutra = new HashSet<Chitietphieutra>();
        }

        public int Id { get; set; }
        public int? DocGiaId { get; set; }
        public DateTime NgayTra { get; set; }
        public DateTime NgayChinhSua { get; set; }
        public ulong? TaoMoi { get; set; }
        public ulong? DaXoa { get; set; }

        public virtual Docgia DocGia { get; set; }
        public virtual ICollection<Chitietphieutra> Chitietphieutra { get; set; }
    }
}
