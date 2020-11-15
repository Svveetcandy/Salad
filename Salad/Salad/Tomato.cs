using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
    class Tomato:Ingridient
    {
        public Tomato(int weight)
        {
            Name = "Помидор";
            CalIn100gr = 18;
            Weight = weight;
            CalInIngridient = Math.Round((weight / 100.0) * CalIn100gr,2);
        }
    }
}
