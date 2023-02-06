namespace app.src.tictactoe.inputs
{
  public class UserPrompt
    {
        public static sbyte ChooseSpace()
        {
          Console.WriteLine("Please Choose a Space:");
          sbyte space = Convert.ToSByte(Console.ReadLine());
          Console.WriteLine("You have chosen: " + space);
          return space; 
        }
    }
}