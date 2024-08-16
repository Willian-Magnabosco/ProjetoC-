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
    public partial class frmListarProdutos : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmListarProdutos()
        {
            InitializeComponent();
            //metodo para carregar combobox
            carregaCombo();

            //cbbProdutos.Items.Add(produtos);
        }

        public void carregaCombo() 
        {
            //inserindo valores no vetor
            produtos[0] = "Banana";
            produtos[1] = "Limão";
            produtos[2] = "Laranja";
            produtos[3] = "Perâ";
            produtos[4] = "Uva";
            produtos[5] = "Maça";
            produtos[6] = "Melancia";
            produtos[7] = "jaboticaba";
            produtos[8] = "Goiaba";
            produtos[9] = "Tanjerina";

            cbbProdutos.Items.Clear();

            for (int i = 0; i < produtos.Length; i++)
            {
                cbbProdutos.Items.Add(produtos[i]);
            }
        }
        private void frmListarProdutos_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //criar um vetor
        string[] produtos = new string[10];

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            //criar um vetor
            string[] produtos = new string[10];
            
            //inserindo valores no vetor
            produtos[0] = "Banana";
            produtos[1] = "Limão";
            produtos[2] = "Laranja";
            produtos[3] = "Perâ";
            produtos[4] = "Uva";
            produtos[5] = "Maça";
            produtos[6] = "Melancia";
            produtos[7] = "jaboticaba";
            produtos[8] = "Goiaba";
            produtos[9] = "Tanjerina";

            //imprimindo os vetores

            //MessageBox.Show("produto", produtos[0]);
            //MessageBox.Show("produto", produtos[5]);

            ltbListaprodutos.Items.Clear();

            //percorrendo o vetor criado
            for (int i = 0; i < produtos.Length; i++)
            {
                ltbListaprodutos.Items.Add(produtos[i]);
            }

            
        }

        private void cbbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbListaritems_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaCombo();
            //MessageBox.Show("oque esta acontecendo");
        }

        private void cbbListaritems_MouseHover(object sender, EventArgs e)
        {
            cbbProdutos.Items.Add("valores novos");

        }

        private void cbbListaritems_MouseClick(object sender, MouseEventArgs e)
        {
            produtos[0] = "Banana";
            produtos[1] = "Limão";
            produtos[2] = "Laranja";
            produtos[3] = "Perâ";
            produtos[4] = "Uva";
            produtos[5] = "Maça";
            produtos[6] = "Melancia";
            produtos[7] = "jaboticaba";
            produtos[8] = "Goiaba";
            produtos[9] = "Tanjerina";

            //imprimindo os vetores

            //MessageBox.Show("produto", produtos[0]);
            //MessageBox.Show("produto", produtos[5]);

            cbbListaritems.Items.Clear();

            //percorrendo o vetor criado
            for (int i = 0; i < produtos.Length; i++)
            {
                cbbListaritems.Items.Add(produtos[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //instanciando o objeto pessoa
            Pessoa p = new Pessoa();
            p.Nome = "senac";
            lblMostrapessoa.Text = p.Nome;
        }

        private void lblMostrapessoa_Click(object sender, EventArgs e)
        {

        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            Bilhete bilhete = new Bilhete();

            bilhete.Documento = txtDocumento.Text;
            bilhete.NumeroCartao = mtbNumerocartao.Text;

            lblMostrardocumento.Text = bilhete.Documento;
            lblnumerocartao.Text = bilhete.NumeroCartao;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbNumerocartao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
