using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using Microsoft.Data.Sqlite;
using Word = Microsoft.Office.Interop.Word;
using System.Text.RegularExpressions;

namespace ProjetoDocx
{
    public partial class SearchForm : Form
    {
        readonly string homepag = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        readonly string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

        public int iddb { get; set; }
        public bool flag = false;

        public SearchForm()
        {
            InitializeComponent();
            rbtnReclamante.Checked = true;
        }

        private void Searchdb(object sender, EventArgs e)
        {
            string campo = "";
            string nome = "";
            string sql = "";

            DataTable dt = new DataTable();

            nome = tbNomeProcurado.Text.Trim();
            if (!string.IsNullOrEmpty(nome))
            {


                //campo =  groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;

                foreach (RadioButton rb in groupBox1.Controls)
                {
                    if (rb.Checked)
                    {
                        campo = rb.Text;
                    }
                }
                if (campo == "Reclamante")
                {
                    campo = "nomeReclamante";
                }
                else if (campo == "Reclamada")
                {
                    campo = "nomeReclamada";
                }
                else
                {
                    campo = "nomeReclamante";
                }

                sql = $"SELECT id, numProcesso, nomeReclamante, nomeReclamada, dataEmissao FROM laudos WHERE {campo} LIKE '{nome}%'";
                
                dt = DB.SelectFromSql(sql);
                //dt = DB.Listar();

                if (dt.Rows.Count > 0)
                {
                    // Method 1 - direct method
                    // dataGridView1.DataSource = dt;

                    // Method 2 - DG Columns
                    // dataGridView2.Columns[0].Visible = false;
                    dgvLaudos.AutoGenerateColumns = false;
                    dgvLaudos.DataSource = dt;
                }
                else
                {
                    // dataGridView2.Rows.Clear();
                    // dataGridView2.Refresh();
                    dt.Clear();
                    dgvLaudos.DataSource = dt;
                }
            }
            else
            {
                // MessageBox.Show("Informe o Nome a ser procurado");
                return;
            }
            // MessageBox.Show(sql);
        }

        private void btnEditarLaudo_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha = dgvLaudos.CurrentRow;
            if (!object.ReferenceEquals(linha, null))
            {
                int colunas = linha.Index;
                string id = dgvLaudos.Rows[colunas].Cells[0].Value.ToString();

                //MessageBox.Show("Id Selecionado: " + id, "Valor da seleção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int paramId = int.Parse(id);
                iddb = paramId;
                flag = true;
                this.Close();
                //AbrirDoc(paramId);
            }
            else
            {
                MessageBox.Show("Nenhum laudo selecionado", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AbrirDoc(int id)
        {
            object oMissing = System.Reflection.Missing.Value;
            string sequential_number;
            string numProcesso;
            string dataCriacao;
            string path;

            DataTable dt = DB.SelectFromId(id);

            if (dt.Rows.Count > 0)
            {

                string str_id = dt.Rows[0].ItemArray[0].ToString();
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
                numProcesso = dt.Rows[0].Field<string>("numProcesso");
                dataCriacao = dt.Rows[0].Field<string>("dataCriacao");
                Regex rgx = new Regex("/");
                string data = rgx.Replace(dataCriacao, "");

                path = appPath + "\\laudos\\1234567-12.1234.1.15.5555\\" + "014-1234567-12.1234.1.15.5555-19062022.docx";
                //path = appPath + "\\laudos\\" + numProcesso + "\\" + sequential_number + "-" + numProcesso + "-" + data + ".docx";
                Console.WriteLine("PATH:..." + path);
                object oTemplate = path;

                Word._Application oWord;
                Word._Document oDoc;
                oWord = new Word.Application();
                try
                {                    
                    oDoc = oWord.Documents.Add(ref oTemplate, ref oMissing, ref oMissing, ref oMissing);
                    // oDoc.Saved = true;
                    // Abre o documento no Word
                    oWord.Visible = true;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
               
            }
            else
            {
                return;
            }
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag)
            {
                EditForm editForm = new EditForm(iddb);
                editForm.ShowDialog();
                flag = false;
            }
            
        }
    }
}