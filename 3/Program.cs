using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a factor A: ");
            double factorA = double.Parse(Console.ReadLine());

            if (factorA == 0)
            {
                Console.WriteLine("it is not a quadratic equation");
            }
            else
            {
                Console.WriteLine("Enter a factor B: ");
                double factorB = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter a factor C: ");
                double factorC = double.Parse(Console.ReadLine());

                double delta = factorB * factorB - 4 * factorA * factorC;
                double squareroot1, squareroot2;
                   
                if (delta > 0)
                {
                    squareroot1 = (-factorB + Math.Sqrt(delta)) / 2 * factorA;
                    squareroot2 = (-factorB - Math.Sqrt(delta)) / 2 * factorA;

                    Console.WriteLine("squareroots of this quadratic equation are: " + squareroot1 + " and " + squareroot2);
                }
                else if (delta == 0)
                {
                    double squareroot0 = -factorB / 2 * factorA;

                    Console.WriteLine("Squareroot of this quadratic equation is: " + squareroot0);
                    
                }
                else
                {
                    Console.WriteLine("This quadratic equation has no results");
                }

            }

            Console.ReadLine();
        }
    }
}
