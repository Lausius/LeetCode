var sol = new Solution();
var result = sol.SortedSquares([-4, -1, -148, 0, 3, 10, 8, -1000]);

Console.WriteLine("[" + string.Join(", ", result) + "]");
public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        // square each number
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = nums[i] * nums[i];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length - 1; j++)
            {
                int left = nums[j];
                int right = nums[j + 1];

                // if left is less than right, swap places
                if (left > right)
                {
                    Console.WriteLine($"SWAPPING {left} -> {right}");
                    nums[j] = right;
                    nums[j + 1] = left;
                    Console.WriteLine("[" + string.Join(", ", nums) + "]");
                }
            }
        }
        return nums;
    }

    // Two-Pointer Technique (only works for already sorted arrays)
    // public int[] SortedSquares(int[] nums)
    // {
    //     int left = 0, right = nums.Length - 1;
    //     int[] result = new int[nums.Length];
    //     int index = nums.Length - 1;

    //     while (left <= right)
    //     {
    //         int leftSquare = nums[left] * nums[left];
    //         int rightSquare = nums[right] * nums[right];

    //         if (leftSquare > rightSquare)
    //         {
    //             result[index] = leftSquare;
    //             left++;
    //         }
    //         else
    //         {
    //             result[index] = rightSquare;
    //             right--;
    //         }

    //         index--;
    //     }

    //     return result;
    // }
}