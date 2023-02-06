namespace app.src.tictactoe.player
{
  public class Player
  {
    public static sbyte playerNumber = 1;

    public static sbyte SetPlayerNumber1()
    {
      sbyte playerNumber = 1;
      Console.WriteLine("\nPlayer is now Player 1");
      return playerNumber;
    }
    public static sbyte SetPlayerNumber2()
    {
      sbyte playerNumber = 2;
      Console.WriteLine("\nPlayer is now Player 2");
      return playerNumber;
    }
  }
}