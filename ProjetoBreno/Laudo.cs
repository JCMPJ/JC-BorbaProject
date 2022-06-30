using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Xceed.Words.NET;
using Word = Microsoft.Office.Interop.Word;

namespace ProjetoBreno
{
    class Laudo
    {
        public int id;
        public string numProcesso;
        public string nomeReclamante;
        public string nomeReclamada;
        public string dataVistoria;
        public string horaVistoria;
        public string localVistoriado;
        public string enderecoVistoriado;
        public string dataInicioPeriodoReclamado;
        public string dataFimPeriodoReclamado;
        public string funcaoExercida;
        public string cidadeEmissao;
        public string dataEmissao;
        public string acompanhantesReclamante;
        public string acompanhantesReclamada;
        public string dataCriacao;

        public Laudo() { }
    }
}
