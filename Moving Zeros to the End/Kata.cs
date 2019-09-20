using System.Linq;

public class Kata
{
  public static int[] MoveZeroes(int[] arr) =>
    arr.ToList().OrderBy(i => i == 0).ToArray();
}