using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Super markette aksiyadir, aldiginiz uc mehsulun qiymetini sira daxil edin. Sadece iki en bahali malin qiymetini oduyeceksiniz.");
            string mehsulsayi = Console.ReadLine();
            int say = int.Parse(mehsulsayi);
            int[] arr = new int[say];

            Console.WriteLine("Diger mehsulu daxil edin.");
            string mehsulsayi1 = Console.ReadLine();
            int say1 = int.Parse(mehsulsayi1);
            int[] arr1 = new int[say1];


            Console.WriteLine("son mehsulu daxil edin.");
            string mehsulsayi2 = Console.ReadLine();
            int say2 = int.Parse(mehsulsayi2);
            int[] arr2 = new int[say2];
            Console.WriteLine(Cheeper(say1, say2, say));

        }
        static int Cheeper(int a, int b, int c)

        {
            if (a < b && a < c)
            {
                return c + b;
            }
            else if (b < a && b < c)
            {
                return a + c;

            }
            else return a + b;
        }



    }
}