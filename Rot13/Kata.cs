using System;
using System.Text;

public class Kata
{
  private static string input =  "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
  private static string output = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm";
  
  public static string Rot13(string message)
  {
    var sb = new StringBuilder();
    foreach(var letter in message)
    {
      var letterIndex = input.IndexOf(letter);
      if (letterIndex >= 0)
      {
        sb.Append(output[letterIndex]);
      }
      else
      {
        sb.Append(letter);
      }
    }
    return sb.ToString();
  }
}