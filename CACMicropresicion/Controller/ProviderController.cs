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
    class ProviderController : BaseController
    {

        private string oldContent, newContent;
        public Dictionary<string, dynamic> data { get; set; }


        public ProviderController()
        {
        }




        public Dictionary<Object, dynamic> getAllProviders()
        {
            try
            {

                var query = from u in db.Proveedor
                            join s in db.Estado on u.IdEstado equals s.IdEstado
                            where u.Eliminado == 0
                            select new
                            {
                                identification = u.IdProveedor,
                                Descripcion = u.Descripcion,
                                Estado = s.Descripcion
                            };

                var users = query.ToList();
                return result(Result.Processed, null, users);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> getAllProvidersToView()
        {
            try
            {

                var query = from p in db.Proveedor
                            join s in db.Estado on p.IdEstado equals s.IdEstado
                            where p.Eliminado == 0
                            select new
                            {
                                identification = p.IdProveedor,
                                name = p.Descripcion,
                                Estado = s.Descripcion
                            };

                var users = query.ToList();
                return result(Result.Processed, null, users);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        #region GetInformationForOtherInstances
        public Dictionary<Object, dynamic> getDataToFillProvidersCombo()
        {

            try
            {

                var query = from p in db.Proveedor
                            where p.Eliminado == 0
                            orderby p.IdProveedor
                            select p;

                return result(Result.Processed, null, query.ToList());

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> getProviderById(int id)
        {

            try
            {

                Proveedor provider = (from u in db.Proveedor
                                where u.IdProveedor == id
                                where u.Eliminado == 0
                                select u).FirstOrDefault();

                return result(Result.Processed, null, provider);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> getInfoById(int id)
        {

            try
            {

                InfoProveedor provider = (from u in db.InfoProveedor
                                      where u.IdProveedor == id
                                      where u.Eliminado == 0
                                      select u).FirstOrDefault();

                return result(Result.Processed, null, provider);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        private InfoProveedor getInfoByIdModify(int id)
        {

            try
            {

                InfoProveedor provider = (from u in db.InfoProveedor
                                          where u.IdProveedor == id
                                          where u.Eliminado == 0
                                          select u).FirstOrDefault();

                return provider;

            }
            catch (Exception ex)
            {
                return new InfoProveedor();
            }

        }

        private DireccionProveedor getAddressByIdModify(int id)
        {

            try
            {

                DireccionProveedor provider = (from u in db.DireccionProveedor
                                          where u.IdProveedor == id
                                          where u.Eliminado == 0
                                          select u).FirstOrDefault();

                return provider;

            }
            catch (Exception ex)
            {
                return new DireccionProveedor();
            }

        }

        public Dictionary<Object, dynamic> getAddressById(int id)
        {

            try
            {

                DireccionProveedor provider = (from u in db.DireccionProveedor
                                      where u.IdProveedor == id
                                      where u.Eliminado == 0
                                      select u).FirstOrDefault();

                return result(Result.Processed, null, provider);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        #endregion

        #region Manipulation of registers


        public Dictionary<Object, dynamic> insertProvider()
        {

            if (String.IsNullOrEmpty(data["description"]))
            {
                return result(Result.Failed, Result.Empty, null);
            }

            try
            {

                string oldContent, newContent;

                Proveedor provider = createProvider();
                oldContent = "";
                newContent = provider.toString();

                Bitacora clientLog = createLog(Log.Insert, Log.Provider, oldContent, newContent);

                db.Proveedor.Add(provider);
                db.Bitacora.Add(clientLog);
                db.SaveChanges();

                return result(Result.Processed, Result.Inserted, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Se ha generado un error: " + ex.Message, null);
            }
        }

        public Dictionary<Object, dynamic> modifyProvider(Proveedor registerProvider, Proveedor modifiedProvider)
        {

             if (String.IsNullOrEmpty(modifiedProvider.Descripcion))
            {
                return result(Result.Failed, Result.Empty, null);
            }

            if (registerProvider.Descripcion.Equals(modifiedProvider.Descripcion)
                && registerProvider.IdEstado.Equals(modifiedProvider.IdEstado))
            {
                return result(Result.Failed, Result.Same, null);
            }

            try
            {

                string oldContent = registerProvider.toString();
                string newContent = modifiedProvider.toString();

                Proveedor newProvider = db.Proveedor.Find(modifiedProvider.IdProveedor);
                db.Entry(newProvider).CurrentValues.SetValues(modifiedProvider);
                db.Entry(newProvider).State = System.Data.Entity.EntityState.Modified;

                Bitacora providerLog = createLog(Log.Modify, Log.Provider, oldContent, newContent);
                db.Bitacora.Add(providerLog);

                db.SaveChanges();

                return result(Result.Processed, Result.Modified, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al modificar el registro: " + ex.Message, null);
            }
        }

        

        public Dictionary<Object, dynamic> deleteProvider(Proveedor registeredProvider)
        {

            try
            {

                Proveedor delProvider = db.Proveedor.Find(data["id"]);
                

                this.oldContent = delProvider.toString();
                delProvider.Eliminado = 1;
                this.newContent = delProvider.toString();

                db.Entry(delProvider).State = System.Data.Entity.EntityState.Modified;

                Bitacora userLog = createLog(Log.Delete, Log.User, this.oldContent, this.newContent);
                db.Bitacora.Add(userLog);

                db.SaveChanges();

                return result(Result.Processed, Result.Deleted, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al modificar el registro: " + ex.Message, null);
            }

        }

        

        
        #endregion

      

        private Proveedor createProvider()
        {

            return new Proveedor()
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



        private bool providerExists(int identification)
        {

            var query = from u in db.Proveedor
                        where u.IdProveedor == identification
                        select u;

            Proveedor p = query.FirstOrDefault<Proveedor>();

            return p != null;

        }
    }
}
