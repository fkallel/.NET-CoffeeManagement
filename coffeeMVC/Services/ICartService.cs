using coffeeMVC.Models;

namespace coffeeMVC.Services
{
    public interface ICartService
    {
        void AddToCart(Product product);
        List<CartItem> GetCartItems();
        decimal GetCartTotal();
    }
}
