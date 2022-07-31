using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());

            Factoriel(a, b);

            static void Factoriel(double a, double b)
            {
                double result1 = 1;
                if (a == 0)
                {
                    result1 = 1;
                }
                else
                {
                    for (double i = a; i > 1; i--)
                    {
                        result1 *= i;
                    }
                }

                double result2 = 1;
                if (b == 0)
                {
                    result2 = 1;
                }
                else
                {
                    for (double i = b; i > 1; i--)
                    {
                        result2 *= i;
                    }
                }

                Console.WriteLine("{0:f2}", result1 / result2);
            }
        }
    }
}