using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.Algorithm.Sort
{
    public class Merge:ITest
    {
        public Merge()
        {
            helper = new Helper();
        }
        private Helper helper;
        /// <summary>
        /// AllCase O(nlogn) | SpaceComplexity O(n)
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public void Ascending(int[] numbers,int left, int right)
        {
            if (left >= right) { return; }
            int mid = left + (right - left) / 2;
            Ascending(numbers, left, mid);
            Ascending(numbers, mid+1, right);

            merge_num(numbers, left, mid, right);
        }

        public void Ascending(string[] items, int left, int right)
        {
            if (left >= right) { return; }
            int mid = left + (right - left) / 2;
            Ascending(items, left, mid);
            Ascending(items, mid + 1, right);
            merge_str(items, left, mid, right);
        }

        public void Descending(int[] numbers, int left, int right)
        {
            if (left >= right) { return; }
            int mid = left + (right - left) / 2;
            Descending(numbers, left, mid);
            Descending(numbers, mid + 1, right);
            merge_num(numbers, left, mid, right,true);
        }

        public void Descending(string[] items, int left, int right)
        {
            if (left >= right) { return; }
            int mid = left + (right - left) / 2;
            Descending(items, left, mid);
            Descending(items, mid + 1, right);
            merge_str(items, left, mid, right, true);
        }

        void merge_num(int[] numbers, int left, int mid, int right, bool isDesc=false)
        {
            int leftLen = mid-left+1,rightLen = right-mid;
            int leftIndex = 0, rightIndex = 0, i = 0;
            int[] leftArr = new int[leftLen];
            int[] rightArr = new int[rightLen];

            for (i = 0; i < leftLen; i++)
            {
                leftArr[i] = numbers[left+i];
            }
            for (i = 0; i <rightLen;i++)
            {
                rightArr[i] = numbers[mid+i+1];
            }

            while (leftIndex < leftLen && rightIndex < rightLen)
            {
                if (leftArr[leftIndex] >= rightArr[rightIndex])
                {
                    numbers[left++] = isDesc? leftArr[leftIndex++]:rightArr[rightIndex++];
                }
                else
                {
                    numbers[left++] = isDesc? rightArr[rightIndex++]:leftArr[leftIndex++];
                }
            }
            while (leftIndex < leftLen)
            {
                numbers[left++] = leftArr[leftIndex++];
            }

            while (rightIndex < rightLen)
            {
                numbers[left++] = rightArr[rightIndex++];
            }
        }

        void merge_str(string[] items, int left, int mid, int right, bool isDesc=false)
        {
            int leftLen = mid - left + 1, rightLen = right-mid;
            int leftIndex=0, rightIndex = 0,i=0;
            string[] leftArr = new string[leftLen];
            string[] rightArr = new string[rightLen];
            for(i=0; i<leftLen; i++)
            {
                leftArr[i] = items[left + i];
            }
            for (i = 0; i < rightLen; i++)
            {
                rightArr[i] = items[mid + i+1];
            }
            while(leftIndex<leftLen && rightIndex < rightLen)
            {
                if(helper.StrComp(leftArr[leftIndex], rightArr[rightIndex]) >= 0)
                {
                    items[left++] = isDesc ? rightArr[rightIndex++]: leftArr[leftIndex++];
                }
                else
                {
                    items[left++] = isDesc ? leftArr[leftIndex++]: rightArr[rightIndex++];
                }
            }
            while (leftIndex < leftLen)
            {
                items[left++] = leftArr[leftIndex++];
            }
            while (rightIndex < rightLen)
            {
                items[left++] = rightArr[rightIndex++];
            }
        }

        public void Execute()
        {
            Helper helper = new Helper();
            Merge sort = new Merge();
            int[] numbers = helper.GetRandomNumbers();
            helper.PrintArray<int>(numbers);
            sort.Ascending(numbers, 0, 9);
            helper.PrintArray<int>(numbers);
            sort.Descending(numbers, 0, 9);
            helper.PrintArray<int>(numbers);

            string[] str = helper.GetRandomStr(5, 2);
            helper.PrintArray<string>(str);
            sort.Ascending(str, 0, 4);
            helper.PrintArray<string>(str);
            sort.Descending(str, 0, 4);
            helper.PrintArray<string>(str);
        }
    }
}
