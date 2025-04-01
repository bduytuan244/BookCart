using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCart.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Fullname { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string? Phone { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string? Address { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Column(TypeName = "bit")]
        public bool IsPaid { get; set; } = false;

        [Column(TypeName = "bit")]
        public bool IsShipped { get; set; } = false;

        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }

        public List<Orderdetail>? OrderDetails { get; set; }
    }
}
