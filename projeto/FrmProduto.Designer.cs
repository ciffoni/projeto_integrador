namespace projeto
{
    partial class FrmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            txtDEscricao = new TextBox();
            txtValor = new TextBox();
            cboTipo = new ComboBox();
            Foto = new PictureBox();
            txtQuantidade = new TextBox();
            btnCadastrar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnPesquisar = new Button();
            dgvProduto = new DataGridView();
            btnFoto = new Button();
            lblfoto = new Label();
            ((System.ComponentModel.ISupportInitialize)Foto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 43);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "cõdigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 83);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 128);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "descrição:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 167);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "valor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 214);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 4;
            label5.Text = "Tipo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 260);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 5;
            label6.Text = "Quantidade:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(500, 47);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 6;
            label7.Text = "Foto:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(167, 47);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(167, 88);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 8;
            // 
            // txtDEscricao
            // 
            txtDEscricao.Location = new Point(167, 130);
            txtDEscricao.Name = "txtDEscricao";
            txtDEscricao.Size = new Size(125, 27);
            txtDEscricao.TabIndex = 9;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(167, 173);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(125, 27);
            txtValor.TabIndex = 10;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(167, 214);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(151, 28);
            cboTipo.TabIndex = 11;
            // 
            // Foto
            // 
            Foto.Location = new Point(500, 88);
            Foto.Name = "Foto";
            Foto.Size = new Size(296, 199);
            Foto.TabIndex = 12;
            Foto.TabStop = false;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(167, 260);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(125, 27);
            txtQuantidade.TabIndex = 13;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(68, 313);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 29);
            btnCadastrar.TabIndex = 14;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(184, 316);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(295, 316);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 16;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(411, 316);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 17;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // dgvProduto
            // 
            dgvProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduto.Location = new Point(61, 391);
            dgvProduto.Name = "dgvProduto";
            dgvProduto.RowHeadersWidth = 51;
            dgvProduto.Size = new Size(804, 252);
            dgvProduto.TabIndex = 18;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(575, 45);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(154, 29);
            btnFoto.TabIndex = 19;
            btnFoto.Text = "Adicionar foto";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // lblfoto
            // 
            lblfoto.AutoSize = true;
            lblfoto.Location = new Point(617, 301);
            lblfoto.Name = "lblfoto";
            lblfoto.Size = new Size(121, 20);
            lblfoto.TabIndex = 20;
            lblfoto.Text = "Caminho da foto";
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 679);
            Controls.Add(lblfoto);
            Controls.Add(btnFoto);
            Controls.Add(dgvProduto);
            Controls.Add(btnPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtQuantidade);
            Controls.Add(Foto);
            Controls.Add(cboTipo);
            Controls.Add(txtValor);
            Controls.Add(txtDEscricao);
            Controls.Add(txtNome);
            Controls.Add(txtCodigo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmProduto";
            Text = "FrmProduto";
            ((System.ComponentModel.ISupportInitialize)Foto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtDEscricao;
        private TextBox txtValor;
        private ComboBox cboTipo;
        private PictureBox Foto;
        private TextBox txtQuantidade;
        private Button btnCadastrar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnPesquisar;
        private DataGridView dgvProduto;
        private Button btnFoto;
        private Label lblfoto;
    }
}