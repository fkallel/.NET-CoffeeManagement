using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coffeeMVC.Models
{

    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
         

        public Product(string name , string description , string category , double price) {
            this.Name = name;
            this.Description= description;
            this.Category = category;
            this.Price = price;
             
          
                    
        
        }
        public Product() { }    
    }
}
