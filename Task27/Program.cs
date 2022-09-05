using System;

namespace HomeTasks_KisEA
{
    class Program       // Программа считает сумму цифр в числе
    {
        static void Main (string[] args)
        {
         
            int getSumOfDigits(int num)
            {
                string str = num.ToString();
                int[] array = new int[str.Length];
                int sum = 0;
                for (int i = 0; i < str.Length; i++){
                                                    array[i] = int.Parse(str[i].ToString());
                                                    sum = sum + array[i];
                                                    }
                return sum;
            }

            try
            {
                Console.Write("Введите целое число: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Сумма цифр в числе = {getSumOfDigits(a)}");
            }
            catch
            {
                Console.WriteLine("Можно вводить только неотрицательные целые числа");
            }
        }
    }
}