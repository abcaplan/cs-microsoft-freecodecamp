public class Solution
{
    // Similar to Fibonacci
    public int ClimbStairs(int n)
    {
        // Base cases
        if (n == 1) return 1;
        if (n == 2) return 2;

        // Initialize the variables for the base cases
        int oneStepBefore = 2;
        int twoStepsBefore = 1;
        int allWays = 0;

        // Compute the number of ways iteratively
        for (int i = 3; i <= n; i++)
        {
            allWays = oneStepBefore + twoStepsBefore;
            twoStepsBefore = oneStepBefore;
            oneStepBefore = allWays;
        }

        return allWays;
    }
}
