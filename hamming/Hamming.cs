using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int dist = 0;

        if (firstStrand.Length != secondStrand.Length)
        {
            throw new System.ArgumentException();
        }

        for (int i = 0; i < firstStrand.Length; i++)
        {
            if (!firstStrand[i].Equals(secondStrand[i]))
            {
                dist++;
            }
        }
      

        return dist;
    }
}