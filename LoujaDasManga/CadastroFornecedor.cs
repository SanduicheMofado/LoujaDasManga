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
    public partial class CadastroFornecedor : Form
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }
        private bool ValidaSenha(string vsenha)
        {
            return vsenha.Any(ch => !char.IsLetterOrDigit(ch));
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //verifica cpf através da função "ValidarCpf"

                string cpf = txtCPF.Text;
                if (ValidarCpf(cpf))
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
                        string sqlinserir = "INSERT INTO fornecedor(nome,dtnascimento,telefone,cpf,senha)" +
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
                        var form = new LoginFornecedor();
                        form.Show();
                    }
                }
                else if (ValidaSenha(txtSenha.Text) == true)
                {
                    MessageBox.Show("CARATERES ESPECIAIS NÃO SÃO PERMITIDOS");
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
        public static bool ValidarCpf(string cpf)
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
        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            string cpf = txtCPF.Text;
            if (ValidarCpf(cpf))
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
            txtTelefone.Clear();
        }
    }
}
