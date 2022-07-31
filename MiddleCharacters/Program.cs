string input = Console.ReadLine();

MiddleCharacters(input);

static void MiddleCharacters(string input)
{
    if(input.Length % 2 == 0)
    {
        for(int i = 0; i < input.Length; i++)
        {
            if(i + 1 == input.Length / 2)
            {
                Console.Write(input[i]);
                Console.Write(input[i + 1]);
            }
        }
    }
    else
    {
        for (int i = 0; i < input.Length; i++)
        {
            if (i == (input.Length - 1) / 2)
            {
                Console.Write(input[i]);
            }
        }
    }
}