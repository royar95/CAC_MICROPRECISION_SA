using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CACMicropresicion.Globals;
using CACMicropresicion.Model;

namespace CACMicropresicion.Controller
{
    class ProductController : BaseController
    {
        public Dictionary<string, dynamic> data { get; set; }

        public ProductController()
        {
        }

        public Dictionary<Object, dynamic> insertProductFromMaintenance()
        {

            if (String.IsNullOrEmpty(data["description"]))
            {
                return result(Result.Failed, Result.Empty, null);
            }

            try
            {
                string oldContent, newContent;
                Producto product = CreateProduct();
                oldContent = "";
                newContent = product.ToString();
                Bitacora productLog = createLog(Log.Insert, Log.Product, oldContent, newContent);
                db.Producto.Add(product);
                db.Bitacora.Add(productLog);
                db.SaveChanges();

                return result(Result.Processed, Result.Inserted, null);
            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Se ha generado un error: " + ex.Message, null);
            }
        }

        public Producto CreateProduct()
        {
            return new Producto()
            {
                IdTipoProducto = data["productType"],
                Descripcion = data["description"],
                Precio = data["price"],
                CantidadInventariable = data["stock"],
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

        public Dictionary<Object, dynamic> getAllProducts()
        {
            try
            {

                var query = from t in db.Producto
                            where t.Eliminado == 0
                            select new
                            {
                                idProducto = t.IdProducto,
                                idTipoCategoria = t.IdTipoProducto,
                                description = t.Descripcion,
                                precio = t.Precio,
                                stock = t.CantidadInventariable,
                                estado = t.IdEstado,
                                eliminado = t.Eliminado
                            };

                var users = query.ToList();
                return result(Result.Processed, null, users);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> getDataToFillProductCombo()
        {
            try
            {
                var query = from t in db.Producto
                            where t.Eliminado == 0
                            orderby t.IdProducto
                            select t;
                return result(Result.Processed, null, query.ToList());
            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> deleteProduct(Producto registeredProduct)
        {
            try
            {

                Producto delProduct = db.Producto.Find(data["id"]);

                string oldContent = delProduct.ToString();
                delProduct.Eliminado = 1;
                delProduct.IdEstado = Status.Inactive;
                string newContent = delProduct.ToString();
                db.Entry(delProduct).State = System.Data.Entity.EntityState.Modified;
                Bitacora paymentLog = createLog(Log.Delete, Log.Product, oldContent, newContent);
                db.Bitacora.Add(paymentLog);
                db.SaveChanges();
                return result(Result.Processed, Result.Deleted, null);
            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al eliminar el registro: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> modifyProduct(Producto registeredProduct, Producto modifiedProduct)
        {
            if (String.IsNullOrEmpty(modifiedProduct.Descripcion) || String.IsNullOrEmpty(Convert.ToString(modifiedProduct.Precio)) ||
                String.IsNullOrEmpty(Convert.ToString(modifiedProduct.CantidadInventariable)))
            {
                return result(Result.Failed, Result.Empty, null);
            }
            
            try
            {
                string oldContent = registeredProduct.ToString();
                string newContent = modifiedProduct.ToString();
                Producto newProduct = db.Producto.Find(modifiedProduct.IdProducto);
                db.Entry(newProduct).CurrentValues.SetValues(modifiedProduct);
                db.Entry(newProduct).State = System.Data.Entity.EntityState.Modified;
                Bitacora ProductLog = createLog(Log.Modify, Log.ProductType, oldContent, newContent);
                db.Bitacora.Add(ProductLog);
                db.SaveChanges();
                return result(Result.Processed, Result.Modified, null);
            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al modificar el registro: " + ex.Message, null);
            }

        }

    }
}
