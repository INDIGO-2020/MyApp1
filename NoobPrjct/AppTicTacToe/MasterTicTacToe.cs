using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoobPrjct.AppTicTacToe
{
    public class MasterTicTacToe
    {
        public MasterTicTacToe()
        {

        }

        private char winner = ' ';
        private char[,] ticTacBoard = new char[3, 3];
        private const char PLAYER = 'X';
        private const char COMPUTER = 'O';
        private char inputUser;

        private void resetBoard()
        {
            for (int row = 0; row < ticTacBoard.GetLength(0); row++)
            {
                for (int col = 0; col < ticTacBoard.GetLength(1); col++)
                {
                    ticTacBoard[row, col] = ' ';
                }
            }
        }

        private void printBoard()
        {
            for (int i = 0; i < ticTacBoard.GetLength(0); i++)
            {
                for (int j = 0; j < ticTacBoard.GetLength(1); j++)
                {
                    Console.Write($" {ticTacBoard[i, j]} ");
                    if (j < ticTacBoard.GetLength(1) - 1)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
                if (i < ticTacBoard.GetLength(0) - 1)
                {
                    Console.WriteLine("---|---|---");
                }
            }
        }


        /*             -- PENJELASAN --
         * Method checkSpaceKosong() ini akan melakukan looping-
         *  pada tiap index ticTacBoard (array dua dimensi).
         * Apabila ditemukan index yang masih kosong selama looping 
         *  maka variabel lokal tersebut akan dikurangi 1.
         * Proses looping akan terus berjalan sampai lokal variabel bernilai 0.
         */
        private int checkSpaceKosong()
        {
            int spaceKosong = 9;

            for (int i = 0; i < ticTacBoard.GetLength(0); i++)
            {
                for (int j = 0; j < ticTacBoard.GetLength(1); j++)
                {
                    if (ticTacBoard[i, j] != ' ')
                    {
                        spaceKosong--;
                    }
                }
            }
            return spaceKosong;
        }

        private void playerMove()
        {
            int x;
            int y;

            do
            {

                Console.Write("Enter baris #(1-3): ");
                x = int.Parse(Console.ReadLine());
                x--;
                Console.Write("\nEnter kolom #(1-3): ");
                y = int.Parse(Console.ReadLine());
                y--;

                if (ticTacBoard[x, y] != ' ')
                {
                    Console.WriteLine("Invalid Move");
                }
                else
                {
                    ticTacBoard[x, y] = PLAYER;
                    break;
                }
            } while (ticTacBoard[x, y] != ' ');
        }

        private char checkWinner()
        {
            //cek baris
            for (int i = 0; i < ticTacBoard.GetLength(0); i++)
            {
                if (ticTacBoard[i, 0] == ticTacBoard[i, 1] && ticTacBoard[i, 0] == ticTacBoard[i, 2] && ticTacBoard[i, 0] != ' ')
                {
                    return ticTacBoard[i, 0];
                }
            }

            //cek kolom
            for (int i = 0; i < ticTacBoard.GetLength(0); i++)
            {
                if (ticTacBoard[0, i] == ticTacBoard[1, i] && ticTacBoard[0, i] == ticTacBoard[2, i] && ticTacBoard[0, i] != ' ')
                {
                    return ticTacBoard[0, i];
                }
            }

            //cek diagonal kiri-bawah kanan
            if (ticTacBoard[0, 0] == ticTacBoard[1, 1] && ticTacBoard[0, 0] == ticTacBoard[2, 2] && ticTacBoard[0,0] != ' ')
            {
                return ticTacBoard[0, 0];
            }
            //cek diagonal kanan-bawah kiri
            if (ticTacBoard[0, 2] == ticTacBoard[1, 1] && ticTacBoard[0, 2] == ticTacBoard[2, 0] && ticTacBoard[0,2] != ' ')
            {
                return ticTacBoard[0, 2];
            }
            return ' ';
        }

        private void computerMove()
        {
            Random random = new();

            int x;
            int y;

            if (checkSpaceKosong() > 0)
            {
                do
                {
                    x = random.Next(3);
                    y = random.Next(3);
                } while (ticTacBoard[x, y] != ' ');
                ticTacBoard[x, y] = COMPUTER;
            }
            else
            {
                printWinner(' ');
            }
            Console.Clear();

        }

        private void printWinner(char winner)
        {
            if (winner == PLAYER)
            {
                Console.WriteLine("YOU WIN!");
            }
            else if (winner == COMPUTER)
            {
                Console.WriteLine("YOU LOSE!");
            }
            else
            {
                Console.WriteLine("DRAW");
            }
        }
        public void Execute()
        {
            do
            {

                winner = ' ';
                inputUser = ' ';
                Console.Clear();
                resetBoard();

                while (winner == ' ' && checkSpaceKosong() != 0)
                {
                    printBoard();

                    playerMove();
                    winner = checkWinner();
                    if (winner != ' ' || checkSpaceKosong() == 0)
                    {
                        break;
                    }

                    computerMove();
                    winner = checkWinner();
                    if (winner != ' ' || checkSpaceKosong() == 0)
                    {
                        break;
                    }
                }

                if (checkSpaceKosong() == 0 && winner == ' ')
                {
                    printWinner(winner);
                }
                else
                {
                    printWinner(winner);
                }
                Console.Write("Mau main Lagi (Y/N): ");
                inputUser = char.Parse(Console.ReadLine().ToLower());
                if (inputUser == 'n')
                    break;
            } while (inputUser == 'y');
        }
    }
}
