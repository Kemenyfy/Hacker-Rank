//Problem:

//John works at a clothing store.He has a large pile of socks that he must pair by color for sale.Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.

//For example, there are socks with colors.There is one pair of color  and one of color . There are three odd socks left, one of each color. The number of pairs is .


//Function Description


//Complete the sockMerchant function in the editor below.It must return an integer representing the number of matching pairs of socks that are available.

//sockMerchant has the following parameter(s):


//n: the number of socks in the pile
//ar: the colors of each sock
//Input Format

//The first line contains an integer , the number of socks represented in .
//The second line contains  space-separated integers describing the colors of the socks in the pile.

//Return the total number of matching pairs of socks that John can sell.

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

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {

        var pairs = 0;
        var sockType = new Dictionary<int, int>();

        // Loop throughout the array of socks
        foreach (var sock in ar)
        {
            // If sock is found
            if (sockType.ContainsKey(sock))
            {
                // Add one pair
                pairs++;
                // Remove that sock from the array
                sockType.Remove(sock);
            }
            else
            {
                // move to the next sock
                sockType.Add(sock, 1);
            }
        }
        return pairs;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
