static void SmallestOfThreeNumbers(int a, int b, int c)
{
    if(a < b && a < c)
    {
        Console.WriteLine(a);
        return;
    }

    if (b < a && b < c)
    {
        Console.WriteLine(b);
        return;
    }

    if (c < b && c < a)
    {
        Console.WriteLine(c);
        return;
    }
}

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

SmallestOfThreeNumbers(a, b, c);