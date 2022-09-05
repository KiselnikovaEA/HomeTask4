using System;

namespace HomeTasks_KisEA
{
    class Program       // Программа принимает два аргумента и возводит число А в число B
    {
        static void Main (string[] args)
        {
         
            int getNaturalPower(int num, int power)
            {
                if (power == 0)
                {
                    Console.WriteLine("Нулевой степени числа не существует");
                    return -1;
                }
                else
                {
                    if (num == 0) return 0;
                    else if (num == 1) return 1;
                    else
                    {
                        int res = num;
                        for (int i = 1; i < power; i++)
                        {
                            res = res * num;
                        }
                        return res;
                    }
                }
            }
            try
            {
                Console.Write("Введите число, которое будем вводить в степень: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите степень: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(getNaturalPower(a,b));
            }
            catch
            {
                Console.WriteLine("Можно вводить только целые числа");
            }
            

        }
    }
}