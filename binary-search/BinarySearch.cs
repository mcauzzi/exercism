using System;
using System.Collections.Generic;
using System.Linq;
public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        if(input.Length==0){
            return -1;
        }
        int l=0;
        int r=input.Length-1;
        for(int i=(l+r)/2;l<=r;){   

            if(value>input[i]){
                l=i+1;
            } else if(value<input[i]){
                r=i-1;
            }else if(value==input[i]){
                return i;
            }

            i=(int)Math.Floor( (double)(l+r)/2);
        }

        return -1;
    }
}