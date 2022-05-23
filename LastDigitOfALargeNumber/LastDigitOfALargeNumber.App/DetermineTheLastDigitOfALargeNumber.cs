using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace LastDigitOfALargeNumber.App
{
    public class DetermineTheLastDigitOfALargeNumber : IDetermineTheLastDigitOfALargeNumber
    {
        public int GetTheLastDigit(BigInteger n1, BigInteger n2)
        {
            var lastDigitCycle = new Dictionary<int, List<int>>()
            {
                {0, new List<int> {0}},
                {1, new List<int> {1}},
                {2, new List<int> {6, 2, 4, 8}},
                {3, new List<int> {1, 3, 9, 7}},
                {4, new List<int> {6, 4}},
                {5, new List<int> {5}},
                {6, new List<int> {6}},
                {7, new List<int> {1, 7, 9, 3}},
                {8, new List<int> {6, 8, 4, 2}},
                {9, new List<int> {1, 9}}
            };

            if (n2 == 0)
            {
                return 1;
            }

            else
            {
                BigInteger lastDigitOfA = n1 % 10;
                int len = lastDigitCycle[(int)lastDigitOfA].Count(); ;
                BigInteger reqIndex = n2 % len;
                return lastDigitCycle[(int)lastDigitOfA][(int)reqIndex];
               // var value = BigInteger.Pow(n1, (int)n2);
               //// var value = Enumerable.Repeat(n1, n2).Aggregate(1, (a, b) => a * b);
               // //BigInteger power = 1;
               // //for (BigInteger i = 1; i <= n2; i++)
               // //{
               // //    power = power * n1;
               // //}

                //var answerToReturn = value % 10;

                //return (int)answerToReturn;
            }
        }
    }
}
