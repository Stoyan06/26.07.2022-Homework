namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Checker(a, b, c);

            static void Checker(int a, int b, int c)
            {
                int negativeCounter = 0;
                if (a == 0 || b == 0 || c == 0)
                {
                    Console.WriteLine("zero");
                    return;
                }


                if (a < 0)
                    negativeCounter++;

                if (b < 0)
                    negativeCounter++;

                if (c < 0)
                    negativeCounter++;

                if (negativeCounter == 0)
                {
                    Console.WriteLine("positive");
                    return;
                }

                if (negativeCounter % 2 == 0)
                {
                    Console.WriteLine("positive");
                }
                else
                {
                    Console.WriteLine("negative");
                }
            }
        }
    }
}