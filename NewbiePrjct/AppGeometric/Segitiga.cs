using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewbiePrjct.AppGeometric
{
    public class Segitiga : Shape
    {
        private static double Tinggi;
        public Segitiga(int _tinggi, int _alas)
        {
            Tinggi = _tinggi;
            Alas = _alas;
        }

        public int Alas { get; set; }

        public override double luasArea()
        {
            return 0.5 * (Alas * Tinggi);
        }
    }
}
