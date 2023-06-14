using System.ComponentModel.DataAnnotations;

namespace coffeeMVC.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }

        public User(int Id, string userName, string password, int phoneNumber)
        {
            Id = Id;
            UserName = userName;
            Password = password;
            PhoneNumber = phoneNumber;
        }

        public User()
        {
        }
    }
}
