using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoobPrjct.AppPaperRockScissor
{
    public class MasterPRS
    {
        private string[,] PRSBoard = new string[1, 2];
        private List<string> PRSList = new List<string>()
        {
            "Paper",
            "Rock",
            "Scissor"
        };
        private string winner = " ";
        private string? playerInput = "...";
        private string? computerInput = "...";
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
                if (playerInput == null || playerInput == " ")
                {
                    Console.Write("Invalid Input");
                }
                else
                {
                    PRSBoard[x,x] = playerInput;
                    break;
                }
            } while (PRSBoard != null);
        }

        private void printBoard()
        {
            for (int i = 0; i < PRSBoard.GetLength(0); i++)
            {
                for (int j = 0; j < PRSBoard.GetLength(1); j++)
                {
                    Console.Write($"{PRSBoard[i,j]}");
                    if (j < PRSBoard.GetLength(1) - 1)
                        Console.Write(" vs ");
                }
            Console.WriteLine();
            }
        }
        public void Execute()
        {
            char inputUser;
            int angka = 0;
            Console.WriteLine("Selamat datang di Aplikasi Paper-Rock-Scissor v1.0 (testing)\n");
            Console.WriteLine("\t\t\t**PENTING**");
            Console.WriteLine("Anda hanya perlu Meng-input angka pada List dibawah ini");
            for (int i = 0; i < PRSList.Count; i++)
            {
                angka++;
                Console.WriteLine($"Angka {angka} untuk {PRSList[i]}");
            }
            Console.WriteLine();
            do
            {
                playerMove();
                printBoard();
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
