

using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace NoobPrjct.AppPaperRockScissor
{
    public class MasterPRSv2
    {
        private string? playerInput;
        private string? computerInput;
        List<string> listofPRS = new List<string>()
        {
            "Paper",
            "Rock",
            "Scissor"
        };
        bool gameState = true;

        private void playerChoose()
        {

            int x;
            while (playerInput != " ")
            {
                Console.Write("Masukkan Angka#(1-3): ");
                x = int.Parse(Console.ReadLine());
                x--;

                playerInput = listofPRS[x];
                break;
            }
        }

        private void computerChoose()
        {
            Random random = new Random();
            int y;

            do
            {
                y = random.Next(3);
                break;
            } while (computerInput != " ");
            computerInput = listofPRS[y];
        }

        private string printDeterminedWinner(string _inputUser, string _inputComputer)
        {
            _inputUser = playerInput;
            _inputComputer = computerInput;
            int result;

            Console.WriteLine($"{_inputUser} vs {_inputComputer}");

            result = (listofPRS.IndexOf(_inputUser) - listofPRS.IndexOf(_inputComputer) + 3) % 3;
            if (_inputUser == _inputComputer)
            {
                Console.WriteLine("Draw");
            }
            else if (result == 1)
            {
                Console.WriteLine("Computer Menang");
            }
            else
            {
                Console.WriteLine("Player Menang");
            }
            return " ";
        }


        public void Execute()
        {
            char inputResult;
            Console.WriteLine("Selamat datang di Aplikasi Paper-Rock-Scissor v2.0 (beta)\n");
            Console.WriteLine("\t\t**PENTING**");
            Console.WriteLine("Anda hanya perlu Meng-input angka pada List dibawah ini");

            for (int i = 0; i < listofPRS.Count; i++)
            {
                Console.WriteLine($"Angka {i + 1} untuk {listofPRS[i]}");
            }
            Console.WriteLine();

            do
            {
                playerChoose();
                computerChoose();

                printDeterminedWinner(playerInput, computerInput);
                Console.Write("Mau main Lagi (Y/N): ");
                inputResult = char.Parse(Console.ReadLine().ToLower());
                if (inputResult == 'n')
                    break;
                else
                    gameState = false;

            } while (gameState != true);
        }
    }
}
