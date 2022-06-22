using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDocx
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void novoLaudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterForm form1 = new RegisterForm();
            form1.ShowDialog();
        }

        private void pesquizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrirDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirDocumento abrirDocumento = new AbrirDocumento();
            abrirDocumento.ShowDialog();
        }
    }
}
