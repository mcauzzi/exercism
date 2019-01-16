using System;
using System.Collections.Generic;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        var nucDictionary = new Dictionary<string, string> { { "G", "C" }, { "C", "G" }, { "T", "A" }, { "A", "U" } };
        var result = string.Empty;
        foreach (var c in nucleotide)
        {
            result += nucDictionary[c.ToString()];
        }

        return result;
    }
}