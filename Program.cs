// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome");
bool pokracovat = true;
while (pokracovat)
{
    Console.WriteLine("Choose the first number");
    float a;
    while (!float.TryParse(Console.ReadLine(), out a))
        Console.WriteLine("Invalid number, please try again");
    Console.WriteLine("Choose the second number");
    float b;
    while (!float.TryParse(Console.ReadLine(), out b))
        Console.WriteLine("Invalid numer, please try again");
    Console.WriteLine("Choose the operation");
    Console.WriteLine("1 - addition");
    Console.WriteLine("2 - subtraction");
    Console.WriteLine("3 - multiplication");
    Console.WriteLine("4 - division");
    char choice = Console.ReadKey().KeyChar;
    Console.WriteLine();
    float result = 0;
    bool validChoice = true;
    switch (choice)
    {
        case '1':
            result = a + b;
            break;
        case '2':
            result = a - b;
            break;
        case '3':
            result = a * b;
            break;
        case '4':
            result = a / b;
            break;
    }
    if (validChoice)
        Console.WriteLine("Result: {0}", result);
    else
        Console.WriteLine("Invalid choice");
    Console.WriteLine("Would you like to make another count? [yes/no]");
    validChoice = false;
    while (!validChoice)
    {
        switch (Console.ReadKey().KeyChar.ToString().ToLower())
        {
            case "y":
                pokracovat = true;
                validChoice = true;
            break;
            case "n":
                pokracovat = false;
                validChoice = true;
            break;
            default:
                Console.WriteLine("Invalid choice, please try again");
            break;
        }
    }
    Console.WriteLine();
}

