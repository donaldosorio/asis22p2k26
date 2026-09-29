using System;
using System.Data.Odbc;

namespace asis22p2k26.CapaModelo
{
    public class ClsConexion
    {
        public OdbcConnection Conexion()
        {
            OdbcConnection conn = new OdbcConnection("DSN=segundoparcial2k26esegundoparcial2k26e");
            try
            {
                conn.Open();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al conectar con la base de datos: " + ex.Message);
            }
            return conn;
        }

        public void Desconexion(OdbcConnection conn)
        {
            try
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }
    }
}
