using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace ProjetoDocx
{
    class DB
    {
        private static SQLiteConnection conn;

        public static SQLiteConnection Conectar()
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            string connString = "Data Source=" + appPath + "\\dbdocX.db";

            conn = new SQLiteConnection(connString);
            conn.Open();
            return conn;
        }

        public static DataTable Listar()
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da;

            try
            {
                using (var cmd = Conectar().CreateCommand())
                {
                    cmd.CommandText = @"SELECT * FROM laudos";
                    da = new SQLiteDataAdapter(cmd.CommandText, Conectar());
                    da.Fill(dt);

                    return dt;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable SelectFromId(int id)
        {
            DataTable dt = new DataTable();
            //SQLiteDataAdapter da;

            try
            {                
                var db = DB.Conectar();
                SQLiteCommand cmd = db.CreateCommand();
                cmd.CommandText = @"SELECT * FROM laudos WHERE id = '" + id + "'";
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, Conectar());
                da.Fill(dt);
                
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void CreateNew(Laudo laudo)
        {
            try
            {
                var cmd = DB.Conectar().CreateCommand();

                string sql = "INSERT INTO laudos (" +
                    "numProcesso, nomeReclamante, nomeReclamada, dataVistoria, horaVistoria, localVistoriado, " +
                    "enderecoVistoriado, dataInicioPeriodoReclamado, dataFimPeriodoReclamado, " +
                    "funcaoExercida, cidadeEmissao, dataEmissao, dataCriacao, " +
                    "acompanhantesReclamante, acompanhantesReclamada) " +
                    "VALUES (" +
                    "@numProcesso, @nomeReclamante, @nomeReclamada, @dataVistoria, @horaVistoria, @localVistoriado, " +
                    "@enderecoVistoriado, @dataInicioPeriodoReclamado, @dataFimPeriodoReclamado, " +
                    "@funcaoExercida, @cidadeEmissao, @dataEmissao, @dataCriacao, @acompanhantesReclamante, @acompanhantesReclamada)";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@numProcesso", laudo.numProcesso);
                cmd.Parameters.AddWithValue("@nomeReclamante", laudo.nomeReclamante);
                cmd.Parameters.AddWithValue("@nomeReclamada", laudo.nomeReclamada);
                cmd.Parameters.AddWithValue("@dataVistoria", laudo.dataVistoria);
                cmd.Parameters.AddWithValue("@horaVistoria", laudo.horaVistoria);
                cmd.Parameters.AddWithValue("@localVistoriado", laudo.localVistoriado);
                cmd.Parameters.AddWithValue("@enderecoVistoriado", laudo.enderecoVistoriado);
                cmd.Parameters.AddWithValue("@dataInicioPeriodoReclamado", laudo.dataInicioPeriodoReclamado);
                cmd.Parameters.AddWithValue("@dataFimPeriodoReclamado", laudo.dataFimPeriodoReclamado);
                cmd.Parameters.AddWithValue("@funcaoExercida", laudo.funcaoExercida);
                cmd.Parameters.AddWithValue("@cidadeEmissao", laudo.cidadeEmissao);
                cmd.Parameters.AddWithValue("@dataEmissao", laudo.dataEmissao);
                cmd.Parameters.AddWithValue("@dataCriacao", laudo.dataCriacao);
                cmd.Parameters.AddWithValue("@acompanhantesReclamante", laudo.acompanhantesReclamante);
                cmd.Parameters.AddWithValue("@acompanhantesReclamada", laudo.acompanhantesReclamada);
                

                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Laudo Cadastrado!", "success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DB.Conectar().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar cadastrar");
                Console.WriteLine(ex.Message);
            }
        }

        public static DataTable SelectFromSql(string arg)
        {
            string sql = arg;
            DataTable dt = new DataTable();
            //SQLiteDataAdapter da = new SQLiteDataAdapter();
            //MessageBox.Show(sql);
            try
            {
                var cmd = DB.Conectar().CreateCommand();
                cmd.CommandText = sql;

                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, Conectar());
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }

        public static int MaxId()
        {
            string sql = @"SELECT MAX(id) FROM laudos";
            DataTable dt = new DataTable();
            try
            {
                var cmd = DB.Conectar().CreateCommand();
                cmd.CommandText = sql;

                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, Conectar());
                da.Fill(dt);

                int maxid = UInt16.Parse(dt.Rows[0].ItemArray[0].ToString());

                return maxid;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }
}
