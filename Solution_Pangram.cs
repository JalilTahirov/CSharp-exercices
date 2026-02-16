public class Solution_Pangram
{
    public void Main()
    {
        Console.WriteLine(Pangram("ABBSWHHD kkkwwk   llwoow kdwd!!!!"));
    }

    public bool Pangram(string word)
    {
        var set = new HashSet<char>();
        foreach(char l in word)
        {
            if(char.IsLetter(l))set.Add(char.ToLower(l));
        }
        return set.Length == 26;
    }
}