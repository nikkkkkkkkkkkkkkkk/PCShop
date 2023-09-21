using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Classes
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SecondName { get; set; }
        //private byte[] ProfilePicture { get; set; }
        [Key]
        public Rights Rights { get; set; }
        //public ShoppingCart? ShoppingCart { get; set; }
        public User(string login, string password, string email, string name, string surname, string secondName) {
            Login = login; 
            Password = password; 
            Email = email; 
            Name = name; 
            Surname = surname; 
            SecondName = secondName;
        }

        public string GetRights()
        {
            return Rights.Type;
        }
    }
    public class Rights
    {
        [ForeignKey("User")]
        public int Id { get; set; }
        public string Type { get; set; }
    }
}
