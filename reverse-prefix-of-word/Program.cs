using System;

public class ReverseString
{
    public static string ReverseSubstring(string word, char ch)
    {
        // Find the index of the first occurrence of the character ch
        int index = word.IndexOf(ch);
        
        // If the character is not found, return the original word
        if (index == -1)
        {
            return word;
        }
        
        // Reverse the segment of the word from index 0 to index of ch (inclusive)
        char[] segment = word.Substring(0, index + 1).ToCharArray();
        Array.Reverse(segment);
        
        // Combine the reversed segment with the rest of the word
        string reversedWord = new string(segment) + word.Substring(index + 1);
        
        // Return the resulting string
        return reversedWord;
    }

    public static void Main(string[] args)
    {
        // Example 1
        string word1 = "abcdefd";
        char ch1 = 'd';
        Console.WriteLine(ReverseSubstring(word1, ch1)); // Output: dcbaefd
        
        // Example 2
        string word2 = "xyxzxe";
        char ch2 = 'z';
        Console.WriteLine(ReverseSubstring(word2, ch2)); // Output: zxyxxe
        
        // Example 3
        string word3 = "abcd";
        char ch3 = 'z';
        Console.WriteLine(ReverseSubstring(word3, ch3)); // Output: abcd
    }
}
