using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CACMicropresicion.Model;
using CACMicropresicion.Globals;

namespace CACMicropresicion.Controller
{
    class UserCtrl : BaseController
    {

        private string oldContent, newContent;
        public Dictionary<Object, dynamic> data { get; set; }
        

        public UserCtrl() { 
        }

        #region GetInformationForOtherInstances
        public Dictionary<Object, dynamic> getDataToFillUsersCombo()
        {

            try
            {

                var query = from u in db.Usuario
                            where u.Eliminado == 0
                            orderby u.IdUsuario
                            select u;

                return result(Result.Processed, null, query.ToList());

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> getAllUsers()
        {
            try
            {

                var query = from u in db.Usuario
                            join s in db.Estado on u.IdEstado equals s.IdEstado
                            where u.Eliminado == 0
                            select new
                            {
                                identification = u.Cedula,
                                name = (u.NombreCompleto + " " + u.PrimerApellido + " " + u.SegundoApellido),
                                username = u.NombreUsuario,
                                type = (u.Tipo == 1) ? "Administrador" : "Operario",
                                status = s.Descripcion,
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
        #endregion

        #region Manipulation of registers
        public Dictionary<Object, dynamic> insertUserFromRegister()
        {

            if (String.IsNullOrEmpty(data["value"]))
            {
                return result(Result.Failed, Result.Empty, null);
            }

            if (userExists(data["identification"]))
            {
                return result(Result.Failed, Result.Exist, null);
            }

            try
            {

                Usuario user = this.createUser();
                data["entity"] = user;

                this.oldContent = String.Empty;
                this.newContent = data["entity"].toString();
                Bitacora userLog = createLog(Log.Insert, Log.User, this.oldContent, this.newContent);

                InfoUsuario userInfo = createUserInformation();

                this.oldContent = "";
                this.newContent = userInfo.toString();
                Bitacora userInfoLog = createLog(Log.Insert, Log.InfoUser, this.oldContent, this.newContent);


                db.Usuario.Add(data["entity"]);
                db.Bitacora.Add(userLog);
                db.InfoUsuario.Add(userInfo);
                db.Bitacora.Add(userInfoLog);

                db.SaveChanges();

                return result(Result.Processed, Result.Inserted, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al insertar el registro: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> insertUserFromMaintenance()
        {

            if (String.IsNullOrEmpty(data["identification"]) ||
                String.IsNullOrEmpty(data["name"]) ||
                String.IsNullOrEmpty(data["lastName1"]) ||
                String.IsNullOrEmpty(data["lastName2"]) ||
                String.IsNullOrEmpty(data["userName"]) ||
                String.IsNullOrEmpty(data["password"]))
            {
                return result(Result.Failed, Result.Empty, null);
            }

            if (userExists(data["identification"]))
            {
                return result(Result.Failed, Result.Exist, null);
            }

            try
            {

                Usuario user = createUser();
                this.oldContent = "";
                this.newContent = user.toString();

                Bitacora userLog = createLog(Log.Insert, Log.User, this.oldContent, this.newContent);

                db.Usuario.Add(user);
                db.Bitacora.Add(userLog);
                db.SaveChanges();

                return result(Result.Processed, Result.Inserted, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Se ha generado un error: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> modifyUser(Usuario registeredUser, Usuario modifiedUser)
        {

            if (String.IsNullOrEmpty(modifiedUser.NombreCompleto) ||
                String.IsNullOrEmpty(modifiedUser.PrimerApellido) ||
                String.IsNullOrEmpty(modifiedUser.SegundoApellido) ||
                String.IsNullOrEmpty(modifiedUser.NombreUsuario) ||
                String.IsNullOrEmpty(modifiedUser.Contrasena))
            {
                return result(Result.Failed, Result.Empty, null);
            }

            if (registeredUser.NombreCompleto.Equals(modifiedUser.NombreCompleto) &&
                registeredUser.PrimerApellido.Equals(modifiedUser.PrimerApellido) &&
                registeredUser.SegundoApellido.Equals(modifiedUser.SegundoApellido) &&
                registeredUser.NombreUsuario.Equals(modifiedUser.NombreUsuario) &&
                registeredUser.Contrasena.Equals(modifiedUser.Contrasena) &&
                registeredUser.Tipo.Equals(modifiedUser.Tipo) &&
                registeredUser.IdEstado.Equals(modifiedUser.IdEstado))
            {
                return result(Result.Failed, Result.Same, null);
            }

            try
            {

                this.oldContent = registeredUser.toString();
                this.newContent = modifiedUser.toString();

                Usuario newUser = db.Usuario.Find(modifiedUser.IdUsuario);
                db.Entry(newUser).CurrentValues.SetValues(modifiedUser);
                db.Entry(newUser).State = System.Data.Entity.EntityState.Modified;

                Bitacora userLog = createLog(Log.Modify, Log.User, this.oldContent, this.newContent);
                db.Bitacora.Add(userLog);

                db.SaveChanges();

                return result(Result.Processed, Result.Modified, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al modificar el registro: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> deleteUser(Usuario registeredUser) {

            try
            {

                Usuario delUser = db.Usuario.Find(data["id"]);

                this.oldContent = delUser.toString();
                delUser.Eliminado = 1;
                this.newContent = delUser.toString();

                db.Entry(delUser).State = System.Data.Entity.EntityState.Modified;

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

        public Dictionary<Object, dynamic> insertContactInformation() {

            try {

                data["entity"] = db.Usuario.Find(((Usuario)data["entity"]).IdUsuario);
                InfoUsuario contactInfo = createUserInformation();

                this.oldContent = String.Empty;
                this.newContent = contactInfo.toString();
                Bitacora contactInfoLog = createLog(Log.Insert, Log.InfoUser, this.oldContent, this.newContent);

                db.InfoUsuario.Add(contactInfo);
                db.Bitacora.Add(contactInfoLog);

                db.SaveChanges();

                return result(Result.Processed, Result.Inserted, null);

            } catch (Exception ex) {

                return result(Result.Failed, "Error al insertar el registro: " + ex.Message, null);

            }
            


        }
        #endregion

        private Usuario createUser()
        {

            return new Usuario()
            {
                Cedula = data["identification"],
                Tipo = data["userType"],
                NombreCompleto = data["name"],
                PrimerApellido = data["lastName1"],
                SegundoApellido = data["lastName2"],
                NombreUsuario = data["userName"],
                Contrasena = data["password"],
                FechaAgrega = DateTime.Now,
                FechaElimina = null,
                UsuarioAgrega = data["user"],
                Eliminado = (byte) data["userDeleted"],
                IdEstado = data["userStatus"]
            };

        }

        private InfoUsuario createUserInformation()
        {

            return new InfoUsuario()
            {
                Tipo = (byte) data["contactInfoType"],
                Valor = data["value"],
                FechaAgrega = DateTime.Now,
                FechaElimina = null,
                UsuarioAgrega = data["user"],
                Eliminado = (byte) data["contactInfoDeleted"],
                IdEstado = data["contactInfoStatus"],
                Usuario = data["entity"]
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

        private bool userExists(string identification)
        {

            var query = from u in db.Usuario
                        where u.Cedula == identification
                        select u;

            Usuario user = query.FirstOrDefault<Usuario>();

            return user != null;

        }

    }
}
