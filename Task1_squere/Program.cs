using System;

namespace Task1_squere
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите число ");
                double num = double.Parse(Console.ReadLine());
                if (num < -1000000)
                {
                    Console.WriteLine("Введите число побольше!");
                    num = 0;
                }
                else if (num > 1000000)
                {
                    Console.WriteLine("Введите число поменьше!");
                    num = 0;
                }
                else
                {
                    Console.WriteLine($"Квадрат введённого вами числа равен:  {num * num}");
                }
            }
            catch
            {
                Console.WriteLine("Вы ввели неверный формат данных!");
            }
        }
    }
}
