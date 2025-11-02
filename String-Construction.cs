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


class Result
{

    /*
     * Complete the 'stringConstruction' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int stringConstruction(string s)
    {
        HashSet<char> uniqueChars = new HashSet<char>();

        foreach (char c in s)
        {
            uniqueChars.Add(c);
        }

        return uniqueChars.Count;
    }    


    public static int stringConstruction2(string s)
    {
        SortedSet<char> uniqueChars = new SortedSet<char>();

        foreach (char c in s)
        {
            uniqueChars.Add(c);
        }

        return uniqueChars.Count;
    }
    
}
