public class Solution
{
    public int RomanToInt(string s)
    {
        int number = 0;
        for (int i = 0; i < s.Length; i++)
        {
            // Check if this character is less than the next character
            if (i < s.Length - 1 && GetValue(s[i]) < GetValue(s[i + 1]))
            {
                number -= GetValue(s[i]);
            }
            else
            {
                number += GetValue(s[i]);
            }
        }
        return number;
    }

    private int GetValue(char romanChar)
    {
        switch (romanChar)
        {
            case 'M':
                return 1000;
            case 'D':
                return 500;
            case 'C':
                return 100;
            case 'L':
                return 50;
            case 'X':
                return 10;
            case 'V':
                return 5;
            case 'I':
                return 1;
            default:
                throw new ArgumentException("Invalid Roman numeral character");
        }
    }
}