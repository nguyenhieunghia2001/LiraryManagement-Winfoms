using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LiraryManagerment.Models
{
    public class BookLiquidation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public DateTime LiquidationDate { get; set; }
        [StringLength(255)]
        public string Reason { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsCreated { get; set; }
        public bool IsUpdated { get; set; }
        
        public int? BookId { get; set; }
        public Book Book { get; set; }
        public int? StaffId { get; set; }
        public Staff Staff { get; set; }
    }
}
