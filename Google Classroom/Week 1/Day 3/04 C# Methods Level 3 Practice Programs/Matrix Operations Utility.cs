using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._04_C__Methods_Level_3_Practice_Programs
{
    internal class Matrix_Operations_Utility
    {
        public static double[,] CreateRandomMatrix(int rows, int cols)
        {
            Random random = new Random();
            double[,] matrix = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }
            return matrix;
        }
        public static double[,] AddMatrices(double[,] a, double[,] b)
        {
            int rows = a.GetLength(0);
            int cols = a.GetLength(1);
            double[,] result = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }
            return result;
        }
        public static double[,] SubtractMatrices(double[,] a, double[,] b)
        {
            int rows = a.GetLength(0);
            int cols = a.GetLength(1);
            double[,] result = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = a[i, j] - b[i, j];
                }
            }
            return result;
        }
        public static double[,] MultiplyMatrices(double[,] a, double[,] b)
        {
            int r1 = a.GetLength(0);
            int c1 = a.GetLength(1);
            int c2 = b.GetLength(1);
            double[,] result = new double[r1, c2];
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    for (int k = 0; k < c1; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return result;
        }
        public static double[,] TransposeMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            double[,] result = new double[cols, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }
            return result;
        }
        public static double Determinant2x2(double[,] m)
        {
            return m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0];
        }
        public static double Determinant3x3(double[,] m)
        {
            double a = m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]);
            double b = m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0]);
            double c = m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);
            return a - b + c;
        }
        public static double[,] Inverse2x2(double[,] m)
        {
            double det = Determinant2x2(m);
            if (det == 0) return new double[0, 0];
            double[,] inv = new double[2, 2];
            inv[0, 0] = m[1, 1] / det;
            inv[0, 1] = -m[0, 1] / det;
            inv[1, 0] = -m[1, 0] / det;
            inv[1, 1] = m[0, 0] / det;
            return inv;
        }
        public static double[,] Inverse3x3(double[,] m)
        {
            double det = Determinant3x3(m);
            if (det == 0) return new double[0, 0];
            double[,] inv = new double[3, 3];
            inv[0, 0] = (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) / det;
            inv[0, 1] = (m[0, 2] * m[2, 1] - m[0, 1] * m[2, 2]) / det;
            inv[0, 2] = (m[0, 1] * m[1, 2] - m[0, 2] * m[1, 1]) / det;
            inv[1, 0] = (m[1, 2] * m[2, 0] - m[1, 0] * m[2, 2]) / det;
            inv[1, 1] = (m[0, 0] * m[2, 2] - m[0, 2] * m[2, 0]) / det;
            inv[1, 2] = (m[0, 2] * m[1, 0] - m[0, 0] * m[1, 2]) / det;
            inv[2, 0] = (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]) / det;
            inv[2, 1] = (m[0, 1] * m[2, 0] - m[0, 0] * m[2, 1]) / det;
            inv[2, 2] = (m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0]) / det;
            return inv;
        }
        public static void DisplayMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            if (rows == 0 || cols == 0)
            {
                Console.WriteLine("Non-invertible.");
                return;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{Math.Round(matrix[i, j], 2),7} ");
                }
                Console.WriteLine();
            }
        }
        public void Demo()
        {
            double[,] a2 = CreateRandomMatrix(2, 2);
            double[,] b2 = CreateRandomMatrix(2, 2);
            Console.WriteLine("A (2x2):");
            DisplayMatrix(a2);
            Console.WriteLine("B (2x2):");
            DisplayMatrix(b2);
            Console.WriteLine("A + B:");
            DisplayMatrix(AddMatrices(a2, b2));
            Console.WriteLine("A - B:");
            DisplayMatrix(SubtractMatrices(a2, b2));
            Console.WriteLine("A * B:");
            DisplayMatrix(MultiplyMatrices(a2, b2));
            Console.WriteLine("Transpose A:");
            DisplayMatrix(TransposeMatrix(a2));
            Console.WriteLine($"Det A: {Determinant2x2(a2)}");
            Console.WriteLine("Inverse A:");
            DisplayMatrix(Inverse2x2(a2));
            double[,] m3 = CreateRandomMatrix(3, 3);
            Console.WriteLine("M (3x3):");
            DisplayMatrix(m3);
            Console.WriteLine($"Det M: {Determinant3x3(m3)}");
            Console.WriteLine("Inverse M:");
            DisplayMatrix(Inverse3x3(m3));
        }
    }
}
