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

        public Dictionary<Object, dynamic> data { get; set; }

        public LogController() { 
        }

        public Dictionary<Object, dynamic> getLogs()
        {
            try
            {

                string identification = data["userId"];
                DateTime startDate = data["startDate"];
                DateTime endDate = data["endDate"];

                var query = from log in db.Bitacora
                            where log.UsuarioAgrega == identification
                            where log.Fecha >= startDate
                            where log.Fecha <= endDate
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
