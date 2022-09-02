// Создаем массив заполненный случайными вещественными числами. Ищем разницу между максимальным и минимальным элементом массива

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
            double minValue = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите максимальное число в массиве: ");
            double maxValue = Double.Parse(Console.ReadLine());
            
            double[] array = ArrayConstructor(size, minValue, maxValue);
            
            PrintArray(array);

            double variation = Variation(array);

            Console.WriteLine($"Разница между максимальным и минимальным элементом = {variation}");

            
        }

        static double[] ArrayConstructor(int size, double minValue, double maxValue) 
        // создание массива размером size заполненного случайными числами [minValue, maxValue]
        {
            
            double[] array = new double[size]; 
            Random number = new Random();

            for (int i = 0; i < size; i++) array[i] = number.NextDouble() * (maxValue - minValue) + minValue;

            return array;
        }

        static double Variation(double[] array)
        // считаем разницу между максимальным и минимальным значением в массиве
        {
            
            double min = array[0];
            double max = array[0];

            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
            }
            
            return max - min;
        }

        static void PrintArray(double[] array)
        {
            Console.WriteLine("Содержимое массива: ");
            Console.WriteLine(String.Join(" ", array));
        }
    }
}


