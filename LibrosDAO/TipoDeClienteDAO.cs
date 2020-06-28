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
    public class TipoDeClienteDAO
    {

        LibrosModelContainer db = new LibrosModelContainer();

        public bool Agregar(TipoDeCliente oTipo)
        {
            db.TiposDeCliente.Add(oTipo);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar (TipoDeCliente oTipo)
        {
            db.Entry(oTipo).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);

        }

        public bool Eliminar(TipoDeCliente oTipo)
        {
            db.TiposDeCliente.Remove(oTipo);
            return db.SaveChanges() > 0 ? true:false;
        }

        public TipoDeCliente Buscar(string pCodigo)
        {

            TipoDeCliente oTipo;
            oTipo = db.TiposDeCliente.DefaultIfEmpty(null).FirstOrDefault(tc => tc.CodigoTipoDeCliente.Trim() == pCodigo.Trim());
            return (oTipo);

        }

        public TipoDeCliente buscar(int pid)
        {
            TipoDeCliente otipo;
            otipo = db.TiposDeCliente.DefaultIfEmpty(null).FirstOrDefault(t => t.Id == pid);
            return (otipo);
        }
        public List<TipoDeCliente> listar()
        {
            return (db.TiposDeCliente.ToList());
        }



    }
}
