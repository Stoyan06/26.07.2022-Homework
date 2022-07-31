int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

AddAndSubtract(a, b, c);

static void AddAndSubtract(int a, int b, int c)
{
    Console.WriteLine(a + b - c);
}