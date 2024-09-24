using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewbiePrjct.AppReadWriteFile
{
    public class ReadWriteDemo
    {
        public void Execute()
        {
            /*
             * Sintaks ini berfungsi untuk mengevaluasi method Combine yang ada pada Class Path
             * yang terdapat 3 parameternya diisikan method GetCurrentDirectory() yang berfungsi
             * untuk melacak posisi file project ini berada, 2 parameter sisanya adalah string
             * yang me-return nilai yang digunakan untuk alamat folder
             * 
            */
            var newDirPath = Path.Combine(Directory.GetCurrentDirectory(), "Folder Baru", "Contoh");
            /*
             * sintaks dibawah intinya adalah Membuat Directory/Folder dengan value yang mereferensi
             * pada variabel diatas. 
             */
            Directory.CreateDirectory(newDirPath);

            /*
             * sama halnya seperti yang pertama, bedanya Method Combine ini mengevaluasi variabel 
             * 'newDirPath' dan string tersebut.
             * Dan selanjutnya value tersebut disimpan di variabel newFilePath
             */
            var newFilePath = Path.Combine(newDirPath, "File Baru.txt");
            
            /*
             * fungsi pembuatan variabel diatas adalah untuk menentukan parameter dari method Create
             * dibawah yang berfungsi untuk membuat file dengan nama File baru.txt
             * value tersebut disimpan kedalam variabel fileStream bertipekan var: (File)
             */
            var fileStream = File.Create(newFilePath);

            using var stringWrite = new StreamWriter(fileStream);
            for (int i = 1; i <= 5; i++)
            {
                stringWrite.WriteLine($"baris ke-{i}");
            }


            using var stringRead = new StringReader(newFilePath);
            bool readFile = true;
            while (readFile)
            {
                var line = stringRead.ReadLine();
                if (string.IsNullOrEmpty(line))
                    readFile = false;
                Console.Write(line);
            }

        }
    }
}
