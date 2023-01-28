using app.src.board;
using app.src.inputs;
public class Program
{
  static void Main(string[] args)
  {
    GameBoard mainBoard = new GameBoard();
    mainBoard.Display();
    Console.WriteLine("\n");
    UserPrompt.ChooseSpace(); 

  }
}

