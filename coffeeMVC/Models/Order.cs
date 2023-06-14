using System.ComponentModel.DataAnnotations;

namespace coffeeMVC.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<ItemOrder> OrderItems { get; set; } = new List<ItemOrder>();
        public double TotalPrice { get; set; }
        public Order(int id , int UserId , double totalPrice) {
           this.Id = id;
            this.UserId = UserId;
                  
            this.TotalPrice = totalPrice;
        
        
        }
        public Order() { }  
    }
 
    }
