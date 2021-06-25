using System;

public static class Kata
{
  public static int MaxSequence(int[] arr)
  {
    // Kadane's algorithm
    // See https://en.wikipedia.org/wiki/Maximum_subarray_problem#Kadane's_algorithm
    var result = 0;
    var currentSum = 0;
    foreach(var i in arr)
    {
      currentSum = Math.Max(0, currentSum + i);
      result = Math.Max(result, currentSum);
    }

    return result;
  }
}