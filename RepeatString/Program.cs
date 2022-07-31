static void RepeatString(string value, int repeatTimes)
{
    for(int i = 0; i < repeatTimes; i++)
    {
        Console.Write(value);
    }
}

string a = Console.ReadLine();
int b = int.Parse(Console.ReadLine());

RepeatString(a, b);