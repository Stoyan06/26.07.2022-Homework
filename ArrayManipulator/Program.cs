List<string> arr = Console.ReadLine().Split().ToList();
string command;

while ((command = Console.ReadLine()) != "end")
{
    List<string> commandSplitter = command.Split().ToList();

    if (commandSplitter[0] == "exchange")
    {
        List<string> memory = new List<string>();

        if (int.Parse(commandSplitter[1]) > arr.Count)
        {
            Console.WriteLine("Invalid index");
            continue;
        }

        for (int i = 0; i <= int.Parse(commandSplitter[1]); i++)
        {
            memory.Add(arr[0]);
            arr.RemoveAt(0);
        }

        for (int i = 0; i < memory.Count; i++)
        {
            arr.Add(memory[i]);
        }
    }

    if (commandSplitter[0] == "max")
    {
        if (commandSplitter[1] == "even")
        {
            List<int> evens = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (int.Parse(arr[i]) % 2 == 0)
                {
                    evens.Add(int.Parse(arr[i]));
                }
            }
            if (evens.Count == 0)
            {
                Console.WriteLine("No matches");
                continue;
            }
            int maxEven = evens[0];
            for (int i = 0; i < evens.Count; i++)
            {
                if (evens[i] >= maxEven)
                {
                    maxEven = evens[i];
                }
            }
            
            for(int i = 0; i < arr.Count; i++)
            {
                if (int.Parse(arr[i]) == maxEven)
                {
                    Console.WriteLine(i);
                }
            }
        }

        if (commandSplitter[1] == "odd")
        {
            List<int> evens = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (int.Parse(arr[i]) % 2 != 0)
                {
                    evens.Add(int.Parse(arr[i]));
                }
            }
            if (evens.Count == 0)
            {
                Console.WriteLine("No matches");
                continue;
            }
            int maxEven = evens[0];
            for (int i = 0; i < evens.Count; i++)
            {
                if (evens[i] >= maxEven)
                {
                    maxEven = evens[i];
                }
            }

            for (int i = 0; i < arr.Count; i++)
            {
                if (int.Parse(arr[i]) == maxEven)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    if (commandSplitter[0] == "min")
    {
        if (commandSplitter[1] == "even")
        {
            List<int> evens = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (int.Parse(arr[i]) % 2 == 0)
                {
                    evens.Add(int.Parse(arr[i]));
                }
            }
            if(evens.Count == 0)
            {
                Console.WriteLine("No matches");
                continue;
            }
            int minEven = evens[0];
            int index = 0;
            for (int i = 0; i < evens.Count; i++)
            {
                if (evens[i] < minEven)
                {
                    minEven = evens[i];
                    index = i;
                }
            }
            Console.WriteLine(index);
        }

        if (commandSplitter[1] == "odd")
        {
            List<int> odds = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (int.Parse(arr[i]) % 2 != 0)
                {
                    odds.Add(int.Parse(arr[i]));
                }
            }
            if (odds.Count == 0)
            {
                Console.WriteLine("No matches");
                continue;
            }
            int minOdd = odds[0];
            int index = 0;
            for (int i = 0; i < odds.Count; i++)
            {
                if (odds[i] < minOdd)
                {
                    minOdd = odds[i];
                    index = i;
                }
            }
            Console.WriteLine(index);
        }
    }

    if (commandSplitter[0] == "first")
    {
        if (commandSplitter[2] == "odd")
        {
            List<int> odds = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (int.Parse(arr[i]) % 2 != 0)
                {
                    odds.Add(int.Parse(arr[i]));
                }
            }

            for (int i = 0; i < int.Parse(commandSplitter[1]); i++)
            {
                if (odds.Count == 0)
                {
                    Console.WriteLine("[]");
                    break;
                }

                if (i == 0 && odds.Count == 1)
                {
                    Console.WriteLine("[" + odds[0] + "]");
                }

                if (i == 0 && odds.Count > 1)
                {
                    Console.Write("[" + odds[i] + ", ");
                }

                if (i != 0 && i != int.Parse(commandSplitter[1]) - 1 && odds.Count > 1)
                {
                    Console.Write(odds[i] + ", ");
                }

                if (i == int.Parse(commandSplitter[1]) - 1 && odds.Count > 1)
                {
                    Console.Write(odds[i] + "]");
                    Console.WriteLine();
                }
            }
        }

        if (commandSplitter[2] == "even")
        {
            List<int> evens = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (int.Parse(arr[i]) % 2 == 0)
                {
                    evens.Add(int.Parse(arr[i]));
                }
            }

            if(int.Parse(commandSplitter[1]) > evens.Count)
            {
                Console.WriteLine("Invalid count");
                continue;
            }

            for (int i = 0; i < int.Parse(commandSplitter[1]); i++)
            {
                if (evens.Count == 0)
                {
                    Console.WriteLine("[]");
                    break;
                }

                if (i == 0 && evens.Count == 1)
                {
                    Console.WriteLine("[" + evens[0] + "]");
                }

                if (i == 0 && evens.Count > 1)
                {
                    Console.WriteLine("[" + evens[i] + ", ");
                }

                if (i != 0 && i != evens.Count - 1 && evens.Count > 1)
                {
                    Console.WriteLine(evens[i] + ", ");
                }

                if (i == evens.Count - 1 && evens.Count > 1)
                {
                    Console.Write(evens[i] + "]");
                    Console.WriteLine();
                }
            }
        }
    }


    if (commandSplitter[0] == "last")
    {
        if (commandSplitter[2] == "odd")
        {
            List<int> odds = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (int.Parse(arr[i]) % 2 != 0)
                {
                    odds.Add(int.Parse(arr[i]));
                }
            }
            odds.Reverse();
            int a = int.Parse(commandSplitter[1]);

            if (int.Parse(commandSplitter[1]) > odds.Count)
            {
                if(odds.Count == 1)
                {
                    Console.WriteLine("[" + odds[0] + "]");
                    continue;
                }

                for(int i = 0; i < odds.Count; i++)
                {
                    if(i == 0)
                    {
                        Console.WriteLine("[" + odds[i] + ", ");
                    }

                    if(i != 0 && i != odds.Count - 1)
                    {
                        Console.Write(odds[i] + ", ");
                    }

                    if(i == odds.Count - 1)
                    {
                        Console.Write(odds[i] + "]");
                        Console.WriteLine();
                    }
                }
            }

            if (a > arr.Count - 1)
            {
                Console.WriteLine("Invalid index");
                continue;
            }

            if (odds.Count == 0)
            {
                Console.WriteLine("[]");
                continue;
            }

            for (int i = 0; i <= a; i--)
            {
                if (i == 0 && odds.Count == 1)
                {
                    Console.WriteLine("[" + (odds[i]) + "]");
                }

                if (i == 0 && odds.Count > 1)
                {
                    Console.WriteLine("[" + odds[i] + ", ");
                }

                if (i != 0 && i != odds.Count - 1 && odds.Count > 1)
                {
                    Console.WriteLine(odds[i] + ", ");
                }

                if (i == odds.Count - 1 && odds.Count > 1)
                {
                    Console.Write(odds[odds.Count - 1] + "]");
                    Console.WriteLine();
                }
            }
        }

        if (commandSplitter[2] == "even")
        {
            List<int> odds = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (int.Parse(arr[i]) % 2 == 0)
                {
                    odds.Add(int.Parse(arr[i]));
                }
            }
            odds.Reverse();
            int a = int.Parse(commandSplitter[1]);

            if (int.Parse(commandSplitter[1]) > odds.Count)
            {
                if (odds.Count == 1)
                {
                    Console.WriteLine("[" + odds[0] + "]");
                    continue;
                }

                for (int i = 0; i < odds.Count; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("[" + odds[i] + ", ");
                    }

                    if (i != 0 && i != odds.Count - 1)
                    {
                        Console.Write(odds[i] + ", ");
                    }

                    if (i == odds.Count - 1)
                    {
                        Console.Write(odds[i] + "]");
                        Console.WriteLine();
                    }
                }
            }

            if (a > arr.Count - 1)
            {
                Console.WriteLine("Invalid index");
                continue;
            }

            if (odds.Count == 0)
            {
                Console.WriteLine("[]");
                continue;
            }

            for (int i = 0; i <= a; i--)
            {
                if (i == 0 && odds.Count == 1)
                {
                    Console.WriteLine("[" + (odds[i]) + "]");
                }

                if (i == 0 && odds.Count > 1)
                {
                    Console.WriteLine("[" + odds[i] + ", ");
                }

                if (i != 0 && i != odds.Count - 1 && odds.Count > 1)
                {
                    Console.WriteLine(odds[i] + ", ");
                }

                if (i == odds.Count - 1 && odds.Count > 1)
                {
                    Console.Write(odds[odds.Count - 1] + "]");
                    Console.WriteLine();
                }
            }
        }
    }
}

for(int i = 0; i < arr.Count; i++)
{
    if(i == 0)
    {
        Console.Write("[" + arr[i] + ", ");
    }

    if(i != 0 && i != arr.Count - 1)
    {
        Console.Write(arr[i] + ", ");
    }

    if(i == arr.Count - 1)
    {
        Console.Write(arr[i] + "]");
    }
}