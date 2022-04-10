using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LiraryManagerment.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Author { get; set; }
        public int Quantity { get; set; }
        public int PublishYear { get; set; }
        public double Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsCreated { get; set; }
        public bool IsUpdated { get; set; }

        //foreinkey
        public int? BookTypeId { get; set; }
        public BookType BookType { get; set; }
        public int? BookStatusId { get; set; }
        public BookStatus BookStatus { get; set; }
        public int? BookLiquidationId { get; set; }
        public BookLiquidation BookLiquidation { get; set; }
    }
}
