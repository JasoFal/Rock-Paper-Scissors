using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class ProjectTests
  {
    [TestMethod]
    public void NewRPSGameConstructor_CreateInstanceOfRockPaperScissors_NewRPSGame()
    {
      NewRPSGame newGame = new NewRPSGame("rock", "test");
      Assert.AreEqual(typeof(NewRPSGame), newGame.GetType());
    }

    [TestMethod]
    public void GetPlayer1Input_ReturnPlayer1Input_String()
    {
      string player1 = "rock";
      NewRPSGame newGame = new NewRPSGame(player1, "test");
      string result = newGame.Player1Input;
      Assert.AreEqual(player1, result);
    }

    [TestMethod]
    public void SetPlayer1Input_SetValueOfPlayer1Input_Void()
    {
      NewRPSGame newGame = new NewRPSGame("rock", "test");
      string newPlayer1Input = "paper";
      newGame.Player1Input = newPlayer1Input;
      Assert.AreEqual(newPlayer1Input, newGame.Player1Input);
    }

    [TestMethod]
    public void GetPlayer2Input_ReturnPlayer2Input_String()
    {
      string player2 = "rock";
      NewRPSGame newGame = new NewRPSGame("player1", player2);
      string result = newGame.Player2Input;
      Assert.AreEqual(player2, result);
    }

    [TestMethod]
    public void SetPlayer2Input_SetValueOfPlayer2Input_Void()
    {
      NewRPSGame newGame = new NewRPSGame("test", "rock");
      string newPlayer2Input = "paper";
      newGame.Player2Input = newPlayer2Input;
      Assert.AreEqual(newPlayer2Input, newGame.Player2Input);
    }

    [TestMethod]
    public void SetRPSVictor_SetValueOfRPSVictor_Void()
    {
      NewRPSGame newGame = new NewRPSGame("rock", "scissors");
      newGame.CheckRPSWinner();
      Assert.AreEqual("Player1", newGame.RPSWinner);
    }

    [TestMethod]
    public void CheckRPSWinner_CheckForPlayer1RockVictory_Void()
    {
      NewRPSGame newGame = new NewRPSGame("rock", "scissors");
      newGame.CheckRPSWinner();
      Assert.AreEqual("Player1", newGame.RPSWinner);
    }

    [TestMethod]
    public void CheckRPSWinner_CheckForPlayer2RockVictory_Void()
    {
      NewRPSGame newGame = new NewRPSGame("scissors", "rock");
      newGame.CheckRPSWinner();
      Assert.AreEqual("Player2", newGame.RPSWinner);
    }

    [TestMethod]
    public void CheckRPSWinner_CheckForPlayer1PaperVictory_Void()
    {
      NewRPSGame newGame = new NewRPSGame("paper", "rock");
      newGame.CheckRPSWinner();
      Assert.AreEqual("Player1", newGame.RPSWinner);
    }

    [TestMethod]
    public void CheckRPSWinner_CheckForPlayer2PaperVictory_Void()
    {
      NewRPSGame newGame = new NewRPSGame("rock", "paper");
      newGame.CheckRPSWinner();
      Assert.AreEqual("Player2", newGame.RPSWinner);
    }

    [TestMethod]
    public void CheckRPSWinner_CheckForPlayer1ScissorsVictory_Void()
    {
      NewRPSGame newGame = new NewRPSGame("scissors", "paper");
      newGame.CheckRPSWinner();
      Assert.AreEqual("Player1", newGame.RPSWinner);
    }

    [TestMethod]
    public void CheckRPSWinner_CheckForPlayer2ScissorsVictory_Void()
    {
      NewRPSGame newGame = new NewRPSGame("paper", "scissors");
      newGame.CheckRPSWinner();
      Assert.AreEqual("Player2", newGame.RPSWinner);
    }
  }
}