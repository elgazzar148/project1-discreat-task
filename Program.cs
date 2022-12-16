using System;

namespace PROJECT2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        int sum = 0 ;
        Console.Write("Enter Your n1: ");
          int  N1 = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("**************");
            Console.WriteLine("");

            Console.Write("Enter Your n2: ");
          int  N2 = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("**************");
            Console.WriteLine("");

            for (int i = N1; i <= N2; i++)
            {
                int j = 1;

                while (j < i && i > 5)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                    j++;

                }
                if (sum == i)
                {
                    Console.Write("----" + i + "---");
                }

                sum = 0;
            }
            }
            
    }
}
