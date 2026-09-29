using System;
using System.Data;
using System.Data.Odbc;

namespace asis22p2k26.CapaModelo
{
    public class ClsSentencias
    {
        private ClsConexion cn = new ClsConexion();

        public DataTable ObtenerDatos(string tabla)
        {
            DataTable dt = new DataTable();
            try
            {
                OdbcConnection conn = cn.Conexion();
                string query = $"SELECT * FROM {tabla};";
                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(dt);
                cn.Desconexion(conn);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la consulta: " + ex.Message);
            }
            return dt;
        }
    }
}
