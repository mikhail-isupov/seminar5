// Создаем массив заполненный трехзначными случайными числами. Ищем число четных чисел в массиве.

using System;

namespace Seminar5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = ArrayConstructor(size, 100, 999);
            
            int count = CountEvenNumbers(array);

            Console.WriteLine($"В созданном массиве {count} четных чисел");
        }

        static int[] ArrayConstructor(int size, int minValue, int maxValue) 
        // создание массива размером size заполненного случайными числами [minValue, maxValue]
        {
            
            int[] array = new int[size]; 
            Random number = new Random();

            for (int i = 0; i < size; i++) array[i] = number.Next(minValue, maxValue + 1);

            return array;
        }

        static int CountEvenNumbers(int[] array)
        // считаем количество четных чисел в массиве
        {
            int countEvenNumbers = 0;

            for (int i = 0; i < array.Length; i++) if (array[i] % 2 == 0) countEvenNumbers += 1;

            return countEvenNumbers;
        }
    }
}
