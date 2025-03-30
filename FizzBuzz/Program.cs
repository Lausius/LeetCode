Console.WriteLine("[" + string.Join(", ", FizzBuzz(15)) + "]");

// IList<string> FizzBuzz(int n)
// {
//     string[] fizzbuzz = new string[n];

//     for (int i = 0; i < fizzbuzz.Length; i++)
//     {
//         int value = i + 1;
//         if(value % 3 != 0 && value % 5 != 0) {
//             fizzbuzz[i] = value.ToString();
//             continue;
//         }
//         if (value % 3 == 0)
//         {
//             fizzbuzz[i] = "Fizz";
//         }
//         if (value % 5 == 0)
//         {
//             fizzbuzz[i] += "Buzz";
//         }
//     }
//     return fizzbuzz;
// }

IList<string> FizzBuzz(int n)
{
    var fizzbuzz = new List<string>(n);

    for (int i = 1; i <= n; i++)
    {
        var value = "";
        if(i % 3 == 0) value = "Fizz";
        if(i % 5 == 0) value += "Buzz";
        fizzbuzz.Add(string.IsNullOrWhiteSpace(value) ? i.ToString() : value);
    }
    return fizzbuzz;
}