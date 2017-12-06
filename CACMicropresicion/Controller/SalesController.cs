using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CACMicropresicion.Model;
using CACMicropresicion.Globals;

namespace CACMicropresicion.Controller
{
    class SalesController : BaseController
    {

        public Dictionary<Object, dynamic> data { get; set; }
        private ICollection<DetalleVenta> detailList;
        private DataGridViewRowCollection saleDetail;

        #region DataToPopulate

        public Dictionary<Object, dynamic> getAllPaymentTypes()
        {

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

        public Dictionary<Object, dynamic> getAllProducts()
        {

            try
            {

                var query = from product in db.Producto
                            join productCategory in db.TipoProducto on product.IdTipoProducto equals productCategory.IdTipoProducto
                            where product.IdEstado == Status.Active
                            where product.Eliminado == 0
                            select new
                            {
                                Código = product.IdProducto,
                                Descripción = product.Descripcion,
                                Precio = product.Precio,
                                Cantidad = product.CantidadInventariable,
                                Tipo = productCategory.Descripcion,
                            };

                var products = query.ToList();
                return result(Result.Processed, null, products);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> getAllCustomers()
        {

            try
            {

                var query = from customer in db.Cliente
                            where customer.IdEstado == Status.Active
                            where customer.Eliminado == 0
                            select customer;

                var customers = query.ToList();
                return result(Result.Processed, null, customers);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        #endregion

        #region ManipulateRegisters 

        public Dictionary<Object, dynamic> insertNewSale() {

            try {

                this.saleDetail = this.data["saleDetail"];

                if (saleDetail.Count == 0) {
                    return result(Result.Failed, Result.NoItems, null);
                }

                Venta newSale = this.createsNewSale();
                ICollection<DetalleVenta> newSaleDetail = this.createNewSaleDetail();
                newSale.DetalleVenta = newSaleDetail;

                Bitacora newSaleLog = this.createLog(Log.Insert, Log.Sale, null, newSale.ToString());

                db.Venta.Add(newSale);
                db.Bitacora.Add(newSaleLog);
                db.SaveChanges();

                return result(Result.Processed, Result.Inserted, null);

            } catch (Exception ex) {
                return result(Result.Failed, "Se ha producido un error: " + ex.Message, null);
            }

        }

        public Venta createsNewSale() {

            return new Venta()
            {
                IdUsuario = this.data["userId"],
                Total = this.data["total"],
                Subtotal = this.data["subtotal"],
                Impuesto = this.data["tax"],
                Descuento = this.data["discount"],
                FechaAgrega = this.data["dateAdded"],
                FechaElimina = this.data["dateDeleted"],
                Eliminado = this.data["deleted"],
                IdEstado = this.data["statusId"],
                IdCliente = this.data["customerId"],
                IdTipoPago = this.data["paymentMethodId"],
                FechaVenta = this.data["saleDate"]
            };

        }

        public ICollection<DetalleVenta> createNewSaleDetail() {

            this.detailList = new List<DetalleVenta>();
            short line = 1;

            foreach (DataGridViewRow item in this.saleDetail) {
                DetalleVenta newItem = new DetalleVenta()
                {
                    Renglon = line,
                    Cantidad = Convert.ToInt32(item.Cells[3].Value),
                    Precio = Convert.ToDecimal(item.Cells[2].Value),
                    IdProducto = Convert.ToInt32(item.Cells[0].Value)
                };
                this.detailList.Add(newItem);
                line++;

                Bitacora newItemLog = this.createLog(Log.Insert, Log.SaleDetail, null, newItem.ToString());
                db.Bitacora.Add(newItemLog);
            }

            return this.detailList;

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

        #endregion
    }
}
