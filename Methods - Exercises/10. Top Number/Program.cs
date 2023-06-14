using System;
namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            bool isDivisibleByEight = false;
            bool isHoldAtLeastOneOdd = false;

            for (int i = 1; i < input; i++)
            {
                int currentNum = i;
                int lastDigit = 0;

                for (int k = 0; k < length; i++)
                {

                }
                if (currentNum%8==0)
                {
                    
                    
                    //for (int j = 0; j < currentNum; j++)
                    //{
                    //    int lastDigit = currentNum % 10;
                    //    if (lastDigit == 1 || lastDigit == 3 || lastDigit == 5 || lastDigit == 7 || lastDigit == 9)
                    //    {
                    //        isHoldAtLeastOneOdd = true;                           
                    //    }
                    //}
                }
                else
                {
                    break;
                }

            }
            if (isDivisibleByEight && isHoldAtLeastOneOdd)
            {
                Console.WriteLine(input);
            }
            
        }
        //static bool IsDivisibleByEight(int input)
        //{
        //    for (int i = 0; i < input; i++)
        //    {
        //        if (i % 8 == 0)
        //        {
        //            isDivisibleByEight = true;
        //        }

        //    }
        //}

    }
}