using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewbiePrjct.AppGeometric
{
    public class Lingkaran : Shape
    {
        private const double PI = 3.14;
        public Lingkaran(int _radius)
        {
            Radius = _radius;
        }

        public int Radius { get; }

        public override double luasArea()
        {
            return PI * (Radius * Radius);
        }
    }
}
