using System;

namespace laskuharjoituksia
{
    class Program
    {
         public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Harjoitus 1
            Console.Write("Anna ensimmäinen numero");
            int Luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna Toinen numero");
            int Luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Luku1 = Luku2 + 3);
            {
                //Harjoitus 2
                Console.Write("Anna ensimmäinen numero");
                int Luku1 = int.Parse(Console.ReadLine());
                Console.Write("Anna Toinen numero");
                int Luku2 = int.Parse(Console.ReadLine());
                Console.WriteLine(Luku1 = Luku2 + 3);
            }
            {
                //Harjoitus 3
                Console.Write("Anna ensimmäinen numero");
                int Luku1 = int.Parse(Console.ReadLine());
                Console.Write("Anna Toinen numero");
                int Luku2 = int.Parse(Console.ReadLine());
                Console.WriteLine(Luku1 = Luku2 + 3);
            }
       
        }
    }
}
