using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using CACMicropresicion.Model;
using CACMicropresicion.Globals;

namespace CACMicropresicion.Controller
{
    class ClientsController : BaseController
    {
        private CAC_MICROPRECISION_SAEntities db = new CAC_MICROPRECISION_SAEntities();

        public Dictionary<Object, dynamic> addClient(int id, string description)
        {
            try
            {
                byte a = 0;
                Cliente cliente = new Cliente()
                {
                    Descripcion = description,
                    FechaAgrega = DateTime.Now,
                    FechaElimina = null,
                    UsuarioAgrega = "probandousuario",
                    Eliminado = a,
                    IdEstado = 10
                };

                db.Cliente.Add(cliente);
                db.SaveChanges();

                return result(Result.Processed, Result.Inserted, null);
            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Se ha generado un error: " + ex.Message, null);
            }
        }

        public List<Cliente> populateClientsList()
        {
            List<Cliente> list = new List<Cliente>();
            var query = from clients in db.Cliente select clients;

            return query.ToList();
        }



        public Dictionary<Object, dynamic> editClient(int id, string description)
        {
            try
            {
                var cliente = db.Cliente
           .Where(w => w.IdCliente == id)
           .SingleOrDefault();
                byte a = 0;
                if (cliente != null)
                {
                    cliente.Descripcion = description;
                    cliente.FechaAgrega = DateTime.Now;
                    cliente.FechaElimina = null;
                    cliente.UsuarioAgrega = "probandousuario";
                    cliente.Eliminado = a;
                    cliente.IdEstado = 10;
                }
                db.SaveChanges();

                //byte a = 0;
                //Cliente cliente = new Cliente()
                //{
                //    Descripcion = description,
                //    FechaAgrega = DateTime.Now,
                //    FechaElimina = null,
                //    UsuarioAgrega = "probandousuario",
                //    Eliminado = a,
                //    IdEstado = 10
                //};

                //db.Cliente.Add(cliente);
                //db.SaveChanges();

                return result(Result.Processed, Result.Modified, null);
            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Se ha generado un error: " + ex.Message, null);
            }
        }




        public string[] getClientsInfo(int id)
        {

            var query = (from clients in db.Cliente
                         join estado in db.Estado on clients.IdEstado
                             equals estado.IdEstado
                         where clients.IdCliente == id
                         select new
                         {
                             des = clients.Descripcion,
                             estado = estado.IdEstado,
                             nom = estado.Descripcion
                         }).AsEnumerable().Select(x => string.Format("{0} * {1} * {2}", x.des, x.estado, x.nom)).ToArray();

            string[] a = query;

            return a;
        }


    }
}
