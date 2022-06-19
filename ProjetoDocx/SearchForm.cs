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

namespace ProjetoDocx
{
    public partial class SearchForm : Form
    {

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

                sql = $"SELECT numProcesso, nomeReclamante, nomeReclamada, dataEmissao FROM laudos WHERE {campo} LIKE '{nome}%'";
                
                dt = DB.SelectFromSql(sql);
                //dt = DB.Listar();

                if (dt.Rows.Count > 0)
                {
                    // Method 1 - direct method
                    // dataGridView1.DataSource = dt;

                    // Method 2 - DG Columns
                    // dataGridView2.Columns[0].Visible = false;
                    dataGridView2.AutoGenerateColumns = false;
                    dataGridView2.DataSource = dt;
                }
                else
                {
                    // dataGridView2.Rows.Clear();
                    // dataGridView2.Refresh();
                    dt.Clear();
                    dataGridView2.DataSource = dt;
                }
            }
            else
            {
                // MessageBox.Show("Informe o Nome a ser procurado");
                return;
            }
            // MessageBox.Show(sql);
        }
    }
}
