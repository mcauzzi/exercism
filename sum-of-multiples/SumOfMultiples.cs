using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        List<int> mulList=new List<int>();
        int result=0;
        multiples=multiples.Where(u => u!=0 ).ToList();
        for(int i=1;i<max;i++){
            foreach(int val in multiples){
                if(i%val==0){
                    mulList.Add(i);
                }
            }
        }
        mulList=mulList.Distinct().ToList();    
        foreach(int val in mulList){
            result+=val;
        }

        return result;    
    }
}