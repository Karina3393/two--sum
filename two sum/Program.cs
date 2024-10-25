public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }
            map[nums[i]] = i;
        }
        return null; 
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = solution.TwoSum(nums, target);

        if (result != null)
        {
            Console.WriteLine("Indices: [" + result[0] + ", " + result[1] + "]");
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }
}


