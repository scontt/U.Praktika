using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Data;

namespace практика.db
{
    public abstract class Person
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract string Password { get; set; }
        public abstract string Email { get; set; }
        public abstract string Phone { get; set; }
        public abstract string Sex { get; set; }
        public abstract string Passport { get; set; }
        public abstract string Address { get; set; }
        public abstract bool IsAdmin { get; }
    }
}
