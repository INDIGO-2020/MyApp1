using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewbiePrjct.AppCollection
{
    public class ListDemo
    {
        public ListDemo()
        {

        }

        public void Execute()
        {
            //1. Cara mendeklarasikan Collection - List
            List<string> listNama = new List<string>();

            //2. Cara mendeklarasikan Colletion - List Initialized
            List<string> listKota = new List<string>
            {
                "banjar",
                "cilacap",
                "tasik"
            };

            //3.cara menambahkan elemen kedalam listNama
            listNama.Add("Lisaaaa");
            listKota.Add("bandung");

            Console.WriteLine($"total kota yang terdaftar di List: {listKota.Count}");
            Console.WriteLine($"kota kedua pada list: {listKota[1]}");
            Console.WriteLine("kemudian kota tersebut dihapus dari list");
            Console.WriteLine("-------");
            listKota.RemoveAt(1);
            Console.WriteLine($"menambahkan kota baru");
            listKota.Insert(1, "serang");
            Console.WriteLine($"nama kota tersebut adalah {listKota[1]}");
            Console.WriteLine(@$"index dari kota ""serang"" adalah {listKota.IndexOf("serang")}");
            listKota.Sort();

            foreach (var item in listKota)
            {
                Console.Write($" |{item}");
            }
            Console.WriteLine();
            listKota.Reverse();
            foreach (var item in listKota)
            {
                Console.Write($" |{item}");
            }
        }

    }
}
