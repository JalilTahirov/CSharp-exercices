<Query Kind="Program" />

void Main()
{
	int res = sumArray(new int[] {100,666});
	Console.WriteLine(res);
}

// You can define other methods, fields, classes and namespaces here
int sumArray(int[] nums, int i = 0)
{
   if(nums.Length <= i) 
       return 0;
   return sumArray(nums, i+1) + nums[i];
}