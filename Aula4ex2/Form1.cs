using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula4ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Coleção de atributos necessários para realizar um cálculo.
        Attributes[] attributes = {
            new Numbers(),
            new Operator()
        };

        //Objeto utilizado para realizar o cálculo desejado
        Calculation calculate = new Calculation();
        //Variável para verificar se o resultado já foi mostrado alguma vez para o usuário
        public bool resultActive = false;


        //Evento criado para pegar o clique de todos os botões e separar seus atributos
        public void separateAttributes(object sender, EventArgs e)
        {
            //Para verificar se todos os attributos foram validados
            bool validate = false;
            //Pegar a entrada do usuário
            string entry = ((Button)sender).Text;

            //Percorre todos os atributos, validando-os
            foreach (Attributes attribute in attributes)
                validate |= attribute.validate(entry);

            //Caso não seja validado, quer dizer que o usuário deseja saber o resultado da operação
            if (!validate)
            {
                //Passa os numeros e os operadores para a expressão numérica ser montada e calculada.
                calculate.numericalExpression(attributes[0].getValues(), attributes[1].getValues());
   
                //Limpa todos os attributos para uma nova entrada
                foreach(Attributes attribute in attributes)
                    attribute.clear();
                //Mostra o resultado para o usuário
                textBox1.Text = calculate.getResult();
                //Diz que o resultado ja foi mostrado
                resultActive = true;
            }
            else
                //Se o resultado não foi mostrado, concatena as entradas do usuário
                if(!resultActive)
                    textBox1.Text += entry;
                else {
                    //Caso o resultado tenha sido mostrado, reinicia uma nova expressão
                    textBox1.Text = entry;
                    resultActive = false;
                }

        }

    }
}
