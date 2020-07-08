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
        public string RandomStr(int maxSize)
        {
            
            return null;
        }
        public void PrintArray<T>(T[] values)
        {
            string allVal = String.Join(',', values);
            Console.WriteLine(allVal);
        }

        /// <summary>
        /// Compare betwenn two string
        /// return 0 when param1==param2 | return -1 when param1>param2 otherwise return 1
        /// </summary>
        /// <param name="small">firat value</param>
        /// <param name="large">second value</param>
        /// <returns>int</returns>
        /// //TimeComplexity O(n) | SpaceComplexity O(1)
        public int StrComp(string small, string large)
        {
            if (small == large) { return 0; }
            int smallLength = small.Length;
            int largeLength = large.Length;
            int endPoint = smallLength < largeLength ? smallLength : largeLength;
            int i = 0;
            while (i < endPoint)
            {
                if (small[i] == large[i])
                {
                    i++; continue;
                }
                if (small[i] > large[i])
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            return smallLength < largeLength ? 1 : -1;
        }
    }
}
