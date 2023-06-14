using System.ComponentModel.DataAnnotations;
namespace coffeeMVC.Models
{
    public class Drink
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
