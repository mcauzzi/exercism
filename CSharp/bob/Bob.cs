using System;
using System.Text.RegularExpressions;
public static class Bob
{
    public static string Response(string statement)
    {
        statement=statement.Trim();
        if( Regex.Matches(statement,@"[a-zA-Z0-9?!]").Count==0 ){
            return "Fine. Be that way!";
        }

        if(statement[statement.Length-1] == '?'){
            if( Regex.Matches(statement,@"[A-Z]").Count > 1 && Regex.Matches(statement,@"[a-z]").Count == 0 ){
                return "Calm down, I know what I'm doing!";
            } else {
                return "Sure.";
            }
        }

        if( Regex.Matches(statement,@"[A-Z]").Count > 1 && Regex.Matches(statement,@"[a-z]").Count == 0 ){
            return "Whoa, chill out!";
        }   
       
        return "Whatever.";
    }
}