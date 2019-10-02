﻿using System;
using System.Globalization;


namespace Aula4ex2.Operations
{
    class Addition : Formulas
    {
        public double calculate(string number1, string number2)
        {
            //Faz a soma de dois numeros considerando o '.' caso houver
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberGroupSeparator = ".";

            return Convert.ToDouble(number1, provider) + Convert.ToDouble(number2, provider);
        }
    }
}
