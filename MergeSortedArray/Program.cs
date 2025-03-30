// You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, 
// representing the number of elements in nums1 and nums2 respectively.

// Merge nums1 and nums2 into a single array sorted in non-decreasing order.

// The final sorted array should not be returned by the function, but instead be stored inside the array nums1.

// To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, 
// and the last n elements are set to 0 and should be ignored. nums2 has a length of n.

var sol = new Solution();
sol.Merge([100, 5, 10, 0, 0, 0], 3, [4, 8, 6], 3);

public class Solution
{
    // public void Merge(int[] nums1, int m, int[] nums2, int n)
    // {
    //     int totalLength = n + m;

    //     // merge array
    //     for (int i = 0; i < nums2.Length; i++)
    //     {
    //         nums1[n + i] = nums2[i];
    //     }

    //     // sort array
    //     for (int i = 0; i < totalLength; i++)
    //     {
    //         // shifted loop
    //         for (int j = i + 1; j < totalLength; j++)
    //         {
    //            if (nums1[i] > nums1[j])
    //             {
    //                 // Swap
    //                 int temp = nums1[i];
    //                 nums1[i] = nums1[j];
    //                 nums1[j] = temp;
    //             }
    //         }
    //     }

    //     Console.WriteLine(string.Join(", ", nums1));
    // }

    // optimized Merging from the End - O(m+n)
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;       // Last valid element in nums1
        int j = n - 1;       // Last element in nums2
        int k = m + n - 1;   // Last position to fill in nums1

        while (j >= 0)  // Keep merging until nums2 is fully processed
        {
            if (i >= 0 && nums1[i] > nums2[j])
            {
                nums1[k--] = nums1[i--];  // Move larger element from nums1
            }
            else
            {
                nums1[k--] = nums2[j--];  // Move element from nums2
            }
        }
    }
}