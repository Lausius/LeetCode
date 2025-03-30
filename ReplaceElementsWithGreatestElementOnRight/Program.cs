var sol = new Solution();
var result = sol.ReplaceElements([17, 18, 5, 4, 6, 1]);

Console.WriteLine("[" + string.Join(", ", result) + "]");

public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        int maxRight = -1; // The last element should always be -1

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            int current = arr[i]; // Store current element before replacing
            arr[i] = maxRight; // Replace with max seen so far
            maxRight = Math.Max(maxRight, current); // Update maxRight
        }

        return arr;
    }
}