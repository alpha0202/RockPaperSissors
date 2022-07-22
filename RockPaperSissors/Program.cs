// See https://aka.ms/new-console-template for more information
Console.WriteLine("Rock paper Scissors");


while (true)
{
    Console.WriteLine("Are you ready?");
    Console.WriteLine("let's begin!!");

    var selectedChoice = SelectChoice();
    var yourChoice = char.Parse(selectedChoice);

    Console.WriteLine($"your choice is: {yourChoice}");

    var opponentChoice = GetOpponentChice();
    Console.WriteLine($" the machine choice: {opponentChoice}");

    DecideWinner(opponentChoice,yourChoice);

    Console.WriteLine("Do you want to play again?");
    Console.WriteLine("write YES to play or any key to stop the game...");

    var playAgain = Console.ReadLine();
    if (playAgain?.ToLower() == "yes")
    {
        continue;
    }
    else
    {
        break;
    }

}

string SelectChoice()
    {
    Console.WriteLine("choose R, P, S: [R]ock, [P]apper, [S]cissors:");
    var selectedChoice = Console.ReadLine();

    if (selectedChoice?.ToLower() != "r" && selectedChoice?.ToLower() != "p" && selectedChoice?.ToLower() != "s")
    {

        Console.WriteLine("Please, Select only one letter: R, P or S.");
        selectedChoice = SelectChoice();
    }
    return selectedChoice;
}


char GetOpponentChice()
{
    char[] optiones = new char[] {'R', 'P','S' };

    Random random = new Random();
    int randomIndex = random.Next(0,optiones.Length);
    
    return optiones[randomIndex];

}


void DecideWinner(char opponentChoice, char yourChoice)
{
    if (opponentChoice == yourChoice)
    {
        Console.WriteLine("Tie!!");
    }

}

