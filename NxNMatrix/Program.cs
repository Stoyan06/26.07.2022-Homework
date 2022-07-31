int size = int.Parse(Console.ReadLine());

NxNMatrix(size);

static void NxNMatrix(int size)
{
    for(int i = 0; i < size; i++)
    {
        for(int y = 0; y < size; y++)
        {
            Console.Write(size + " ");
        }
        Console.WriteLine();
    }
}