namespace projeto
{
    partial class FrmCliente
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
            label8 = new Label();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            txtfone = new TextBox();
            txtEmail = new TextBox();
            txtcpf = new TextBox();
            txtCep = new TextBox();
            txtNcasa = new TextBox();
            txtComplemento = new TextBox();
            btnCadastrar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnPesquisar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 39);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "lCódigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 81);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 125);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 2;
            label3.Text = "fone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 170);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 3;
            label4.Text = "E-mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 206);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 4;
            label5.Text = "Cpf/ cnpj";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(78, 243);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 5;
            label6.Text = "cep:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 296);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 6;
            label7.Text = "nº casa:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(78, 351);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 7;
            label8.Text = "complemento:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(167, 34);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 8;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(167, 77);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 9;
            // 
            // txtfone
            // 
            txtfone.Location = new Point(167, 120);
            txtfone.Name = "txtfone";
            txtfone.Size = new Size(125, 27);
            txtfone.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(167, 166);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtcpf
            // 
            txtcpf.Location = new Point(167, 205);
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(125, 27);
            txtcpf.TabIndex = 12;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(167, 252);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(125, 27);
            txtCep.TabIndex = 13;
            // 
            // txtNcasa
            // 
            txtNcasa.Location = new Point(167, 302);
            txtNcasa.Name = "txtNcasa";
            txtNcasa.Size = new Size(125, 27);
            txtNcasa.TabIndex = 14;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(167, 350);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(125, 27);
            txtComplemento.TabIndex = 15;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(59, 408);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 29);
            btnCadastrar.TabIndex = 16;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(186, 411);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(59, 456);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 18;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(183, 456);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 19;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(378, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(689, 376);
            dataGridView1.TabIndex = 20;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 488);
            Controls.Add(dataGridView1);
            Controls.Add(btnPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtComplemento);
            Controls.Add(txtNcasa);
            Controls.Add(txtCep);
            Controls.Add(txtcpf);
            Controls.Add(txtEmail);
            Controls.Add(txtfone);
            Controls.Add(txtNome);
            Controls.Add(txtCodigo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label8;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtfone;
        private TextBox txtEmail;
        private TextBox txtcpf;
        private TextBox txtCep;
        private TextBox txtNcasa;
        private TextBox txtComplemento;
        private Button btnCadastrar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnPesquisar;
        private DataGridView dataGridView1;
    }
}