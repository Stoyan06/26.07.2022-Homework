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
            int input = int.Parse(Console.ReadLine());

            TribonacciSequence(input);

            static void TribonacciSequence(int input)
            {
                List<int> numbers = new List<int>();
                for(int i = 0; i < input; i++)
                {
                    if(i == 0 || i == 1)
                    {
                        numbers.Add(1);
                        continue;
                    }
                    int repeats = i;
                    if(repeats > 3)
                    {
                        repeats = 3;
                    }

                    numbers.Add(0);

                    for(int y = 1; y <= repeats; y++)
                    {
                        numbers[numbers.Count - 1] += numbers[numbers.Count - 1 - y];
                    }
                }
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
    }
}