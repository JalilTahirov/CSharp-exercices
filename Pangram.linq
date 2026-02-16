<Query Kind="Program" />

void Main()
{

	Console.WriteLine(Pangram("?????abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"));
	
}

// You can define other methods, fields, classes and namespaces here

    public bool Pangram(string word)
    {
        var set = new HashSet<char>();
        
        foreach(char l in word)
        {
			if(!char.IsLetterOrDigit(l)){Console.WriteLine(l);}
			if(char.IsLetter(l))
			{
			      set.Add(char.ToLower(l));

			}
        }
		Console.WriteLine(set);
        return set.Count() == 26;
        
    }