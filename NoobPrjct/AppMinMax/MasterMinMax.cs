using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoobPrjct.AppMinMax
{
    public class MasterMinMax
    {
        /*
         * aku ingin membuat sebuah class yang dapat menentukan nilai Min-Max pada
         * array yang muncul secara randomize.
         */

        public void Execute()
        {
            int[] arrays = new int[10];

            Random random = new Random();
            bool roll = true;

            while (roll)
            {
                for (int i = 0; i < arrays.Length; i++)
                {
                    arrays[i] = random.Next(1, 101);
                }
                Console.Write($"check item in Array: ");
                foreach (var item in arrays)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine("\n");
                getMinMaxMean(arrays);

                Console.Write("Tekan Y untuk Mulai atau Tekan N untuk Exit");
                var key = Console.ReadKey(false).Key;
                switch (key)
                {
                    case ConsoleKey.Y:
                        Console.Clear();
                        roll = true;
                        break;
                    case ConsoleKey.N:
                        roll = false;
                        break;
                    default:

                        break;
                }
            }


        }

        private void getMinMaxMean(int[] arrays)
        {
            int min = arrays[0];
            int max = arrays[0];
            int mean = 0;
            for (int i = 0; i < arrays.Length; i++)
            {
                if (arrays[i] > max)
                {
                    max = arrays[i];
                }
                else if (arrays[i] < min)
                {
                    min = arrays[i];
                }
                mean += arrays[i];
            }
            double total = (double)mean / arrays.Length;
            

            Console.WriteLine($"Nilai Max dari Array adalah {max}");
            Console.WriteLine($"Nilai Min dari Array adalah {min}");
            Console.WriteLine($"Nilai Mean dari Array adalah {total}");
        }
    }
}
