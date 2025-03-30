var sol = new Solution();

var result = sol.FindMaxConsecutiveOnes([1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 1]);

Console.WriteLine(result);

public class Solution
{
    // public int FindMaxConsecutiveOnes(int[] nums)
    // {
    //     int max = 0;

    //     int count = 0;
    //     if (nums[0] == 1)
    //         count++;
    //     for (int i = 1; i < nums.Length; i++)
    //     {
    //         int current = nums[i];
    //         int previous = nums[i - 1];

    //         if (current == 0 && previous == 1 && count > max)
    //             max = count;

    //         if (current == 1)
    //             count++;

    //         if (current == 0)
    //             count = 0;
    //     }

    //     if (count > max)
    //         max = count;

    //     return max;
    // }

    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int max = 0, count = 0;

        foreach (int num in nums)
        {
            if (num == 1)
            {
                count++;
                max = Math.Max(max, count);
            }
            else
            {
                count = 0;
            }
        }

        return max;
    }
}