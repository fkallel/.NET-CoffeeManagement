using coffeeMVC.Models;

namespace coffeeMVC.Services
{
    public class CartService : ICartService
    {
        private readonly List<CartItem> _cartItems;

        public CartService()
        {
            _cartItems = new List<CartItem>();
        }

        public void AddToCart(Product product)
        {
            var cartItem = _cartItems.FirstOrDefault(ci => ci.ProductId == product.Id);

            if (cartItem == null)
            {
                cartItem = new CartItem
                {
                    ProductId = product.Id,
                    Quantity = 1,
                    Price = (decimal)product.Price
                };

                _cartItems.Add(cartItem);
            }
            else
            {
                cartItem.Quantity++;
            }
        }

        public List<CartItem> GetCartItems()
        {
            return _cartItems;
        }

        public decimal GetCartTotal()
        {
            decimal total = 0;

            foreach (var item in _cartItems)
            {
                total += item.Quantity * item.Price;
            }

            return total;
        }
    }
}
