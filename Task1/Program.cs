// Tas1
/*
Write a function:

class Solution { public int solution(int[] A); }

that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

Given A = [1, 2, 3], the function should return 4.

Given A = [−1, −3], the function should return 1.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [1..100,000];
each element of array A is an integer within the range [−1,000,000..1,000,000].

Test score:
https://app.codility.com/c/feedback/demo7JFGKX-DQJ/
 
*/

using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        Array.Sort(A);

        if (A[0] < 0)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0)
                {
                    A[i] = 0;
                }
                else
                {
                    break;
                }
            }
        }

        int lengthA = A.Length;
        int[] arr = Enumerable.Range(1, A[lengthA - 1] + 1).ToArray();
        int[] arrExcept = arr.Except(A).ToArray();

        return arrExcept[0];
    }
}
