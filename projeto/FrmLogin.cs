using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projeto.classe;

namespace projeto
{
    public partial class FrmLogin : Form
    {
        MySqlConnection conexao;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text == "")
                {
                    label3.Text = "E-mail está vazio!";
                    return;
                }
                if (txtSenha.Text == "")
                {
                    label3.Text = "Senha está vazio";
                    return;
                }
                string datasource = "datasource=localhost;username=root;password='';database=projeto";

                conexao = new MySqlConnection(datasource);
                string sql = "select codigo,nome,email,cargo,ativo,senha from usuario where email=@email";
                
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@email", txtEmail.Text);
                conexao.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                //se achar informação
                if (reader.Read())
                {
                    SessaoUsuario.Cargousuario = Convert.ToInt32(reader["cargo"]);
                    SessaoUsuario.UsuarioLogador = reader["nome"].ToString();
                    SessaoUsuario.Codigo = Convert.ToInt32(reader["codigo"]);
                    string senha = reader["senha"].ToString();
                    int ativo = Convert.ToInt32(reader["ativo"].ToString());
                    if (ativo ==0)
                    {
                        label3.Text = "Sua conta está desativada! ";
                        return;
                    }
                    else
                    {
                        if (BCrypt.Net.BCrypt.Verify(txtSenha.Text, senha))
                        {
                            MessageBox.Show($"Bem vindo, {SessaoUsuario.UsuarioLogador} ");
                            FrmMenu principal = new FrmMenu();
                            principal.Show();
                        }
                        else
                        {
                            label3.Text = "Usuario ou Senha invalido!";
                        }
                    }
               
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Erro:"+ ex.Message);
            }
        }
    }
}
