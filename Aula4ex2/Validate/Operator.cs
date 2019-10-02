using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4ex2
{
    class Operator : Attributes
    {
        private readonly string[] operators = { "+", "-", "*", "/"};
        private List<string> values = new List<string>();

        //Validar se é um operador ou nao
        public bool validate(string entry)
        {
            foreach (string operation in operators)
                if (entry.Equals(operation))
                {
                    values.Add(entry);
                    return true;
                }

            return false;
        }

        //Retorna a coleção de operadores digitados
        public List<string> getValues()
        {
            return values;
        }

        public void clear()
        {
            values.Clear();
        }

    }
}
