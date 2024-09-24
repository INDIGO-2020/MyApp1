using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewbiePrjct.AppCollection
{
    public class QueueDemo
    {
        public void Execute()
        {
            Queue<string> kota = new Queue<string>();
            kota.Enqueue("Tasik");
            kota.Enqueue("Bandung");
            kota.Enqueue("Depok");
            kota.Enqueue("Jakarta");

            Console.WriteLine($"total queue kota adalah {kota.Count()}");
            Console.WriteLine($"kota pertama queue sebelum dihapus adalah {kota.Dequeue()}");
            Console.WriteLine($"update queue kota {kota.Count()}");
            Console.WriteLine($"kota pertama queue tanpa dihapus adalah {kota.Peek()}");
            Console.WriteLine($"cek queue kota {kota.Count()}");
        }
    }
}
