using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;  

namespace WebCadastro
{
    public class clsBanco
    {
        protected SqlConnection _conexao;
        private SqlCommand _comando;

        public clsBanco()
        {
            string sStringConexao =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|webvehiclesdb.mdf;Integrated Security=True";

            _conexao = new SqlConnection(sStringConexao);
            _comando = new SqlCommand();
            _comando.Connection = _conexao;     
        }
        
        public bool ConectaBanco()
        {
            try
            {
                _conexao.Open();
                return true;
            }
            catch (Exception erro)
            {
                return false;
            } 
        }

        public bool  DesconectaBanco()
        {
            try
            {
                _conexao.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public SqlDataReader RetornaDR(string sSQL)
        {
            if (_conexao.State == ConnectionState.Closed)
            {
                _conexao.Open(); 
            }
            _comando.CommandText = sSQL;
            SqlDataReader drReader = _comando.ExecuteReader();
            return drReader;   
        }

        public DataSet RetornaDS(string sSQL)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet dsDados = new DataSet();

            if (ConectaBanco())
            {
                _comando.CommandText = sSQL;
                dataAdapter.SelectCommand = _comando;
                dataAdapter.Fill(dsDados);
                DesconectaBanco();     
            }

            return dsDados;
        }

        public DataTable RetornaDT(string sSQL)
        {
            DataTable dtDados = new DataTable();
            if (ConectaBanco())
            {
                _comando.CommandText = sSQL;
                dtDados.Load(_comando.ExecuteReader());
                DesconectaBanco();     
            }
            return dtDados;
        }

        public int ExecutarSQL(string sSQL)
        {
            int iLinhas = 0;

            if (ConectaBanco())
            {
                _comando.CommandText = sSQL;
                iLinhas = _comando.ExecuteNonQuery();
                DesconectaBanco();   
            }
            return iLinhas;
        }

        public void Mensagem(string sMensagem, Page Pagina)
        {
            ScriptManager.RegisterStartupScript(Pagina, this.GetType(),
                "Aviso", "<script language='javascript'>alert('" +
                sMensagem + "'); </script>", false);  
        }
    }
}