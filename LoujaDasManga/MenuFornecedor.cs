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
    public partial class MenuFornecedor : Form
    {
        public MenuFornecedor()
        {
            InitializeComponent();
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new CatalogoFornecedor();
            form.Show();
        }
    }
}
