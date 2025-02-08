namespace Tamagotchi_Pokemon.Utils;

internal static class CapitalizeWords
{
    public static string CapitalizeFirstLetter(string word)
    {
        string firstLetter = word.Substring(0, 1).ToUpper();
        string restOfWord = word.Substring(1);

        return $"{firstLetter}{restOfWord}";
    }

    public static string CapitalizeAllLetters(string word)
    {
        return word.ToUpper();
    }
}
