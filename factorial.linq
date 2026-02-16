<Query Kind="Program" />

void Main()
{
    
	Console.WriteLine(factorial(4)); // 1 * 2 * 3 * 4
	
}

// You can define other methods, fields, classes and namespaces here


public int factorial(int n)
{
	if(n == 0) return 1;
	return n * factorial(n-1);
}