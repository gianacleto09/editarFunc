using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace cadastroFunc
{
    internal class bd
    {

        string conexao = "server=localhost; user=root;password=;database=db_projeto";
        public MySqlConnection conn = null;

        public void abrirConn()
        {
            try
            {
                conn = new MySqlConnection(conexao);
                conn.Open();
                //MessageBox.Show("Funfando");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void fecharConn()
        {
            try
            {
                conn = new MySqlConnection(conexao);
                conn.Close();
                //MessageBox.Show("Closei");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
