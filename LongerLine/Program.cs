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
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            int y4 = int.Parse(Console.ReadLine());

            CenterPoint(x1, y1, x2, y2, x3, y3, x4, y4);

            static void CenterPoint(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
            {
                int x1Work = x1;
                int y1Work = y1;
                int x2Work = x2;
                int y2Work = y2;
                int x3Work = x3;
                int y3Work = y3;
                int x4Work = x4;
                int y4Work = y4;
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
                if (x3 < 0)
                {
                    x3Work = x3Work * -1;
                }
                if (y3 < 0)
                {
                    y3Work = y3Work * -1;
                }
                if (x4 < 0)
                {
                    x4Work = x4Work * -1;
                }
                if (y4 < 0)
                {
                    y4Work = y4Work * -1;
                }

                int sum1 = x1Work + y1Work;
                int sum2 = x2Work + y2Work;
                int sum3 = x3Work + y3Work;
                int sum4 = x4Work + y4Work;

                if (sum1 + sum2 < sum3 + sum4)
                {
                    if (sum3 < sum4)
                    {
                        Console.WriteLine("(" + x3 + ", " + y3 + ")" + " " + "(" + x4 + ", " + y4 + ")");
                    }
                    else
                    {
                        Console.WriteLine("(" + x4 + ", " + y4 + ")" + " " + "(" + x3 + ", " + y3 + ")");
                    }
                }
                else
                {
                    if (sum1 < sum2)
                    {
                        Console.WriteLine("(" + x1 + ", " + y1 + ")" + " " + "(" + x2 + ", " + y2 + ")");
                    }
                    else
                    {
                        Console.WriteLine("(" + x2 + ", " + y2 + ")" + " " + "(" + x1 + ", " + y1 + ")");
                    }
                }
            }
        }
    }
}