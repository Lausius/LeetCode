
Console.WriteLine("[" + string.Join(", ", TwoSum([2, 5, 5, 11], 10)) + "]");

// int[] TwoSum(int[] nums, int target)
// {
//     int[] result = new int[2];

//     for (int i = 0; i < nums.Length; i++)
//     {
//         int currentNum = nums[i];
//         for (int j = 1; j < nums.Length; j++)
//         {
//             if(i == j)
//                 continue;

//             int nextNum = nums[j];
//             var sum = currentNum + nextNum;
//             Console.WriteLine($"{currentNum} + {nextNum} = {sum}");

//             if (sum == target)
//             {
//                 result[0] = i;
//                 result[1] = j;
//                 return result;
//             }
//         }
//     }

//     return result;
// }

int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> kvps = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        int diff = target - nums[i];
        if (kvps.ContainsKey(diff))
            return [kvps[diff], i];

        kvps[nums[i]] = i;
    }
    return [];
}