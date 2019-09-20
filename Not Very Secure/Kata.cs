using System.Text.RegularExpressions;

public class Kata
{
  public static bool Alphanumeric(string str) =>
    string.IsNullOrEmpty(str) ? false : (new Regex("^[a-zA-Z0-9]*$")).IsMatch(str); 
}