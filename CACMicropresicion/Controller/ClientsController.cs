using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CACMicropresicion.Globals;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using CACMicropresicion.Model;

namespace CACMicropresicion.Controller
{
    class ClientsController : BaseController
    {
        public Dictionary<string, dynamic> data { get; set; }
        private CAC_MICROPRECISION_SAEntities db = new CAC_MICROPRECISION_SAEntities();
      
        public Dictionary<Object,dynamic> populateClientsList()
        {
            List<Cliente> list = new List<Cliente>();
            var query = from clients in db.Cliente where clients.Eliminado == 0 select clients;
            return result(Result.Processed, Result.Modified, query.ToList());
            
        }

        

        public Cliente CreateClient() {
            return new Cliente()
            {
                Descripcion = data["description"],
                FechaAgrega = DateTime.Now,
                FechaElimina = null,
                UsuarioAgrega = data["user"],
                Eliminado = 0,
                IdEstado = Status.Active
            };
        }

        private Bitacora createLog(string action, string table, string oldContent, string newContent)
        {

            return new Bitacora()
            {
                Fecha = DateTime.Now,
                Accion = action,
                TablaAfectada = table,
                ContenidoViejo = oldContent,
                ContenidoNuevo = newContent,
                UsuarioAgrega = data["user"]
            };

        }


        
        public Dictionary<Object, dynamic> deleteClient(Cliente registeredClient)
        {
            try
            {

                Cliente delClient = db.Cliente.Find(data["id"]);

                string oldContent = delClient.toString();
                delClient.Eliminado = 1;
                string newContent = delClient.toString();

                db.Entry(delClient).State = System.Data.Entity.EntityState.Modified;

                Bitacora clientLog = createLog(Log.Delete, Log.Client, oldContent, newContent);
                db.Bitacora.Add(clientLog);

                db.SaveChanges();

                return result(Result.Processed, Result.Deleted, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al eliminar el registro: " + ex.Message, null);
            }

        }



        public Dictionary<Object, dynamic> modifyClient(Cliente registeredClient, Cliente modifiedClient)
        {

            if (String.IsNullOrEmpty(modifiedClient.Descripcion)) {
                return result(Result.Failed, Result.Empty, null);
            }

            if (registeredClient.Descripcion.Equals(modifiedClient.Descripcion)
                && registeredClient.IdEstado.Equals(modifiedClient.IdEstado))
            {
                return result(Result.Failed, Result.Same, null);
            }

            try
            {

                string oldContent = registeredClient.toString();
                string newContent = modifiedClient.toString();

                Cliente newClient = db.Cliente.Find(modifiedClient.IdCliente);
                db.Entry(newClient).CurrentValues.SetValues(modifiedClient);
                db.Entry(newClient).State = System.Data.Entity.EntityState.Modified;

                Bitacora clientLog = createLog(Log.Modify, Log.Client, oldContent, newContent);
                db.Bitacora.Add(clientLog);

                db.SaveChanges();

                return result(Result.Processed, Result.Modified, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al modificar el registro: " + ex.Message, null);
            }

        }
        

        public Dictionary<Object, dynamic> getDataToFillClientsCombo()
        {

            try
            {

                var query = from c in db.Cliente
                            where c.Eliminado==0
                            orderby c.IdCliente
                            select c;

                return result(Result.Processed, null, query.ToList());

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        


        public Dictionary<Object, dynamic> insertClientFromMaintenance()
        {

            if (String.IsNullOrEmpty(data["description"]))
            {
                return result(Result.Failed, Result.Empty, null);
            }
            
            try
            {

                string oldContent, newContent;

                Cliente client = CreateClient();
                oldContent = "";
                newContent = client.toString();

                Bitacora clientLog = createLog(Log.Insert, Log.Client, oldContent, newContent);

                db.Cliente.Add(client);
                db.Bitacora.Add(clientLog);
                db.SaveChanges();

                return result(Result.Processed, Result.Inserted, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Se ha generado un error: " + ex.Message, null);
            }

        }



        public Dictionary<Object, dynamic> getAllClients()
        {
            try
            {

                var query = from c in db.Cliente
                            join s in db.Estado on c.IdEstado equals s.IdEstado
                            where c.Eliminado == 0
                            select new
                            {
                                identification = c.IdCliente,
                                description = c.Descripcion,
                                status = s.Descripcion,
                                deleted = (c.Eliminado == 1) ? "Si" : "No"
                            };

                var users = query.ToList();
                return result(Result.Processed, null, users);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }





    }
}
