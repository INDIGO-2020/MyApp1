using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoobPrjct.AppPaperRockScissor
{
    public class MasterPRS
    {
        private string[,] PRSBoard = new string[0, 1];
        private List<string> PRSList = new List<string>()
        {
            "Paper",
            "Rock",
            "Scissor"
        };
        private string winner = " ";
        private string? playerInput = null;
        private string? computerInput = null;
        private bool gameOn;
        private void computerMove()
        {
            Random random = new Random();
            int computerRandomize;

            computerRandomize = random.Next(0, PRSList.Count);
            computerInput = PRSList[computerRandomize];

            Console.WriteLine(computerInput);
        }

        private void playerMove()
        {
            int x;

            do
            {
                Console.Write("Masukkan Angka#(1-3): ");
                x = int.Parse(Console.ReadLine());
                x--;
                playerInput = PRSList[x];
                if (playerInput == null)
                {
                    Console.Write("Invalid Input");
                }
                else
                {
                    Console.WriteLine(playerInput);
                    break;
                }
            } while (gameOn);
        }
        public void Execute()
        {
            char inputUser;
            do
            {
                playerMove();
                computerMove();
                Console.Write("Mau main Lagi (Y/N): ");
                inputUser = char.Parse(Console.ReadLine().ToLower());
                if (inputUser == 'n')
                    break;
                else gameOn = true;
            } while (gameOn);
        }
    }
}
