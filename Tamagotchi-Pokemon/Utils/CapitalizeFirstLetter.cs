namespace Tamagotchi_Pokemon.Utils;

internal static class CapitalizeFirstLetter
{
    public static string CapitalizeString(string word)
    {
        string firstLetter = word.Substring(0, 1).ToUpper();
        string restOfWord = word.Substring(1);

        return $"{firstLetter}{restOfWord}";
    }
}
