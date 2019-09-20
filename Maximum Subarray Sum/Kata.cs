using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata
{
  public static int MaxSequence(int[] arr)
  {
    int result = 0;
    for (var i = 0; i < arr.Length; i++)
    {
      for (var j = 1; j < arr.Length - i + 1; j++)
      {
        var subArray = new int[j];
        Array.Copy(arr, i, subArray, 0, j);
        result = Math.Max(result, subArray.Sum());
      }
    }
    return result;
  }
}