//Problem:

//Emma is playing a new mobile game that starts with consecutively numbered clouds.Some of the clouds are thunderheads and others are cumulus.She can jump on any cumulus cloud having a number that is equal to the number of the current cloud plus or . She must avoid the thunderheads.Determine the minimum number of jumps it will take Emma to jump from her starting postion to the last cloud. It is always possible to win the game.

//For each game, Emma will get an array of clouds numbered  if they are safe or  if they must be avoided. For example, indexed from . The number on each cloud is its index in the list so she must avoid the clouds at indexes  and.She could follow the following two paths:  or.The first path takes  jumps while the second takes.

//Function Description

//Complete the jumpingOnClouds function in the editor below.It should return the minimum number of jumps required, as an integer.

//jumpingOnClouds has the following parameter(s):

//c: an array of binary integers

//Input Format

//The first line contains an integer , the total number of clouds.The second line contains  space-separated binary integers describing clouds where .

//Output Format

//Print the minimum number of jumps needed to win the game.

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
    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c)
    {
        // Create Variable for Storing amount of jumps and to initialize index value
        int jumps = 0;
        int i = 0;

        // Iterate as long as index value is within array length minus first index as it is the array's length
        while (i < c.Length - 1)
        {
            // Check if jumping two spaces is a valid option
            if (i + 2 < c.Length && c[i + 2] == 0)
            {
                jumps++;
                i = i + 2;
            }
            // if not jump only one space
            else
            {
                jumps++;
                i++;
            }
        }
        return jumps;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = jumpingOnClouds(c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
