namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if(type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                Print(a);
            }

            if (type == "double")
            {
                double b = double.Parse(Console.ReadLine());
                Print(b);
            }

            if (type == "string")
            {
                string c = Console.ReadLine();
                Print(c);
            }

            static void Print(int input)
            {
                Console.WriteLine(input * 2);
            }

            static void Print(double input2)
            {
                Console.WriteLine("{0:f2}",input2 * 1.5);
            }

            static void Print(string input3)
            {
                Console.WriteLine("$" + input3 + "$");
            }
        }
    }
}