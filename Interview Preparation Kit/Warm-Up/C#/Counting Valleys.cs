//Problem:

//Gary is an avid hiker.He tracks his hikes meticulously, paying close attention to small details like topography.During his last hike he took exactly  steps.For every step he took, he noted if it was an uphill, , or a downhill, step.Gary's hikes start and end at sea level and each step up or down represents a  unit change in altitude. We define the following terms:

//A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level and ending with a step down to sea level.
//A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step up to sea level.
//Given Gary's sequence of up and down steps during his last hike, find and print the number of valleys he walked through.

//For example, if Gary's path is , he first enters a valley  units deep. Then he climbs out an up onto a mountain  units high. Finally, he returns to sea level and ends his hike.

//Function Description

//Complete the countingValleys function in the editor below.It must return an integer that denotes the number of valleys Gary traversed.

//countingValleys has the following parameter(s):

//n: the number of steps Gary takes
//s: a string describing his path
//Input Format

//The first line contains an integer, the number of steps in Gary's hike.
//The second line contains a single string , of characters that describe his path.

//Output Format

//Print a single integer that denotes the number of valleys Gary walked through during his hike.

//Thoughts:

//1. Create Variable for Storing Sea Level
//2. Create Variable for Amount of Valleys
//3. Iterate throughout string while Adding or Subtracting to Sea Level
//4. Every Time Sea Level goes from 0 to -1 add one Valley.

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

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s)
    {
        // Create Variable for Storing Sea Level and to count amount of valleys
        var seaLevel = 0;
        var valleys = 0;

        // Iterate throughout string while Adding or Subtracting to Sea Level and if it is a new valley, add it to count
        for (int i = 0; i < n; i++)
        {
            if (s[i] == 'D')
                seaLevel--;
            else
                seaLevel++;

            if (seaLevel == -1 && s[i] == 'D')
                valleys++;
        }
        return valleys;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
