﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Show
{
    public class COperacion<Tipo>
    {
        public Tipo Suma(Tipo x, Tipo y) {
            dynamic a = x, b = y;
            return a + b;
        }

        public Tipo Resta(Tipo x, Tipo y)
        {
            dynamic a = x, b = y;
            return a - b;
        }
        public Tipo Multiplicacion(Tipo x, Tipo y)
        {
            dynamic a = x, b = y;
            return a * b;
        }
        public Tipo Divicion(Tipo x, Tipo y)
        {
            dynamic a = x, b = y;
            return a / b;
        }
    }
}
