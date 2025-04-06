// See https://aka.ms/new-console-template for more information


using System.Numerics;
using System.Runtime.InteropServices.Marshalling;
using static System.Runtime.InteropServices.JavaScript.JSType;
Console.ForegroundColor = ConsoleColor.White;

int gamesCount = 0;
string[] previousGames = new string[100];

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


// This method prompts user which gamemode he wants to play
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


// This method run selcted game mode by user
void RunGameMode(int choice)
{
    MathOperation gameMode;
    switch (choice)
    {
        case 1:
            gameMode = MathOperation.Addition;
            for (int i = 0; i < 10; i++)
            {
                PlayGame(gameMode, i);
            };
            break;
        case 2:
            gameMode = MathOperation.Subtraction;
            for (int i = 0; i < 10; i++)
            {
                PlayGame(gameMode, i);
            };
            break;
        case 3:
            gameMode = MathOperation.Division;
            for (int i = 0; i < 10; i++)
            {
                PlayGame(gameMode, i);
            };
            break;
        case 4:
            gameMode = MathOperation.Multiplication;
            for (int i = 0; i < 10; i++)
            {
                PlayGame(gameMode, i);
            };
            break;
        case 5:
            displayPreviousGames();
            break;
    }
};

// Method containing game logic for every mode
void PlayGame(MathOperation mode, int round)
{
    Random number = new Random();
    
    int number1 = number.Next(101);
    int number2 = number.Next(101);
    float result = 0;
    string operationSign = "";


    switch (mode)
    {
        case MathOperation.Addition:
            operationSign = "+";
            result = number1 + number2;
            break;
        case MathOperation.Subtraction:
            operationSign = "-";
            result = number1 - number2;
            break;
        case MathOperation.Division:
            operationSign = "/";
            result = 1.31f;
            // Checks if the outcome of generated numbers is an integer, if not it generates numbers again until it is
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
            break;
        case MathOperation.Multiplication:
            operationSign = "*";
            result = number1 * number2;
            break;
    };

    Console.Clear();
    Console.WriteLine("========== MATH  GAME ==========");
    Console.WriteLine($"           ROUND {round + 1}/10          ");
    Console.WriteLine("=                              =");
    Console.WriteLine($"           {number1} {operationSign} {number2} = ?  ");
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

    previousGames[gamesCount] = $"{number1} {operationSign} {number2} = ? | Your answer:  {answer} | Correct answer: {result}";
    gamesCount++;

    Console.WriteLine("Press any key to contionue to next question.");
    Console.ReadKey();

    Console.Clear();
};

// Method displays game history
void displayPreviousGames()
{
    Console.Clear();
    Console.WriteLine("========== MATH  GAME ==========");
    Console.WriteLine("=                              =");
    Console.WriteLine("=        PREVIOUS GAMES        =");
    Console.WriteLine("=                              =");
    Console.WriteLine("================================\n");


    for (int i = 0; i < gamesCount; i++)
    {
        Console.WriteLine(previousGames[i]);
        Console.WriteLine("");
    }

    Console.Write("Press any key to go back.");
    Console.ReadKey();
    Console.Clear();
};

enum MathOperation { Addition,  Subtraction, Division, Multiplication };