using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int res = 0;
        for (int i = 0; i <= max; i++)
        {
            res += i;
        }

        return (int)Math.Pow(res, 2);
    }

    public static int CalculateSumOfSquares(int max)
    {
        int res = 0;
        for (int i = 1; i <= max; i++)
        {
            res += (int)Math.Pow(i, 2);
        }

        return res;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}