// ищем произведение пар элементов массива
using System;

namespace Seminar5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4, 5};
            
            int[] arrayPairwise = ArrayPairwiseMultiplication(array);

            Console.WriteLine(String.Join(",", arrayPairwise));
        }

        static int[] ArrayPairwiseMultiplication(int[] array)
        {
            int newArraySize = array.Length / 2 + array.Length % 2;

            int[] newArray = new int[newArraySize];

            for (int i = 0; i < newArraySize; i++) newArray[i] = array[i] * array[array.Length - i - 1];

            return newArray;
        }
    }
}
