/* ATTENTION !!
 * UNTUK MENJALANKAN PROGRAM KALKULATOR INI, HAL YANG PERLU DILAKUKAN ADALAH:
 * 
 * 1. COPY SINTAKS YANG ADA PADA METHOD EXECUTE
 * 2. PASTE DI PROGRAM.CS
 * 3. RUN PROGRAM AND BOOM!
 */
namespace NoobPrjct.AppKalkulator
{
    //JALAN PIKIRKU KALA MEMBUAT APP INI:
    //1. Bikin Kalkulator App
    //2. Implementasikan Inheritance
    //3. Implementasikan Looping
    //4. Implementasikan Method
    public class MasterKalkulator
    {
        public MasterKalkulator()
        {

        }
        public double OperandA { get; set; }
        public double OperandB { get; set; }
        private List<double> historyCalculator = new List<double>();
        public void InputUser()
        {
            Console.Write($"Operand Kiri: ");
            var inputPertama = double.Parse(Console.ReadLine());
            Console.Write($"Operan Kanan: ");
            var inputKedua = double.Parse(Console.ReadLine());
            OperandA = inputPertama;
            OperandB = inputKedua;

        }
        private double Tambah()
        {
            return OperandA + OperandB;
        }

        private double Kurangi()
        {
            return OperandA - OperandB;
        }

        private double Kali()
        {
            return OperandA * OperandB;
        }

        private double Bagi()
        {
            return OperandA / OperandB;
        }

        private double Modulus()
        {
            return OperandA % OperandB;
        }

        private int Factorial(int n)
        {
            if (n == 1)
            { 
                return 1; 
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        private void historyCalculate()
        {
            int count = 0;
            if(historyCalculator.Count == 0)
            {
                Console.WriteLine("belum ada history");
            }
            else
            {
                foreach (var item in historyCalculator)
                {
                    count++;
                    Console.WriteLine($"{count}. {item}");
                }
            }
            Console.ReadLine();
        }
        public void Execute()
        {
            int? inputUser;
            MasterKalkulator kalkulator = new();
            do
            {
                Console.Clear();
                Console.WriteLine("Aplikasi Kalkulator Terminal");
                Console.WriteLine("By Angga | Sept 2024");
                Console.WriteLine("*====*\n");

                Console.WriteLine("1. Penjumlahan\n" +
                    "2. Pengurangan\n" +
                    "3. Perkalian\n" +
                    "4. Pembagian\n" +
                    "5. Hasil Bagi\n" +
                    "6. Faktorial\n" +
                    "7. History\n" +
                    "9. Exit App\n");

                Console.Write("Pilih: ");
                inputUser = int.Parse(Console.ReadLine());
                switch (inputUser)
                {
                    case 1:
                        //Penjumalahan
                        InputUser();
                        Console.WriteLine($"Hasil Penjumlahan: {Tambah()}");
                        historyCalculator.Add(Tambah());
                        Console.ReadLine();
                        break;

                    case 2:
                        //Pengurangan
                        InputUser();
                        Console.WriteLine($"Hasil Pengurangan: {Kurangi()}");
                        historyCalculator.Add(Kurangi());
                        Console.ReadLine();
                        break;

                    case 3:
                        //Perkalian
                        InputUser();
                        Console.WriteLine($"Hasil Perkalian: {Kali()}");
                        historyCalculator.Add(Kali());
                        Console.ReadLine();
                        break;

                    case 4:
                        //Pembagian
                        InputUser();
                        Console.WriteLine($"Hasil Pembagian: {Bagi()}");
                        historyCalculator.Add(Bagi());
                        Console.ReadLine();
                        break;

                    case 5:
                        //Hasil Bagi
                        InputUser();
                        Console.WriteLine($"Hasil Bagi: {Modulus()}");
                        historyCalculator.Add(Modulus());
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.Write("Masukkan nilai n: ");
                        OperandA = double.Parse(Console.ReadLine());
                        int faktorial = (int)OperandA;
                        Console.WriteLine($"hasil Faktorial {OperandA}!: {Factorial(faktorial)}");
                        historyCalculator.Add(Factorial(faktorial));
                        Console.ReadLine();
                        break;
                    case 7:
                        historyCalculate();
                        break;
                    default:
                        break;

                }
            } while (inputUser != 9);
        }
    }
}
