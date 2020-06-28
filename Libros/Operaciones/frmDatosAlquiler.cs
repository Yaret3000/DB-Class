using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrosEDM;
using LibrosEDM.ModeloAplicacion;
using LibrosEDM.Extensiones;
using LibrosDAO;

namespace Libros.Operaciones
{
    public partial class frmDatosAlquiler : Form
    {
        private LibroDAO opeLib = new LibroDAO();
        public OperacionesABC Ope = OperacionesABC.Ninguno;
        public usp_ObtenerAlqClte_Result Registro = null;
        public List<AlquilerDeLibro> lstGrid = new List<AlquilerDeLibro>();
        public int idCliente;
        public frmDatosAlquiler()
        {
            InitializeComponent();
        }

        


        private void AsignarControles()
        {
            this.TxtCodigo.Text = this.Registro.CodigoDeAlquiler;
            this.DtpFechaAlq.Value = this.Registro.FechaDelAlquiler;
            this.DtpFechaDev.Value = this.Registro.FechaEstimadaDevolucion;
           
        }//fin asignar controles

        private void Limpiarcontroles()
        {
            this.TxtCodigo.Text = "";
            this.DtpFechaAlq.Value = DateTime.Now;
            this.DtpFechaDev.Value = DateTime.Now;
        }//fin de limpiar controles

        private void CargarCmbLibros()
        {
            if (this.Ope == OperacionesABC.Agregar)
            {
                CmbLibros.DataSource = opeLib.Listar(false);
            }
            if (Ope == OperacionesABC.Modificar || Ope == OperacionesABC.Eliminar)
            {
                List<ListaLibro> oLista = new List<ListaLibro>();
                oLista.Add(new ListaLibro { LibroId = Registro.idLibro, Titulo = Registro.Titulo });
                CmbLibros.DataSource = oLista;
            }
            CmbLibros.DisplayMember = "Titulo";
            CmbLibros.ValueMember = "LibroId";
        }

        private void frmDatosAlquiler_Load(object sender, EventArgs e)
        {
            
            CargarCmbLibros();
            //CmbLibros.SelectedIndex = -1;
            if (this.Ope == OperacionesABC.Agregar)
            {
                Limpiarcontroles();
            }
            if (this.Ope == OperacionesABC.Modificar || Ope == OperacionesABC.Eliminar)
            {
                AsignarControles();
                TxtCodigo.Enabled = false;
                CmbLibros.Enabled = false;
                CmbCopia.Enabled = false;
            }
            if (Ope == OperacionesABC.Eliminar)
            {
                DtpFechaAlq.Enabled = false;
                DtpFechaDev.Enabled = false;
            }

        }
        private bool ValidarDatos()
        {
            if (TxtCodigo.Text.Trim().Length==0)
            {
                MessageBox.Show("Código no puede ser vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigo.Focus();
                return false;
            }
    var q = opeLib.BuscarAqlquiler(TxtCodigo.Text.Trim());
            if (q != null && this.Ope == OperacionesABC.Agregar)
            {
        MessageBox.Show("Código ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        TxtCodigo.Focus();
        return false;
    }
            return true;
    }//fin de validar datos

    
        

        private void CargarCmbCopia(int LibroId)
        {
            if (this.Ope == OperacionesABC.Agregar)
            {
                //cargar copias del libro que aún no han sido alquiladas
                var qLista = opeLib.ListarCopias(LibroId, false);
                this.CmbCopia.DataSource = (from l in qLista
                                            where !(from g in lstGrid
                                                    select g.CopiaDeLibroId).Contains(l.Id)
                                            select l).ToList();
            }
            if (Ope == OperacionesABC.Modificar || Ope == OperacionesABC.Eliminar)
            {
                List<CopiaDeLibro> oLista = new List<CopiaDeLibro>();
                oLista.Add(new CopiaDeLibro { Id = Registro.idCopia, NumeroDeCopia = Registro.NumeroDeCopia });
                CmbCopia.DataSource = oLista;
            }
            this.CmbCopia.DisplayMember = "NumeroDeCopia";
            this.CmbCopia.ValueMember = "Id";
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos()) // sin dejar nada vacio
            {
                if (this.Ope == OperacionesABC.Agregar)
                {
                    this.Registro = new usp_ObtenerAlqClte_Result();
                }//fin de si es nuevo
                if (this.Ope != OperacionesABC.Eliminar || this.Ope != OperacionesABC.Ninguno)
                {
                    this.Registro.CodigoDeAlquiler = this.TxtCodigo.Text.Trim();
                    this.Registro.FechaDelAlquiler = this.DtpFechaAlq.Value;
                    this.Registro.FechaEstimadaDevolucion = this.DtpFechaDev.Value;
                    this.Registro.Titulo = this.CmbLibros.Text.Trim();
                    this.Registro.NumeroDeCopia = int.Parse(this.CmbCopia.Text);

                    //campos escondidos
                    this.Registro.idCopia = (int)this.CmbCopia.SelectedValue;
                    this.Registro.idLibro = (int)this.CmbLibros.SelectedValue;
                    this.Registro.idCliente = this.idCliente;

                }//modifica y agrega
                Close();
            }// if validardatos
        }

       

        private void CmbLibros_SelectedValueChanged(object sender, EventArgs e)
        {

            if (CmbLibros.SelectedIndex>=0)
            {
                try
                {
                    CargarCmbCopia((int)CmbLibros.SelectedValue);
                }
                catch { }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Registro = null;
            this.Close();
        }
    }
}
