using Projeto_CalculadoraOrientada_a_Objetos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_CalculadoraOrientada_a_Objetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmbOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal a, b;
            a = decimal.Parse(txtN1.Text);
            b = decimal.Parse(txtN2.Text);
            switch (cmbOperacao.Text)
            {
                case "Somar":
                    {
                        //INSTANCIANDO A CLASSE
                        CalculadoraBásica objCalc = new CalculadoraBásica();
                        objCalc.Num1 = a;
                        objCalc.Num2 = b;
                        objCalc.Soma();
                        lblResultado.Text = objCalc.Resultado.ToString();
                        break;
                    }
                case "Subtrair":
                    {
                        //INSTANCIANDO A CLASSE
                        CalculadoraBásica objCalc = new CalculadoraBásica();
                        objCalc.Num1 = a;
                        objCalc.Num2 = b;
                        lblResultado.Text = objCalc.Subtrair();
                        break;
                    }
                case "Multiplicar":
                    {
                        CalculadoraBásica objCalc = new CalculadoraBásica();
                        lblResultado.Text = objCalc.Multiplicar().ToString();
                      //lblResultado.Text = objCalc.Multiplicar(a, b);

                        break;
                    }
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

