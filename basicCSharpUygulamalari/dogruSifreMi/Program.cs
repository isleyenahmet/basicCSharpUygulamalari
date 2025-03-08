using System;

namespace dogruSifreMi {
    class Program
    {
        static void Main(string[] args)
        {
            int sifre = 4596;
            int tahminHakki = 3;
            Console.WriteLine("Sisteme Giris Yapabilmeniz Icın 3 Hakkiniz Vardir. Yanlışsa Sistem Bloke Olur!\n");
           

            while(tahminHakki != 0)
            {
                Console.Write("Lutfen Sifre Tahmininizi Giriniz: ");
                int tahmin = int.Parse(Console.ReadLine());

                if (tahmin == sifre)
                {
                    Console.WriteLine("Tebrikler Doğru Tahmin Ettiniz Sifreniz: " + sifre);
                    break;
                }
                else
                {
                    tahminHakki = tahminHakki - 1;
                    if (tahminHakki == 0)
                    {
                        Console.WriteLine("3 Kere Yanlış Deneme Yaptiginiz icin Sistem Bloke Olmuştur.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Tahmininiz Yanlış. " + tahminHakki + " hakkınız Kalmistir.");
                    }

                }
            }
        }
    }
}

