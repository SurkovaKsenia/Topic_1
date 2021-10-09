using System;


namespace Task2._1_NDS
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            { 
            decimal rate = 0.2m;
            decimal cost;
            Console.WriteLine("Введите стоимость товара");
            string input_cost = Console.ReadLine();
            cost = decimal.Parse(input_cost) - decimal.Parse(input_cost) * rate;
            Console.WriteLine("");
            Console.WriteLine($"Стоимость товара без НДС составляет {Math.Round(cost,2)} руб.");
            CalculationsRate(rate, input_cost);
            }
            catch
            {
                Console.WriteLine("Вы ввели неверный формат данных!");
            }
        }

        static void CalculationsRate(decimal rate, string input_cost)
        {
            decimal rate_receipt = decimal.Parse(input_cost) * rate;
            Console.WriteLine($"Сумма НДС в чеке {Math.Round(rate_receipt,2)} руб.");
            if (Math.Round(rate_receipt - Math.Truncate(rate_receipt),1) >= 0.5m)
            {
                Console.WriteLine($"Сумма НДС для налоговой декларации {Math.Ceiling(rate_receipt)} руб.");
            }
            else
            {
                Console.WriteLine($"Сумма НДС для налоговой декларации {Math.Floor(rate_receipt)} руб.");
            }
        }
    }
}
