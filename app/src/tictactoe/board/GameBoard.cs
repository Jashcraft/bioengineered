using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.src.tictactoe.inputs;
using app.src.tictactoe.player;


namespace app.src.tictactoe.board
{
  public class GameBoard
  {
    Object[,] boardArr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

    public void Display()
    {
      for (var i = 0; i < 3; i++)
      {
        Console.Write("\n");
        for (var x = 0; x < 3; x++)
        {
          Console.Write("{0} ", boardArr[i, x]);
        }
      }
    }
    public void Update(sbyte space)
    {
      if (Player.playerNumber == 1)
      {
        switch (space)
        {
          case 1:
            boardArr[0, 0] = "o";
            break;
          case 2:
            boardArr[0, 1] = "o";
            break;
          case 3:
            boardArr[0, 2] = "o";
            break;
          case 4:
            boardArr[1, 0] = "o";
            break;
          case 5:
            boardArr[1, 1] = "o";
            break;
          case 6:
            boardArr[1, 2] = "o";
            break;
          case 7:
            boardArr[2, 0] = "o";
            break;
          case 8:
            boardArr[2, 1] = "o";
            break;
          case 9:
            boardArr[2, 2] = "o";
            break;
          default:
            Console.WriteLine("Space Chosen Out Of Bounds!");
            UserPrompt.ChooseSpace();
            break;
        }
      }
      if (Player.playerNumber ==2){
        switch (space)
        {
          case 1:
            boardArr[0, 0] = "x";
            break;
          case 2:
            boardArr[0, 1] = "x";
            break;
          case 3:
            boardArr[0, 2] = "x";
            break;
          case 4:
            boardArr[1, 0] = "x";
            break;
          case 5:
            boardArr[1, 1] = "x";
            break;
          case 6:
            boardArr[1, 2] = "x";
            break;
          case 7:
            boardArr[2, 0] = "x";
            break;
          case 8:
            boardArr[2, 1] = "x";
            break;
          case 9:
            boardArr[2, 2] = "x";
            break;
          default:
            Console.WriteLine("Space Chosen Out Of Bounds!");
            UserPrompt.ChooseSpace();
            break;
        }
      }
      Display();
    }
  }
}