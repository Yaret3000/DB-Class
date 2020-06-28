using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrosDAO;
using Libros.Consulta;

namespace Libros.Consulta
{
    public partial class FrmBuscarCliente : Form
    {
        private ClientesDAO oCltDAO = new ClientesDAO();
        public FrmBuscarCliente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //if (oCltDAO.ProcBuscarCliente(txtNombre.Text.Trim(), txtApellido.Text.Trim()).Count() == 0)
            //    MessageBox.Show("No hay registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //else
                uspBuscarClienteBindingSource.DataSource = oCltDAO.ProcBuscarCliente(txtNombre.Text.Trim(), txtApellido.Text.Trim());
            if (dgResultado.RowCount==1)
            {
                MessageBox.Show("No hay registro", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
                return;

            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
