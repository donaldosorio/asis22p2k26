using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantenimiento2k26.CapaVista
{
    internal class vista
    {
        public partial class FrmContenedor : Form
        {
            public FrmContenedor()
            {
                InitializeComponent();
                this.IsMdiContainer = true;
                this.StartPosition = FormStartPosition.CenterScreen;
                this.Text = "Sistema de Gestión - asis22p2k26";
            }

            private void abrirMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
            {
                FrmMantenimientoBase frm = new FrmMantenimientoBase();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}

