using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace coffeeMVC.Models
{
    public class CartItem
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
