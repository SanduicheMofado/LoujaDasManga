using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoujaDasManga
{
    public partial class Cliente_Fornecedor : Form
    {
        public Cliente_Fornecedor()
        {
            InitializeComponent();
        }

        private void txtCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new LoginCliente();
            form.Show();
        }

        private void txtFornecedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new LoginFornecedor();
            form.Show();
        }
    }
}
