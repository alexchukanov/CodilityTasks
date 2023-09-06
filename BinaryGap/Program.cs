//Task Bynary Gap

/*
Task description

A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones
at both ends in the binary representation of N.

For example, number 9 has binary representation 1001 and contains a binary gap of length 2. 
The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. 
The number 20 has binary representation 10100 and contains one binary gap of length 1. 
The number 15 has binary representation 1111 and has no binary gaps. 
The number 32 has binary representation 100000 and has no binary gaps.

Write a function:

class Solution { public int solution(int N); }

N is an integer within the range [1..2,147,483,647].

Task score:
https://app.codility.com/demo/results/trainingAMYGNQ-84Q/
*/

using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

int[] numberArr = new int[] { 9, 529, 20, 15, 1041 };
Solution sl = new Solution();

foreach (var N in numberArr)
{
    Console.WriteLine($"N={N} Binary={Convert.ToString(N, 2).Trim('0')} Gap={sl.solution(N)}");
}


class Solution
{
    public int solution(int N)
    {
        string binaryStr = Convert.ToString(N, 2).Trim('0');

        int count = 0;

        string[] setArr = binaryStr.Split('1');

        foreach (var item in setArr)
        {
            if (item.Length > count)
            {
                count = item.Length;
            }
        }

        return count;
    }
}