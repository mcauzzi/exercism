using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> nucCount=new Dictionary<char, int>{
            {'A', 0}, {'T', 0}, {'C', 0}, {'G', 0}
        };

        foreach(char c in sequence){
            try{
                nucCount[c]++;
            } catch (KeyNotFoundException){
                throw new ArgumentException();
            }
        }

        return nucCount;
    }
}