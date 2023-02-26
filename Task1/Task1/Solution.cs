using System;

public class Solution
{
    /*
     * Time complexity:  O(N), since we traverse the input array and where N is the length of the input array.
     * Space complexity: O(1), since we modify the input array in place.
     */
    public int solution(int[] A)
    {
        if (A == null || A.Length == 0)
        {
            return 1;
        }

        int N = A.Length;

        for (int i = 0; i < N; i++)
        {
            // Swap the elements to their corresponding positions
            while (A[i] > 0 && A[i] <= N && A[A[i] - 1] != A[i])
            {
                int temp = A[A[i] - 1];
                A[A[i] - 1] = A[i];
                A[i] = temp;
            }
        }

        for (int i = 0; i < N; i++)
        {
            // find first index where value doesn't match corresponding index + 1
            if (A[i] != i + 1)
            {
                return i + 1;
            }
        }

        return N + 1;
    }
}
