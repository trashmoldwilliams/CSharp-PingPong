using Xunit;
using System.Collections.Generic;
using PingPongNS.Objects;

namespace PingPongNS
{
  public class PingPongTest
  {
    [Fact]
    public void Play_ForNumberTwo_ListOfOneAndTwo()
    {
      List<string> pingPong = PingPong.Play(2);
      List<string> expectedList = new List<string> { "1", "2" };
      Assert.Equal(expectedList, pingPong);
    }

  }
}
