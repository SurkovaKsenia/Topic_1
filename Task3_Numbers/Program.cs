using System;

namespace Task3_Numbers
{
    class Program
    {
        static void Main()
        {
            int count = 0;
            double sum = 0, num;
            double max = -1000,  min = 1000;
            while (true) 
            {
                Console.WriteLine("Введите рациональное число");
                string input = Console.ReadLine();
                    if (double.TryParse(input, out num))
                    {
                        count += 1;
                        sum = sum + num;
                        if (num <= min) { min = num; }
                        if (num >= max) { max = num; }
                    }
                    else if (input == "")
                    {
                        Console.WriteLine("Ввод данных завершён");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели неверный тип данных. Попробуйте снова!");
                    }
            }
            Output(count, sum, min, max);
        }

        static void Output (int count, double sum, double min, double max)
        {
            Console.WriteLine("");
            Console.WriteLine($"Количество введённых элементов равно {count}");
            Console.WriteLine($"Сумма этих элементов равна {sum}");
            Console.WriteLine($"Среднее значение элементов равно {sum / count}");
            Console.WriteLine($"Максимум последовательности равен {max}");
            Console.WriteLine($"Минимум последовательности равен {min}");
        }
    }
}
