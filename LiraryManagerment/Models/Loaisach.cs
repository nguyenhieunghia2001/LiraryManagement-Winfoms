using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LiraryManagerment.Models
{
    public partial class Loaisach
    {
        public Loaisach()
        {
            Sach = new HashSet<Sach>();
        }

        public int Id { get; set; }
        public string TenLoai { get; set; }
        public string KyHieu { get; set; }

        public virtual ICollection<Sach> Sach { get; set; }
    }
}
