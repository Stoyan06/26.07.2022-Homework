char start = char.Parse(Console.ReadLine());
char stop = char.Parse(Console.ReadLine());

CharactersInRange(start, stop);

static void CharactersInRange(char a,char b)
{
    for (int i = a + 1; i < b; i++)
    {
        Console.Write((char)i + " ");
    }
}