using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewbiePrjct.AppCollection
{
    public class DictionaryDemo
    {
        public void Execute()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>
            {
                { "Yogyakarta", "Daerah Istimewa" },
                { "Tasik", "Kota santri" },
                { "Bandung", "Lautan Api" },
                { "Jakarta", "Ibu Kota" }
            };

            string? karakteristikKota;
            bool emangBetul = dic.TryGetValue("Yogyakarta", out karakteristikKota);
            foreach (var item in dic)
            {
                Console.WriteLine($"Kota {item.Key} dikenal sebagai {item.Value}");
            }

            Console.WriteLine($"betulkah {karakteristikKota} itu {dic.Keys.ElementAt(2)}? {emangBetul}");
        }
    }
}
