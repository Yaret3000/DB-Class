using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrosEDM;
using LibrosEDM.ModeloAplicacion;
using LibrosEDM.Extensiones;

namespace LibrosDAO
{
    public class LibroDAO
    {

        private LibrosModelContainer db = new LibrosModelContainer();

        public List<usp_ObtenerAlqClte_Result> ObtenerAlquiler(int ClienteId)
        {
            return db.usp_ObtenerAlqClte(ClienteId).ToList();
        }

        public List<Libro> Listar()
        {
            return db.Libros.ToList();
        }//listar sin parametros

        public List<ListaLibro> Listar(bool Alquilado)
        {
            List<ListaLibro> q;
            if (Alquilado)
            {
                q = (from l in db.Libros
                     join c in db.CopiasDeLibro on l.Id equals c.LibroId
                     join a in db.AlquileresDeLibro on c.Id equals a.CopiaDeLibroId
                     where a.FechaRealDevolucion.Year == 1900
                     select new ListaLibro { LibroId = l.Id, Titulo = l.Titulo }).Distinct().ToList();
            }//fin de si alquilado
            else
            {
                q = (from l in db.Libros
                     join c in db.CopiasDeLibro on l.Id equals c.LibroId
                     where !(from a in db.AlquileresDeLibro where a.FechaRealDevolucion.Year == 1900 select a.CopiaDeLibroId).Contains(c.Id)
                     select new ListaLibro { LibroId = l.Id, Titulo = l.Titulo }).Distinct().ToList();
            }
            return q;
        }
        //enviar copias que no esten alquiladas para ese libro idlib
        public List<CopiaDeLibro> ListarCopias(int idLib, bool Alquilado)
        {
            List<CopiaDeLibro> q = new List<CopiaDeLibro>();
            if (Alquilado == false)
            {
                q = (from c in db.CopiasDeLibro
                     where c.LibroId == idLib &&
                     !(from a in db.AlquileresDeLibro where a.FechaRealDevolucion.Year == 1900 select a.CopiaDeLibroId).Contains(c.Id)
                     select c).ToList();
            }
            return q;
        }

        public AlquilerDeLibro BuscarAqlquiler(string pCodigo)
        {
            return (db.AlquileresDeLibro
                .DefaultIfEmpty(null)
                .FirstOrDefault(a => a.CodigoDeAlquiler.Trim() == pCodigo.Trim()));
        }// final de buscar alquiler por codigo

        public bool GuardarAlquiler(List<AlquilerDeLibro> pLista, int idClte)
        {
            AlquilerDeLibro oAlq;
            bool Nuevo = false;
            bool hayError = false;

            foreach (AlquilerDeLibro k in pLista)
            {
                oAlq = BuscarAqlquiler(k.CodigoDeAlquiler.Trim());
                if (oAlq == null)
                {
                    oAlq = new AlquilerDeLibro();
                    Nuevo = true;
                }
                else
                {
                    Nuevo = false;
                }
                oAlq.CodigoDeAlquiler = k.CodigoDeAlquiler;
                oAlq.FechaDelAlquiler = k.FechaDelAlquiler;
                oAlq.FechaEstimadaDevolucion = k.FechaEstimadaDevolucion;
                oAlq.FechaRealDevolucion = DateTime.Parse("01/01/1900");
                oAlq.CopiaDeLibroId = k.CopiaDeLibroId;
                oAlq.ClienteId = k.ClienteId;
                if (Nuevo)
                { db.AlquileresDeLibro.Add(oAlq); }
                else { db.Entry(oAlq).State = EntityState.Modified; }
                hayError = db.SaveChanges() > 0 ? false : true;


            }//foreach

            //eliminar lo que no viene en la cuadricula (plista)
            //Sacar lo que esta en la base de datos
            List<usp_ObtenerAlqClte_Result> bLista = ObtenerAlquiler(idClte);//refrescar el combo

            //todo lo que este en blista (b.d) que no este en plista (cuadricula)
            List<usp_ObtenerAlqClte_Result> qLista;
            if (pLista.Count > 0)
            {
                qLista = (from b in bLista
                          where !(from p in pLista select p.CodigoDeAlquiler).Contains(b.CodigoDeAlquiler)
                          select b).ToList();
            }
            else
            {
                qLista = bLista;
            }

            //proceder a eliminar de la base de datos
            foreach (usp_ObtenerAlqClte_Result k in qLista)
            {
                oAlq = new AlquilerDeLibro();
                oAlq = BuscarAqlquiler(k.CodigoDeAlquiler);
                db.AlquileresDeLibro.Remove(oAlq);
                hayError = db.SaveChanges() > 0 ? false : true;
            }//fin del foreach eliminar

            return !hayError;
        }//fin de guardar lista


    }
}
