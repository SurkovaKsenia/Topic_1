using System;

namespace Task2_DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите, пожалуйста, что-нибудь");
            dynamic data = Console.ReadLine();
            double d;
            int i;
            bool b;
            if (int.TryParse(data, out i))
            {
                Console.WriteLine("Это целое число!");
            }
            else if (double.TryParse(data, out d))
            {
                Console.WriteLine("Это рациональное число!");
            }
            else if (bool.TryParse(data, out b))
            {
                Console.WriteLine("Это логический тип данных!");
            }
            else
            {
                Console.WriteLine("Это текст!");
            }
        }
    }
}
