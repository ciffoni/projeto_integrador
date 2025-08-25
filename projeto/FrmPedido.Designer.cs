namespace projeto
{
    partial class FrmPedido
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
            dgvPedido = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            data_pedido = new DateTimePicker();
            data_entrega = new DateTimePicker();
            cboCliente = new ComboBox();
            ValorTotal = new Label();
            label5 = new Label();
            label6 = new Label();
            cboForma = new ComboBox();
            label7 = new Label();
            cboStatus = new ComboBox();
            btnFinalizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).BeginInit();
            SuspendLayout();
            // 
            // dgvPedido
            // 
            dgvPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedido.Location = new Point(71, 250);
            dgvPedido.Name = "dgvPedido";
            dgvPedido.RowHeadersWidth = 51;
            dgvPedido.Size = new Size(608, 188);
            dgvPedido.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 26);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 1;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 64);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 2;
            label2.Text = "data pedido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 116);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 3;
            label3.Text = "data entrega";
            // 
            // data_pedido
            // 
            data_pedido.Location = new Point(195, 64);
            data_pedido.Name = "data_pedido";
            data_pedido.Size = new Size(250, 27);
            data_pedido.TabIndex = 4;
            // 
            // data_entrega
            // 
            data_entrega.Location = new Point(195, 111);
            data_entrega.Name = "data_entrega";
            data_entrega.Size = new Size(250, 27);
            data_entrega.TabIndex = 5;
            // 
            // cboCliente
            // 
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(166, 27);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(151, 28);
            cboCliente.TabIndex = 6;
            cboCliente.SelectedIndexChanged += cboCliente_SelectedIndexChanged;
            // 
            // ValorTotal
            // 
            ValorTotal.AutoSize = true;
            ValorTotal.Location = new Point(195, 152);
            ValorTotal.Name = "ValorTotal";
            ValorTotal.Size = new Size(50, 20);
            ValorTotal.TabIndex = 7;
            ValorTotal.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 152);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 8;
            label5.Text = "Valor total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(100, 187);
            label6.Name = "label6";
            label6.Size = new Size(151, 20);
            label6.TabIndex = 9;
            label6.Text = "forma de pagamento";
            // 
            // cboForma
            // 
            cboForma.FormattingEnabled = true;
            cboForma.Location = new Point(283, 193);
            cboForma.Name = "cboForma";
            cboForma.Size = new Size(151, 28);
            cboForma.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(363, 151);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 11;
            label7.Text = "Status";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(437, 151);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(151, 28);
            cboStatus.TabIndex = 12;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(587, 210);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(172, 29);
            btnFinalizar.TabIndex = 13;
            btnFinalizar.Text = "Finalizar Compra";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFinalizar);
            Controls.Add(cboStatus);
            Controls.Add(label7);
            Controls.Add(cboForma);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(ValorTotal);
            Controls.Add(cboCliente);
            Controls.Add(data_entrega);
            Controls.Add(data_pedido);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPedido);
            Name = "FrmPedido";
            Text = "FrmPedido";
            Load += FrmPedido_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPedido;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker data_pedido;
        private DateTimePicker data_entrega;
        private ComboBox cboCliente;
        private Label ValorTotal;
        private Label label5;
        private Label label6;
        private ComboBox cboForma;
        private Label label7;
        private ComboBox cboStatus;
        private Button btnFinalizar;
    }
}