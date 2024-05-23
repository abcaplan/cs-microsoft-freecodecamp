// https://app.codility.com/c/run/trainingEQRJXB-78G/

/* An array A consisting of N integers is given. Rotation of the array means that each element
** is shifted right by one index, and the last element of the array is moved to the first place.
** For example, the rotation of array A = [3, 8, 9, 7, 6] is [6, 3, 8, 9, 7] 
** (elements are shifted right by one index and 6 is moved to the first place).
**
** The goal is to rotate array A K times; that is, each element of A will be shifted to the right K times.
*/

using System;

public class Solution
{
    public int[] solution(int[] A, int K)
    {
        {
            int N = A.Length;

            // No elements to rotate, return array as it is
            if (N == 0)
            {
                return A;
            }

            // !!! Reduce K to the effective number of rotations
            K = K % N;

            // No K rotations, so the array is returned as it is received initially
            if (K == 0)
            {
                return A;
            }


            // Create a new array for the result
            int[] result = new int[N];

            // Place the last K elements at the beginning of the result array
            for (int i = 0; i < K; i++)
            {
                result[i] = A[N - K + i];
            }

            // Place the remaining elements after the first K elements
            for (int i = 0; i < N - K; i++)
            {
                result[K + i] = A[i];
            }

            return result;
        }
    }
}

class Program
{
    static void Main()
    {
        Solution sol = new Solution();

        int[] A1 = { 3, 8, 9, 7, 6 };
        int K1 = 3;
        Console.WriteLine(string.Join(", ", sol.solution(A1, K1))); // Output: 9, 7, 6, 3, 8

        int[] A2 = { 0, 0, 0 };
        int K2 = 1;
        Console.WriteLine(string.Join(", ", sol.solution(A2, K2))); // Output: 0, 0, 0

        int[] A3 = { 1, 2, 3, 4 };
        int K3 = 4;
        Console.WriteLine(string.Join(", ", sol.solution(A3, K3))); // Output: 1, 2, 3, 4
    }
}
