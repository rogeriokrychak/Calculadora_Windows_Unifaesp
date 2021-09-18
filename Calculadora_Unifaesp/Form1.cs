using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Unifaesp
{
    public partial class Form1 : Form
    {
        //variáveis globais
        double entrada01;
        double entrada02;
        char operacao;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
                visor.Text = "";
            visor.Text += "1";//concatenar com o número 1
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
                visor.Text = "";
            visor.Text += "2";//concatenar com o número 2
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
                visor.Text = "";
            visor.Text += "3";//concatenar com o número 3
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
                visor.Text = "";
            visor.Text += "4";//concatenar com o número 4
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
                visor.Text = "";
            visor.Text += "5";//concatenar com o número 5
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
                visor.Text = "";
            visor.Text += "6";//concatenar com o número 6
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
                visor.Text = "";
            visor.Text += "7";//concatenar com o número 7
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
                visor.Text = "";
            visor.Text += "8";//concatenar com o número 8
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
                visor.Text = "";
            visor.Text += "9";//concatenar com o número 9
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (visor.Text != "0")
                visor.Text += "0";//concatenar com o número 0
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            visor.Text = "0";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            operacao = '+';
            entrada01 = double.Parse(visor.Text);
            visor.Text = "0";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            entrada02 = double.Parse(visor.Text);
            switch (operacao)
            {
                case '+'://soma
                    double soma = entrada01 + entrada02;
                    visor.Text = soma.ToString();
                    break;
                case '-':
                    double subtr = entrada01 - entrada02;
                    visor.Text = subtr.ToString();
                    break;
                case 'x':
                    double multipl = entrada01 * entrada02;
                    visor.Text = multipl.ToString();
                    break;
                case '/':
                    double divisao = entrada01 / entrada02;
                    visor.Text = divisao.ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnSubtr_Click(object sender, EventArgs e)
        {
            operacao = '-';
            entrada01 = double.Parse(visor.Text);
            visor.Text = "0";
        }

        private void btnMultipl_Click(object sender, EventArgs e)
        {
            operacao = 'x';
            entrada01 = double.Parse(visor.Text);
            visor.Text = "0";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            operacao = '/';
            entrada01 = double.Parse(visor.Text);
            visor.Text = "0";
        }
    }
}
