using System;

namespace Task2._2_area
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите, пожалуйста, ширину вашей комнаты в метрах");
                double width = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите, пожалуйста, длину вашей комнаты в метрах");
                double length = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите, пожалуйста, высоту вашей комнаты в метрах");
                double height = double.Parse(Console.ReadLine());

                double area_door = AreaDoor();

                double area_window = AreaWindow();

                CalculateArea(width, height, length, area_door, area_window);
            }
            catch { Console.WriteLine("Вы ввели неверный формат данных!"); }
        }

        static void CalculateArea (double width, double height, double length, double area_door, double area_window)
        {
          double area = (width * height * 2) + (length * height * 2) - 
                        (area_door + area_window);
          Console.WriteLine("");
          Console.WriteLine($"Площадь стен в помещении {area} кв. м.");
        }

        static double AreaDoor()
        {
            int i;
            double area = 0;
            Console.WriteLine("Сколько дверей в вашей комнате?");
            int count_door = int.Parse(Console.ReadLine());
            
            for (i = 1; i <= count_door; i++)
            {
                Console.WriteLine($"Высота {i} -ой двери в м?");
                double height_door = double.Parse(Console.ReadLine());

                Console.WriteLine($"Ширина {i} -ой двери в м?");
                double width_door = double.Parse(Console.ReadLine());

                area = area + width_door * height_door;
            }
            return area;
        }

        static double AreaWindow()
        {
            int i;
            double area = 0;
            Console.WriteLine("Сколько окон в вашей комнате?");
            int count_window = int.Parse(Console.ReadLine());
            for (i = 1; i <= count_window; i++)
            {
                Console.WriteLine($"Высота {i} -ого окна в м?");
                double height_window = double.Parse(Console.ReadLine());

                Console.WriteLine($"Ширина {i} -ого окна в м?");
                double width_window = double.Parse(Console.ReadLine());

                area = area + width_window * height_window;
            }
            return area;
        }
    }
}
