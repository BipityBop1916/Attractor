namespace hw27;
using System.Text.RegularExpressions;

public static class Tools
{
    public static string MyToUpper(this string? input)
    {
        if (input == null) throw new ArgumentNullException(nameof(input));
        
        List<char> charList = input.ToCharArray().ToList();

        for (int i = 0; i < charList.Count; i++)
        {
            charList[i] = char.ToUpper(charList[i]);
        }
        
        return new string(charList.ToArray());
    }

    public static string MyToLower(this string? input)
    {
        if (input == null) throw new ArgumentNullException(nameof(input));
        
        List<char> charList = input.ToCharArray().ToList();

        for (int i = 0; i < charList.Count; i++)
        {
            charList[i] = char.ToLower(charList[i]);
        }
        
        return new string(charList.ToArray());
    }

    public static string MyTrim(this string? input)
    {
        if (input == null) throw new ArgumentNullException(nameof(input));
        Regex whitespace = new Regex(@"\s");
        
        List<char> charList = input.ToCharArray().ToList();
        
        if (charList.Count == 0) return input;
        
        while (charList.Count > 0 && whitespace.IsMatch(charList[0].ToString()))
        {
            charList.RemoveAt(0);
        }

        while (charList.Count > 0 && whitespace.IsMatch(charList[^1].ToString()))
        {
            charList.RemoveAt(charList.Count - 1);
        }
        
        return new string(charList.ToArray());
    }

    public static bool MyIsNullOrWhiteSpace(this string? input)
    {
        if (input == null) return true;
        if (input.MyTrim().Length == 0) return true;
        return false;
    }
}