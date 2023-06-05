using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio_AdoNet
{
    internal class Banco
    {
        private string stringConexao = "Data Source=localhost;" + "Initial Catalog=Academia_Atos_Adonet_Exercicio; User ID=exercicio_adonet;" +
            "password=senha123; language=Portuguese";

        private SqlConnection cn;

        private void conecxao()
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                conecxao();
                cn.Open();

                return cn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {

                return;
            }
        }

        public DataTable executarConsultaGenerica(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand command = new SqlCommand(sql, cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adpter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adpter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
