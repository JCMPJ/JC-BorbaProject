using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;
using Word = Microsoft.Office.Interop.Word;

namespace ProjetoDocx
{
    public partial class EditForm : Form
    {
        readonly List<string> listAcReclamante = new List<string>();
        readonly List<string> listAcReclamada = new List<string>();
        readonly string homepag = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        readonly string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        Laudo laudo = new Laudo();
        private int id;

        public EditForm(int arg)
        {
            InitializeComponent();
            id = arg;
        }

        private void Inicio(object sender, EventArgs e)
        {
            DataTable dt = DB.SelectFromId(id);

            if (dt.Rows.Count > 0)
            {

                string str_id = dt.Rows[0].ItemArray[0].ToString();
                tbProcesso.Text = dt.Rows[0].Field<string>("numProcesso");
                tbReclamante.Text = dt.Rows[0].Field<string>("nomeReclamante");
                tbReclamada.Text = dt.Rows[0].Field<string>("nomeReclamada");
                tbDataVistoria.Text = dt.Rows[0].Field<string>("dataVistoria");
                tbHoraInicio.Text = dt.Rows[0].Field<string>("horaVistoria");
                tbLocalVistoria.Text = dt.Rows[0].Field<string>("localVistoriado");
                tbEndLocal.Text = dt.Rows[0].Field<string>("enderecoVistoriado");                
                tbDataIniPeriodo.Text  = dt.Rows[0].Field<string>("dataInicioPeriodoReclamado");                
                tbDataFimPeriodo.Text = dt.Rows[0].Field<string>("dataFimPeriodoReclamado");
                tbFuncaoExercida.Text = dt.Rows[0].Field<string>("funcaoExercida");
                tbCidadeEmissao.Text = dt.Rows[0].Field<string>("cidadeEmissao");
                tbDataEmissao.Text = dt.Rows[0].Field<string>("dataEmissao");
                string dataCriacao = dt.Rows[0].Field<string>("dataCriacao");

                tbProcesso.Focus();
            }
        }

        private void BtnMontar_Click(object sender, EventArgs e)
        {

        }

        private bool InserirNaLista(TextBox tb, ListBox lb, List<string> lista)
        {
            if (!string.IsNullOrEmpty(tb.Text))
            {
                lista.Add(tb.Text);
                tb.Text = null;
                tb.Focus();

                lb.DataSource = null;
                lb.DataSource = lista;

                return true;
            }
            else
            {
                return false;
            }

        }

        internal void EditarAcompanhante(string nome, string nomeAnterior, ListBox lb, List<string> lista)
        {
            Console.WriteLine("FORA DO IF Nome:..." + nome + "Nome anterior:..." + nomeAnterior);
            if (!nome.Equals(nomeAnterior))
            {
                Console.WriteLine("DENTRO DO IF Nome:..." + nome + "Nome anterior:..." + nomeAnterior);
                lista[lb.SelectedIndex] = nome;
                lb.DataSource = null;
                lb.DataSource = lista;
            }
        }

        private void CMSI_EditarRemoverReclamante(object sender, ToolStripItemClickedEventArgs e)
        {
            string btnNome = e.ClickedItem.Name.ToString();
            // (smExcluir, smEditar): Reclamante; editarReclamada, excuirReclamada
            ListBox lb;
            List<string> li;
            lb = lboxReclamante;
            li = listAcReclamante;
            EditarExcluir(btnNome, lb, li);
        }

        private void CMSI_EditarRemoverReclamada(object sender, ToolStripItemClickedEventArgs e)
        {
            string btnNome = e.ClickedItem.Name.ToString();
            // (smExcluir, smEditar): Reclamante; editarReclamada, excuirReclamada
            ListBox lb;
            List<string> li;
            lb = lboxReclamada;
            li = listAcReclamada;
            EditarExcluir(btnNome, lb, li);
        }
        private void EditarExcluir(string acao, ListBox lb, List<string> lista)
        {
            // Editar
            if (acao == "smEditar" || acao == "editarReclamada")
            {

            }
            // Excluir
            if (acao == "smExcluir" || acao == "excluirReclamada")
            {
                string caption = "Tem certeza que quer remover?";
                string message = lb.Text;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    lista.RemoveAt(lb.SelectedIndex);
                    lb.DataSource = null;
                    lb.DataSource = lista;
                }
            }
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                TextBox tb = (TextBox)sender;
                string str = tb.Name;
                if (str == "tbTesReclamante")
                {
                    this.InserirNaLista(tbTesReclamante, lboxReclamante, listAcReclamante);
                }
                else if (str == "tbTesReclamada")
                {
                    this.InserirNaLista(tbTesReclamada, lboxReclamada, listAcReclamada);
                }
            }
        }

        private void LboxAcompanhantesReclamante_Opening(object sender, CancelEventArgs e)
        {

        }

        private void BTN_InsLwReclamante_Click(object sender, EventArgs e)
        {
            this.InserirNaLista(tbTesReclamante, lboxReclamante, listAcReclamante);
        }

        private void BTN_InsLwReclamada_Click(object sender, EventArgs e)
        {
            this.InserirNaLista(tbTesReclamada, lboxReclamada, listAcReclamada);
        }
    }
}
