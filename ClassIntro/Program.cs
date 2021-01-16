using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "ismail";
            int yas = 23;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 86;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "React";
            kurs2.Egitmen = "Engin Demirog";
            kurs2.IzlenmeOrani = 8;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "İsmail Candan";
            kurs3.IzlenmeOrani = 65;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Phyton";
            kurs4.Egitmen = "Engin Demirog";
            kurs4.IzlenmeOrani = 55;

            Kurs[] kurslar = new Kurs[] 
            { 
                kurs1, kurs2, kurs3, kurs4 
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            
            }

            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
