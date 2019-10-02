using Aula4ex2.Operations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4ex2
{
    class Calculation
    {
        //Valor da expressão matemática
        private double value = 0;
        //Coleção de operações
        private Dictionary<string, Formulas> operations = new Dictionary<string, Formulas>();


        public Calculation() {
            //Asim que instaciar o objeto, criar todos as operações a serem utilizadas nessa calculadora
            operations.Add("+", new Addition());
            operations.Add("-", new Subtraction());
            operations.Add("*", new Multiplication());
            operations.Add("/", new Division());
        }

        public void numericalExpression(List<string> numbers, List<string> operators)
        {
            /*
                Faz o calculo da seguinte forma:
                numeros[1,2,3,4]
                operações[+,-,+]

                Para i = 0
                1+2 = 3
                numeros[i] = 3

                Para i = 1
                3-3 = 0
                numeros[i] = 0

                Para i = 2
                0+4 = 4
                numeros[i] = 4

                Resultado:
                value = 4;
                
             */
            for (int i = 0; i < operators.Count; i++)
            {
                value = operations[operators[i]].calculate(numbers[i], numbers[i + 1]);
                numbers[i + 1] = value.ToString();
            }
        }

        //Retornar resultado para o usuário
        public string getResult()
        {
            return Convert.ToString(value);
        }

    }
}
