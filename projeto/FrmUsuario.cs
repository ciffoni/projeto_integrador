using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System.Data;
namespace projeto
{
    public partial class FrmUsuario : Form
    {
        /// <summary>
        /// conexao serve para variavel global de conexao mysql
        /// </summary>
        MySqlConnection conexao;
        /// <summary>
        /// IdCargo armazenar o cargo selecionado
        /// </summary>
        int idcargo;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

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
                string sql = "insert into usuario(nome,email,senha,cargo,ativo) values (@nome,@email,@senha,@cargo,1)";
                MySqlCommand command = new MySqlCommand(sql, conexao);
                string senha = TxtSenha.Text.Trim();// limpar os espaços gerados
                string senhahash = BCrypt.Net.BCrypt.HashPassword(senha);
                command.Parameters.AddWithValue("@nome", TxtNome.Text);
                command.Parameters.AddWithValue("@email", TxtEmail.Text);
                command.Parameters.AddWithValue("@senha", senhahash);
                command.Parameters.AddWithValue("@cargo", idcargo);
                conexao.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Cadastro com sucesso");
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

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            /* cargos que irao utilizar o sistema
            cboCargo.Items.Add("Administrador");
            cboCargo.Items.Add("Gerente");
            cboCargo.Items.Add("Vendedor");
            cboCargo.Items.Add("Estoquista");
            */
            //obter as informações do entidade cargo
            cboCargo.DataSource = obterDados("select * from cargo");
            cboCargo.ValueMember = "codigocargo";
            cboCargo.DisplayMember = "cargo";
            //obter as informações do usuario no datagrid
            dataGridView1.DataSource = obterDados("select * from usuario");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                /// <summary>
                /// data_source é o caminho do banco de dados
                /// </summary>
                string data_source = "datasource=localhost;username=root;password='';database=projeto";
                conexao = new MySqlConnection(data_source);
                string sql = "Update usuario set nome=@nome,email=@email,senha=@senha,cargo=@cargo where codigo=@id";
                MySqlCommand command = new MySqlCommand(sql, conexao);
                string senha = TxtSenha.Text.Trim();// limpar os espaços gerados
                string senhahash = BCrypt.Net.BCrypt.HashPassword(senha);
                command.Parameters.AddWithValue("@nome", TxtNome.Text);
                command.Parameters.AddWithValue("@email", TxtEmail.Text);
                command.Parameters.AddWithValue("@senha", senhahash);
                command.Parameters.AddWithValue("@cargo", cboCargo.Text);
                command.Parameters.AddWithValue("@id", Convert.ToInt32(TxtCodigo.Text));
                conexao.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Editar com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao Editar");
                }
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtCodigo.Text))
                {
                    /// <summary>
                    /// data_source é o caminho do banco de dados
                    /// </summary>
                    string data_source = "datasource=localhost;username=root;password='';database=projeto";
                    conexao = new MySqlConnection(data_source);
                    string sql = "Delete from usuario where codigo=@id";
                    MySqlCommand command = new MySqlCommand(sql, conexao);
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(TxtCodigo.Text));
                    conexao.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Esxcluido com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Excluir");
                    }
                    conexao.Close();
                }
                else
                {
                    MessageBox.Show("Campo codigo está vazio");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }

        }

        private void cboCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            idcargo = Convert.ToInt32(((DataRowView)cboCargo.SelectedItem)["codigocargo"]);
        }

        //criar o metodo para obter as informações do banco
        public DataTable obterDados(string sql)
        {
            //criar a tabela
            DataTable dt = new DataTable();
            //caminho do servidor
            string datasource = "datasource=localhost;username=root;password='';database=projeto";
            conexao = new MySqlConnection(datasource);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(dt);
            conexao.Close();
            return dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = 0;
            codigo= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            TxtCodigo.Text=codigo.ToString();
            TxtNome.Text = dataGridView1.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            TxtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();
            TxtSenha.Text = dataGridView1.Rows[e.RowIndex].Cells["senha"].Value.ToString();
            cboCargo.Text = dataGridView1.Rows[e.RowIndex].Cells["cargo"].Value.ToString();
            bool ativo = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["ativo"].Value);
            chkAtivo.Visible = true;
            if (ativo == true)
            {
                chkAtivo.Checked = true;
            }
            else
            {
                chkAtivo.Checked = false;
            }
        }
    }
}
