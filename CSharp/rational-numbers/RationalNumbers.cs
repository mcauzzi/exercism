using System;
using System.Diagnostics;

public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r)
    {
        return Math.Pow(realNumber, (double)r.numerator/r.denominator);
    }
}

public struct RationalNumber
{
    public int numerator{get; private set;}
    public int denominator{get; private set;}
    public RationalNumber(int numerator, int denominator)
    {
        this.numerator=numerator;
        this.denominator=denominator;
        int gcd=GCD(this.numerator,this.denominator);

        while(gcd != 1 && gcd!=0){
            this.numerator/=gcd;
            this.denominator/=gcd;
            gcd=GCD(this.numerator, this.denominator);
        }

        if(this.numerator==0){
            this.denominator=1;
        }
        
        if(this.denominator<0){
            if(this.numerator<0){
                this.numerator=Math.Abs(this.numerator);
                this.denominator=Math.Abs(this.denominator);
            } else {
                this.denominator=Math.Abs(this.denominator);
                this.numerator= -this.numerator;
            }
        }
    }

    public RationalNumber Add(RationalNumber r)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        int lcm=LCM(r1.denominator, r2.denominator);
        int num=((lcm/r1.denominator)*r1.numerator)+((lcm/r2.denominator)*r2.numerator);
        return new RationalNumber(num,lcm);
    }
   
    public RationalNumber Sub(RationalNumber r)
    {
        return this+(new RationalNumber(-r.numerator, r.denominator));
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        return r1.Sub(r2);
    }

    public RationalNumber Mul(RationalNumber r)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber(r1.numerator*r2.numerator,r1.denominator*r2.denominator);
    }

    public RationalNumber Div(RationalNumber r)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber(r1.numerator*r2.denominator,r1.denominator*r2.numerator);
    }

    public RationalNumber Abs()
    {
       if(this.numerator < 0){
           return new RationalNumber(Math.Abs(this.numerator), this.denominator);
       }

       return this;
    }

    public RationalNumber Reduce()
    {
        return this;
    }

    public RationalNumber Exprational(int power)
    {
        if(power < 0){
            return new RationalNumber((int) Math.Pow(this.denominator,power), (int)Math.Pow(this.numerator, power));
        } else {
            return new RationalNumber((int) Math.Pow(this.numerator,power), (int)Math.Pow(this.denominator, power));
        }
    }

    public double Expreal(int baseNumber)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

#region Private Methods
     private static int LCM(int n, int m){
        int max=Math.Max(n,m);
        int min=Math.Min(n,m);
        for(int i = 1; i<2000000000 ; i++){

            if( (max*i)%min ==0 ){
                return max*i;
            }
        }

        throw new IndexOutOfRangeException();
    }

    private static int GCD(int n, int m){
        int max=Math.Max(n,m);
        int gcd=0;
        for(int i = 1; i<=max ; i++){
            if(n%i==0 && m%i==0){
               gcd=i;
            }
        }

       return gcd;
    }
#endregion
}