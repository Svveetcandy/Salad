using System;

namespace Salad
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "1. Добавить ингридиент.\n" +
                "2. Подсчитать калорийность салата.\n" +
                "3. Сортировка ингридиентов по калориям.\n" +
                "4. Поиск ингридиентов из даипазона калорийности.\n" +
                "0. Выход.\n\n" +
                "Выберите действие: ";
            Salad salad = new Salad();
            int choice;
            bool escape = false;
            while (!escape)
            {
                Console.Clear();
                Console.Write(menu);
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        salad.AddIngridient();
                        break;
                    case 2:
                        salad.CountCalInSalad();
                        break;
                    case 3:
                        salad.SortIngridients();
                        break;
                    case 4:
                        salad.SearchOfIngridientsByCalories();
                        break;
                    case 0:
                        escape = true;
                        break;
                    default:
                        Console.WriteLine("Данного действия нет в меню.");
                        break;
                }
                Console.WriteLine("Нажмите любую клавишу...");
                Console.ReadKey();
            }
        }
    }
}
