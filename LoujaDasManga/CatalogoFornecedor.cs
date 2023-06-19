using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LoujaDasManga.Dados;

namespace LoujaDasManga
{
    public partial class CatalogoFornecedor : Form
    {
        public CatalogoFornecedor()
        {
            InitializeComponent();
            AtualizarGrid();
            //vai carregar a lista
            cbListaCateg.DataSource = CarregarCateg();
            //exibir a categoria
            cbListaCateg.DisplayMember = "nome";
            //valor do elemento
            cbListaCateg.ValueMember = "codigo";


            cbCategoria.DataSource = CarregarCateg();
            //
            cbCategoria.DisplayMember = "nome";
            //
            cbCategoria.ValueMember = "codigo";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                //Vai perguntar se deseja realmente alterar
                DialogResult resp = MessageBox.Show("Deseja realmente alterar os dados do cliente", "sistema",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    //vai iniciar capturando os dados alterados nos campos da tela e alterar no banco de dados
                    int linha = dtLista.SelectedRows[0].Index;
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
                    string sqlAlterar = "UPDATE produto SET categoria=@categoria,nome=@nome,estoque=@estoque,preco=@preco,descricao=@descricao,autor=@autor";

                    SqlCommand cmd = new SqlCommand(sqlAlterar, con);
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = prod.Codigo;
                    cmd.Parameters.Add("@categoria", SqlDbType.VarChar).Value = prod.Categoria;
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = prod.Nome;
                    cmd.Parameters.Add("@estoque", SqlDbType.Int).Value = prod.Estoque;
                    cmd.Parameters.Add("@preco", SqlDbType.Decimal).Value = prod.Preco;
                    cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = prod.Descricao;
                    cmd.Parameters.Add("@autor", SqlDbType.VarChar).Value = prod.Autor;

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Produto alterado com sucesso");
                    AtualizarGrid();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao editar os produtos: " + erro.Message);
            }
        }
        public static DataTable ListarProduto()//retorna o produto
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
        public void AtualizarGrid()
        {
            //O comando datasource faz com que os dados vindos do ListarProduto(), carreguem dentro do DataGridView da lista
            dtLista.DataSource = ListarProduto();
            //montando o DataGridView com o cabeçalho
            dtLista.Columns[0].HeaderText = "Cod";
            dtLista.Columns[1].HeaderText = "Nome";
            dtLista.Columns[2].HeaderText = "estoque";
            dtLista.Columns[3].HeaderText = "Preço";
            dtLista.Columns[4].HeaderText = "Descrição";
            dtLista.Columns[5].HeaderText = "Autor";
            dtLista.Columns[6].HeaderText = "Gênero";
            //e tamanho das colunas
            dtLista.Columns[0].Width = 50;
            dtLista.Columns[1].Width = 150;
            dtLista.Columns[2].Width = 50;
            dtLista.Columns[3].Width = 50;
            dtLista.Columns[4].Width = 160;
            dtLista.Columns[5].Width = 120;
            dtLista.Columns[6].Width = 90;

            //faz com que selecione a linha toda do DataGridView
            dtLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //primissôes do usuario
            dtLista.AllowUserToAddRows = false;
            dtLista.AllowUserToDeleteRows = false;
            dtLista.ReadOnly = true;
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
                        cbCategoria.Text = prod.Categoria.ToString();
                    }
                    else
                    {
                        // Handle the case where the product is null
                        MessageBox.Show("O produto selecionado não existe.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("erro ao tentar carregar dados");
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

        private void txtAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomeM.Text == string.Empty || txtValorU.Text == string.Empty || txtAutor.Text == string.Empty)
                {
                    MessageBox.Show("PREECHA TODOS OS CAMPOS!", "ERRO\n", MessageBoxButtons.OK);
                }
                else
                {
                    //abrir conexão
                    SqlConnection con = new SqlConnection(Banco.Conexao);
                    con.Open();
                    string sqlinserir = "INSERT INTO produto(categoria,nome,estoque,preco,descricao,autor)" +
                        "VALUES (@categoria,@nome,@estoque,@preco,@descricao,@autor)";
                    SqlCommand cmd = new SqlCommand(sqlinserir, con);
                    //especificar cada campo com seu valor da tela
                    cmd.Parameters.Add("@categoria", SqlDbType.VarChar).Value = cbCategoria.Text;
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNomeM.Text;
                    cmd.Parameters.Add("@estoque", SqlDbType.Int).Value = Convert.ToInt32(txtEstoque.Text);
                    cmd.Parameters.Add("@preco", SqlDbType.Decimal).Value = Convert.ToDecimal(txtValorU.Text);
                    cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = txtDescricao.Text;
                    cmd.Parameters.Add("@autor", SqlDbType.VarChar).Value = txtAutor.Text;
                    //se tudo estver ok vai executar e inserir no banco
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("DADOS ENVIADOS COM SUCESSO!", "SUCESSO\n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    AtualizarGrid();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao adicionar os produtos: " + erro.Message);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
        }

        private void cbListaCateg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAutor.Clear();
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtEstoque.Clear();
            txtNomeM.Clear();
            txtValorU.Clear();
            cbCategoria.SelectedIndex = 0;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            try
            {
                //Vai perguntar se deseja realmente alterar
                DialogResult resp = MessageBox.Show("Deseja realmente deletar o produto?", "sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    //vai iniciar capturando os dados da tela
                    int linha = dtCarrinho.SelectedRows[0].Index;
                    Dados prod = new Dados();
                    prod.Codigo = Convert.ToInt32(txtCodigo.Text);
                    //abrir conexão
                    SqlConnection con = new SqlConnection(Banco.Conexao);
                    con.Open();
                    string sqlAlterar = "DELETE FROM produto WHERE codigo=@codigo";

                    SqlCommand cmd = new SqlCommand(sqlAlterar, con);
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = prod.Codigo;

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Produto retirado");
                    AtualizarGrid();
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
            var form = new MenuFornecedor();
            form.Show();
        }
    }
}
