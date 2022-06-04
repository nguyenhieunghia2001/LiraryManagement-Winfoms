﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LiraryManagerment.Models
{
    public partial class Tinhtrangsach
    {
        public Tinhtrangsach()
        {
            Sach = new HashSet<Sach>();
        }

        public int Id { get; set; }
        public string Ten { get; set; }

        public virtual ICollection<Sach> Sach { get; set; }
    }
}
