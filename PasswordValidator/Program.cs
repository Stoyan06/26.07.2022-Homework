string password = Console.ReadLine();

PassValidator(password);

static void PassValidator(string password)
{
    int digitCounter = 0;
    bool run = true;
    bool run2 = false;

  if(password.Length < 6 || password.Length > 10)
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
        run = false;
    }

  for(int i = 0; i < password.Length; i++)
    {
        if (char.IsDigit(password[i]) || char.IsLetter(password[i]))
        {
            
        }
        else
        {
            run = false;
            run2 = true;
        }
    }

  if(run2 == true)
    {
        Console.WriteLine("Password must consist only of letters and digits");
    }

    for (int i = 0; i < password.Length; i++)
    {
        if (char.IsDigit(password[i]) == true)
        {
            digitCounter++;
        }
    }

    if(digitCounter < 2)
    {
        Console.WriteLine("Password must have at least 2 digits");
        run = false;
    }

    if(run == true)
    {
        Console.WriteLine("Password is valid");
    }
}