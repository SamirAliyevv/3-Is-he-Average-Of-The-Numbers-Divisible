using System;

namespace _3_Is_The_Average_Of_The_Numbers_Divisible
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 66, 35, 56, 7, 8, 21, 99 };
            int  count = 0;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3==0)
                {
                    sum+= numbers[i];
                    count++;
                }

            }
            Console.WriteLine(sum / count);
        }     
    }
}
