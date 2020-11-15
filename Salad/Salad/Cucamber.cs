using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
    class Cucamber : Ingridient
    {
        public Cucamber(int weight)
        {
            Name = "Огурец";
            CalIn100gr = 16;
            Weight = weight;
            CalInIngridient = Math.Round((weight / 100.0) * CalIn100gr, 2);
        }
    }
}
