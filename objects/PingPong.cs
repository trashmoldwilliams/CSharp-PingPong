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
        output.Add(i + "");
      }

      return output;
    }
  }
}
