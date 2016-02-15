using System.Collections.Generic;

namespace PingPongNS.Objects
{
  public class PingPong
  {
    public PingPong()
    {

    }

    public static List<string> Play(int number)
    {
      List<string> output = new List<string> {};
      for (var i = 1; i <= number; i++)
      {
        string current = i + "";
        if( i % 15 == 0 )
        {
          current = "pingpong";
        } else if( i % 3 == 0 )
        {
          current = "ping";
        } else if( i % 5 == 0)
        {
          current = "pong";
        }
        output.Add(current);
      }

      return output;
    }
  }
}
