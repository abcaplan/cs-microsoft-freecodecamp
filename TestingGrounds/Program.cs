using System;

public class Solution
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
}


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