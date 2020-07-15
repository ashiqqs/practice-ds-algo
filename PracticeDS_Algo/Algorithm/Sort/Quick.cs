using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.Algorithm.Sort
{
    public class Quick : ITest
    {
        public Quick()
        {
            helper = new Helper();
        }
        private Helper helper;

        /// <summary>
        /// WrostCase O(n^2) | BestCase O(nlogn) | AvgCase O(nlogn)
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        public void Ascending(int[] numbers, int low, int high)
        {
            if (low >= high)
            {
                return;
            }
            int pivot = partition_asc(numbers, low, high);
            Ascending(numbers, low, pivot - 1);
            Ascending(numbers, pivot + 1, high);
        }
        public void Descending(int[] numbers, int low, int high)
        {
            if (low >= high)
            {
                return;
            }
            int pivot = partition_desc(numbers, low, high);
            Descending(numbers, low, pivot - 1);
            Descending(numbers, pivot + 1, high);
        }
        public void Ascending(string[] items, int low, int high)
        {
            if (low >= high) { return; }
            int pivot = partition_str(items, low, high);
            Ascending(items, low, pivot - 1);
            Ascending(items, pivot+1, high);
        }
        public void Descending(string[] items, int low, int high)
        {
            if (low >= high) { return; }
            int pivot = partition_str(items, low, high, true);
            Descending(items, low, pivot - 1);
            Descending(items, pivot + 1, high);
        }
        int partition_asc(int[] numbers, int low, int high)
        {
            int pivot = numbers[high], temp;
            int midPoint = low - 1, j;
            for (j = low; j < high; j++)
            {
                if (numbers[j] < pivot)
                {
                    temp = numbers[j];
                    numbers[j] = numbers[++midPoint];
                    numbers[midPoint] = temp;
                }
            }
            temp = numbers[++midPoint];
            numbers[midPoint] = pivot;
            numbers[high] = temp;
            return midPoint;
        }
        int partition_desc(int[] numbers, int low, int high)
        {
            int pivot = numbers[low], temp;
            int midPoint = high + 1, j;
            for (j = high; j > low; j--)
            {
                if (numbers[j] < pivot)
                {
                    temp = numbers[j];
                    numbers[j] = numbers[--midPoint];
                    numbers[midPoint] = temp;
                }
            }
            temp = numbers[--midPoint];
            numbers[midPoint] = pivot;
            numbers[low] = temp;
            return midPoint;
        }
        int partition_str(string[] items, int low, int high, bool isDesc = false)
        {
            string pivot = items[high], temp;
            int midPoint = low-1, j;
            for (j = low; j < high; j++)
            {
                if (isDesc)
                {
                    if (helper.StrComp(pivot, items[j]) > 0)
                    {
                        temp = items[j];
                        items[j] = items[++midPoint];
                        items[midPoint] = temp;
                    }
                }
                else
                {
                    if (helper.StrComp(items[j], pivot) > 0)
                    {
                        temp = items[j];
                        items[j] = items[++midPoint];
                        items[midPoint] = temp;
                    }

                }
            }
            temp = items[++midPoint];
            items[midPoint] = pivot;
            items[high] = temp;
            return midPoint;
        }
        public void Execute()
        {
            int[] numbers = helper.GetRandomNumbers();
            helper.PrintArray<int>(numbers);
            Ascending(numbers, 0, 9);
            helper.PrintArray<int>(numbers);
            Descending(numbers, 0, 9);
            helper.PrintArray<int>(numbers);

            string[] items = helper.GetRandomStr(10,3);
            helper.PrintArray<string>(items);
            Ascending(items, 0, 9);
            helper.PrintArray<string>(items);
            Descending(items, 0, 9);
            helper.PrintArray<string>(items);
        }
    }
}
