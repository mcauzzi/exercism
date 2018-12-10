using System;
using System.Collections.Generic;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        List<int> digitList=GetDigits(number);
        int numDigits=digitList.Count;
        int sum=0;

        foreach(int n in digitList){
            sum+=(int) (Math.Pow(n, numDigits));
        }

        if(sum==number){
            return true;
        } else {
            return false;
        }
    }

    private static List<int> GetDigits(int num){
        List<int> digitList=new List<int>();
        while(num!=0){
            digitList.Add(num%10);
            num/=10;
        }

        return digitList;
    }
}