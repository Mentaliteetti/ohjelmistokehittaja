using System;

namespace laskuharjoituksia
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            {


                //Harjoitus 1
                Console.Write("Anna Ensimmäinen numero");

                int Luku1 = int.Parse(Console.ReadLine());

                Console.Write("Anna Toinen numero");
                int Luku2 = int.Parse(Console.ReadLine());
                {
                    Console.WriteLine(Luku1 = Luku2 + 3);

                    //Harjoitus 2
                    Console.Write("Anna Ensimmäinen numero");
                    _ = int.Parse(Console.ReadLine());
                    Console.Write("Anna Toinen numero");
                    _ = int.Parse(Console.ReadLine());
                    Console.WriteLine(Luku1 = Luku2 - 2);

                    //Harjoitus 3
                    Console.Write("Anna Ensimmäinen numero");
                    int.Parse(Console.ReadLine());
                    Console.Write("Anna Toinen numero");
                    _ = int.Parse(Console.ReadLine());
                    Console.WriteLine(Luku1 = Luku2 * 5);

                    //Harjoitus 4
                    Console.Write("Anna Ensimmäinen numero");
                    _ = int.Parse(Console.ReadLine());
                    Console.Write("Anna Toinen numero");
                    _ = int.Parse(Console.ReadLine());
                    Console.WriteLine(Luku1 = Luku1 / Luku2);

                    //Harjoitus 5
                    Console.Write("Anna Ensimmäinen numero");
                    _ = int.Parse(Console.ReadLine());
                    Console.Write("Anna Toinen numero");
                    _ = int.Parse(Console.ReadLine());
                    Console.WriteLine("Luku1 % Luku2 = 4");



                }
            }
        }
    }
}

