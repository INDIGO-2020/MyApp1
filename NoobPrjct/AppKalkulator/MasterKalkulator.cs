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

        public void InputUser()
        {
            Console.Write($"Operand Kiri: ");
            var inputPertama = double.Parse(Console.ReadLine());
            Console.Write($"Operan Kanan: ");
            var inputKedua = double.Parse(Console.ReadLine());
            OperandA = inputPertama;
            OperandB = inputKedua;

        }
        public double Tambah()
        {
            return OperandA + OperandB;
        }

        public double Kurangi()
        {
            return OperandA - OperandB;
        }

        public double Kali()
        {
            return OperandA * OperandB;
        }

        public double Bagi()
        {
            return OperandA / OperandB;
        }

        public double Modulus()
        {
            return OperandA % OperandB;
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
                    "9. Exit App\n");

                Console.Write("Pilih: ");
                inputUser = int.Parse(Console.ReadLine());
                switch (inputUser)
                {
                    case 1:
                        //Penjumalahan
                        kalkulator.InputUser();
                        Console.WriteLine($"Hasil Penjumlahan: {kalkulator.Tambah()}");
                        Console.ReadLine();
                        break;

                    case 2:
                        //Pengurangan
                        kalkulator.InputUser();
                        Console.WriteLine($"Hasil Pengurangan: {kalkulator.Kurangi()}");
                        Console.ReadLine();
                        break;

                    case 3:
                        //Perkalian
                        kalkulator.InputUser();
                        Console.WriteLine($"Hasil Perkalian: {kalkulator.Kali()}");
                        Console.ReadLine();
                        break;

                    case 4:
                        //Pembagian
                        kalkulator.InputUser();
                        Console.WriteLine($"Hasil Pembagian: {kalkulator.Bagi()}");
                        Console.ReadLine();
                        break;

                    case 5:
                        //Hasil Bagi
                        kalkulator.InputUser();
                        Console.WriteLine($"Hasil Bagi: {kalkulator.Modulus()}");
                        Console.ReadLine();
                        break;

                    default:
                        break;

                }
            } while (inputUser != 9);
        }
    }
}
