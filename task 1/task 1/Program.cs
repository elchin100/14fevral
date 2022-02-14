using System;

namespace wichoneisbigmethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("uc eded sira ile deyer daxil edin ve neticeni gozleyin");
            string b = Console.ReadLine();
            int eded = int.Parse(b);


            Console.WriteLine("ikinci deyeri daxil edin");
            string c = Console.ReadLine();
            int eded1 = int.Parse(c);
            Console.WriteLine("ucuncu deyeri daxil edin ve, netice size en boyuk reqemi gosterecek");
            string d = Console.ReadLine();
            int eded2 = int.Parse(d);
            if (eded == eded1 && eded1 == eded2)
            {
                Console.WriteLine("beraberlik var ");

            }

            else Console.WriteLine(Biggernumber(eded, eded1, eded2));


        }
        static int Biggernumber(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;

            }

            else if (b > a && b > c)
            {

                return b;
            }
            else return c;




        }









    }
}