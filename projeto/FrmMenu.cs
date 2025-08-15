using projeto.classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario();
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = SessaoUsuario.UsuarioLogador;
            toolStripStatusLabel2.Text = SessaoUsuario.Cargousuario.ToString();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanciar o formulario produto
            FrmProduto produto = new FrmProduto();
            // disendo que é filho do menu
            produto.MdiParent = this;
            //mostra a janela
            produto.Show();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListarProduto produto= new FrmListarProduto();
            produto.MdiParent = this;
            produto.Show();
        }
    }
}
