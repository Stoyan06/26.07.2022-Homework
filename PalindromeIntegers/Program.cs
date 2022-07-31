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
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                Check(input);
            }

            static void Check(string input)
            {
                string reversed = String.Empty;
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversed += input[i];
                }

                if (reversed == input)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }
    }
}