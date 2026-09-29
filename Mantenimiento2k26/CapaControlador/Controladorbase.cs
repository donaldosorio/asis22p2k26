using System.Data;
using asis22p2k26.CapaModelo;

namespace asis22p2k26.CapaControlador
{
    public class ClsControladorBase
    {
        private ClsSentencias sn = new ClsSentencias();

        public DataTable CargarTabla(string nombreTabla)
        {
            return sn.ObtenerDatos(nombreTabla);
        }
    }
}
