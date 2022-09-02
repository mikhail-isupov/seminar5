// Создаем массив заполненный случайными числами. Ищем сумму элементов на нечетных позициях

using System;

namespace Seminar5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите минимальное число в массиве: ");
            int minValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите максимальное число в массиве: ");
            int maxValue = int.Parse(Console.ReadLine());
            
            int[] array = ArrayConstructor(size, minValue, maxValue);
            
            int sum = SumOddElements(array);

            Console.WriteLine($"В созданном массиве сумма всех элементов на нечетных позициях = {sum}");
        }

        static int[] ArrayConstructor(int size, int minValue, int maxValue) 
        // создание массива размером size заполненного случайными числами [minValue, maxValue]
        {
            
            int[] array = new int[size]; 
            Random number = new Random();

            for (int i = 0; i < size; i++) array[i] = number.Next(minValue, maxValue + 1);

            return array;
        }

        static int SumOddElements(int[] array)
        // считаем сумму всех элементов массива на нечетных позициях
        {
            int sumOddElements = 0;

            for (int i = 0; i < array.Length; i += 2) sumOddElements += array[i];
            // элемент с индексом 0 стоит на первой позиции
            
            return sumOddElements;
        }
    }
}

