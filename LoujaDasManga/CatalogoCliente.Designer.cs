namespace LoujaDasManga
{
    partial class CatalogoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoCliente));
            this.dtLista = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNomeM = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtValorU = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.dtCarrinho = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCarrinho = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbListaCateg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cbCodigo1 = new System.Windows.Forms.ComboBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValorT = new System.Windows.Forms.TextBox();
            this.txtOk = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtDeletar = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.txtCod1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // dtLista
            // 
            this.dtLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLista.Location = new System.Drawing.Point(322, 27);
            this.dtLista.Name = "dtLista";
            this.dtLista.RowTemplate.Height = 25;
            this.dtLista.Size = new System.Drawing.Size(432, 345);
            this.dtLista.TabIndex = 13;
            this.dtLista.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtLista_MouseClick);
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
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtNomeM
            // 
            this.txtNomeM.Enabled = false;
            this.txtNomeM.Location = new System.Drawing.Point(12, 210);
            this.txtNomeM.Name = "txtNomeM";
            this.txtNomeM.Size = new System.Drawing.Size(265, 23);
            this.txtNomeM.TabIndex = 1;
            this.txtNomeM.Text = "Nome*";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(12, 348);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(243, 243);
            this.txtDescricao.TabIndex = 9;
            // 
            // txtValorU
            // 
            this.txtValorU.Enabled = false;
            this.txtValorU.Location = new System.Drawing.Point(12, 289);
            this.txtValorU.Name = "txtValorU";
            this.txtValorU.Size = new System.Drawing.Size(91, 23);
            this.txtValorU.TabIndex = 4;
            this.txtValorU.Text = "Valor*";
            // 
            // txtAutor
            // 
            this.txtAutor.Enabled = false;
            this.txtAutor.Location = new System.Drawing.Point(12, 250);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(161, 23);
            this.txtAutor.TabIndex = 2;
            this.txtAutor.Text = "Autor*";
            // 
            // dtCarrinho
            // 
            this.dtCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCarrinho.Location = new System.Drawing.Point(322, 401);
            this.dtCarrinho.Name = "dtCarrinho";
            this.dtCarrinho.RowTemplate.Height = 25;
            this.dtCarrinho.Size = new System.Drawing.Size(432, 190);
            this.dtCarrinho.TabIndex = 14;
            this.dtCarrinho.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtCarrinho_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(322, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Carrinho";
            // 
            // btnCarrinho
            // 
            this.btnCarrinho.Location = new System.Drawing.Point(12, 602);
            this.btnCarrinho.Name = "btnCarrinho";
            this.btnCarrinho.Size = new System.Drawing.Size(148, 23);
            this.btnCarrinho.TabIndex = 10;
            this.btnCarrinho.Text = "Adicionar ao carrinho";
            this.btnCarrinho.UseVisualStyleBackColor = true;
            this.btnCarrinho.Click += new System.EventHandler(this.btnCarrinho_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(679, 602);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 10;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtEstoque
            // 
            this.txtEstoque.Enabled = false;
            this.txtEstoque.Location = new System.Drawing.Point(109, 289);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(75, 23);
            this.txtEstoque.TabIndex = 5;
            this.txtEstoque.Text = "Estoque*";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Location = new System.Drawing.Point(180, 250);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(97, 23);
            this.txtCategoria.TabIndex = 3;
            this.txtCategoria.Text = "Categoria*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(439, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "GÊNERO";
            // 
            // cbListaCateg
            // 
            this.cbListaCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListaCateg.FormattingEnabled = true;
            this.cbListaCateg.Location = new System.Drawing.Point(497, 5);
            this.cbListaCateg.Name = "cbListaCateg";
            this.cbListaCateg.Size = new System.Drawing.Size(121, 23);
            this.cbListaCateg.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(322, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Listagem";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(190, 289);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(40, 23);
            this.txtCodigo.TabIndex = 6;
            this.txtCodigo.Text = "Cod";
            // 
            // cbCodigo1
            // 
            this.cbCodigo1.Enabled = false;
            this.cbCodigo1.FormattingEnabled = true;
            this.cbCodigo1.Location = new System.Drawing.Point(12, 12);
            this.cbCodigo1.Name = "cbCodigo1";
            this.cbCodigo1.Size = new System.Drawing.Size(68, 23);
            this.cbCodigo1.TabIndex = 34;
            this.cbCodigo1.Text = "Cliente*";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(12, 319);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(81, 23);
            this.txtQuantidade.TabIndex = 7;
            this.txtQuantidade.Text = "Quantidade*";
            // 
            // txtValorT
            // 
            this.txtValorT.Enabled = false;
            this.txtValorT.Location = new System.Drawing.Point(99, 319);
            this.txtValorT.Name = "txtValorT";
            this.txtValorT.Size = new System.Drawing.Size(85, 23);
            this.txtValorT.TabIndex = 8;
            this.txtValorT.Text = "Valor total*";
            // 
            // txtOk
            // 
            this.txtOk.Location = new System.Drawing.Point(186, 602);
            this.txtOk.Name = "txtOk";
            this.txtOk.Size = new System.Drawing.Size(69, 23);
            this.txtOk.TabIndex = 1;
            this.txtOk.Text = "Alterar";
            this.txtOk.UseVisualStyleBackColor = true;
            this.txtOk.Click += new System.EventHandler(this.txtOk_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(198, 12);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 38;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtDeletar
            // 
            this.txtDeletar.Location = new System.Drawing.Point(322, 597);
            this.txtDeletar.Name = "txtDeletar";
            this.txtDeletar.Size = new System.Drawing.Size(75, 23);
            this.txtDeletar.TabIndex = 39;
            this.txtDeletar.Text = "RETIRAR";
            this.txtDeletar.UseVisualStyleBackColor = true;
            this.txtDeletar.Click += new System.EventHandler(this.txtDeletar_Click);
            // 
            // Voltar
            // 
            this.Voltar.BackColor = System.Drawing.SystemColors.Window;
            this.Voltar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Voltar.Location = new System.Drawing.Point(287, 12);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(29, 32);
            this.Voltar.TabIndex = 40;
            this.Voltar.Text = "←";
            this.Voltar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Voltar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Voltar.UseVisualStyleBackColor = false;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // txtCod1
            // 
            this.txtCod1.Location = new System.Drawing.Point(198, 41);
            this.txtCod1.Name = "txtCod1";
            this.txtCod1.Size = new System.Drawing.Size(10, 23);
            this.txtCod1.TabIndex = 9999;
            this.txtCod1.TabStop = false;
            this.txtCod1.Visible = false;
            // 
            // CatalogoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(789, 637);
            this.Controls.Add(this.txtCod1);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.txtDeletar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtOk);
            this.Controls.Add(this.txtValorT);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.cbCodigo1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbListaCateg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnCarrinho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtCarrinho);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtValorU);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNomeM);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtLista);
            this.Name = "CatalogoCliente";
            this.Text = "Catalogo";
            ((System.ComponentModel.ISupportInitialize)(this.dtLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtLista;
        private PictureBox pictureBox1;
        private TextBox txtNomeM;
        private TextBox txtDescricao;
        private TextBox txtValorU;
        private TextBox txtAutor;
        private DataGridView dtCarrinho;
        private Label label2;
        private Button btnCarrinho;
        private Button btnFinalizar;
        private TextBox txtEstoque;
        private TextBox txtCategoria;
        private Label label3;
        private ComboBox cbListaCateg;
        private Label label1;
        private TextBox txtCodigo;
        private ComboBox cbCodigo1;
        private TextBox txtQuantidade;
        private TextBox txtValorT;
        private Button txtOk;
        private Button btnLimpar;
        private Button txtDeletar;
        private Button Voltar;
        private TextBox txtCod1;
    }
}