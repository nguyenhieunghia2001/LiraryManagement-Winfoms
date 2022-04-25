using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LiraryManagerment.Models
{
    public partial class Chitietphieumuon
    {
        public int Id { get; set; }
        public int? PhieuMuonId { get; set; }
        public int? SachId { get; set; }

        public virtual Phieumuon PhieuMuon { get; set; }
        public virtual Sach Sach { get; set; }
    }
}
