using System;
using System.Collections.Generic;

namespace RockPaperScissors.Models
{
  public class NewRPSGame
  {
    public string Player1Input { get; set; }
    public string Player2Input { get; set; }
    public string RPSWinner { get; set; }
    public NewRPSGame(string player1, string player2)
    {
      Player1Input = player1;
      Player2Input = player2;
    }
    public void PickANumberRPSBot()
    {
      Random rnd = new Random();
      int rngNum1To3 = rnd.Next(1, 3);
      if (rngNum1To3 == 1)
      {
        Player2Input = "rock";
      }
      else if (rngNum1To3 == 2)
      {
        Player2Input = "paper";
      }
      else if (rngNum1To3 == 3)
      {
        Player2Input = "scissors";
      }
    }
    public void CheckRPSWinner()
    {
      if (Player1Input == "rock" && Player2Input == "scissors")
      {
        RPSWinner = "Player1";
      }
      else if (Player1Input == "scissors" && Player2Input == "rock")
      {
        RPSWinner = "Player2";
      }
      else if (Player1Input == "paper" && Player2Input == "rock")
      {
        RPSWinner = "Player1";
      }
      else if (Player1Input == "rock" && Player2Input == "paper")
      {
        RPSWinner = "Player2";
      }
      else if (Player1Input == "scissors" && Player2Input == "paper")
      {
        RPSWinner = "Player1";
      }
      else if (Player1Input == "paper" && Player2Input == "scissors")
      {
        RPSWinner = "Player2";
      }
    }
  }
}