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
    public partial class frmClientes : Form
    {
        private TipoDeClienteDAO otipoDAO = new TipoDeClienteDAO();
        private ClientesDAO oClienteDAO = new ClientesDAO();
        private bool NuevoRegistro = false;

        private Cliente oCliente;

        private void DesactivaControles(bool EstadoCtrl)
        {
            txtNombres.Enabled = !EstadoCtrl;
            txtApellidos.Enabled = !EstadoCtrl;
            cboTipo.Enabled = !EstadoCtrl;
            btnGuardar.Enabled = !EstadoCtrl;
            btnEliminar.Enabled = !EstadoCtrl;
        }//fin del método desactivar controles

        private void LimpiarControles()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            cboTipo.SelectedIndex = -1;  //no hay nada seleccionado
        }
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (NuevoRegistro == true)
            {
                Cliente oCliente = new Cliente();
                oCliente.CodigoDelCliente = txtCodigo.Text.Trim();
                oCliente.NombresDelCliente = txtNombres.Text.Trim();
                oCliente.ApellidosDelCliente = txtApellidos.Text.Trim();
                oCliente.TipoDeClienteId = (int)cboTipo.SelectedValue;



                if (oClienteDAO.Agregar(oCliente) == false)
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
                Cliente oCliente = oClienteDAO.Buscar(txtCodigo.Text.Trim());
                oCliente.NombresDelCliente = txtNombres.Text.Trim();
                oCliente.ApellidosDelCliente = txtApellidos.Text.Trim();
                oCliente.TipoDeClienteId = (int)cboTipo.SelectedValue;

                if (oClienteDAO.Modificar(oCliente) == false)
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

            LimpiarControles();
            DesactivaControles(true);
            txtCodigo.Text = "";
            txtCodigo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                Cliente oCliente = oClienteDAO.Buscar(txtCodigo.Text.Trim());
                if (oClienteDAO.Eliminar(oCliente) == false)
                {
                    MessageBox.Show("El registro no puede ser eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else
                {
                    MessageBox.Show("El registro eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarControles();
                    DesactivaControles(true);
                    txtCodigo.Text = "";
                    txtCodigo.Focus();

                    return;

                }
            }
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            DesactivaControles(true);
            LimpiarControles();
            if (txtCodigo.Text.Trim().Length < 3)
            {
                MessageBox.Show("Longitud debe ser 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
            oCliente = oClienteDAO.Buscar(txtCodigo.Text.Trim());
            if (oCliente != null)
            {
                NuevoRegistro = false;
                txtNombres.Text = oCliente.NombresDelCliente.Trim();
                txtApellidos.Text = oCliente.ApellidosDelCliente.Trim();
                cboTipo.SelectedValue = oCliente.TipoDeClienteId;
                DesactivaControles(false);
            }
            else
            {
                NuevoRegistro = true;
                DesactivaControles(false);
                btnEliminar.Enabled = false;
            }

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cboTipo.DataSource = otipoDAO.listar();  
            cboTipo.DisplayMember = "DescripcionTipoDeCliente";  
            cboTipo.ValueMember = "Id";  
            cboTipo.SelectedIndex = -1;  
        }
    }
}
