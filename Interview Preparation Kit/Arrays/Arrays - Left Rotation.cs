//Problem:

//A left rotation operation on an array shifts each of the array's elements 1 unit to the left. For example, if 2 left rotations are performed on array [1,2,3,4,5], then the array would become [3,4,5,1,2].

//Given an array a of n integers and a number, d, perform d left rotations on the array.Return the updated array to be printed as a single line of space-separated integers.

//Function Description

//Complete the function rotLeft in the editor below.It should return the resulting array of integers.

//rotLeft has the following parameter(s):

//An array of integers a.
//An integer d, the number of rotations.

//Input Format

//The first line contains two space-separated integers  and , the size of and the number of left rotations you must perform.
//The second line contains  space-separated integers .

//Output Format

//Print a single line of n space-separated integers denoting the final state of the array after performing d left rotations.

//Sample Input

//5 4
//1 2 3 4 5

//Sample Output

//5 1 2 3 4

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the rotLeft function below.
    public static int[] rotLeft(int[] a, int d)
    {
        int[] result = new int[a.Length];

        for (int i = d; i < a.Length; i++)
        {
            result[i - d] = a[i];
        }

        for (int j = 0; j < d; j++)
        {
            result[a.Length - d + j] = a[j];
        }

        return result;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int[] result = rotLeft(a, d);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}

