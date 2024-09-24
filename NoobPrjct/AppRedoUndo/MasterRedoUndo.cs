using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoobPrjct.AppRedoUndo
{
    public class MasterRedoUndo
    {
        /*      --- PENJELASAN ---
         * Method dibawah merupakan implementasi bagaimana Undo-Redo bekerja
         * 1. Aplikasi dimulai dengan mendeklarasikan Stack[Char]
         *  - redoStack berfungsi untuk menaruh nilai dari char yang diketikkan
         *  - undoStack untuk menaruh nilai yang telah dihapus dari redoStack
         *  - redoStack dan undoStack memiliki tujuan yang sama; 
         *      'push(insert), pop(remove and return value)'.
         * 2. Proses eksekusi program berada dalam looping dengan kondisi awal True
         * 3. Ada 2 input yang digunakan yaitu 
         *      Console.Key.LeftArrow; 
         *      Console.Key.RightArrow;
         * 3. LeftArrow untuk Menjalankan Logika 'Undo' tiap huruf yang telah diketik
         * 4. RightArrow untuk menjalankan Logika 'Redo' tiap huruf yang pernah diketik
         */
        public void Execute()
        {
            Stack<char> redoStack = new Stack<char>();
            Stack<char> undoStack = new Stack<char>();
            bool runProgram = true;

            while (runProgram)
            {
                var key = Console.ReadKey(false).Key;
                switch (key)
                {
                    /*      --- PENJELASAN ---
                     * cek aja di CHATGPT, lebih rinci.
                     */
                    case ConsoleKey.LeftArrow:
                        undoStack.Push(redoStack.Pop());
                        Console.Clear();
                        PrintChar(redoStack);
                        break;
                    case ConsoleKey.RightArrow:
                        redoStack.Push(undoStack.Pop());
                        Console.Clear();
                        PrintChar(redoStack);
                        break;
                    default:
                        redoStack.Push((char)key);
                        break;
                }
            }
        }

        private void PrintChar(Stack<char> redoStack)
        {
            char[] stackPrintOut = redoStack.ToArray();
            for (int i = stackPrintOut.Length - 1; i >= 0; i--)
            {
                Console.Write(stackPrintOut[i].ToString().ToLower());
            }
        }
    }
}
