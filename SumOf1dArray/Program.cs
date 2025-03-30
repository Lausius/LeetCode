int[] result = RunningSum([1, 2, 3, 4]);
Console.WriteLine("[" + string.Join(", ", result) + "]");

// int[] RunningSum(int[] nums)
// {
//     List<int> newNums = [];

//     for (int i = 0; i < nums.Length; i++)
//     {
//         int index = i;
//         int sum = 0;

//         while (index >= 0)
//         {
//             sum += nums[index];
//             index--;
//         }

//         newNums.Add(sum);
//     }

//     return newNums.ToArray();
// }

int[] RunningSum(int[] nums)
{
    for (int i = 1; i < nums.Length; i++)
    {
        Console.WriteLine($"{nums[i - 1]} + {nums[i]}");
        nums[i] = nums[i - 1] + nums[i];
        Console.WriteLine(nums[i]);
    }

    return nums;
}