namespace LoujaDasManga
{
    partial class CatalogoFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoFornecedor));
            this.cbListaCateg = new System.Windows.Forms.ComboBox();
            this.txtAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtValorU = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNomeM = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtLista = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLista)).BeginInit();
            this.SuspendLayout();
            // 
            // cbListaCateg
            // 
            this.cbListaCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListaCateg.FormattingEnabled = true;
            this.cbListaCateg.Location = new System.Drawing.Point(497, 5);
            this.cbListaCateg.Name = "cbListaCateg";
            this.cbListaCateg.Size = new System.Drawing.Size(121, 23);
            this.cbListaCateg.TabIndex = 23;
            this.cbListaCateg.SelectedIndexChanged += new System.EventHandler(this.cbListaCateg_SelectedIndexChanged);
            // 
            // txtAdicionar
            // 
            this.txtAdicionar.Location = new System.Drawing.Point(94, 597);
            this.txtAdicionar.Name = "txtAdicionar";
            this.txtAdicionar.Size = new System.Drawing.Size(67, 23);
            this.txtAdicionar.TabIndex = 22;
            this.txtAdicionar.Text = "Adicionar";
            this.txtAdicionar.UseVisualStyleBackColor = true;
            this.txtAdicionar.Click += new System.EventHandler(this.txtAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(322, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Listagem";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(12, 250);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(180, 23);
            this.txtAutor.TabIndex = 17;
            this.txtAutor.Text = "AUTOR*";
            // 
            // txtValorU
            // 
            this.txtValorU.Location = new System.Drawing.Point(12, 293);
            this.txtValorU.Name = "txtValorU";
            this.txtValorU.Size = new System.Drawing.Size(132, 23);
            this.txtValorU.TabIndex = 16;
            this.txtValorU.Text = "VALOR UNITÁRIO*";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 350);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(218, 241);
            this.txtDescricao.TabIndex = 15;
            this.txtDescricao.Text = "DESCRIÇÃO";
            // 
            // txtNomeM
            // 
            this.txtNomeM.Location = new System.Drawing.Point(12, 210);
            this.txtNomeM.Name = "txtNomeM";
            this.txtNomeM.Size = new System.Drawing.Size(243, 23);
            this.txtNomeM.TabIndex = 14;
            this.txtNomeM.Text = "NOME*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // dtLista
            // 
            this.dtLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLista.Location = new System.Drawing.Point(322, 27);
            this.dtLista.Name = "dtLista";
            this.dtLista.RowTemplate.Height = 25;
            this.dtLista.Size = new System.Drawing.Size(427, 564);
            this.dtLista.TabIndex = 12;
            this.dtLista.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtLista_MouseClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(12, 597);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(67, 23);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(439, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "GÊNERO";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(155, 293);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(75, 23);
            this.txtEstoque.TabIndex = 26;
            this.txtEstoque.Text = "Estoque*";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(12, 322);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 23);
            this.cbCategoria.TabIndex = 27;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(236, 293);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(57, 23);
            this.txtCodigo.TabIndex = 28;
            this.txtCodigo.Text = "Cod";
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(198, 12);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 29;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(322, 602);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 30;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // Voltar
            // 
            this.Voltar.BackColor = System.Drawing.SystemColors.Window;
            this.Voltar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Voltar.Location = new System.Drawing.Point(287, 12);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(29, 32);
            this.Voltar.TabIndex = 41;
            this.Voltar.Text = "←";
            this.Voltar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Voltar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Voltar.UseVisualStyleBackColor = false;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // CatalogoFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(761, 637);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbListaCateg);
            this.Controls.Add(this.txtAdicionar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtValorU);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNomeM);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtLista);
            this.Name = "CatalogoFornecedor";
            this.Text = "CatalogoFornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbListaCateg;
        private Button txtAdicionar;
        private Label label2;
        private Label label1;
        private DataGridView dtCarrinho;
        private TextBox txtAutor;
        private TextBox txtValorU;
        private TextBox txtDescricao;
        private TextBox txtNomeM;
        private PictureBox pictureBox1;
        private DataGridView dtLista;
        private Button btnEditar;
        private Label label3;
        private TextBox txtEstoque;
        private ComboBox cbCategoria;
        private TextBox txtCodigo;
        private Button btnLimpar;
        private Button btnDeletar;
        private Button Voltar;
    }
}