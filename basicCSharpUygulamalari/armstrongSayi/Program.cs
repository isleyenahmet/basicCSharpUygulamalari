using System;

namespace armstrongSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int klon, rakam;
            int us = 0;
            double toplam = 0;
            Console.Write("Lutfen Bir Sayi Giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            klon = sayi;  // sayi degerini korumam gerek!!
            while(klon != 0)
            {
                klon = klon / 10;
                us = us + 1;
            }
            klon = sayi;
            while(klon != 0)
            {
                rakam = klon % 10;
                klon = klon / 10;
                toplam = toplam + Math.Pow(rakam, us);
            }
            int newToplam = Convert.ToInt32(toplam);
            if(sayi == newToplam)
            {
                Console.WriteLine("Sayiniz Armastrongdur.");
            }
            else
            {
                Console.WriteLine("Sayiniz Armastrong Degildir.");

            }

        }
    }
}