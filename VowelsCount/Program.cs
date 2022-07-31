string text = Console.ReadLine();
VowelCounter(text);

static void VowelCounter(string text)
{
    int counter = 0;
    for (int i = 0; i < text.Length; i++)
    {
        char a = text[i];

        if (a.Equals('A') || a.Equals('a') || a.Equals('O') || a.Equals('o') || a.Equals('U') || a.Equals('u') || a.Equals('E') || a.Equals('e') || a.Equals('I') || a.Equals('i'))
        {
            counter++;
        }
    }
    Console.WriteLine(counter);
}