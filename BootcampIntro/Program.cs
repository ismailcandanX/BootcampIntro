using System;

namespace BootcampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety = tip güvenliği
            // Do not repeat yourself = Kendini tekrarlama
            // kategoriEtiketi, değer tutucu, alias

            string kategoriEtiketi = "kategoriler";
            Console.WriteLine(kategoriEtiketi);
            int ogrenciSayısı = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmısMı = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (sistemeGirisYapmısMı == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else if (dolarBugun < dolarDun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else
            {
                Console.WriteLine("Değişmedi Oku");
            }

        }
    }
}
