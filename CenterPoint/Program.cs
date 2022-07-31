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
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            CenterPoint(x1, y1, x2, y2);

            static void CenterPoint(int x1, int y1, int x2, int y2)
            {
                int x1Work = x1;
                int y1Work = y1;
                int x2Work = x2;
                int y2Work = y2;
                if (x1 < 0)
                {
                    x1Work = x1Work * -1;
                }
                if (y1 < 0)
                {
                    y1Work = y1Work * -1;
                }
                if (x2 < 0)
                {
                    x2Work = x2Work * -1;
                }
                if (y2 < 0)
                {
                    y2Work = y2Work * -1;
                }

                int sum1 = x1Work + y1Work;
                int sum2 = x2Work + y2Work;

                if (sum1 < sum2)
                {
                    Console.WriteLine("(" + x1 + ", " + y1 + ")");
                }
                else
                {
                    Console.WriteLine("(" + x2 + ", " + y2 + ")");
                }
            }
        }
    }
}