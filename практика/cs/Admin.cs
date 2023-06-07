using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика.cs
{
    public class Admin
    {
        public Admin(int id, string name, string password, string email, string phone, string sex, string passport, string address)
        {
            Id = id;
            Name = name;
            Password = password;
            Email = email;
            Phone = phone;
            Sex = sex;
            Passport = passport;
            Address = address;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Sex { get; set; }
        public string Passport { get; set; }
        public string Address { get; set; }
        public byte IsAdmin { get; } = 1;
    }
}
