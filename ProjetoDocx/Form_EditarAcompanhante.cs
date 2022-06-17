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
    public partial class Form_EditarAcompanhante : Form
    {

        private static readonly string empty = string.Empty;
        string nomeNovo = empty;        
        readonly string nomeVelho = empty;
        readonly ListBox lbo;
        readonly List<string> lis;
        readonly RegisterForm form1;
        

        public Form_EditarAcompanhante(string nome, RegisterForm parent, ListBox lb, List<string> li)
        {
            InitializeComponent();

            form1 = parent;
            nomeVelho = nome;
            lbo = lb;
            lis = li;
            tb_EditarAcompanhante.Text = nome;
        }

        private void BTN_EditarAcompanhante_Click(object sender, EventArgs e)
        {
            nomeNovo = tb_EditarAcompanhante.Text;
            Close();
        }        

        private void BTN_CancelAcompanhante_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_EditarAcompanhante_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.EditarAcompanhante(nomeNovo, nomeVelho, lbo, lis);
        }
    }
}
