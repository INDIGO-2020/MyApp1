using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewbiePrjct.AppATM
{
    public class BankAccount
    {
        public int Pin { get; set; }
        public string? Amount { get; set; }
        public double Saldo { get; set; }
        public string? Nama { get; set; }

        public bool validPin(int _pin)
        {
            if (_pin == Pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double cekSaldo()
        {
            return Saldo;
        }

        public bool withDraw(double amount)
        {
            if (amount <= Saldo)
            {
                Saldo -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Deposit(double amount)
        {
            Saldo += amount;
            return Saldo;
        }


        /*
         * Untuk menjalankan Aplikasi ini, Invoke Method dibawah ke Program.cs
         */

        //public void Execute()
        //{
        //    BankAccount bankAccount = new BankAccount();
        //    bankAccount.Pin = 1234;
        //    bankAccount.Saldo = 200000;
        //    bankAccount.Nama = "AnggaAF";

        //    Console.WriteLine("Welcome to ATM Mandiri");
        //    Console.Write("Silahkan Masukkan Pin Anda: ");
        //    int pin = int.Parse(Console.ReadLine());
        //    bool cekPin = bankAccount.validPin(pin);

        //    if (cekPin)
        //    {
        //        Console.WriteLine($"Hello {bankAccount.Nama}");
        //        Console.WriteLine("**=======**");
        //    }
        //    else
        //    {
        //        Console.WriteLine("pin salah!");
        //    }

        //    //TODO: membuat 3 Menu utama Aplikasi ATM
        //    Console.Write("1.Cek Saldo\n" +
        //        "2. WD\n" +
        //        "3. Depo\n");
        //    Console.Write("Pilih: ");
        //    int opsiUser = int.Parse(Console.ReadLine());

        //    //TODO: menerapkan function dari ketiga menu diatas tersebut
        //    switch (opsiUser)
        //    {
        //        case 1:
        //            double saldo = bankAccount.Saldo;
        //            Console.Write($"Saldo anda: Rp.{saldo}");
        //            break;

        //        case 2:
        //            Console.Write("Masukkan jumlah yang ditarik: Rp.");
        //            double amountWithdraw = double.Parse(Console.ReadLine());
        //            bool cekAmount = bankAccount.withDraw(amountWithdraw);
        //            if (cekAmount)
        //            {
        //                Console.WriteLine($"Penarikan berhasil! Sisa Saldo: Rp.{bankAccount.Saldo},-");
        //            }
        //            else
        //            {
        //                Console.WriteLine($"Saldo tidak mencukupi untuk ditarik. Saldo Anda {bankAccount.Saldo}");
        //            }
        //            break;
        //        case 3:
        //            Console.Write("Silahkan masukkan jumlah uang yang di depositkan: ");
        //            double amountDeposit = double.Parse(Console.ReadLine());
        //            Console.WriteLine("Tunggu Sebentar");
        //            double saldoTerbaru = bankAccount.Deposit(amountDeposit);
        //            Console.WriteLine($"Berhasil ditambahkan! Saldo anda: {saldoTerbaru}");
        //            break;
        //        default:
        //            Console.WriteLine("Pilihan tidak valid");
        //            break;
        //    }
        //}
    }
}
