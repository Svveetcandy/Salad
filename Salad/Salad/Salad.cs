using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
    class Salad
    {
        string listOfIngridients= "Какой ингридиент хотите добавить в салат?\n" +
            "1. Огурец.\n" +
            "2. Капуста.\n" +
            "3. Помидор.\n" +
            "4. Картофель.\n" +
            "Ваш выбор: ";
        public List<Ingridient> salad { get; set; } = new List<Ingridient>();
        public double CalInSalad { get; set; }
        public void AddIngridient()
        {
            int choice, weight;
            Console.Write(listOfIngridients);
            int.TryParse(Console.ReadLine(), out choice);
            Console.Write("Введите массу ингридиента: ");
            int.TryParse(Console.ReadLine(), out weight);
            switch (choice)
            {
                case 1:
                    {

                        Ingridient cucamber = new Cucamber(weight);
                        cucamber.Name = cucamber.Name + " " + salad.Count;
                        salad.Add(cucamber);
                        break;
                    }
                case 2:
                    {
                        Ingridient cabbage = new Cabbage(weight);
                        cabbage.Name = cabbage.Name + " " + salad.Count;
                        salad.Add(cabbage);
                        break;
                    }
                case 3:
                    {
                        Ingridient tomato = new Tomato(weight);
                        tomato.Name = tomato.Name + " " + salad.Count;
                        salad.Add(tomato);
                        break;
                    }
                case 4:
                    {
                        Ingridient potato = new Potato(weight);
                        potato.Name = potato.Name + " " + salad.Count;
                        salad.Add(potato);
                        break;
                    }
                default:
                    {
                        Console.Write("Такого ингридиента нет.");
                        break;
                    }
            }

        }
        public void CountCalInSalad()
        {
            double count=0;
            foreach(Ingridient ingridient in salad)
            {
                count = count + ingridient.CalInIngridient;
            }
            CalInSalad = Math.Round(count, 2);
            Console.WriteLine("Калорий в салате: "+CalInSalad);
        }
        public void SortIngridients()
        {
            string sortList = "Сортировать по:\n" +
                "1. Массе.\n" +
                "2. Калориям в 100 гр.\n" +
                "3. Калориям в ингридиенте.\n" +
                "4. Названию.\n" +
                "Ваш выбор:";
            int choice;
            Console.Write(sortList);
            int.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case 1:
                    salad.Sort((item1, item2) => item1.Weight - item2.Weight);
                    break;
                case 2:
                    salad.Sort((item1, item2) => item1.CalIn100gr - item2.CalIn100gr);
                    break;
                case 3:
                    int value;
                    salad.Sort((item1, item2) => value=(int)(item1.CalInIngridient - item2.CalInIngridient));
                    break;
                case 4:
                    salad.Sort((item1, item2) => string.Compare(item1.Name, item2.Name));
                    break;
            }
            if (salad.Count != 0) salad[0].PrintShapka();
            foreach(Ingridient ingridient in salad)
            {
                ingridient.PrintIngridient();
            }
            
        }
        public void SearchOfIngridientsByCalories()
        {
            int caloriesStart, caloriesEnd;
            Console.Write("По калориям искать ингридиенты\nот: ");
            int.TryParse(Console.ReadLine(), out caloriesStart);
            Console.Write("до: ");
            int.TryParse(Console.ReadLine(), out caloriesEnd);
            if (caloriesEnd < caloriesStart)
            {
                Console.WriteLine("Диапазон калорий введен не корректно.\nНажмите любую клавишу для выхода...");
                Console.ReadKey();
                return;
            }
            if (salad.Count != 0) salad[0].PrintShapka();
            foreach (Ingridient ingridient in salad)
            {
                if (ingridient.CalInIngridient <= caloriesEnd && ingridient.CalInIngridient >= caloriesStart)
                {
                    ingridient.PrintIngridient();
                }
            }
        }

    }
}
