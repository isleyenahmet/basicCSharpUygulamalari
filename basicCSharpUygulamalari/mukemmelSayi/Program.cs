using System;

namespace mukemmelSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            Console.WriteLine("Mukemmel Sayi Uygulamasina Hos Geldiniz\n");

            Console.Write("Lutfen Bir Sayi Giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            for(int i = 1; i <= sayi/2; i++)
            {
                if(sayi % i == 0)
                {
                    toplam = toplam + i;
                }
            }
            
            if(toplam == sayi)
            {
                Console.WriteLine(sayi + " Mukemmel Bir Sayidir.");
            }
            else
            {
                Console.WriteLine(sayi + " Mukemmel Sayi Degildir.");
            }
        }
    }
}