using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static projeto.FrmListarProduto; //forms listar produto

namespace projeto
{
    public partial class FrmPedido : Form
    {
        private List<ItemCarrinho> _itemCarrinho;
        public FrmPedido( List<ItemCarrinho>CarrinhoREcebido)
        {
            _itemCarrinho = CarrinhoREcebido;
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            dgvPedido.DataSource = _itemCarrinho;
        }
    }
}
