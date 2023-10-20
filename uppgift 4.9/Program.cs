using System;
namespace uppgift_4_9
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in hur många stjärnor som kateten ska vara.");
            int tal = int.Parse(Console.ReadLine());

            for (int i = 0; i < tal; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
            Console.ReadKey();
        }
    }
}
