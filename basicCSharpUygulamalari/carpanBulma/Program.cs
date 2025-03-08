using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lutfen Carpanlarini Bulmak Istediginiz Sayiyi Giriniz: ");
        int sayi = int.Parse(Console.ReadLine());

        for(int i = 1; i <= sayi / 2; i++)
        {
            if(sayi % i == 0)
            {
                Console.Write(i + ", ");
            }
        }

    }
}
