using app.src.tictactoe.board;
using app.src.tictactoe.inputs;
using app.src.tictactoe.checks;
using app.src.tictactoe.player;
using app.src.tictactoe.gameStatus;
public class TicTacToe
{
  public static int playerNumber = 1;
  public static void Start()
  {

    GameBoard mainBoard = new GameBoard();
    while (GameStatus.Check() == false)
    {
      for (sbyte i = 0; i < Player.playerArr.Length; i++)
      {
        Console.WriteLine("Current Player: " + Player.playerNumber);
        mainBoard.Display();
        Console.WriteLine("\n");
        sbyte space = UserPrompt.ChooseSpace();
        bool isValid = ChooseSpacePrompt.CheckBoard(space);
        while (isValid == false)
        {
          space = UserPrompt.ChooseSpace();
          isValid = ChooseSpacePrompt.CheckBoard(space);
        }
        Console.WriteLine("Space is valid");
        mainBoard.Update(space);
        if (i > 0)
        {
          i = 0;
        }
        Player.playerNumber++;
        if (Player.playerNumber > 2)
        {
          Player.playerNumber = 1;
        }

        
      }
    }
    Console.WriteLine("Game Over");
  }

}