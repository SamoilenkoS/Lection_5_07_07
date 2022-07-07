using System;

namespace Lection_5_07_07_Console
{
    class Program
    {
        static void Main()
        {
        }

        static void Test()
        {
            //int a = 10;
            //int b = 0;
            //Console.WriteLine(a / b);
            //ArrayHelper.MaxIndex(new int[] { 1, 2, 3 });
            //int a = int.MaxValue;
            //checked
            //{
            //    int b = a + 1;
            //    Console.WriteLine(a);
            //    Console.WriteLine(b);
            //}

            //int[] array = null;
            //try
            //{
            //    ArrayHelper.Reverse(array);
            //}
            //catch(NullReferenceException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //try
            //{
            //    int item = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(item);
            //}
            //catch (FormatException)//raise when incorrect input
            //{
            //    Console.WriteLine("Your message here");
            //}
            //catch(OverflowException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            ////catch(Exception ex)
            //{

            //}
            //catch(Inva)

            //int[] array = ArrayHelper.GenerateArray(6);

            //PrintArray(array);

            //ArrayHelper.HalfReverse(array);

            //PrintArray(array);
            //Console.WriteLine(ArrayHelper.MaxIndex(array));
            //Console.WriteLine(ArrayHelper.Max(array));
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

        private static int[,] GenerateMatrix(int x, int y)
        {
            Random random = new Random();
            int[,] matrix = new int[x, y];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, x * y);
                }
            }

            return matrix;
        }

        private static void PowerMatrix(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] *= matrix[i, j];
                }
            }
        }

        private static int SumByOddIndexes(int[,] matrix)
        {
            if(matrix == null)
            {
                throw new ArgumentException();
            }

            int sum = 0;
            for (int i = 1; i < matrix.GetLength(0); i += 2)
            {
                for (int j = 1; j < matrix.GetLength(1); j += 2)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }

        private static void Reverse(int[,] matrix)
        {
            if(matrix == null)
            {
                throw new ArgumentException();
            }

            for (int i = 0, count = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) && count < matrix.Length / 2; j++, count++)
                {
                    Swap(ref matrix[i, j], ref matrix[matrix.GetLength(0) - 1 - i, matrix.GetLength(1) - 1 - j]);
                }
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private static int Sum(int[,] matrix)
        {
            if(matrix == null)
            {
                throw new ArgumentException();
            }

            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
