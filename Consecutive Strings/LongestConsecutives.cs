using System.Linq;
  
public class LongestConsecutives 
{
    public static string LongestConsec(string[] strarr, int k) =>
      strarr.Length == 0 || k <= 0 || k > strarr.Length ? 
        string.Empty :
        strarr
          .Select(
            (s, i) =>
              strarr
                .Skip(i)
                .Take(k)
                .Aggregate((a, b) => a + b))
          .OrderByDescending(s => s.Length)
          .FirstOrDefault();
}