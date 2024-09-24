using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace NewbiePrjct.AppGeometric
{
    public class Shape
    {
        public Shape()
        {

        }
        public int Panjang { get; set; }
        public int Lebar { get; set; }

        public virtual double luasArea()
        {
            return Panjang * Lebar;
        }
    }
}
