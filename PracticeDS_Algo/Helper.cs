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
        public int[] GetRandomNumbers(int length=10, int min=0, int max=100)
        {
            int[] numbers = new int[length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                numbers[i] = random.Next(min,max);
            }
            return numbers;
        }
        public string[] GetRandomStr(int numberOfStr=10, int wordSize=5)
        {
            Random random = new Random();
            const string chars = "ABCSDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstwxyz";
            string[] words = new string[numberOfStr];
            for(int i=0; i<numberOfStr; i++)
            {
                StringBuilder word = new StringBuilder();
                for(int j=0; j<wordSize; j++)
                {
                    int index = random.Next(0, 51);
                    word.Append(chars[index]);
                }
                words[i] = word.ToString();
            }
            return words;
        }
        public void PrintArray<T>(T[] values)
        {
            int len = values.Length;
            Console.WriteLine();
            Console.Write("[");
            for (int i=0; i<len; i++)
            {
                Console.Write($"{values[i]}");
                if (i != len - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("]");
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
