using Xunit;
using System.Collections.Generic;

namespace PingPongGenerator
{
  public class PingPongTest
  {
    // [Fact]
    // public void  Genarator_GenarteNumbertoMax_true()
    // {
    //   PingPongGenerator testMaxNumber = new PingPongGenerator() {};
    //   List<object> test = new List<object>() {1, 2, 3, 4, 5};
    //   Assert.Equal(test, testMaxNumber.Generator(5));
    // }

    // [Fact]
    // public void Generator_EveryFifteenthNumberBecomesPingPong_true()
    // {
    //   PingPongGenerator testFifteenthNumber = new PingPongGenerator() {};
    //   List<object> test = new List<object>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, "ping-pong"};
    //   Assert.Equal(test, testFifteenthNumber.Generator(15));
    // }

    // [Fact]
    // public void Generator_EveryThirdNumberBecomesPing_true()
    // {
    //   PingPongGenerator testThirdNumber = new PingPongGenerator() {};
    //   List<object> test = new List<object>() {1, 2, "ping", 4, 5, "ping", 7, 8};
    //   Assert.Equal(test, testThirdNumber.Generator(8));
    // }

    [Fact]
    public void Generator_EveryFifthNumberBecomesPong_true()
    {
      PingPongGenerator testFifthNumber = new PingPongGenerator() {};
      List<object> test = new List<object>() {1, 2, "ping", 4, "pong", "ping", 7, 8};
      Assert.Equal(test, testFifthNumber.Generator(8));
    }
  }
}
