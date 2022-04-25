using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LiraryManagerment.Models
{
    public partial class Chitietthanhlysach
    {
        public int Id { get; set; }
        public int? ThanhLySachId { get; set; }
        public int? SachId { get; set; }

        public virtual Nhanvien Sach { get; set; }
        public virtual Thanhlysach ThanhLySach { get; set; }
    }
}
