using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CACMicropresicion.Globals;
using CACMicropresicion.Model;

namespace CACMicropresicion.Controller
{
    class LogController: BaseController
    {

        public LogController() { 
        }

        public Dictionary<Object, dynamic> getLogs()
        {
            try
            {

                var query = from log in db.Bitacora
                            orderby log.Fecha
                            select new
                            {
                                log.Fecha,
                                log.TablaAfectada,
                                log.Accion,
                                log.ContenidoNuevo,
                                log.ContenidoViejo,
                                log.UsuarioAgrega
                            };

                var logs = query.ToList();
                return result(Result.Processed, null, logs);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

    }
}
