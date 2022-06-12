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
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;
using Word = Microsoft.Office.Interop.Word;

namespace ProjetoDocx
{
    public partial class Form1 : Form
    {
        List<string> listAcReclamante = new List<string>();
        List<string> listAcReclamada = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMontar_Click(object sender, EventArgs e)
        {
            string tx;
            string path = Directory.GetCurrentDirectory();
            try
            {
                using (DocX documento = DocX.Load(path + "\\modelo-v01.docx"))
                {
                    tx = tbProcesso.Text;
                    documento.ReplaceText("#numProcesso", tx.Replace(',', '.'));

                    tx = tbReclamante.Text;
                    documento.ReplaceText("#nomeReclamante", tx.ToUpper());

                    tx = tbReclamada.Text;
                    documento.ReplaceText("#nomeReclamada", tx.ToUpper());

                    documento.ReplaceText("#dataVistoria", tbDataVistoria.Text);
                    documento.ReplaceText("#horaVistoria", tbHoraInicio.Text);
                    documento.ReplaceText("#localVistoriado", tbLocalVistoria.Text);
                    documento.ReplaceText("#enderecoVistoriado", tbEndLocal.Text);

                    documento.ReplaceText("#inicioPeriodoReclamado", tbDataIniPeriodo.Text);
                    documento.ReplaceText("#fimPeriodoReclamado", tbDataFimPeriodo.Text);

                    tx = tbFuncaoExercida.Text;
                    documento.ReplaceText("#FUNCAO", tx.ToUpper());

                    // Montar local e data da emissão do laudo
                    string[] meses = {"" , "janeiro", "fevereiro", "março", "abril", "maio", "junho",
                                  "julho", "agosto", "setembro", "outubro", "novembro", "dezembro"};

                    string dma = tbDataEmissao.Text;
                    if (!string.IsNullOrEmpty(dma) && !string.IsNullOrEmpty(tbCidadeEmissao.Text))
                    {
                        string dia, mes, ano, strmes, data;
                        string[] arrDMA = dma.Split('/');
                        dia = arrDMA[0];
                        mes = arrDMA[1];
                        strmes = meses[Int32.Parse(mes)];
                        ano = arrDMA[2];
                        data = $"{tbCidadeEmissao.Text}, {dia} de {strmes} de {ano}";

                        documento.ReplaceText("#localDataEmissao", data);
                    }

                    documento.SaveAs(path + "\\novo-documento.docx");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return;
            }

            this.AbrirDoc("novo-documento.docx");

            //Close this form.
            //this.Close();
        }

        private void AbrirDoc(string nomeDoc)
        {
            object oMissing = System.Reflection.Missing.Value;

            // string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            string path = Directory.GetCurrentDirectory();
            string c = path + "\\novo-documento.docx";
            object oTemplate = c;

            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();

            oDoc = oWord.Documents.Add(ref oTemplate, ref oMissing, ref oMissing, ref oMissing);

            string nomes = "";
            foreach (Word.Paragraph paragrafo in oDoc.Paragraphs)
            {
                string txtParagrafo = paragrafo.Range.Text;
                if (txtParagrafo.IndexOf("#PeloReclamante") >= 0)
                {
                    nomes = "";
                    foreach(string n in listAcReclamante)
                    {
                        nomes += "\t" + n + "\r\n";
                    }
                    paragrafo.Range.Select();
                    paragrafo.Reset();
                    paragrafo.set_Style("Normal");
                    paragrafo.Range.Font.Size = 12;
                    paragrafo.Range.Font.Name = "Arial";
                    paragrafo.Range.Font.Bold = 0;
                    paragrafo.Range.Text = nomes;
                    
                }
                else if (txtParagrafo.IndexOf("#PelaReclamada") >= 0)
                {
                    nomes = "";
                    foreach (string n in listAcReclamada)
                    {
                        nomes += "\t" + n + "\r\n";
                    }
                    paragrafo.Range.Select();
                    paragrafo.Reset();
                    paragrafo.set_Style("Normal");
                    paragrafo.Range.Font.Size = 12;
                    paragrafo.Range.Font.Name = "Arial";
                    paragrafo.Range.Font.Bold = 0;
                    paragrafo.Range.Text = nomes;
                }
            }
            oWord.Visible = true;
            try
            {
                //oDoc.Save();
            }
            catch (Exception e)
            {
                DialogResult dialogResult = MessageBox.Show(e.Message);
                oDoc = null;
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

        private void btnInsLwReclamante_Click(object sender, EventArgs e)
        {
            this.InserirNaLista(tbTesReclamante, lboxReclamante, listAcReclamante);
        }

        private void btnInsLwReclamada_Click(object sender, EventArgs e)
        {
            this.InserirNaLista(tbTesReclamada, lboxReclamada, listAcReclamada);
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

        private void Inicio(object sender, EventArgs e)
        {
            tbProcesso.Focus();
        }
    }
}
