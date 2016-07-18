using System.Collections.Generic;

namespace PingPongGenerator
{
  public class PingPongGenerator
  {
    private List<object> _numbers = new List<object>() {};

    public List<object> Generator(int number)
    {
      for (int i = 1; i <= number; i += 1 ) {
        if (i % 15 == 0)
        {
          _numbers.Add("ping-pong");
        }
        else if (i % 3 == 0)
        {
          _numbers.Add("ping");
        }
        else if (i % 5 == 0)
        {
          _numbers.Add("pong");
        }
        else
        {
          _numbers.Add(i);
        }
      }
      return _numbers;
    }
  }
}
