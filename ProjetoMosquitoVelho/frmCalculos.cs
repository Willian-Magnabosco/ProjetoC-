using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMosquitoVelho
{
    public partial class frmCalculos : Form
    {
        public frmCalculos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declarando as variáveis
            double num1, num2, resp;

            //Atribuir valors as variáveis
            num1 = Convert.ToDouble( txbN1.Text);
            num2 = Convert.ToDouble( txbN2.Text);
            //Calculando
            //resp = num1 + num2;
            resp = somaValor(num1, num2);

            //enviando vaor para a resposta
            lblResposta.Text = resp.ToString();
        }
        // criando o metodo para somar valores e retornar o resultado
        public double somaValor(double num1, double num2)
        {
            return (num1 + num2);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbN1.Text = "";
            txbN2.Clear();
            lblResposta.Text = "";
            txbN1.Focus();
        }
    }
}
