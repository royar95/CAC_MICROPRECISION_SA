using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CACMicropresicion.Globals;
using CACMicropresicion.Model;

namespace CACMicropresicion.Controller
{
    class PurchaseController : BaseController
    {

        public PurchaseController() {
        }

        #region DataToPopulate

        public Dictionary<Object, dynamic> getAllMaterials() {

            try
            {

                var query = from material in db.Material
                            join materialType in db.TipoMaterial on material.IdTipoMaterial equals materialType.IdTipoMaterial
                            join provider in db.Proveedor on material.IdProveedor equals provider.IdProveedor
                            where material.IdEstado == Status.Active
                            where material.Eliminado == 0
                            select new
                            {
                                Código = material.IdMaterial,
                                Descripción = material.Descripcion,
                                Tipo = materialType.Descripcion,
                                Proveedor = provider.Descripcion
                            };

                var materials = query.ToList();
                return result(Result.Processed, null, materials);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> getAllPaymentTypes() {

            try
            {

                var query = from type in db.TipoPago
                            where type.IdEstado == Status.Active
                            where type.Eliminado == 0
                            select type;

                var types = query.ToList();
                return result(Result.Processed, null, types);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        #endregion

    }
}
