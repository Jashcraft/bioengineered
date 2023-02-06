using app.src.tictactoe;
using app.src.tictactoe.board;

namespace app.src.tictactoe.gameStatus
{
  public class GameStatus
  {
    public static bool Check()
{
    
    
    // check rows
    if (GameBoard.GameBoard.boardArr[0,0] == "x" && GameBoard.boardArr[0, 1] == "x" && GameBoard.boardArr[0, 2] == "x") { return true; }
    if (GameBoard.boardArr[1, 0] == "x" && GameBoard.boardArr[1, 1] == "x" && GameBoard.boardArr[1, 2] == "x") { return true; }
    if (GameBoard.boardArr[2, 0] == "x" && GameBoard.boardArr[2, 1] == "x" && GameBoard.boardArr[2, 2] == "x") { return true; }

    // check columns
    if (GameBoard.boardArr[0, 0] == "x" && GameBoard.boardArr[1, 0] == "x" && GameBoard.boardArr[2, 0] == "x") { return true; }
    if (GameBoard.boardArr[0, 1] == "x" && GameBoard.boardArr[1, 1] == "x" && GameBoard.boardArr[2, 1] == "x") { return true; }
    if (GameBoard.boardArr[0, 2] == "x" && GameBoard.boardArr[1, 2] == "x" && GameBoard.boardArr[2, 2] == "x") { return true; }

    // check diags
    if (GameBoard.boardArr[0, 0] == "x" && GameBoard.boardArr[1, 1] == "x" && GameBoard.boardArr[2, 2] == "x") { return true; }
    if (GameBoard.boardArr[0, 2] == "x" && GameBoard.boardArr[1, 1] == "x" && GameBoard.boardArr[2, 0] == "x") { return true; }

    return false;
}

    
  }
}