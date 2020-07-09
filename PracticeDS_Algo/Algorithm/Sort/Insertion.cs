using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.Algorithm.Sort
{
    public class Insertion : ISorter, ITest
    {
        /// <summary>
        /// TimeComplexity O(n^2) | SpaceComplexity O(1)
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int[] Ascending(int[] numbers)
        {
            int count = 0;
            int i, j, temp, endPoint=numbers.Length;
            for(i=1; i<endPoint; i++)
            {
                temp = numbers[i];
                j = i-1;
                while (j >= 0 && numbers[j] > temp)
                {
                    count++;
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = temp;
            }
            Console.WriteLine("Total iteration: " + count);
            return numbers;
        }

        public string[] Ascending(string[] items)
        {
            Helper helper = new Helper();
            int i, j, endPoint = items.Length;
            string temp;
            for(i=1; i<endPoint; i++)
            {
                temp = items[i];
                j = i - 1;
                while(j>=0 && helper.StrComp(temp, items[j]) > 0)
                {
                    items[j + 1] = items[j];
                    j--;
                }
                items[j + 1] = temp;
            }
            return items;
        }

        public int[] Descending(int[] numbers)
        {
            int i, j, temp, length = numbers.Length, count=0;
            for(i=0; i<length; i++)
            {
                temp = numbers[i];
                for(j=i-1; j>=0 && numbers[j] < temp; j--)
                {
                    numbers[j + 1] = numbers[j];
                    count++;
                }
                numbers[j + 1] = temp;
            }
            Console.WriteLine("Total iteration: " + count);
            return numbers;
        }

        public string[] Descending(string[] items)
        {
            Helper helper = new Helper();
            int i, j, endPoint = items.Length;
            string temp;
            for(i=1; i<endPoint; i++)
            {
                temp = items[i];
                j = i - 1;
                while(j>=0 && helper.StrComp(temp, items[j]) < 0)
                {
                    items[j + 1] = items[j];
                    j--;
                }
                items[j + 1] = temp;
            }
            return items;
        }

        public void Execute()
        {
            Helper helper = new Helper();
            var items = helper.GetRandomNumbers();
            helper.PrintArray(items);
            Ascending(items);
            helper.PrintArray(items);
            Descending(items);
            helper.PrintArray(items);

            var words = helper.GetRandomStr();
            helper.PrintArray(words);
            Ascending(words);
            helper.PrintArray(words);
            Descending(words);
            helper.PrintArray(words);
        }
    }
}
