namespace projeto
{
    partial class FrmListarProduto
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnComprar = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(69, 50);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(648, 377);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(744, 387);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(94, 29);
            btnComprar.TabIndex = 1;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // FrmListarProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 450);
            Controls.Add(btnComprar);
            Controls.Add(flowLayoutPanel1);
            Name = "FrmListarProduto";
            Text = "FrmListarProduto";
            Load += FrmListarProduto_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnComprar;
    }
}