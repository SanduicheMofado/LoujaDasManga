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

namespace LoujaDasManga
{
    public partial class LoginFornecedor : Form
    {
        public LoginFornecedor()
        {
            InitializeComponent();
        }

        private void bntCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new CadastroFornecedor();
            form.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "!\n", MessageBoxButtons.OK);
            }
            else if (txtNome.Text=="adm" && txtSenha.Text=="123")
            {
                this.Hide();
                var form = new MenuFornecedor();
                form.Show();
            }
            else
            {
                try
                {
                    string nome = txtNome.Text, senha = txtSenha.Text;

                    SqlConnection con = new SqlConnection(Banco.Conexao);
                    con.Open();

                    //Vai usar os valores para fazer a busca no banco de dados
                    string qry = "SELECT * FROM fornecedor WHERE nome='" + nome + "' AND senha='" + senha + "'";

                    //Vai percorrer a tabela fazendo a leitura dos dados
                    SqlCommand cmd = new SqlCommand(qry, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        MessageBox.Show("Logado com sucesso", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        var form = new MenuFornecedor();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário e/ou senha incorretos. \n Tente novamente!", "!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    con.Close();
                }
                catch { }
            }
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var form = new Cliente_Fornecedor();
            form.Show();
        }
    }
}
