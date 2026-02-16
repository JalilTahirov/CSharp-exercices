<Query Kind="Program" />

void Main()
{
	var nums  = new int[] {1,2,3,1,4,5};
	Console.WriteLine(ContainsDuplicates(nums));
}

// You can define other methods, fields, classes and namespaces here

public bool ContainsDuplicates(int[] nums)
{
        nums.Sort();
		Console.WriteLine(nums);
        for(int i = 1; i<nums.Length; i++ )
        {
            if(nums[i] == nums[i-1])
            {
                return true;
            }
        }

        return false;
}