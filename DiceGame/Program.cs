// See https://aka.ms/new-console-template for more information

Console.WriteLine("===A Simple Dice Game.=== \n Type 'Start or 'S' to start game. ");
string gameStart = Console.ReadLine()!;



while ((!(gameStart.Equals("Start", StringComparison.OrdinalIgnoreCase) || gameStart.Equals("S", StringComparison.OrdinalIgnoreCase))))
{
  Console.ForegroundColor = ConsoleColor.DarkRed;
  Console.WriteLine("Please enter a valid input.");
  Console.ResetColor();
  Console.WriteLine("===A Simple Dice Game.=== \n Type 'Start or 'S' to start game. ");
 gameStart = Console.ReadLine()!;
  
}

Random random = new();
int firstDice = 1;
int secDice = 2;
int thirdDice = 3;
int originalScore = firstDice + secDice + thirdDice;
int totalScore = 0;
const int doublePoint = 2;
const int triplePoint = 6;

Console.WriteLine($"Dice One: {firstDice} Dice Two: {secDice} Dice Three: {thirdDice}");

if (firstDice == secDice && secDice == thirdDice)
{
  totalScore = originalScore + triplePoint;
  Console.WriteLine($"Wow! you got a triple. \n Your Total Score is {totalScore}");
}

else if (firstDice == secDice || secDice == thirdDice || thirdDice == firstDice)
{
  totalScore = originalScore + doublePoint;
  Console.WriteLine($"Wow! you got a double. \n Your Total Score is {totalScore}.");
}

if (totalScore >= 10  && totalScore <= 13)
{
    Console.WriteLine("Hurray! You are awarded a BALOON.");

}

else if (totalScore >= 14  && totalScore <= 16)
{
  Console.WriteLine("Congratulations! You are awarded an exercise book");
}

else if (totalScore == 17)
{
  Console.WriteLine("You  are awarded a 5000mah power bank");
}

else if (totalScore == 21)
{
  Console.WriteLine("Your total score is 21. \n Guess what?... 21 is a lucky Number! \n You are awarded a Samsung A23.");
}

else if (totalScore >= 18 && totalScore <= 20)
{
  Console.WriteLine($"Your total score is {totalScore}.");
  Console.WriteLine("Congratulations! You are awarded a Silver Bird ticket.");
}

else if (totalScore >= 22 && totalScore <= 24)
{
  Console.WriteLine($"Your Total Score is {totalScore}.");
  Console.WriteLine("Congratulation! you are awarded a Baloon, a 5000mAH Powerbank, a Samsung A23, and a Silver Bird ticket.");
}
else 
{
Console.WriteLine($"Your Total Score is {totalScore}. \n Nice try, you can do that again.");
}