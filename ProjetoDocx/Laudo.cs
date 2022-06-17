using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDocx
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

        private static SQLiteConnection conn;

        public Laudo() { }
    }
}
