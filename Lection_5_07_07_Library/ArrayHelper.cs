using System;

namespace Lection_5_07_07_Library
{
    public class ArrayHelper
    {
        /// <summary>
        /// Find max element index in non-empy array
        /// </summary>
        /// <param name="array">Non-empty array</param>
        /// <returns>Index of element with max value</returns>
        /// <exception cref="ArgumentException">Array is null or empty</exception>
        public static int MaxIndex(int[] array)
        {
            CheckArrayNullOrEmpty(array);

            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[maxIndex] < array[i])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        public static int Max(int[] array)
        {
            return array[MaxIndex(array)];
        }

        public static void Reverse(int[] array)
        {
            CheckNonNullArray(array);

            int halfSize = array.Length / 2;
            for (int i = 0; i < halfSize; i++)
            {
                Swap(ref array[i], ref array[array.Length - 1 - i]);
            }
        }

        public static void HalfReverse(int[] array)
        {
            int halfSize = array.Length / 2;
            int rightStartPosition = halfSize + array.Length % 2;
            for (int i = 0; i < halfSize; i++)
            {
                Swap(ref array[i], ref array[rightStartPosition + i]);
            }
        }

        public static int[] GenerateArray(int size)
        {
            int[] array = new int[size];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }

            return array;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static void CheckNonNullArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException();
            }
        }

        private static void CheckArrayNullOrEmpty(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException();
            }
        }
    }
}
