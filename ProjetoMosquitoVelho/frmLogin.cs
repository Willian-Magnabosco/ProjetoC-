using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjetoMosquitoVelho
{
    public partial class frmLogin : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

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
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
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
            if (txtUsuario.Text.Equals ("senac") && txtSenha.Text.Equals("12345"))
            {
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ususario ou senha invalidos!!!");
                limparCampos();
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
