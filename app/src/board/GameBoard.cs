using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.src.board
{
    public class GameBoard
    {
        sbyte [,] boardArr = {{1,2,3},{4,5,6},{7,8,9}};

        public void Display()
        {
          for (var i = 0; i < 3; i++)
          {
            Console.Write("\n");
            for (var x = 0; x < 3; x++)
            {
              Console.Write("{0} ", boardArr[i,x]);
            }
          }
        }
    }
}