using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to Rock Paper Scissors");
      Console.WriteLine("Do you wish to play? If so enter 'yes' below.");
      string userAgreement = Console.ReadLine();
      if (userAgreement.ToLower() == "yes")
      {
        StartNewGame();
      }
    }

    static void StartNewGame()
    {
      Console.Write("Player 1 enter either rock, paper, or scissors: ");
      string rpsInput1 = null;
      while (true)
      {
        var key = Console.ReadKey(true);
        if (key.Key == ConsoleKey.Enter)
          break;
        rpsInput1 += key.KeyChar;
      }
      Console.Write("Player 2 enter either rock, paper, or scissors: ");
      string rpsInput2 = null;
      while (true)
      {
        var key = Console.ReadKey(true);
        if (key.Key == ConsoleKey.Enter)
          break;
        rpsInput2 += key.KeyChar;
      }
      if (rpsInput1 == "rock" || rpsInput1 == "paper" || rpsInput1 == "scissors" && rpsInput2 == "rock" || rpsInput2 == "paper" || rpsInput2 == "scissors")
      {
        NewRPSGame newGame = new NewRPSGame(rpsInput1, rpsInput2);
        GameResults(newGame);
      }
      else
      {
        Console.WriteLine("!!!!!!!!!!!!!!!");
        Console.WriteLine("Please enter rock, paper, or scissors");
        Main();
      }
    }
    static void GameResults(NewRPSGame newGame)
    {
      Console.WriteLine($"Player 1 picked {newGame.Player1Input}");
      Console.WriteLine($"Player 2 picked {newGame.Player2Input}");
      newGame.CheckRPSWinner();
      Console.WriteLine($"{newGame.RPSWinner}: WINS!!");
      Console.WriteLine("-------------------------------------------");
      Console.WriteLine("Would you like to play again.");
      Console.WriteLine("If no enter 'new' below");
      string newGameResponse = Console.ReadLine();
      if (newGameResponse.ToLower() == "new")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
    }
  }
}