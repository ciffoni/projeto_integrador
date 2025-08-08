using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace projeto
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            //chama a caixa de dialogo
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem| *.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Selecione a Imagem do Produto";
           // verifica se pressionou o ok
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //pega o caminho da foto
                string caminhocompletofotooriginal= openFileDialog.FileName;
               //pega o nome do arquivo
                string nomeArquivo = Path.GetFileName(caminhocompletofotooriginal);
                //criando o caminho da pasta de imagem no sistema
                string pastaDestino = Path.Combine(Application.StartupPath, "Produto");
                //verifica se existe o diretorio
                if(!Directory.Exists(pastaDestino) )
                {
                    //cria o diretorio
                    Directory.CreateDirectory(pastaDestino) ;

                }
                string caminhodestino = Path.Combine(pastaDestino, nomeArquivo);
                try
                {
                    //copiando o arquivo para o destino
                    File.Copy(caminhocompletofotooriginal, caminhodestino, true);
                    //mostrando o texto com o nome da foto
                    lblfoto.Text = Path.Combine(pastaDestino, nomeArquivo);
                    //carregando a foto na picture
                    Foto.Image = Image.FromFile(lblfoto.Text);
                }catch(Exception ex)
                {
                    MessageBox.Show($"Erro ao copiar a imagem:{ex.Message}", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblfoto.Text = "";
                }

            }
        }
    }
}
