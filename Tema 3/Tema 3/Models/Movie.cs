using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Tema3.Models.Base;

namespace Tema3.Models
{
    /// gen un magazin de casete sau ceva
    public class Movie: BaseEntity
    {
        public int copyId { get; set; }
        public string movieName { get; set; }
        //public List<string> actors { get; set; }

        public int price { get; set; }

        public DateTime rentalDate { get; set; }
    }
}
