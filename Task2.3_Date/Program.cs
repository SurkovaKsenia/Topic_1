using System;

namespace Task2._3_Date
{
    class Program
    {
        static void Main(string[] args)
        {
            int count_min;
            Console.WriteLine("Введите количество минут");
            string input_min = Console.ReadLine();
            if (int.TryParse(input_min, out count_min))
            {
                if (count_min <= 0)
                {
                    Console.WriteLine("Событие уже началось!");
                }
                else
                {
                    GetDayHourMin(count_min);
                }
            }
            else
            {
                Console.WriteLine("Вы ввели неверный формат!");
            }
        }

        static void GetDayHourMin(int count_min)
        {
            double hour, min, day;
            double h, d;

            d =  count_min / 1440;//24 часа = 1440 мин
            day = Math.Truncate(d);

            h = (count_min - 1440 * day) / 60;
            hour = Math.Truncate(h);

            min = ((count_min - 1440*day) - 60 * hour);

            PrintResult(day, hour, min);
            Console.WriteLine("");
            DifferenceOfMinutes();
        }

        static void PrintResult(double day, double hour, double min)
        {
                if (day % 10 > 1 && day % 10 < 5)
                {
                    Console.Write($"Осталось {day} дня");
                }
                else if (day % 10 == 1)
                {
                    Console.Write($"Осталось {day} день");
                }
                else
                {
                    Console.Write($"Осталось {day} дней");
                }
        
                if (hour % 10 > 1 && hour % 10 < 5)
                {
                    Console.Write($", {hour} часа");
                }
                else if (hour % 10 == 1)
                {
                    Console.Write($", {hour} час");
                }
                else
                {
                    Console.Write($", {hour} часов");
                }
        
                if ( min % 10 > 1 && min %10 < 5)
                {
                    Console.Write($", {min} минуты");
                }
                else if (min % 10 == 1)
                {
                    Console.Write($", {min} минута");
                }
                else
                {
                    Console.Write($", {min} минут");
                }
        }

        static void DifferenceOfMinutes()
        {
            DateTime date1 = new DateTime();
            DateTime date2 = new DateTime();
            Console.WriteLine("");
            Console.WriteLine("Введите дату в формате dd.mm.yyyy");
            date2 = DateTime.Parse(Console.ReadLine());
            date1 = DateTime.Now;
            System.TimeSpan diff = (date1 - date2);
            double days = diff.TotalDays;
            double hours = diff.TotalHours;
            double mins = diff.TotalMinutes;
            double min = Math.Round(days * 1440 + hours * 60 + mins);
            Console.WriteLine($"Разница между сегодняшней датой и введённой составляет {min} минут");
        }
    }
}
