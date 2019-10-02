using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4ex2
{
    class Numbers : Attributes
    {
        private readonly string[] numbers = { "0", "1", "2" , "3" , "4" , "5", "6", "7", "8", "9"};
        private List<string> values = new List<string>();
        private string value = null;

        //Validar se é um número ou nao
        public bool validate(string entry)
        {
            
            foreach(string number in numbers)
                if (entry.Equals(number) || entry.Equals("."))
                {
                    value += entry;
                    return true;   
                }

            values.Add(value);
            value = null;

            return false;
        }

        //Retorna a coleção de números digitados
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
