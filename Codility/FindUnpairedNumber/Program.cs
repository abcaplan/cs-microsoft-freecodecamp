// https://app.codility.com/c/run/trainingRWEYZH-A9H/

/* A non-empty array A consisting of N integers is given.
** The array contains an odd number of elements, and each element of the array
** can be paired with another element that has the same value, 
** except for one element that is left unpaired.
*/

class Solution
{
    public int solution(int[] A)
    {
        int result = 0;

        foreach (int num in A)
        {
            // XOR gates
            result ^= num;
        }

        return result;
    }
}