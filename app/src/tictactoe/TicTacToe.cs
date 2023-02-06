using app.src.tictactoe.board;
using app.src.tictactoe.inputs;
using app.src.tictactoe.checks;
using app.src.tictactoe.player;
public class TicTacToe
{
    public static void Start()
  {
    GameBoard mainBoard = new GameBoard();
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
    


    if (Player.playerNumber == 1){
      Player.SetPlayerNumber2();
    };
        if (Player.playerNumber == 2){
      Player.SetPlayerNumber1();
    };
  }
}