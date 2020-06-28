using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libros
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tipoDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oFrm = new Catalogos.frmTipoDeCliente();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void terminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oFrm = new Catalogos.frmClientes();
            oFrm.ShowDialog();
            oFrm.Dispose();

        }

        private void busquedasDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oFrm = new Consulta.FrmBuscarCliente();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void alquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oFrm = new Operaciones.frmAlquiler();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }
    }
}
