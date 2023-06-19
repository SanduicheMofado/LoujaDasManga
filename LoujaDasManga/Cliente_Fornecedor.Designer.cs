namespace LoujaDasManga
{
    partial class Cliente_Fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente_Fornecedor));
            this.txtCliente = new System.Windows.Forms.Button();
            this.txtFornecedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(12, 71);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(87, 32);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.Text = "Cliente";
            this.txtCliente.UseVisualStyleBackColor = true;
            this.txtCliente.Click += new System.EventHandler(this.txtCliente_Click);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(170, 71);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(87, 32);
            this.txtFornecedor.TabIndex = 1;
            this.txtFornecedor.Text = "Fornecedor";
            this.txtFornecedor.UseVisualStyleBackColor = true;
            this.txtFornecedor.Click += new System.EventHandler(this.txtFornecedor_Click);
            // 
            // Cliente_Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(273, 115);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtCliente);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Name = "Cliente_Fornecedor";
            this.Text = "Cliente_Fornecedor";
            this.ResumeLayout(false);

        }

        #endregion

        private Button txtCliente;
        private Button txtFornecedor;
    }
}