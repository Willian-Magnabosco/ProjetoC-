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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            /*
            this.Close();
            Close();*/
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("senac") && txtSenha.Text.Equals("12345"))
            {
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("usuario ou senha invalidos");
                limparCampos();
            }
        }
        public void limparCampos() 
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
                
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
                txtUsuario.Focus();
            }
        }

        private void btnEntrar_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
