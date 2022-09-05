using System;

namespace HomeTasks_KisEA
{
    class Program       // Программа создаёт и печатает массив чисел
    {
        static void Main (string[] args)
        {
         
            int[] createNewArray(int size)
            {
                int[] array = new int[size];

                for (int i = 0; i < size; i++)
                {
                    array[i] = new Random().Next(0, 100);
                }
                return array;
            }

            void printArray(int[] array)
            {
                for(int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
            }

            int[] sortMaxMinArray(int[] array)
            {
                int maxElement, maxInd, box, i, j;
                for(i = 0; i < array.Length - 2; i++)
                {
                    maxElement = array[i];
                    maxInd = i;
                    for(j = i + 1; j < array.Length; j++)
                    {
                        if(array[j] > maxElement)
                        {
                            maxElement = array[j];
                            maxInd = j;
                        }
                    }
                    box = array[i];
                    array[i] = array[maxInd];
                    array[maxInd] = box;                    
                }
                return array;
            }

            double findMedian (int[] array)
            {
                sortMaxMinArray(array);
                double median;
                if(array.Length % 2 == 0)
                median = ((double)array[array.Length/2] + (double)array[array.Length/2 - 1])/2;
                else median = (double) array[array.Length/2];
                return median;
            }

                Console.Write("Введите размерность массива: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int[] numbers = createNewArray(a);
                Console.Write("Результат создания массива: ");
                printArray(numbers);
                sortMaxMinArray(numbers);
                Console.Write("Результат сортировки массива: ");
                printArray(numbers);
                Console.WriteLine($"Значение медианы: {findMedian(numbers)}");
        }
    }
}