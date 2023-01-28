using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.src.inputs;

namespace app.src.checks
{
  public class ChooseSpacePrompt
  {
    public static bool Check(sbyte space)
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
  }
}