using System;
using System.Collections;

public class Clock : IEquatable<Clock>
{
    public Clock(int hours, int minutes)
    {
        var hoursToAdd=minutes/60;

        if(minutes<0){
            hoursToAdd-=1;
        }

        Hours=(hours+hoursToAdd)%24;
        if(Hours<0){
            Hours+=24;
        }

        Minutes=minutes%60;
        if(Minutes<0){
            Minutes+=60;
        }
    }

    public int Hours
    {
        get;set;
    }

    public int Minutes
    {
        get;set;
    }

    public Clock Add(int minutesToAdd)
    {
        return new Clock(Hours, Minutes+minutesToAdd);
    }

    public Clock Subtract(int minutesToSubtract)
    {
        return new Clock(Hours, Minutes-minutesToSubtract);
    }

    public override string ToString()
    {
        var str="";

        if(Hours<10){
            str+="0"+Hours+":";
        } else {
            str+=Hours+":";
        }

        if(Minutes<10){
            str+="0"+Minutes;
        } else {
            str+=Minutes;
        }

        return str;
    }

    public bool Equals(Clock c){
        if( c.Minutes == Minutes && c.Hours == Hours ){
            return true;
        } else {
            return false;
        }
    }

    public override bool Equals(Object obj){
        return Equals(obj as Clock);
    }
}