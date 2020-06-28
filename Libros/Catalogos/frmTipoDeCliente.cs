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
using LibrosEDM;
using LibrosEDM.ModeloAplicacion;

namespace Libros.Catalogos
{
    public partial class frmTipoDeCliente : Form
    {
        private TipoDeClienteDAO oTipoDAO = new TipoDeClienteDAO();
        private bool NuevoRegistro = false;


        public frmTipoDeCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (NuevoRegistro == true)
            {
                TipoDeCliente oTipo = new TipoDeCliente();
                oTipo.CodigoTipoDeCliente = txtCodigo.Text.Trim();
                oTipo.DescripcionTipoDeCliente = txtDescripcion.Text.Trim();

                if (oTipoDAO.Agregar(oTipo) == false)
                {
                    MessageBox.Show("El nuevo registro no pudo ser grabado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }
                else
                {
                    MessageBox.Show("El nuevo registro fue grabado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // return;
                }

            }
            else
            {
                TipoDeCliente oTipo = oTipoDAO.Buscar(txtCodigo.Text.Trim());
                oTipo.DescripcionTipoDeCliente = txtDescripcion.Text.Trim();
                if (oTipoDAO.Modificar(oTipo) == false)
                {
                    MessageBox.Show("El Registro no fue Modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }
                else
                {
                    MessageBox.Show("Registro Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // return;
                }


            }

            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            txtCodigo.Focus();
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            TipoDeCliente oTipo = oTipoDAO.Buscar(txtCodigo.Text.Trim());
            if (oTipoDAO.Eliminar(oTipo) == false)
            {
                MessageBox.Show("El registro no puede ser eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                MessageBox.Show("El registro eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCodigo.Text = "";
                txtDescripcion.Text = "";
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;
                txtCodigo.Focus();

                return;

            }

        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            TipoDeCliente oTipoClte;
            if (txtCodigo.Text.Trim().Length <3)
            {
                MessageBox.Show("La longitud del codigo es de 3", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
            oTipoClte = oTipoDAO.Buscar(txtCodigo.Text.Trim());
            if (oTipoClte != null)
            {
                NuevoRegistro = false;
                txtDescripcion.Text = oTipoClte.DescripcionTipoDeCliente.Trim();
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;

            }
            else
            {
                NuevoRegistro = true;
                txtDescripcion.Text = "";
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = false;

            }

        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
