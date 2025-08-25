using MySql.Data.MySqlClient;
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
using static projeto.FrmListarProduto; //forms listar produto

namespace projeto
{
    public partial class FrmPedido : Form
    {
        MySqlConnection com;
        int idUsuario;
        decimal totalpedido;
        private List<ItemCarrinho> _itemCarrinho;
        public FrmPedido(List<ItemCarrinho> CarrinhoREcebido)
        {
            _itemCarrinho = CarrinhoREcebido;
            InitializeComponent();
        }
        private void AtualizarCarrinho()
        {
            dgvPedido.DataSource = _itemCarrinho;
            dgvPedido.Refresh();
            //calculando o total de itens selecionado
            ValorTotal.Text = _itemCarrinho.Sum(Item => Item.Subtotal).ToString();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            //puxa a informação da compra
            AtualizarCarrinho();
            //chama a classe conexao
            conexao com = new conexao();

            //prenche o combo cliente
            cboCliente.DataSource = com.obterDados("select codigoCliente, nome from cliente");
            cboCliente.ValueMember = "codigocliente";
            cboCliente.DisplayMember = "nome";
            // prenche o combo box da forma de pagamento
            cboForma.Items.Add("cartão debito");
            cboForma.Items.Add("cartao credito");
            cboForma.Items.Add("PIX");

            //preenche o combo do status do pedido
            cboStatus.Items.Add("recebido");
            cboStatus.Items.Add("produção");
            cboStatus.Items.Add("enviado");
            cboStatus.Items.Add("Concluido");


        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            idUsuario = Convert.ToInt32(((DataRowView)cboCliente.SelectedItem)["codigoCliente"]);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            string datasource = "datasource=localhost;username=root;password='';database=projeto";
            com = new MySqlConnection(datasource);

            try
            {
                if (cboCliente.Text == "")
                {
                    MessageBox.Show("Cliente está vazio");
                    return;
                }
                if (cboForma.Text == "")
                {
                    MessageBox.Show("Forma de pagamento vazio"); return;
                }
                if(cboStatus.Text == "")
                {
                    MessageBox.Show("Status está vazio");return;
                }
                string sqlpedido = "Insert into pedido(data_pedido,data_entrega,codigoUsuario,codigoCliente,formapagamento,status)" +
                    "values( @datapedido,@dataentrega,@usuario,@cliente,@forma,@status)";
                MySqlCommand comandopedido= new MySqlCommand(sqlpedido,com);
                comandopedido.Parameters.AddWithValue("@usuario",SessaoUsuario.Codigo);
                comandopedido.Parameters.AddWithValue("@datapedido",data_pedido.Value);
                comandopedido.Parameters.AddWithValue("@dataentrega",data_entrega.Value);
                comandopedido.Parameters.AddWithValue("@cliente", idUsuario);
                comandopedido.Parameters.AddWithValue("@forma", cboForma.Text);
                comandopedido.Parameters.AddWithValue("@status",cboStatus.Text);
                com.Open();
                comandopedido.ExecuteNonQuery();
                //guarda o registro do pedido inserido
                int idpedido=Convert.ToInt32(comandopedido.LastInsertedId);

                // inserir o item do pedido
                string sqlitens = "insert into pedido_itens(codigopedido,codigoproduto,quantidade,valor,total)" +
                    "values(@pedido,@produto,@quantidade,@valor,@total)";
               // pega linha a linha dos produtos
                foreach (var item in _itemCarrinho)
                {
                    MySqlCommand cmd = new MySqlCommand(sqlitens, com);
                    cmd.Parameters.AddWithValue("@pedido",idpedido);
                    cmd.Parameters.AddWithValue("@produto",item.ProdutoId);
                    cmd.Parameters.AddWithValue("@quantidade",item.Quantidade);
                    cmd.Parameters.AddWithValue("@valor",item.valor);
                    cmd.Parameters.AddWithValue("@total",item.Subtotal);
                    cmd.ExecuteNonQuery();
                    totalpedido += item.Subtotal;
                }
                ValorTotal.Text=totalpedido.ToString();
                com.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("erro: "+ ex.Message);
            }

        }
    }
}
