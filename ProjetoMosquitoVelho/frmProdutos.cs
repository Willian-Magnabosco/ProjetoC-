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
    public partial class frmProdutos : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            frmFuncionarios abrir = new frmFuncionarios();
            abrir.Show();
            this.Hide();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //ltbProdutos.Items.Clear();
            ltbProdutos.Items.Add(txtDigiteproduto.Text);
            txtDigiteproduto.Clear();
            txtDigiteproduto.Focus();

        }

        private void txtDigiteproduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ltbProdutos.Items.Add(txtDigiteproduto.Text);
                txtDigiteproduto.Clear();
                txtDigiteproduto.Focus();
            }
            
        }

        private void ltbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pegando o indice selecionado
            //lblEscolhido.Text = ltbProdutos.SelectedIndex.ToString();

            //pegando o valor selecionado
            lblEscolhido.Text = ltbProdutos.SelectedItem.ToString();
        }

        private void btnTiraritem_Click(object sender, EventArgs e)
        {
            //ltbProdutos.Items.Remove(ltbProdutos.SelectedIndex);
            ltbProdutos.Items.RemoveAt(ltbProdutos.SelectedIndex);

        }
    }
}
