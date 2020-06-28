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
using LibrosEDM.Extensiones;

namespace Libros.Operaciones
{
    public partial class frmAlquiler : Form
    {
        private ClientesDAO opeCliente = new ClientesDAO();
        private LibroDAO opeLibro = new LibroDAO();

        public frmAlquiler()
        {
            InitializeComponent();
        }

        private void frmAlquiler_Load(object sender, EventArgs e)
        {
            CargarCmbCliente(); 
        }

        private void CargarCmbCliente()
        {
            cmbCliente.DataSource = opeCliente.listar();
            cmbCliente.DisplayMember = "NombreCompleto";
            cmbCliente.ValueMember = "Id";
        }

       

        private void btnIr_Click(object sender, EventArgs e)
        {
            var oFrmCliente = new Catalogos.frmClientes();
            oFrmCliente.ShowDialog();
            oFrmCliente.Dispose();
            CargarCmbCliente();

        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            uspObtenerAlqClteResultBindingSource.DataSource = opeLibro.ObtenerAlquiler((int)cmbCliente.SelectedValue);
            if (grdAlquiler.Rows.Count > 0)
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

       

        private List<AlquilerDeLibro> ListarGrid()
        {
            List<AlquilerDeLibro> oLista = new List<AlquilerDeLibro>();
            AlquilerDeLibro oAlq;
            
            foreach (DataGridViewRow k in grdAlquiler.Rows)
            {
                oAlq = new AlquilerDeLibro();                
                oAlq.CodigoDeAlquiler = k.Cells[0].Value.ToString();
                oAlq.FechaDelAlquiler = (DateTime)k.Cells[1].Value;
                oAlq.FechaEstimadaDevolucion = (DateTime)k.Cells[3].Value;
                oAlq.CopiaDeLibroId = (int)k.Cells[5].Value;
                oAlq.Id = (int)k.Cells[7].Value;
                oAlq.ClienteId = (int)cmbCliente.SelectedValue;
                oLista.Add(oAlq);
            }//foreach
            return oLista;
        }//fin de listar grid

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (opeLibro.GuardarAlquiler(ListarGrid(), (int)cmbCliente.SelectedValue) == false)
            {
                MessageBox.Show("Operación fallida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            uspObtenerAlqClteResultBindingSource.Clear();
            cmbCliente.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            var oFrmDetalle = new Operaciones.frmDatosAlquiler();
            oFrmDetalle.Ope = OperacionesABC.Agregar;
            oFrmDetalle.lstGrid = ListarGrid();
            oFrmDetalle.idCliente = (int)cmbCliente.SelectedValue;
            oFrmDetalle.ShowDialog();
            if (oFrmDetalle.Registro != null) //resitro saber si agrego o no
            {
                
                uspObtenerAlqClteResultBindingSource.Add(oFrmDetalle.Registro);
            }
            oFrmDetalle.Dispose();            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var oFrmDetalle = new Operaciones.frmDatosAlquiler();
            oFrmDetalle.Ope = OperacionesABC.Modificar;
            // Envia el registro donde esta el cursor o sea el seleccionado
            oFrmDetalle.Registro = (usp_ObtenerAlqClte_Result)uspObtenerAlqClteResultBindingSource.Current;
            oFrmDetalle.ShowDialog();
            if (oFrmDetalle.Registro != null)
            {
                foreach (DataGridViewRow k in grdAlquiler.Rows)
                {
                    //verifica el codigo para ver a quien se va ha modificar
                    if (k.Cells[0].Value == oFrmDetalle.Registro.CodigoDeAlquiler)
                    {
                        k.Cells[1].Value = oFrmDetalle.Registro.FechaDelAlquiler;
                        k.Cells[2].Value = oFrmDetalle.Registro.Titulo.Trim();
                        k.Cells[3].Value = oFrmDetalle.Registro.FechaEstimadaDevolucion;
                        k.Cells[4].Value = oFrmDetalle.Registro.NumeroDeCopia;
                        k.Cells[5].Value = oFrmDetalle.Registro.idCopia;
                        k.Cells[6].Value = oFrmDetalle.Registro.idLibro;
                        k.Cells[8].Value = oFrmDetalle.Registro.idCliente;
                        //pendiente campos ocultos

                    }
                }
            }
            oFrmDetalle.Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var oFrmDetalle = new Operaciones.frmDatosAlquiler();
            oFrmDetalle.Ope = OperacionesABC.Eliminar;
            oFrmDetalle.Registro = (usp_ObtenerAlqClte_Result)uspObtenerAlqClteResultBindingSource.Current;
            oFrmDetalle.ShowDialog();
            if (oFrmDetalle.Registro != null)
            {
                uspObtenerAlqClteResultBindingSource.Remove(oFrmDetalle.Registro);
            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAgregar.PerformClick();

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnModificar.PerformClick();

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEliminar.PerformClick();
        }
    }
}
