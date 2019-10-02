//Problem:

//Given a 6 x 6 2D Array, arr:

//1 1 1 0 0 0
//0 1 0 0 0 0
//1 1 1 0 0 0
//0 0 0 0 0 0
//0 0 0 0 0 0
//0 0 0 0 0 0

//We define an hourglass in A to be a subset of values with indices falling in this pattern in arr's graphical representation:

//a b c
//  d
//e f g

//There are 16 hourglasses in arr, and an hourglass sum is the sum of an hourglass' values. Calculate the hourglass sum for every hourglass in arr, then print the maximum hourglass sum.

//For example, given the 2D array:

//-9 -9 -9  1 1 1 
// 0 -9  0  4 3 2
//-9 -9 -9  1 2 3
// 0  0  8  6 6 0
// 0  0  0 -2 0 0
// 0  0  1  2 4 0

//We calculate the following 16 hourglass values:

//-63, -34, -9, 12,
//-10, 0, 28, 23,
//-27, -11, -2, 10,
//9, 17, 25, 18

//Our highest hourglass value is 28 from the hourglass:

//0 4 3
//  1
//8 6 6

//Function Description

//Complete the function hourglassSum in the editor below.It should return an integer, the maximum hourglass sum in the array.

//hourglassSum has the following parameter(s):

//arr: an array of integers

//Input Format

//Each of the 6 lines of inputs arr[i] contains 6 space-separated integers arr[i][j].

//Output Format

//Print the largest (maximum) hourglass sum found in arr.

//Sample Input

//1 1 1 0 0 0
//0 1 0 0 0 0
//1 1 1 0 0 0
//0 0 2 4 4 0
//0 0 0 2 0 0
//0 0 1 2 4 0

//Sample Output

//19

//The hourglass with the maximum sum(19) is:

//2 4 4
//  2
//1 2 4

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

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr)
    {
        // We initialize an new List for our hourglasses sums
        var hourglasses = new List<int>();

        // We loop around the top four rows
        for (var row = 0; row <= 3; row++)
        {
            // // We loop around the first four columns
            for (var column = 0; column <= 3; column++)
            {
                // Initialize a variable for our sums
                var sum = 0;

                // We add for each of the seven positions in our hourglasses
                sum += arr[row][column];
                sum += arr[row][column + 1];
                sum += arr[row][column + 2];
                sum += arr[row + 1][column + 1];
                sum += arr[row + 2][column];
                sum += arr[row + 2][column + 1];
                sum += arr[row + 2][column + 2];

                // We push the result into our array
                hourglasses.Add(sum);
            }
        }
        
        // We return the biggest int in our List
        return hourglasses.Max();
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
