using System.Text;

public class Kata
{
  public static string Encrypt(string text, int n)
  {
    if (n < 1 || string.IsNullOrEmpty(text))
    {
      return text;
    }

    var prefix = new StringBuilder();
    var suffix = new StringBuilder();
    for (int i = 0; i < text.Length; i++)
      {
         if (i % 2 == 1)
         {
           prefix.Append(text[i]);
         }
         else
         {
           suffix.Append(text[i]);
         }
       }

       return Encrypt(prefix.Append(suffix).ToString(), --n);
  }
  
  public static string Decrypt(string encryptedText, int n)
  {
    if (n < 1 || string.IsNullOrEmpty(encryptedText))
    {
      return encryptedText;
    }

    var midPoint = encryptedText.Length / 2;
    var prefix = encryptedText.Substring(0, midPoint);
    var suffix = encryptedText.Substring(midPoint);

    char[] result = new char[encryptedText.Length];

    for (int i = 0; i < suffix.Length; i++)
    {
      result[i * 2] = suffix[i];
    }

    for (int i = 0; i < prefix.Length; i++)
    {
      result[i * 2 + 1] = prefix[i];
    }

    return Decrypt(new string(result), --n);
  }
}