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

        public void searchRows(Bunifu.Framework.UI.BunifuCustomDataGrid dg, string searchValue) {

            dg.CurrentCell = null;
            int valueLength = searchValue.Length;

            foreach (DataGridViewRow row in dg.Rows)
            {
                row.Visible = true;

                if (!searchValue.Equals(String.Empty))
                {
                    if (valueLength > row.Cells[1].Value.ToString().Length)
                    {
                        row.Visible = false;
                        continue;
                    }

                    string cellValue = row.Cells[1].Value.ToString().Substring(0, valueLength);

                    if (!cellValue.Equals(searchValue))
                    {
                        row.Visible = false;
                    }
                }
            }

        }

    }
}
