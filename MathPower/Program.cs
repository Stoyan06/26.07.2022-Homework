int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

MathPower(a, b);

static void MathPower(int index, int power)//5 ^ 2
{
    int result = 1;

    for(int i = 0; i < power; i++)
    {
        result = result * index;
    }

    Console.WriteLine(result);
}