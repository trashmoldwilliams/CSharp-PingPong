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

    [Fact]
    public void Play_ForNumberThree_ListOfOneTwoPing()
    {
      List<string> pingPong = PingPong.Play(3);
      List<string> expectedList = new List<string> { "1", "2", "ping"};
      Assert.Equal(expectedList, pingPong);
    }

    [Fact]
    public void Play_ForNumberFive_ListOfOneTwoPingThreeFourPong()
    {
      List<string> pingPong = PingPong.Play(5);
      List<string> expectedList = new List<string> { "1", "2", "ping", "4", "pong" };
      Assert.Equal(expectedList, pingPong);
    }

  }
}
