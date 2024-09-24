using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoobPrjct.AppRollDice
{
    public class MasterRollDice
    {
        /*
         * PR Next Update; 
         *      1. Tambahkan dadu menjadi 2 buah
         *      2. Identifikasi setiap double, beri bonus 5 tiap double
         *      
         */
        Random dice = new Random();
        private int roll = 3;
        private int remainRoll;
        private bool gameOn = true;
        private char inputUser;
        public void Execute()
        {
            do
            {
                Console.Clear();

                Console.WriteLine("Welcome to Aplikasi Dadu v1.0");
                Console.WriteLine("\nKamu akan diberi 3x Kesempatan untuk roll dadu");

                RollDadu();
                gameOn = checkRollChance();
            }while(gameOn);
        }

        private void RollDadu()
        {
            int[] skorDadu = new int[roll];
            int total = 0;
            for (int i = 0; i < roll; i++)
            {
                skorDadu[i] = dice.Next(1, 7);
                Console.WriteLine($"Dadu ke-{i + 1} adalah {skorDadu[i]}");
                total += skorDadu[i];
                Thread.Sleep(500);
            }
            Console.WriteLine($"Total dadu yang didapat {total}");
        }
        private bool checkRollChance()
        {
            remainRoll--;
            if(remainRoll <= 0)
            {
                Console.Write("Mau main Lagi (Y/N) ");
                inputUser = char.ToLower(Console.ReadKey(true).KeyChar);
                if(inputUser == 'y')
                {
                    return true;
                }
                else if(inputUser == 'n')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
