using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CACMicropresicion.Globals;
using CACMicropresicion.Model;

namespace CACMicropresicion.Controller
{
    class ProductTypeController : BaseController
    {
        public Dictionary<string, dynamic> data { get; set; }
        private CAC_MICROPRECISION_SAEntities db = new CAC_MICROPRECISION_SAEntities(); 


        public ProductTypeController()
        {
        }

        public Dictionary<Object, dynamic> insertProductTypeFromMaintenance()
        {

            if (String.IsNullOrEmpty(data["description"]))
            {
                return result(Result.Failed, Result.Empty, null);
            }

            try
            {
                string oldContent, newContent;
                TipoProducto productType = CreateProductType();
                oldContent = "";
                newContent = productType.ToString();
                Bitacora productTypeLog = createLog(Log.Insert, Log.ProductType, oldContent, newContent);
                db.TipoProducto.Add(productType);
                db.Bitacora.Add(productTypeLog);
                db.SaveChanges();

                return result(Result.Processed, Result.Inserted, null);
            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Se ha generado un error: " + ex.Message, null);
            }         
        }

        public TipoProducto CreateProductType()
        {
            return new TipoProducto()
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

        public Dictionary<Object, dynamic> getDataToFillProductTypesCombo()
        {
            try
            {
                var query = from t in db.TipoProducto
                            where t.Eliminado == 0
                            orderby t.IdTipoProducto
                            select t;
                return result(Result.Processed, null, query.ToList());
            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> getAllProductTypes()
        {
            try
            {

                var query = from t in db.TipoProducto
                            join s in db.Estado on t.IdEstado equals s.IdEstado
                            where t.Eliminado == 0
                            select new
                            {
                                idProducto = t.IdTipoProducto,
                                description = t.Descripcion,
                                estado = s.Descripcion,
                                //eliminado = t.Eliminado
                            };

                var users = query.ToList();
                return result(Result.Processed, null, users);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }


        public Dictionary<Object, dynamic> deleteProductType(TipoProducto registeredProductType)
        {
            try
            {

                TipoProducto delProductType = db.TipoProducto.Find(data["id"]);

                string oldContent = delProductType.ToString();
                delProductType.Eliminado = 1;
                delProductType.IdEstado = Status.Inactive;
                string newContent = delProductType.ToString();
                db.Entry(delProductType).State = System.Data.Entity.EntityState.Modified;
                Bitacora paymentLog = createLog(Log.Delete, Log.ProductType, oldContent, newContent);
                db.Bitacora.Add(paymentLog);
                db.SaveChanges();
                return result(Result.Processed, Result.Deleted, null);
            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al eliminar el registro: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> modifyProductType(TipoProducto registeredProductType, TipoProducto modifiedProductType)
        {
            if (String.IsNullOrEmpty(modifiedProductType.Descripcion))
            {
                return result(Result.Failed, Result.Empty, null);
            }
            if (modifiedProductType.Descripcion.Equals(registeredProductType.Descripcion))
            {
                return result(Result.Failed, Result.Same, null);
            }
            try
            {
                string oldContent = registeredProductType.ToString();
                string newContent = modifiedProductType.ToString();
                TipoProducto newProductType = db.TipoProducto.Find(modifiedProductType.IdTipoProducto);
                db.Entry(newProductType).CurrentValues.SetValues(modifiedProductType);
                db.Entry(newProductType).State = System.Data.Entity.EntityState.Modified;
                Bitacora ProductTypeLog = createLog(Log.Modify, Log.ProductType, oldContent, newContent);
                db.Bitacora.Add(ProductTypeLog);
                db.SaveChanges();
                return result(Result.Processed, Result.Modified, null);
            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al modificar el registro: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> getProductTypeById(int id)
        {

            try
            {

                TipoProducto user = (from u in db.TipoProducto
                                 where u.IdTipoProducto == id
                                 where u.Eliminado == 0
                                 select u).FirstOrDefault();

                return result(Result.Processed, null, user);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

    }
}
