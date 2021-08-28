using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace PracticeDS_Algo.Algorithm.BookPractice
{
    public class Permutation
    {
        private int[] used, numbers;
        private int i, length;

        public Permutation()
        {
            Console.Write("How many numbers: ");
            length = int.Parse(Console.ReadLine());
            used = new int[length+1];
            numbers = new int[length+1];

        }


        public void GenPermutation(int at) {
            if (at == length + 1)
            {
                for(i=1; i<=length; i++)
                {
                    Write(numbers[i]);
                }
                WriteLine();
                return;
            }

            for (int i = 1; i <= length; i++) {

                if (used[i] == 0)
                {
                    used[i] = 1;
                    numbers[at] = i;
                    GenPermutation(at + 1);
                    used[i] = 0;
                }
                    
            }
        }
    }
}
