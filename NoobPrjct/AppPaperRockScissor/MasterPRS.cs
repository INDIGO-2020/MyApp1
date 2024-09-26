using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoobPrjct.AppPaperRockScissor
{

    /*
     * UNTUK ANGGA BILA NANTI UDAH JADI PROGRAMMER YANG MANTAP DAN HUMBLE
     * TOLONG SELESAIKAN APLIKASI GAMPANG INI, NIATKU INGIN MEMBUAT APLIKASI
     * KERTAS-GUNTING-BATU DENGAN USER INPUT DAN RANDOMIZE COMPUTER MELALUI 
     * OUTPUT ARRAY 2 DIMENSI.
     * 
     * YANG JELAS AKU PENGEN LIAT INI PROGRAM JALAN.
     */
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
        private string? playerInput = null;
        private string? computerInput;
        private bool gameOn;

        private int checkSpaceKosong()
        {
            int spaceKosong = 2;

            for (int i = 0; i < PRSBoard.GetLength(0); i++)
            {
                for (int j = 0; j < PRSBoard.GetLength(1); j++)
                {
                    if (PRSBoard[i, j] != " ")
                    {
                        spaceKosong--;
                    }
                }
            }
            return spaceKosong;
        }
        private void computerMove()
        {
            Random random = new Random();
            int x;

            if (checkSpaceKosong() > 0)
            {
                do
                {
                    x = random.Next(3);
                    break;
                } while (PRSBoard[x, x] == null);
                computerInput = PRSList[x];

                PRSBoard[x, 1] = computerInput;
            }

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

                PRSBoard[x, x] = playerInput;
                break;
            } while (PRSBoard[x, x] == " ");
        }

        private void printBoard()
        {
            for (int i = 0; i < PRSBoard.GetLength(0); i++)
            {
                for (int j = 0; j < PRSBoard.GetLength(1); j++)
                {
                    Console.Write($"{PRSBoard[i, j]}");
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
            Console.WriteLine("\t\t**PENTING**");
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
