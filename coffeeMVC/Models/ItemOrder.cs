using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coffeeMVC.Models
{
    public class ItemOrder
    {
        [Key]
        public int Id { get; set; }
      
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        public ItemOrder( int OrderId , int ProductId, int quantity,double unitPrice) { 
        
         this.OrderId = OrderId;
            this.ProductId = ProductId;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;

        
        }
        public ItemOrder() { }  
    }
}