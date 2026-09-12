internal class Program
{
    private static void Main(string[] args)
    {
        // radar → radar ✅
        // madam → madam ✅
        // level → level ✅
        // hello → olleh ❌

        Console.WriteLine(IsPalindromeV2("level")); // True
        Console.WriteLine(IsPalindromeV2("hello")); // False
    }

    // Time: O(n)
    // Space: O(n)
    static bool IsPalindrome(string text)
    {
        var reversed = new string(text.Reverse().ToArray());
        return text == reversed;
    }

    // Time: O(n)
    // Space: O(1)
    static bool IsPalindromeV2(string text)
    {
        int left = 0;
        int right = text.Length - 1;

        while (left < right) 
        { 
            if(text[left] != text[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}