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
        public Dictionary<Object, dynamic> data { get; set; }


        public ProviderController()
        {
        }

        public Dictionary<Object, dynamic> getAddress(int providerID)
        {

        }

        public Dictionary<Object, dynamic> getAllProviders()
        {
            try
            {

                var query = from u in db.Proveedor
                            where u.Eliminado == 0
                            select new
                            {
                                identification = u.IdProveedor,
                                name = u.Descripcion,
                                deleted = (u.Eliminado == 1) ? "Si" : "No"
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

        
        #endregion

        #region Manipulation of registers
        

        public Dictionary<Object, dynamic> insertProvider()
        {

            if (String.IsNullOrEmpty(data["phone"]) ||
                String.IsNullOrEmpty(data["name"]) ||
                String.IsNullOrEmpty(data["provincia"]) ||
                String.IsNullOrEmpty(data["canton"]) ||
                String.IsNullOrEmpty(data["distrito"]) ||
                String.IsNullOrEmpty(data["address"]) ||
                String.IsNullOrEmpty(data["email"]))
            {
                return result(Result.Failed, Result.Empty, null);
            }
            

            try
            {

                Proveedor provider = createProvider();
                this.oldContent = "";
                this.newContent = provider.toString();
                db.Proveedor.Add(provider);

                Bitacora userLog = createLog(Log.Insert, Log.User, this.oldContent, this.newContent);

                InfoProveedor info = new InfoProveedor((byte)1, data["email"], DateTime.Now, DateTime.Now, data["user"],
                (byte)data["userDeleted"], provider.IdProveedor, data["userStatus"]);
                info.FechaElimina = null;

                DireccionProveedor dir = new DireccionProveedor(data["provincia"], data["canton"], data["distrito"],
                     data["address"], DateTime.Now, DateTime.Now, (byte)0 , data["user"],
                     provider.IdProveedor, data["userStatus"]);
                dir.FechaElimina = null;

                db.InfoProveedor.Add(info);
                db.DireccionProveedor.Add(dir);
                db.Bitacora.Add(userLog);
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

            if (registerProvider.Descripcion.Equals(modifiedProvider.Descripcion))
            {
                return result(Result.Failed, Result.Same, null);
            }

            try
            {

                this.oldContent = registerProvider.toString();
                this.newContent = modifiedProvider.toString();

                Proveedor newProvider = db.Proveedor.Find(modifiedProvider.IdProveedor);
                db.Entry(newProvider).CurrentValues.SetValues(modifiedProvider);
                db.Entry(newProvider).State = System.Data.Entity.EntityState.Modified;
                

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

        

        public Dictionary<Object, dynamic> insertProviderInfo()
        {

            if (String.IsNullOrEmpty(data["value"]))
            {
                return result(Result.Failed, Result.Empty, null);
            }

            try
            {

                data["entity"] = db.Proveedor.Find(((Proveedor)data["entity"]).IdProveedor);
                InfoProveedor providerInfo = createProviderInformation();

                this.oldContent = String.Empty;
                this.newContent = providerInfo.toString();

                db.InfoProveedor.Add(providerInfo);

                db.SaveChanges();

                return result(Result.Processed, Result.Inserted, null);

            }
            catch (Exception ex)
            {

                return result(Result.Failed, "Error al insertar el registro: " + ex.Message, null);

            }



        }
        #endregion

        private InfoProveedor createProviderInformation()
        {

            

            return new InfoProveedor()
            {
                Tipo = (byte)1,
                Valor = data["email"],
                FechaAgrega = DateTime.Now,
                FechaElimina = null,
                UsuarioAgrega = data["user"],
                Eliminado = (byte)data["userDeleted"],
                IdEstado = data["contactInfoStatus"],
                Proveedor = data["entity"]
            };

        }

        private DireccionProveedor createProviderAddress()
        {

            return new DireccionProveedor()
            {
                Provincia = data["provincia"],
                Canton = data["canton"],
                Distrito = data["canton"],
                DireccionExacta = data["direccion"],
                FechaAgrega = DateTime.Now,
                FechaElimina = null,
                UsuarioAgrega = data["user"],
                Eliminado = (byte)data["contactInfoDeleted"],
                IdEstado = data["contactInfoStatus"],
                Proveedor = data["entity"]
            };

        }

        private Proveedor createProvider()
        {

            return new Proveedor()
            {
                Descripcion = data["name"],
                FechaAgrega = DateTime.Now,
                FechaElimina = null,
                UsuarioAgrega = data["user"],
                Eliminado = (byte)data["userDeleted"],
                IdEstado = data["userStatus"]
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
