using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewbiePrjct.AppSorting
{
    public class ShortListDemo
    {
        List<string> Nama = new List<string>()
        {
            "Rangga",
            "Akbar",
            "Celoz",
            "Fauzi",
            "Ilham",
            "Zai",
            "Rai"
        };

        public void Execute()
        {
            Nama.Sort();
            Console.WriteLine($"Kumpulan Nama setelah di Sorting:");

            foreach (var item in Nama)
            {
                Console.WriteLine(item);
            }
        }
    }
}
