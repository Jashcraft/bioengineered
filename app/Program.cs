using app.src.board;
using app.src.inputs;
using app.src.checks;
public class Program
{
  static void Main(string[] args)
  {
    GameBoard mainBoard = new GameBoard();
    mainBoard.Display();
    Console.WriteLine("\n");
    sbyte space = UserPrompt.ChooseSpace();
    bool isValid = ChooseSpacePrompt.Check(space);
    while (isValid == false)
    {
      space = UserPrompt.ChooseSpace();
      isValid = ChooseSpacePrompt.Check(space);
    }
    Console.WriteLine("Space is valid");
    mainBoard.Update(space);
  }
}

