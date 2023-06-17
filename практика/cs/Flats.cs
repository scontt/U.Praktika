using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика.cs
{
    public class Flats
    {
        public int Id { get; set; }

        public int Area { get; set; }

        public decimal Price { get; set; }

        public int Level { get; set; }

        public int RoomsAmount { get; set; }

        public int FlatTypeId { get; set; }

        public int UserId { get; set; }

        public DateTime PublishDate { get; set; }

        public Image Image { get; set; }
    }
}
