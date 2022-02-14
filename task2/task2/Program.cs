using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eded daxil edin");
            string eded = Console.ReadLine();
            int eded2 = int.Parse(eded);
            Console.WriteLine(ededcemi(eded2));



        }
        static int ededcemi(int a)
        {
            int count;
            int cem = 0;
            while (a > 0)
            {
                count = a % 10;
                a /= 10;
                cem += count;

            }
            return cem;


        }
    }
}