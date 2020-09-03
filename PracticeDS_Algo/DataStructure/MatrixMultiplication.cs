using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticeDS_Algo.DataStructure
{
    public class MatrixMultiplication:ITest
    {

        /*
         * The number of columns of the first matrix must equal 
         * to the number of rown of the 2nd matrix.
         * And the result will have the same number of rows as the 1st matrix,
         * and the name number of columns as the 2nd matrix.
         * 
         * Ex: (2x3).(3x4) = (2x3)
         */
        public int[][] TakeMatrix()
        {
            Console.Write("Enter the number of rows:\t");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns:\t");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[][] matrix = new int[rows][];
            Helper helper = new Helper();
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[cols];
                matrix[i] = helper.GetRandomNumbers(cols, 1, 10);
            }
            return matrix;
        }

        public void PrintMatrix(int[][] matrix)
        {
            foreach (int[] row in matrix)
            {
                foreach (int col in row)
                {
                    Console.Write($"\t{col}");
                }
                Console.WriteLine();
            }
        }

        public int[][] Multiply(int[][] matrix1, int[][] matrix2)
        {
            int matrix1RowLen = matrix1.Count();
            int matrix1ColLen = matrix1[0].Count();
            int matrix2RowLen = matrix2.Count();
            int matrix2ColLen = matrix2[0].Count();

            if (matrix1ColLen != matrix2RowLen)
            {
                throw new Exception("Column of matrix-1 and Row of matrix-2 doesn't match. Not possible to multiply.");
            }
            int[][] result = new int[matrix1RowLen][];
            for (int mr1 = 0; mr1 < matrix1RowLen; mr1++)
            {
                result[mr1] = new int[matrix2ColLen];
                for (int mc2 = 0; mc2 < matrix2ColLen; mc2++)
                {
                    int cell = 0;
                    for (int mc1 = 0, mr2 = 0; mc1 < matrix1ColLen; mc1++, mr2++)
                    {
                        cell += matrix1[mr1][mc1] * matrix2[mr2][mc2];
                    }
                    result[mr1][mc2] = cell;
                }
            }
            return result;
        }

        public void Execute()
        {
            
            Console.WriteLine("Matrix-1:");
            Console.WriteLine("-----------------------------");
            int[][] matrix1 = TakeMatrix();
            PrintMatrix(matrix1);
            Console.WriteLine();

            Console.WriteLine("Matrix-2:");
            Console.WriteLine("-----------------------------");
            int[][] matrix2 = TakeMatrix();
            PrintMatrix(matrix2);
            Console.WriteLine();

            int[][] result = Multiply(matrix1, matrix2);
            Console.WriteLine("Multiplication:");
            Console.WriteLine("-----------------------------");
            PrintMatrix(result);
        }
    }
}
