using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using Word = Microsoft.Office.Interop.Word;


namespace ProjetoDocx
{
    public partial class AbrirDocumento : Form
    {
        readonly string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

        public AbrirDocumento()
        {
            InitializeComponent();
        }

        private void AbrirDocumento_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            object oMissing = System.Reflection.Missing.Value;

            // string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            string path = appPath + "\\laudos\\1234567-12.1234.1.15.5555\\" + "014-1234567-12.1234.1.15.5555-19062022.docx";

            object oTemplate = path;

            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oDoc = oWord.Documents.Open(path, ReadOnly: true);
            //oDoc.Activate();
            oWord.Visible = true;
        }
    }
}
