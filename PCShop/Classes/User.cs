using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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
        private byte[]? ProfilePicture { get; set; }
        public Rights Rights = new();
        public ShoppingCart? ShoppingCart { get; set; }
        public User(string login, string password, string email, string name, string surname, string secondName)
        {
            Login = login; 
            Password = password; 
            Email = email; 
            Name = name; 
            Surname = surname; 
            SecondName = secondName;
        }
        public User(string login, string password, string email, string name, string surname, string secondName, string profilePicture, Rights rights) : this(login, password, email, name, surname, secondName)
        {
            ProfilePicture = File.ReadAllBytes(profilePicture);
            Rights = rights;
        }

        public string GetRights()
        {
            return Rights.Type;
        }

        public string LoadImage(string fileName)
        {
            var filePath = $"{Path.GetTempPath()}/PCShop/{fileName}.png";
            Directory.CreateDirectory($"{Path.GetTempPath()}/PCShop");
            var createFile = File.Create(filePath);
            createFile.Write(ProfilePicture);
            createFile.Close();
            return filePath;
        }
    }
    public class Rights
    {
        public int Id { get; set; }
        public string Type { get; set; } = "";
    }
}
