// See https://aka.ms/new-console-template for more information


using System.Runtime.InteropServices.Marshalling;

DisplayMenu();

int whichMode = GetPlayerChoice();

void DisplayMenu()
{
    Console.WriteLine("========== MATH  GAME ==========");
    Console.WriteLine("=            OPTIONS           =");
    Console.WriteLine("=                              =");
    Console.WriteLine("=         1. ADDITION          =");
    Console.WriteLine("=        2. SUBTRACTION        =");
    Console.WriteLine("=         3. DIVISION          =");
    Console.WriteLine("=       4. MULTIPLICATION      =");
    Console.WriteLine("================================\n");
};

int GetPlayerChoice()
{
    int choice = 0;
    
    while (choice < 1 || choice > 4)
    {
        Console.Write("Write a number to choose an option: ");
        choice = Convert.ToInt32(Console.ReadLine());

        if (choice < 1 || choice > 4)
        {
            Console.WriteLine("You must choose typing a number between 1-4.");
            Console.Clear();
            DisplayMenu();
        };
    };

    return choice;
};
