// See https://aka.ms/new-console-template for more information


using System.Runtime.InteropServices.Marshalling;
using static System.Runtime.InteropServices.JavaScript.JSType;
Console.ForegroundColor = ConsoleColor.White;

int gamesCount = 0;

while (true)
{
    DisplayMenu();
    int menuChoice = GetPlayerChoice();

    if (menuChoice == 0)
    {
        return 0;
    };

    RunGameMode(menuChoice);
};

void DisplayMenu()
{
    Console.WriteLine("========== MATH  GAME ==========");
    Console.WriteLine($"=        GAMES PLAYED: {gamesCount}       =");
    Console.WriteLine("=                              =");
    Console.WriteLine("=            OPTIONS           =");
    Console.WriteLine("=                              =");
    Console.WriteLine("=         1. ADDITION          =");
    Console.WriteLine("=        2. SUBTRACTION        =");
    Console.WriteLine("=         3. DIVISION          =");
    Console.WriteLine("=       4. MULTIPLICATION      =");
    Console.WriteLine("=      5. PREVIOUS RESULTS     =");
    Console.WriteLine("=                              =");
    Console.WriteLine("=           0. Quit            =");
    Console.WriteLine("================================\n");
};

int GetPlayerChoice()
{
    int choice = -1;
    
    while (choice < 0 || choice > 5)
    {
        Console.Write("Write a number to choose an option: ");
        choice = Convert.ToInt32(Console.ReadLine());

        if (choice < 0 || choice > 5)
        {
            Console.WriteLine("");
            Console.Write("You must choose typing a number between 0-4: ");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            DisplayMenu();
        };
    };

    return choice;
};

void RunGameMode(int choice)
{
    switch (choice)
    {
        case 1:
            AdditionMode();
            gamesCount++;
            break;
        case 2:
            SubtractionMode();
            gamesCount++;
            break;
        case 3:
            DivisionMode();
            gamesCount++;
            break;
        case 4:
            MultiplicationMode();
            gamesCount++;
            break;
        case 5:
            break;
    }
};

string AdditionMode()
{
    Random number = new Random();

    int number1 = number.Next(101);
    int number2 = number.Next(101);
    int result = number1 + number2;

    Console.Clear();
    Console.WriteLine("========== MATH  GAME ==========");
    Console.WriteLine("=                              =");
    Console.WriteLine($"           {number1} + {number2} = ?  ");
    Console.WriteLine("=                              =");
    Console.WriteLine("================================\n");
    Console.Write("Enter you answer here: ");
    int answer = Convert.ToInt32(Console.ReadLine());

    if (answer == result)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Correct!");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Wrong!");
        Console.ForegroundColor = ConsoleColor.White;
    }

    System.Threading.Thread.Sleep(3000);

    Console.Clear();
    return null;
};

string SubtractionMode()
{
    Random number = new Random();

    int number1 = number.Next(101);
    int number2 = number.Next(101);
    int result = number1 - number2;

    Console.Clear();
    Console.WriteLine("========== MATH  GAME ==========");
    Console.WriteLine("=                              =");
    Console.WriteLine($"           {number1} - {number2} = ?  ");
    Console.WriteLine("=                              =");
    Console.WriteLine("================================\n");
    Console.Write("Enter you answer here: ");
    int answer = Convert.ToInt32(Console.ReadLine());

    if (answer == result)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Correct!");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Wrong!");
        Console.ForegroundColor = ConsoleColor.White;
    }

    System.Threading.Thread.Sleep(3000);

    Console.Clear();
    return null;
};

string DivisionMode()
{
    Random number = new Random();
    int number1 = 0;
    int number2 = 0;
    float result = 1.31f;
    
    while (result % 1 != 0)
    {
        number1 = number.Next(101);
        number2 = number.Next(101);
        while (number2 == 1)
        {
            number2 = number.Next(101);
        };
        result = (float)number1 / number2;
    };

    Console.Clear();
    Console.WriteLine("========== MATH  GAME ==========");
    Console.WriteLine("=                              =");
    Console.WriteLine($"           {number1} / {number2} = ?  ");
    Console.WriteLine("=                              =");
    Console.WriteLine("================================\n");
    Console.Write("Enter you answer here: ");
    int answer = Convert.ToInt32(Console.ReadLine());

    if (answer == result)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Correct!");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Wrong!");
        Console.ForegroundColor = ConsoleColor.White;
    }

    System.Threading.Thread.Sleep(1000);

    Console.Clear();
    return null;
};

string MultiplicationMode()
{
    Random number = new Random();

    int number1 = number.Next(101);
    int number2 = number.Next(101);
    int result = number1 * number2;
    string operationSign = "/";

    Console.Clear();
    Console.WriteLine("========== MATH  GAME ==========");
    Console.WriteLine("=                              =");
    Console.WriteLine($"           {number1} / {number2} = ?  ");
    Console.WriteLine("=                              =");
    Console.WriteLine("================================\n");
    Console.Write("Enter you answer here: ");
    int answer = Convert.ToInt32(Console.ReadLine());

    if (answer == result)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Correct!");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Wrong!");
        Console.ForegroundColor = ConsoleColor.White;
    }

    System.Threading.Thread.Sleep(3000);

    Console.Clear();
    return null;
};