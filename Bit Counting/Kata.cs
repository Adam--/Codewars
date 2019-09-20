using System;
using System.Linq;

public class Kata
{
  public static int CountBits(int n)
  {
    return Convert.ToString(n, 2).Count(c => c == '1');
  }
}