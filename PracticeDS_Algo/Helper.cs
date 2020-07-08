using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo
{
    public class Helper
    {
        /// <summary>
        /// Get Random number between 0-100
        /// Space Complexity O(n)
        /// Time Complexity O(n)
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public int[] GetRandomNumbers(int length)
        {
            int[] numbers = new int[length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                numbers[i] = random.Next(0, 100);
            }
            return numbers;
        }
        public void PrintArray<T>(T[] values)
        {
            string allVal = String.Join(',', values);
            Console.WriteLine(allVal);
        }
    }
}
