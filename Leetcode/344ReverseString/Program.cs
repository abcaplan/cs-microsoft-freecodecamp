public class Solution
{
    public void ReverseString(char[] s)
    {
        int leftPos = 0;
        int rightPos = s.Length - 1;

        while (leftPos < rightPos)
        {
            char temp = s[leftPos];
            s[leftPos] = s[rightPos];
            s[rightPos] = temp;

            leftPos++;
            rightPos--;
        }
    }
}