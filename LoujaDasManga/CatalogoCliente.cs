using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace LoujaDasManga
{
    public partial class CatalogoCliente : Form
    {
        public CatalogoCliente()
        {
            InitializeComponent();
            AtualizarGrid();
            AtualizarCarrinho();
            //vai carregar a lista
            cbListaCateg.DataSource = CarregarCateg();
            //exibir a categoria
            cbListaCateg.DisplayMember = "nome";
            //valor do elemento
            cbListaCateg.ValueMember = "codigo";
            //Carrega o código do cliente
            cbCodigo1.DataSource = Cliente();
            //
            cbCodigo1.DisplayMember = "Cliente";
            //
            cbCodigo1.ValueMember = "codigo";
        }

        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantidade.Text == string.Empty)
                {
                    MessageBox.Show("Por favor preencha os campos!", "ERRO");
                }
                else
                {
                    //vai iniciar capturando os dados nos campos da tela e jogar no banco de dados
                    int linha = dtLista.SelectedRows[0].Index;
                    Dados prod = new Dados();
                    prod.Codigo = Convert.ToInt32(txtCodigo.Text);
                    prod.CodigoCli = Convert.ToInt32(cbCodigo1.SelectedValue);
                    prod.Quantidade = Convert.ToInt32(txtQuantidade.Text);

                    //abrir conexão
                    SqlConnection con = new SqlConnection(Banco.Conexao);
                    con.Open();
                    string sqlAlterar = "INSERT INTO carrinho(produto_codigo,cliente_codigo,quantidade)" +
                                        "VALUES(@produto_codigo,@cliente_codigo,@quantidade)";

                    SqlCommand cmd = new SqlCommand(sqlAlterar, con);
                    cmd.Parameters.Add("@produto_codigo", SqlDbType.Int).Value = prod.Codigo;
                    cmd.Parameters.Add("@cliente_codigo", SqlDbType.Int).Value = prod.CodigoCli;
                    cmd.Parameters.Add("@quantidade", SqlDbType.Int).Value = prod.Quantidade;

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Produto adicionado ao carrinho");
                    AtualizarCarrinho();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao ao adicionar produto ao carrinho: " + erro.Message);
            }
        }
        public static DataTable CarregarCateg()
        {
            try
            {
                //abrir conexão com o banco de dados
                SqlConnection con = new SqlConnection(Banco.Conexao);
                con.Open();
                //vai armazenar na variavel sql o comando de selecionar tudo da tabela categorias
                string sql = "SELECT * FROM categorias";
                //executar um comando sql
                SqlCommand cmd = new SqlCommand(sql, con);
                //vai efetuar uma leitura dos dados
                SqlDataReader dr = cmd.ExecuteReader();
                //fazer tratamento da tabela
                DataTable dt = new DataTable();
                //vai carregar os dados obtidos na leitura
                dt.Load(dr);
                //vai retornar as informações para o cbCategoria
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable Cliente()
        {
            try
            {
                SqlConnection con = new SqlConnection(Banco.Conexao);
                con.Open();
                string sql = "SELECT * FROM cliente";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable ListarProduto()//retorna o tipo de produto
        {
            try
            {
                SqlConnection con = new SqlConnection(Banco.Conexao);
                con.Open();
                string sql = "SELECT * FROM produto";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable Carrinho()//retorna o tipo de produto
        {
            try
            {
                SqlConnection con = new SqlConnection(Banco.Conexao);
                con.Open();
                string sql = "SELECT carrinho.*,produto.*" +
                             "FROM carrinho INNER JOIN produto ON carrinho.produto_codigo = produto.codigo";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AtualizarCarrinho()
        {
            //O comando datasource faz com que os dados vindos do ListarProduto(), carreguem dentro do DataGridView da lista
            dtCarrinho.DataSource = Carrinho();
            //montando o DataGridView com o cabeçalho
            dtCarrinho.Columns[0].HeaderText = ""; /*carrincod*/
            dtCarrinho.Columns[1].HeaderText = ""; /*clicod*/
            dtCarrinho.Columns[2].HeaderText = ""; /*prodcod*/
            dtCarrinho.Columns[3].HeaderText = "Quantidade";
            dtCarrinho.Columns[4].HeaderText = "cod";
            dtCarrinho.Columns[5].HeaderText = "Nome";
            dtCarrinho.Columns[6].HeaderText = ""; /*estoq*/
            dtCarrinho.Columns[7].HeaderText = "Preço";
            dtCarrinho.Columns[8].HeaderText = "Descrição";
            dtCarrinho.Columns[9].HeaderText = "Autor";
            dtCarrinho.Columns[10].HeaderText = "Gênero";
            //e tamanho das colunas
            dtCarrinho.Columns[0].Width = -10;
            dtCarrinho.Columns[1].Width = -10;
            dtCarrinho.Columns[2].Width = -10;
            dtCarrinho.Columns[3].Width = 75;
            dtCarrinho.Columns[4].Width = 40;
            dtCarrinho.Columns[5].Width = 150;
            dtCarrinho.Columns[6].Width = -10;
            dtCarrinho.Columns[7].Width = 50;
            dtCarrinho.Columns[8].Width = 105;
            dtCarrinho.Columns[9].Width = 90;
            dtCarrinho.Columns[10].Width = 70;

            //faz com que selecione a linha toda do DataGridView
            dtCarrinho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //primissôes do usuario
            dtCarrinho.AllowUserToAddRows = false;
            dtCarrinho.AllowUserToDeleteRows = false;
            dtCarrinho.ReadOnly = true;
            dtCarrinho.AllowUserToResizeColumns = false;
            dtCarrinho.AllowUserToResizeRows = false;
        }
        public void AtualizarGrid()
        {
            //Carrega os dados do ListarProduto() no datagridview
            dtLista.DataSource = ListarProduto();
            //monta o cabeçalho do DataGridView
            dtLista.Columns[0].HeaderText = "Cod";
            dtLista.Columns[1].HeaderText = "Nome";
            dtLista.Columns[2].HeaderText = "estoque";
            dtLista.Columns[3].HeaderText = "Preço";
            dtLista.Columns[4].HeaderText = "Descrição";
            dtLista.Columns[5].HeaderText = "Autor";
            dtLista.Columns[6].HeaderText = "Gênero";
            //tamanho das colunas
            dtLista.Columns[0].Width = 50;
            dtLista.Columns[1].Width = 150;
            dtLista.Columns[2].Width = 50;
            dtLista.Columns[3].Width = 50;
            dtLista.Columns[4].Width = 160;
            dtLista.Columns[5].Width = 120;
            dtLista.Columns[6].Width = 90;

            //faz com que selecione a linha toda do DataGridView
            dtLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //permissôes do usuario
            dtLista.AllowUserToAddRows = false;
            dtLista.AllowUserToDeleteRows = false;
            dtLista.ReadOnly = true;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            AtualizaEstoque();
        }
        public void AtualizaEstoque()
        {
            try
            {
                if (dtCarrinho.Rows.Count > 0)
                {
                    //enumera os elementos da lista e executa os comandos para cada um deles
                    foreach (DataGridViewRow row in dtCarrinho.Rows)
                    {
                        int codigo = Convert.ToInt32(row.Cells[2].Value);

                        Dados prod = SelecionarCarrinho(codigo); //pega os dados do produto

                        int quant = Convert.ToInt32(prod.Quantidade);
                        int estoq = Convert.ToInt32(prod.Estoque);
                        int upd = (estoq - quant);
                        prod.Estoque = upd;

                        AtualizarProduto(prod); //atualiza o produto individual
                    }

                    MessageBox.Show("Todos os produtos foram atualizados com sucesso!");
                    AtualizarCarrinho();
                    AtualizarGrid();
                }
                else
                {
                    MessageBox.Show("Não há produtos no carrinho.");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar os produtos: " + erro.Message);
            }
        }

        private void AtualizarProduto(Dados prod)
        {
            string updateQuery = "UPDATE produto SET estoque = @estoque WHERE codigo = @codigo";

            SqlConnection con = new SqlConnection(Banco.Conexao);

            using (SqlCommand cmd = new SqlCommand(updateQuery,con))
            {
                cmd.Parameters.AddWithValue("@estoque", prod.Estoque);
                cmd.Parameters.AddWithValue("@codigo", prod.Codigo);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void dtLista_MouseClick(object sender, MouseEventArgs e)
        {
            //ao clicar no DataGridView vai selecionar o cliente//
            try
            {
                //vai verificar se há uma linha selecionada no DataGridView//
                if (dtLista.SelectedRows.Count > 0)
                {
                    int linha = dtLista.SelectedRows[0].Index;
                    //vai pegar o código do produto que foi clicado//
                    int codigo = Convert.ToInt32(dtLista.Rows[linha].Cells[0].Value);
                    //chamar a classe com uma função//
                    Dados prod = SelecionarProduto(codigo);
                    if (prod != null)
                    {
                        txtCodigo.Text = prod.Codigo.ToString();
                        txtNomeM.Text = prod.Nome.ToString();
                        txtAutor.Text = prod.Autor.ToString();
                        txtDescricao.Text = prod.Descricao.ToString();
                        txtValorU.Text = prod.Preco.ToString();
                        txtEstoque.Text = prod.Estoque.ToString();
                        txtCategoria.Text = prod.Categoria.ToString();
                        txtQuantidade.Text = prod.Quantidade.ToString();
                    }
                    else
                    {
                        MessageBox.Show("O produto selecionado não existe.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("erro ao tentar carregar dados");
            }
        }
        public static Dados SelecionarCarrinho(int codigo)
        {
            try
            {
                SqlConnection con = new SqlConnection(Banco.Conexao);
                con.Open();
                string SqlSelecionar = "SELECT carrinho.*,produto.*" +
                                       "FROM carrinho INNER JOIN produto ON carrinho.produto_codigo = produto.codigo";
                SqlCommand cmd = new SqlCommand(SqlSelecionar, con);
                //Vai usar o codigo para fazer a busca no banco de dados
                cmd.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;

                //Vai percorrer a tabela fazendo a leitura dos dados
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //Seguir na sequencia do banco de dados
                    Dados prod = new Dados();
                    if (prod != null)
                    {
                        prod.Codigo1 = Convert.ToInt32(dr[0]);
                        prod.Codigo = Convert.ToInt32(dr[2]);
                        prod.Quantidade = Convert.ToInt32(dr[3]);
                        prod.Nome = dr[5].ToString();
                        prod.Estoque = Convert.ToInt32(dr[6]);
                        prod.Preco = Convert.ToDecimal(dr[7]);
                        prod.Descricao = dr[8].ToString();
                        prod.Autor = dr[9].ToString();
                        prod.Categoria = dr[10].ToString();

                        con.Close();
                        return prod;
                    }
                    else
                    {
                        MessageBox.Show("O produto selecionado não existe.");
                        return prod;
                    }
                }
                else
                {
                    con.Close();
                    return null;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return null;
            }
        }
        public static Dados SelecionarProduto(int codigo)
        {
            try
            {
                SqlConnection con = new SqlConnection(Banco.Conexao);
                con.Open();
                string SqlSelecionar = "SELECT * FROM produto WHERE codigo=@codigo";
                SqlCommand cmd = new SqlCommand(SqlSelecionar, con);
                //Vai usar o codigo para fazer a busca no banco de dados
                cmd.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;

                //Vai percorrer a tabela fazendo a leitura dos dados
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //Seguir na sequencia do banco de dados
                    Dados prod = new Dados();
                    prod.Codigo = Convert.ToInt32(dr[0]);
                    prod.Nome = dr[1].ToString();
                    prod.Estoque = Convert.ToInt32(dr[2]);
                    prod.Preco = Convert.ToDecimal(dr[3]);
                    prod.Descricao = dr[4].ToString();
                    prod.Autor = dr[5].ToString();
                    prod.Categoria = dr[6].ToString();

                    con.Close();
                    return prod;
                }
                else
                {
                    con.Close();
                    return null;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return null;
            }
        }

        private void dtCarrinho_MouseClick(object sender, MouseEventArgs e)
        {
            //ao clicar no DataGridView vai selecionar o cliente//
            try
            {
                //vai verificar se há uma linha selecionada no DataGridView//
                if (dtLista.SelectedRows.Count > 0)
                {
                    int linha = dtCarrinho.SelectedRows[0].Index;
                    //vai pegar o código do produto que foi clicado//
                    int codigo = Convert.ToInt32(dtCarrinho.Rows[linha].Cells[2].Value);

                    //chamar a classe com uma função//
                    Dados prod = SelecionarCarrinho(codigo);

                        txtCod1.Text = prod.Codigo1.ToString();
                        txtCodigo.Text = prod.Codigo.ToString();
                        txtNomeM.Text = prod.Nome.ToString();
                        txtAutor.Text = prod.Autor.ToString();
                        txtDescricao.Text = prod.Descricao.ToString();
                        txtValorU.Text = prod.Preco.ToString();
                        txtEstoque.Text = prod.Estoque.ToString();
                        txtCategoria.Text = prod.Categoria.ToString();
                        txtQuantidade.Text = prod.Quantidade.ToString();
                    }
            }
            catch (Exception)
            {
                MessageBox.Show("erro ao tentar carregar dados");
            }
        }

        private void txtOk_Click(object sender, EventArgs e)
        {
            try
            {
                //Vai perguntar se deseja realmente alterar
                DialogResult resp = MessageBox.Show("Tem certeza?", "sistema",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    //vai iniciar capturando os dados alterados nos campos da tela e alterar no banco de dados
                    int linha = dtCarrinho.SelectedRows[0].Index;
                    Dados prod = new Dados();
                    prod.Codigo = Convert.ToInt32(txtCodigo.Text);
                    prod.Descricao = txtDescricao.Text;
                    prod.Nome = txtNomeM.Text;
                    prod.Estoque = Convert.ToInt32(txtEstoque.Text);
                    prod.Preco = Convert.ToDecimal(txtValorU.Text);
                    prod.Descricao = txtDescricao.Text;
                    prod.Autor = txtAutor.Text;

                    //abrir conexão
                    SqlConnection con = new SqlConnection(Banco.Conexao);
                    con.Open();
                    string sqlAlterar = "UPDATE carrinho SET categoria=@categoria,nome=@nome,estoque=@estoque,preco=@preco,descricao=@descricao,autor=@autor,quantidade=@quantidade" +
                                        "WHERE codigo=@codigo";

                    SqlCommand cmd = new SqlCommand(sqlAlterar, con);
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = prod.Codigo;
                    cmd.Parameters.Add("@categoria", SqlDbType.VarChar).Value = prod.Categoria;
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = prod.Nome;
                    cmd.Parameters.Add("@estoque", SqlDbType.Int).Value = prod.Estoque;
                    cmd.Parameters.Add("@preco", SqlDbType.Decimal).Value = prod.Preco;
                    cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = prod.Descricao;
                    cmd.Parameters.Add("@autor", SqlDbType.VarChar).Value = prod.Autor;
                    cmd.Parameters.Add("@quantidade", SqlDbType.VarChar).Value = prod.Quantidade;

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Carrinho alterado");
                    AtualizarCarrinho();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar os produtos: " + erro.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAutor.Clear();
            txtCategoria.Clear();
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtEstoque.Clear();
            txtNomeM.Clear();
            txtQuantidade.Clear();
            txtValorT.Clear();
            txtValorU.Clear();
        }

        private void txtDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                //Vai perguntar se deseja realmente alterar
                DialogResult resp = MessageBox.Show("Deseja realmente retirar o produto do carrinho?", "sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    //vai iniciar capturando os dados da tela
                    int linha = dtCarrinho.SelectedRows[0].Index;
                    Dados prod = new Dados();
                    prod.Codigo1 = Convert.ToInt32(txtCod1.Text);
                    //abrir conexão
                    SqlConnection con = new SqlConnection(Banco.Conexao);
                    con.Open();
                    string sqlAlterar = "DELETE FROM carrinho WHERE codigo=@codigo";

                    SqlCommand cmd = new SqlCommand(sqlAlterar, con);
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = prod.Codigo1;

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Produto retirado");
                    AtualizarCarrinho();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Voltar_Click(object sender, EventArgs e)
        {

            this.Close();
            var form = new MenuCliente();
            form.Show();
        }
    }
}
