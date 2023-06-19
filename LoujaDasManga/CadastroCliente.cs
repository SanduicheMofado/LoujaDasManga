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

namespace LoujaDasManga
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            //fecha a janela atual e abre janela de Login

            this.Close();
            var form = new LoginCliente();
            form.Show();
        }
        public static DataTable CarregarUF()
        {
            try
            {
                //abre conexão com o banco de dados

                SqlConnection con = new SqlConnection(Banco.Conexao);
                con.Open();

                //armazena o comando "SELECT *" na variavel sql

                string sql = "SELECT * FROM uf";

                //executa um comando sql

                SqlCommand cmd = new SqlCommand(sql, con);

                //faz leitura dos dados

                SqlDataReader dr = cmd.ExecuteReader();

                //cria tabela

                DataTable dt = new DataTable();

                //vai carregar os dados obtidos

                dt.Load(dr);

                //retorna as informações para cbUF

                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private bool ValidaSenha(string vsenha)
        {
            return vsenha.Any(ch => !char.IsLetterOrDigit(ch));
        }
        private void bntEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                //verifica cpf através da função "IsValidCpf"
                string cpf = txtCPF.Text;
                if (IsValidCpf(cpf))
                {
                    if (txtNome.Text == string.Empty || txtTelefone.Text == string.Empty || txtNascimento.Text == string.Empty || txtCPF.Text == string.Empty || txtSenha.Text == string.Empty)
                    {
                        MessageBox.Show("PREECHA TODOS OS CAMPOS!", "ERRO\n", MessageBoxButtons.OK);
                    }
                    else if (ValidaSenha(txtSenha.Text) == false)
                    {
                        //abre conexão

                        SqlConnection con = new SqlConnection(Banco.Conexao);
                        con.Open();
                        string sqlinserir = "INSERT INTO cliente(nome,dtnascimento,telefone,cpf,senha)" +
                                            "VALUES (@nome,@dtnascimento,@telefone,@cpf,@senha)";
                        SqlCommand cmd = new SqlCommand(sqlinserir, con);

                        //especifica cada campo com seu valor

                        cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
                        cmd.Parameters.Add("@dtnascimento", SqlDbType.Date).Value = Convert.ToDateTime(txtNascimento.Text);
                        cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = txtTelefone.Text;
                        cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = txtCPF.Text;
                        cmd.Parameters.Add("@senha", SqlDbType.Int).Value = Convert.ToInt32(txtSenha.Text);

                        //vai executar e inserir no banco
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cadastrado com sucesso", "!\n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();

                        this.Close();
                        var form = new LoginCliente();
                        form.Show();
                    }
                    else if (ValidaSenha(txtSenha.Text) == true)
                    {
                        MessageBox.Show("CARATERES ESPECIAIS NÃO SÃO PERMITIDOS");
                    }
                }
                else
                {
                    MessageBox.Show("CPF INVALIDO!!");
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        public static bool IsValidCpf(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                return false;

            // Remove qualquer caractere que não seja um número
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // Verifica se o CPF possui 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Verifica se todos os dígitos são iguais
            if (cpf.Distinct().Count() == 1)
                return false;

            // Calcula o primeiro dígito verificador
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                sum += int.Parse(cpf[i].ToString()) * (10 - i);
            }
            int mod = sum % 11;
            int digit1 = mod < 2 ? 0 : 11 - mod;

            // Verifica se o primeiro dígito verificador está correto
            if (int.Parse(cpf[9].ToString()) != digit1)
                return false;

            // Calcula o segundo dígito verificador
            sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += int.Parse(cpf[i].ToString()) * (11 - i);
            }
            mod = sum % 11;
            int digit2 = mod < 2 ? 0 : 11 - mod;

            // Verifica se o segundo dígito verificador está correto
            if (int.Parse(cpf[10].ToString()) != digit2)
                return false;

            return true;
        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            string cpf = txtCPF.Text;
            if (IsValidCpf(cpf))
            {
                lblCheck.Visible = true;
                lblCheck.Text = "√";
                lblCheck.ForeColor = Color.Green;
            }
            else
            {
                lblCheck.Visible = true;
                lblCheck.Text = "X";
                lblCheck.ForeColor = Color.Red;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCPF.Clear();
            txtNascimento.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtTelefone.Clear();
        }
    }
}
