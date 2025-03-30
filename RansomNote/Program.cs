Solution solution = new Solution();

Console.WriteLine(solution.CanConstruct("a", "b"));
Console.WriteLine(solution.CanConstruct("aa", "ab"));
Console.WriteLine(solution.CanConstruct("aa", "aab"));
Console.WriteLine(solution.CanConstruct("aauws", "abolowisu"));
Console.WriteLine(solution.CanConstruct("aauws", "aabolowisu"));

public class Solution
{
    // public bool CanConstruct(string ransomNote, string magazine)
    // {
    //     for (int i = 0; i < ransomNote.Length; i++)
    //     {
    //         char letter = ransomNote[i];
    //         Console.WriteLine($"Testing if {magazine} contains {letter}...");

    //         int index = magazine.IndexOf(letter);

    //         // if magazine doesn't contain the ransomnote letter, it can't be true
    //         if (index == -1)
    //             return false;

    //         magazine = magazine.Remove(index, 1);
    //     }

    //     return true;
    // }

    // hashmap solution
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var charCounts = new Dictionary<char, int>(); // value is the count of the letters

        //populate magazineLetters
        foreach (char letter in magazine)
        {
            if (charCounts.ContainsKey(letter))
                charCounts[letter]++;
            else
                charCounts[letter] = 1;
        }

        // Check if ransomNote can be formed
        foreach (char letter in ransomNote)
        {
            if (!charCounts.ContainsKey(letter) || charCounts[letter] == 0)
                return false; // Letter is missing or not enough occurrences

            charCounts[letter]--; // Use one occurrence of the letter
        }

        return true;
    }
}