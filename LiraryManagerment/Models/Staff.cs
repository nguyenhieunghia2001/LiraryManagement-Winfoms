using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LiraryManagerment.Models
{
    public class Staff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(100)]
        public string Degree { get; set; }
        [StringLength(100)]
        public string Department { get; set; }
        [StringLength(100)]
        public string Position { get; set; }
        [Required]
        [StringLength(15)]
        public string Phone { get; set; }
        [Required]
        [StringLength(255)]
        public string FullName { get; set; }
        [Required]
        public DateTime BOD { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsCreated { get; set; }
        public bool IsUpdated { get; set; }


    }
}
