﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
    class Potato: Ingridient
    {
        public Potato(int weight)
        {
            Name = "Картофель";
            CalIn100gr = 77;
            Weight = weight;
            CalInIngridient = Math.Round((weight / 100.0) * CalIn100gr, 2);
        }
    }
}
