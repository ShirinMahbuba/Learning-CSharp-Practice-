using System;
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[]
                    { i, j };
                }
            }

        }
        return new int[0];
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("koto gulo testcases nite chaw?");
        int testcases = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for(int i =1;i<=testcases;i++)
        {
            Console.WriteLine("Testcase{i}:");
            Console.Write("nums :");
            string line = Console.ReadLine();
            string[] parts = line.Split(',' );
            int[] nums = Array.ConvertAll(parts, int.Parse);
            Console.Write("target value:");
            int target = int.Parse(Console.ReadLine());

            Solution s = new Solution();
            int[] result = s.TwoSum(nums, target);

            if(result.Length == 2)
            {
                Console.WriteLine("output:" + result[0] + "," + result[1]);

            }
            else
            {
                Console.WriteLine("not matched");

            }

        }

    }
}
