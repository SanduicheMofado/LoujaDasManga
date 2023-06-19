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
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var form = new LoginCliente();
            form.Show();
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            this.Close();
            var form = new CatalogoCliente();
            form.Show();
        }
    }
}
