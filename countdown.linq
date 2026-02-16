<Query Kind="Program" />

void Main()
{

	countdown(5);
	
}

// You can define other methods, fields, classes and namespaces here
	public void countdown(int n)
	{
	    if(n==0)
	    {
	        Console.WriteLine("Happy NEW YEAR!!");
	    }
	    else
	    {
	        Console.WriteLine(n + "   Minutes Left");
	        countdown(n-1);
			Console.WriteLine(n);
	    }
	}
	