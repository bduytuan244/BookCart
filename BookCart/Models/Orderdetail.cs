using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCart.Models
{
    [Table("OrderDetails")]
    public class Orderdetail
    {
        [Key]
        public int Id { get; set; } 

        public int OrderId { get; set; } 
        [ForeignKey("OrderId")]
        public Order? Order { get; set; }

        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book? Book { get; set; }

        [Column(TypeName = "int")]
        public int Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; } 

        [Column(TypeName = "money")]
        public decimal TotalPrice => Quantity * Price; 
    }
}
