using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
namespace projeto
{
    public partial class FrmUsuario : Form
    {
        /// <summary>
        /// conexao serve para variavel global de conexao mysql
        /// </summary>
        MySqlConnection conexao;
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
                string sql = "insert into usuario(nome,email,senha,cargo) values (@nome,@email,@senha,@cargo)";
                MySqlCommand command = new MySqlCommand(sql, conexao);
                string senha = TxtSenha.Text.Trim();// limpar os espaços gerados
                string senhahash = BCrypt.Net.BCrypt.HashPassword(senha);
                command.Parameters.AddWithValue("@nome", TxtNome.Text);
                command.Parameters.AddWithValue("@email", TxtEmail.Text);
                command.Parameters.AddWithValue("@senha", senhahash);
                command.Parameters.AddWithValue("@cargo", cboCargo.Text);
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
            //cargos que irao utilizar o sistema
            cboCargo.Items.Add("Administrador");
            cboCargo.Items.Add("Gerente");
            cboCargo.Items.Add("Vendedor");
            cboCargo.Items.Add("Estoquista");
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
    }
}
