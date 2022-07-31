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
            int end = int.Parse(Console.ReadLine());

            TopNumbersInRange(end);

            static void TopNumbersInRange(int end)
            {
                for (int i = 1; i <= end; i++)
                {
                    int sum = 0;
                    int length = i.ToString().Length;
                    int divider = 1;
                    bool containsOdd = false;
                    for (int y = 0; y < length; y++)
                    {
                        sum += (i / divider) % 10;
                        if (((i / divider) % 10) % 2 != 0)
                        {
                            containsOdd = true;
                        }
                        divider *= 10;
                    }

                    if (sum % 8 == 0 && containsOdd == true)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}