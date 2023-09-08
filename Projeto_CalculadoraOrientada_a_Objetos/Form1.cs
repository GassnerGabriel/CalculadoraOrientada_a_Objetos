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
                        CalcCientifica objCalc = new CalcCientifica();
                        objCalc.Num1 = a;
                        objCalc.Num2 = b;
                        objCalc.Soma();
                        lblResultado.Text = objCalc.Resultado.ToString();
                        break;
                    }
                case "Subtrair":
                    {
                        //INSTANCIANDO A CLASSE
                        CalcCientifica objCalc = new CalcCientifica();
                        objCalc.Num1 = a;
                        objCalc.Num2 = b;
                        lblResultado.Text = objCalc.Subtrair();
                        break;
                    }
                case "Multiplicar":
                    {
                        CalcCientifica objCalc = new CalcCientifica();
                        objCalc.Num1 = a;
                        objCalc.Num2 = b;
                        lblResultado.Text = objCalc.Multiplicar().ToString();
                        //lblResultado.Text = objCalc.Multiplicar(a, b);
                        break;
                    }
                case "Potenciação":
                    {
                        CalcCientifica objCalc = new CalcCientifica();
                        objCalc.Num1 = a;
                        objCalc.Num2 = b;
                        lblResultado.Text = objCalc.Potenciacao();
                        //lblResultado.Text = objCalc.Potenciacao(a, b);
                        break;
                    }
                case "Comparar":
                    {
                        CalcCientifica objCalc = new CalcCientifica();
                        //objCalc.Num1 = a;
                        //objCalc.Num2 = b;
                        lblResultado.Text = objCalc.Comparar(a, b);
                        break;
                    }
                case "Par_Impar":
                    {
                        CalcCientifica objCalc = new CalcCientifica();
                        objCalc.Num1 = a;
                        objCalc.Num2 = b;
                        lblResultado.Text = objCalc.Par_Impar();
                        break;
                    }
                default:
                    break;
            }
        }
    }
}

