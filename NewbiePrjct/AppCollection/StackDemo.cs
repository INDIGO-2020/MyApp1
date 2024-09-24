using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewbiePrjct.AppCollection
{
    public class StackDemo
    {
        public void Execute()
        {
            //1. cara pendeklarasian Stack tanpa collection initializer
            Stack<string> kotaa = new Stack<string>();
            //2. Menambahkan element pada Stack
            kotaa.Push("tasik");
            kotaa.Push("jakarta");
            kotaa.Push("bandung");

            Console.WriteLine($"{kotaa.Count()}");
            Console.WriteLine($"{kotaa.Peek()}");
            Console.WriteLine($"{kotaa.Count()}");
            Console.WriteLine($"{kotaa.Pop()}");
            Console.WriteLine($"{kotaa.Count()}");

        }

    }
}
