using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CACMicropresicion.Model;
using CACMicropresicion.Globals;

namespace CACMicropresicion.Controller
{
    class LoginCtrl : BaseController
    {

        public Dictionary<string, dynamic> data { get; set; }

        public LoginCtrl() {
            this.db = new CAC_MICROPRECISION_SAEntities();
        }

        public Dictionary<Object, dynamic> validateCredentials() {

            if (String.IsNullOrEmpty(data["username"]) || String.IsNullOrEmpty(data["password"])) {
                return result(Result.Failed, Result.Empty, null);
            }

            Usuario user;

            if ( ( user = getUser() ) == null) {
                return result(Result.Failed, Result.FailedCredentials, null);
            }

            if (user.IdEstado != Status.Active) {
                return result(Result.Failed, Result.UserNotActive, null);
            }

            return result(Result.Processed, null, user);

        }

        private Usuario getUser () {

            string userName = data["username"];
            string password = data["password"];

            var query = from u in db.Usuario
                        where u.NombreUsuario == userName
                        where u.Contrasena == password
                        where u.Eliminado == ((byte)0)
                        select u;

            return query.FirstOrDefault<Usuario>();

        }

    }
}
