using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(string S)
    {
        // Store the number of appearances of all characters in a dictionary
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        // Count the appearances
        foreach (char c in S)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        // Count the number of characters with odd appearances
        int oddCount = 0;
        foreach (int count in charCount.Values)
        {
            if (count % 2 != 0)
            {
                oddCount++;
            }
        }

        // A palindrome can only have a maximum of one odd appearance of a character
        // Calculate characters to be removed to form a palindrome
        int charRemoved;
        if (oddCount > 1)
        {
            charRemoved = oddCount - 1;
        }
        else
        {
            charRemoved = 0;
        }

        return charRemoved;
    }
}

using System;

class Solution
{
    public void solution(int N)
    {
        bool enable_print = false;
        int result = 0;

        while (N > 0)
        {
            int last_number = N % 10;
            if (last_number != 0)
            {
                enable_print = true;
            }
            if (enable_print)
            {
                result = result * 10 + last_number;
            }
            N = N / 10;
        }
    }
}

/*public class Solution
{
    public int solution(int[] A)
    {
        int arrayLength = A.Length;

        bool[] present = new bool[arrayLength + 1];

        for (int i = 0; i < arrayLength; i++)
        {
            if (A[i] > 0 && A[i] <= arrayLength)
            {
                present[arrayLength[i]] = true;
            }
        }

        for (int i = 1; i <= arrayLength; i++)
        {
            if (!present[i])
            {
                return i;
            }
        }

        return arrayLength + 1;
    }
} */


/*
class Program
{
    static int f(int n)
    {
        int c = 0;
        while (n >= 0)
        {
            n = n - 2;
            c = c + n - 2;
        }
        return c;
    }

    static void Main(string[] args)
    {
        int result1 = f(0);
        int result2 = f(0 - 2);
        int result3 = f(2);
        int result4 = f(2 - 2);
        int result5 = f(4);
        int result6 = f(4 - 2);

        Console.WriteLine(result1);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
        Console.WriteLine(result4);
        Console.WriteLine(result5);
        Console.WriteLine(result6);
    }
}
*/