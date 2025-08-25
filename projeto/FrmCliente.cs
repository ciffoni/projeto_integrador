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

namespace projeto
{
    public partial class FrmCliente : Form
    {
        MySqlConnection conexao;
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                /// <summary>
                /// data_source é o caminho do banco de dados
                /// </summary>
                string data_source = "datasource=localhost;username=root;password='';database=projeto";
                conexao = new MySqlConnection(data_source);
                string sql = "insert into cliente(nome,fone,email,cnpj_cpf,cep,num_casa,complemento)" +
                    " values (@nome,@fone,@email,@cnpj,@cep,@num_casa,@complemento)";
                MySqlCommand command = new MySqlCommand(sql, conexao);
                command.Parameters.AddWithValue("@nome", txtNome.Text);
                command.Parameters.AddWithValue("@fone", txtfone.Text);
                command.Parameters.AddWithValue("@email", txtEmail.Text);
                command.Parameters.AddWithValue("@cnpj", txtcpf.Text);
                command.Parameters.AddWithValue("@cep", txtCep.Text);
                command.Parameters.AddWithValue("@num_casa", txtNcasa.Text);
                command.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                conexao.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Cadastro Cliente com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro no cadastro");
                }
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
    }
}
