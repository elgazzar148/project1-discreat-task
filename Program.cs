using System;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("***************");
            Console.Write("Enter n2: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("***************");
            Console.WriteLine();


            for (int i = n1; i <= n2; i++)
            {

                
                for (int y = 2; y <=i; y++)
                {
                    if (i % y == 0)

                    {
                        break;
                    }

                    if (y == i - 1)
                    {
                        Console.Write("---" + i);
                        
                        
                    }

                }


            }
        }
    }
}
