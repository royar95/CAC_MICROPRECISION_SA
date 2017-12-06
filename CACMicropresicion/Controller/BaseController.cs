using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CACMicropresicion.Model;
using CACMicropresicion.Globals;

namespace CACMicropresicion.Controller
{
    public class BaseController
    {

        protected CAC_MICROPRECISION_SAEntities db;

        public BaseController() {
            this.db = new CAC_MICROPRECISION_SAEntities();
        }

        public Dictionary<Object, dynamic> result(int ResutCode, string ResultMessage, Object ResultContent)
        {

            Dictionary<Object, dynamic> result = new Dictionary<object, dynamic>();
            result["code"] = ResutCode;
            result["msg"] = ResultMessage;
            result["content"] = ResultContent;
            return result;

        }

        public Dictionary<Object, dynamic> getAllRegisterStatus() {

            try
            {

                var query = from e in db.Estado
                            where e.Tipo == 1
                            where e.Eliminado == 0
                            orderby e.IdEstado
                            select e;

                return result(Result.Processed, null, query.ToList());

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> getAllProcessStatus() {

            try
            {
                
                var query = from e in db.Estado
                            where e.Tipo == 2
                            where e.Eliminado == 0
                            orderby e.IdEstado
                            select e;

                return result(Result.Processed, null, query.ToList());

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }



    }
}
