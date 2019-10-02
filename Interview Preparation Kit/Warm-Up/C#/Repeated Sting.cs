//Problem:

//Lilah has a string, , of lowercase English letters that she repeated infinitely many times.

//Given an integer, , find and print the number of letter a's in the first  letters of Lilah's infinite string.

//For example, if the string and, the substring we consider is , the first  characters of her infinite string. There are  occurrences of a in the substring.

//Function Description

//Complete the repeatedString function in the editor below.It should return an integer representing the number of occurrences of a in the prefix of length  in the infinitely repeating string.

//repeatedString has the following parameter(s):

//s: a string to repeat
//n: the number of characters to consider
//Input Format

//The first line contains a single string, .
//The second line contains an integer, .

//Output Format

//Print a single integer denoting the number of letter a's in the first  letters of the infinite string created by repeating  infinitely many times.

//Assuming height is in cm and weight is in kg

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

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n)
    {
        // Set Count Variable to long zero
        var count = 0L;

        // Iterate over string to find out how many a's are present and add them to count
        foreach (var letter in s)
        {
            if (letter == 'a')
                count++;
        }

        // Find out how many strings fit in n length. Multiply count by that number
        var possibleStringRepeats = n / s.Length;
        count *= (long)possibleStringRepeats;

        // Check for any remaining pieces of the string
        var offsetStringLength = n % s.Length;

        // Iterate over remaining pieces to find how many a's are present and add them to count
        for (int i = 0; i < offsetStringLength; i++)
        {
            if (s[i] == 'a')
                count++;
        }

        return count;

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

