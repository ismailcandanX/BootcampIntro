using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java Kursu";

            // array = dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı" ,
                "Programlamaya başlangıç için temel kurs" ,
            "Java Kursu" , "Phyton" , "React"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Finished :)");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - Footer");

        }
    }
}
