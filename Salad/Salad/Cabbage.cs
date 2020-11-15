using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
    class Cabbage:Ingridient
    {
        public Cabbage(int weight)
        {
            Name = "Капуста";
            CalIn100gr = 25;
            Weight = weight;
            CalInIngridient = Math.Round((weight / 100.0) * CalIn100gr, 2);
        }
    }
}
