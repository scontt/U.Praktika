using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using практика.cs;

namespace практика.db
{
    public class Users : Person
    {
        public Users (int id, string name, string password, string email, string phone, string sex, string passport, string address)
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

        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Password { get; set; }
        public override string Email { get; set; }
        public override string Phone { get; set; }
        public override string Sex { get; set; }
        public override string Passport { get; set; }
        public override string Address { get; set; }
        public override bool IsAdmin { get; } = false;
    }
}
