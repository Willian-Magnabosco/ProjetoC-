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
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        //limpar campos
        public void limparCampos()
        {
            txtNum1.Clear();
            txtNum2.Clear();
            lblResposta.Text = "";
            rdbSomar.Checked = false;
            rdbSubtrair.Checked = false;
            rdbMultiplicar.Checked = false;
            rdbDividir.Checked = false;
            txtNum1.Focus();

        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1, num2, resp = 0;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            //instanciar o objeto/classe
            Operacoes op = new Operacoes();
            if (rdbSomar.Checked)
            {
                resp = op.somar(num1, num2);
            }
            if (rdbSubtrair.Checked)
            {
                resp = op.subtrair(num1, num2);
            }
            if (rdbMultiplicar.Checked)
            {
                resp = op.multiplicar(num1, num2);
            }
            if (rdbDividir.Checked)
            {
                if (num2 == 0)
                {
                    MessageBox.Show("impossível divisão por 0","sistemaABC",MessageBoxButtons.OK,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
                    //executar o metodo limparCampos
                    limparCampos();

                }
                else
                {
                    resp = op.dividir(num1, num2);
                }
            }

            lblResposta.Text = resp.ToString();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rbnSomar_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
