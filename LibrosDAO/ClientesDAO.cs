using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LibrosEDM;
using LibrosEDM.ModeloAplicacion;


namespace LibrosDAO
{
    public class ClientesDAO
    {

        LibrosModelContainer db = new LibrosModelContainer();

        public bool Agregar(Cliente oCliente)
        {
            db.Clientes.Add(oCliente);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(Cliente oCliente)
        {
            db.Entry(oCliente).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);

        }

        public bool Eliminar(Cliente oCliente)
        {
            db.Clientes.Remove(oCliente);
            return db.SaveChanges() > 0 ? true : false;
        }

        public Cliente Buscar(string pCodigo)
        {

            Cliente oCliente;
            oCliente = db.Clientes.DefaultIfEmpty(null).FirstOrDefault(tc => tc.CodigoDelCliente.Trim() == pCodigo.Trim());
            return (oCliente);

        }


        public List<usp_BuscarCliente_Result>ProcBuscarCliente(String Nomb,String ape)
        {
            return db.usp_BuscarCliente(Nomb, ape).ToList();
        }

        public List<Cliente>listar()
        {
            return (db.Clientes.ToList());
        }
}
}
