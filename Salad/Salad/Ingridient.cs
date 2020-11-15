using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
    class Ingridient
    {
        public string Name { get; set; }
        public int CalIn100gr { get; set; }
        public int Weight { get; set; }
        public double CalInIngridient { get; set; }
        public void PrintShapka()
        {
            Console.WriteLine("{0,15}\t{1,15}\t{2,15}\t{3,15}\n", "Название", "Кал в 100гр", "Масса", "Калории");
        }
        public void PrintIngridient()
        {
            Console.WriteLine("{0,15}\t{1,15}\t{2,15}\t{3,15}", Name, CalIn100gr, Weight, CalInIngridient);
        }
    }
}
