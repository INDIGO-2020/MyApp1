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

        }
        public void Execute()
        {
            computerMove();
        }
    }
}
