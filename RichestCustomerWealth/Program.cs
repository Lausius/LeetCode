int result = MaximumWealth([[1, 5], [7, 3], [3, 5]]);
Console.WriteLine(result);

// int MaximumWealth(int[][] accounts)
// {
//     int maxWealth = 0;
//     for (int i = 0; i < accounts.Length; i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < accounts[i].Length; j++)
//         {
//             sum += accounts[i][j];
//         }

//         if (maxWealth < sum)
//             maxWealth = sum;
//     }
//     return maxWealth;
// }

int MaximumWealth(int[][] accounts)
{
    int maxWealth = 0;
    
    foreach (int[] customer in accounts)
    {
        int sum = 0;
        foreach (int bank in customer)
        {
            sum += bank;
        }

        if (maxWealth < sum)
            maxWealth = sum;
    }

    return maxWealth;
}

// int MaximumWealth(int[][] accounts)
// {
//     return accounts.Select(account => account.Sum()).Max();
// }