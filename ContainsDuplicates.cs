

public class Solution
{
	

	public void Main()
	{
		var myNums = new int[] {1,2,3, 1};
		var res = ContainsDuplicates(myNums);
		Console.WriteLine(res);
	}

	// You can define other methods, fields, classes and namespaces here
	public static bool ContainsDuplicates(int[] nums)
	{
		var un = new HashSet<int>();
		// for each value check if it contains in hashset if no add it there
		for(int i = 0; i < nums.Length; i++)
		{
			if(un.Contains(nums[i]))
			{
				return true;
			}
			else
			{
				un.Add(nums[i]);
			}
		
		}
		
		return false;
	}
}

