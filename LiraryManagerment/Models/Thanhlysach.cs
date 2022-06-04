using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LiraryManagerment.model
{
    public partial class Thanhlysach
    {
        public Thanhlysach()
        {
            Chitietthanhlysach = new HashSet<Chitietthanhlysach>();
        }

        public int Id { get; set; }
        public int? IdNhanVien { get; set; }
        public string LyDo { get; set; }
        public DateTime NgayThanhLy { get; set; }
        public DateTime NgayChinhSua { get; set; }
        public ulong? TaoMoi { get; set; }
        public ulong? DaXoa { get; set; }

        public virtual ICollection<Chitietthanhlysach> Chitietthanhlysach { get; set; }
    }
}
