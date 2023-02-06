

namespace app.src.tictactoe.checks
{
  public class ChooseSpacePrompt
  {
    public static bool CheckBoard(sbyte space)
    {
      bool valid = true;
      // check if input is valid
      if (space > 9)
      {
        Console.WriteLine("Space not available, please choose another space");
        valid = false;
      }
      return valid;
    }
    public static bool CheckIfTaken(sbyte space)
    {
      bool valid = true;
      // convert 'space' to string 

      string newstring = space.ToString();
      // check if input is valid
      if (newstring =="o" || newstring =="x")
      {
        Console.WriteLine("Space is Taken, please choose another space");
        valid = false;
      }
      return valid;
    }
  }
}