// Given a fixed-length integer array arr, duplicate each occurrence of zero, shifting the remaining elements to the right.

// Note that elements beyond the length of the original array are not written. Do the above modifications to the input array in place and do not return anything.

var sol = new Solution();
sol.DuplicateZeros([1, 0, 2, 3, 0, 4, 5, 0]);
Console.WriteLine("EXPECTED: [1, 0, 0, 2, 3, 0, 0, 4]");
sol.DuplicateZeros([8, 4, 5, 0, 0, 0, 0, 7]);
Console.WriteLine("EXPECTED: [8, 4, 5, 0, 0, 0, 0, 0]");
sol.DuplicateZeros([0, 1, 7, 6, 0, 2, 0, 7]);
Console.WriteLine("EXPECTED: [0, 0, 1, 7, 6, 0, 0, 2]");
sol.DuplicateZeros([1, 0, 2, 3, 0, 4, 5, 0]);
Console.WriteLine("EXPECTED: [1, 0, 0, 2, 3, 0, 0, 4]");
sol.DuplicateZeros([0, 4, 1, 0, 0, 8, 0, 0, 3]);
Console.WriteLine("EXPECTED: [0, 0, 4, 1, 0, 0, 0, 0, 8]");

public class Solution
{
    public void DuplicateZeros(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    arr[j] = arr[j - 1];
                    // Console.WriteLine(string.Join(", ", arr));
                }
                i++;
                Console.WriteLine(string.Join(", ", arr));
            }
        }

        Console.WriteLine("ACTUAL: " + "[" + string.Join(", ", arr) + "]");
    }
}