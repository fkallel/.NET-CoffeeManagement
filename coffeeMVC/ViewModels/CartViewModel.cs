using coffeeMVC.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace coffeeMVC.ViewModels
{
    public class CartViewModel
    {
        [Key] public int Id { get; set; }
        public List<CartItem> CartItems { get; set; }
        public decimal CartTotal { get; set; }
      
        public List<Product> Products { get; set; }
    }
}
