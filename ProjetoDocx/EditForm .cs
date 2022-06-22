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

        string sequential_number;
        string numProcesso;
        string dataCriacao;
        string path;
        string str_id;

        string acompanhantesReclamada = null;
        string acompanhantesReclamante= null;

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

                str_id = dt.Rows[0].ItemArray[0].ToString();
                Console.WriteLine("Id:..." + str_id);
                numProcesso = dt.Rows[0].Field<string>("numProcesso");
                tbProcesso.Text = numProcesso;
                tbReclamante.Text = dt.Rows[0].Field<string>("nomeReclamante");
                tbReclamada.Text = dt.Rows[0].Field<string>("nomeReclamada");
                tbDataVistoria.Text = dt.Rows[0].Field<string>("dataVistoria");
                tbHoraInicio.Text = dt.Rows[0].Field<string>("horaVistoria");
                tbLocalVistoria.Text = dt.Rows[0].Field<string>("localVistoriado");
                tbEndLocal.Text = dt.Rows[0].Field<string>("enderecoVistoriado");
                tbDataIniPeriodo.Text = dt.Rows[0].Field<string>("dataInicioPeriodoReclamado");
                tbDataFimPeriodo.Text = dt.Rows[0].Field<string>("dataFimPeriodoReclamado");
                tbFuncaoExercida.Text = dt.Rows[0].Field<string>("funcaoExercida");
                tbCidadeEmissao.Text = dt.Rows[0].Field<string>("cidadeEmissao");
                tbDataEmissao.Text = dt.Rows[0].Field<string>("dataEmissao");
                dataCriacao = dt.Rows[0].Field<string>("dataCriacao");
                acompanhantesReclamante = dt.Rows[0].Field<string>("acompanhantesReclamante");
                acompanhantesReclamada = dt.Rows[0].Field<string>("acompanhantesReclamada");
                
                PreencherListaReclamantes();
                PreencherListaReclamadas();

                tbProcesso.Focus();
            }
        }

        private void BtnMontar_Click(object sender, EventArgs e)
        {

        }

        private void PreencherListaReclamantes()
        {            
            acompanhantesReclamante = acompanhantesReclamante.Trim();
            string[] nomes = acompanhantesReclamante.Split('\r');
            
            InserirNaLista(nomes, lboxReclamante, listAcReclamante);
        }

        private void PreencherListaReclamadas()
        {
            
            acompanhantesReclamada = acompanhantesReclamada.Trim();
            
            string[] nomes = acompanhantesReclamada.Split('\r');

            InserirNaLista(nomes, lboxReclamada, listAcReclamada);
        }

        private void InserirNaLista(string[] nomes, ListBox lb, List<string> lista)
        {
            string n;
            foreach (string nome in nomes)
            {
                n = nome.Trim();
                lista.Add(n);

                lb.DataSource = null;
                lb.DataSource = lista;
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
            /*
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
            */
        }

        private void BTN_InsLwReclamante_Click(object sender, EventArgs e)
        {
            // this.InserirNaLista(tbTesReclamante, lboxReclamante, listAcReclamante);
        }

        private void BTN_InsLwReclamada_Click(object sender, EventArgs e)
        {
            // this.InserirNaLista(tbTesReclamada, lboxReclamada, listAcReclamada);
        }

        private void btnAbrirWord_Click(object sender, EventArgs e)
        {
            object oMissing = System.Reflection.Missing.Value;
            string data = "";

            //string str_id = dt.Rows[0].ItemArray[0].ToString();
            //Int16 idBd = dt.Rows[0].Field<Int16>("id");
            //sequential_number = Convert.ToString(id);
            sequential_number = str_id.Trim();
            int idBd = int.Parse(str_id);

            if (idBd < 10)
            {
                sequential_number = "00" + sequential_number;
            }
            else if (idBd < 100)
            {
                sequential_number = "0" + sequential_number;
            }
            //numProcesso = dt.Rows[0].Field<string>("numProcesso");
            //dataCriacao = dt.Rows[0].Field<string>("dataCriacao");
            if (!string.IsNullOrEmpty(dataCriacao))
            {
                Regex rgx = new Regex("/");
                data = rgx.Replace(dataCriacao, "");
            }
            else
            {
                MessageBox.Show("Erros dataCriacao: " + dataCriacao);
                return;
            }


            //path = appPath + "\\laudos\\1234567-12.1234.1.15.5555\\" + "014-1234567-12.1234.1.15.5555-19062022.docx";
            path = appPath + "\\laudos\\" + numProcesso + "\\" + sequential_number + "-" + numProcesso + "-" + data + ".docx";
            Console.WriteLine("PATH:..." + path);

            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            if (File.Exists(path))
            {
                oDoc = oWord.Documents.Open(path, ReadOnly: true);
                //oDoc.Activate();
                oWord.Visible = true;
            }
            else
            {
                MessageBox.Show("Erro o arquivo não foi encontrado!\n" + path);
            }

        }
    }
}
