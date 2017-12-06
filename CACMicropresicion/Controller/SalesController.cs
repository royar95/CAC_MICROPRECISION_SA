using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CACMicropresicion.Model;
using CACMicropresicion.Globals;
using iTextSharp.text;
using System.Data;

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

        public Dictionary<Object, dynamic> getSalesByDate (DateTime purchaseDate)
        {

            try
            {

                var query = from sale in db.Venta
                            join user in db.Usuario on sale.IdUsuario equals user.IdUsuario
                            join customer in db.Cliente on sale.IdCliente equals customer.IdCliente
                            join status in db.Estado on sale.IdEstado equals status.IdEstado
                            join paymentMethod in db.TipoPago on sale.IdTipoPago equals paymentMethod.IdTipoPago
                            where sale.FechaVenta == purchaseDate
                            where sale.Eliminado == 0
                            select new
                            {
                                Id = sale.IdVenta,
                                Fecha = sale.FechaVenta,
                                Cliente = customer.Descripcion,
                                Total = sale.Total,
                                Pago = paymentMethod.Descripcion,
                                Usuario = (user.NombreCompleto + " " + user.PrimerApellido + " " + user.SegundoApellido),
                                Estado = status.Descripcion,
                                Agregada = sale.FechaAgrega
                            };

                var sales = query.ToList();
                return result(Result.Processed, null, sales);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> getSaleById (int id)
        {

            try
            {

                Venta saleHeader = (from sale in db.Venta
                                         where sale.IdVenta == id
                                         where sale.Eliminado == 0
                                         select sale).FirstOrDefault();

                var saleDetail = (from detail in db.DetalleVenta
                                      join product in db.Producto on detail.IdProducto equals product.IdProducto
                                      where detail.IdVenta == id
                                      orderby detail.Renglon
                                      select new
                                      {
                                          detail.IdVenta,
                                          detail.IdDetalleVenta,
                                          detail.Renglon,
                                          detail.IdProducto,
                                          product.Descripcion,
                                          detail.Precio,
                                          detail.Cantidad
                                      }
                                                    ).ToList();

                Dictionary<Object, dynamic> sales = new Dictionary<object, dynamic>();
                sales["header"] = saleHeader;
                sales["detail"] = saleDetail;

                return result(Result.Processed, null, sales);

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

        public Dictionary<Object, dynamic> modifySale ()
        {

            try
            {

                //Old registers
                Venta oldSaleHeader = this.data["oldSaleHeader"];
                DataGridViewRowCollection oldSaleDetail = this.data["oldSaleDetail"];

                //New ones
                Venta newSaleHeader = this.createNewSale(oldSaleHeader);
                DataGridViewRowCollection newSaleDetail = this.data["saleDetail"];

                if (!hasChanges(oldSaleHeader, newSaleHeader, oldSaleDetail, newSaleDetail))
                {
                    return result(Result.Failed, Result.Same, null);
                }

                //Data for the modified sale header
                string oldContent = oldSaleHeader.ToString();
                string newContent = newSaleHeader.ToString();

                Venta saleHeaderModified = db.Venta.Find(oldSaleHeader.IdVenta);
                db.Entry(saleHeaderModified).CurrentValues.SetValues(newSaleHeader);
                db.Entry(saleHeaderModified).State = System.Data.Entity.EntityState.Modified;

                Bitacora saleHeaderModLog = createLog(Log.Modify, Log.Sale, oldContent, newContent);
                db.Bitacora.Add(saleHeaderModLog);

                //Data for the modified sale Detail
                db.DetalleVenta.RemoveRange(db.DetalleVenta.Where(d => d.IdVenta == newSaleHeader.IdVenta));
                ICollection<DetalleVenta> newDetail = new List<DetalleVenta>();

                foreach (DataGridViewRow item in newSaleDetail)
                {

                    short line = 1;
                    DetalleVenta newItem = new DetalleVenta()
                    {
                        IdVenta = Convert.ToInt32(item.Cells[0].Value),
                        IdProducto = Convert.ToInt32(item.Cells[1].Value),
                        Renglon = line,
                        Precio = Convert.ToDecimal(item.Cells[3].Value),
                        Cantidad = Convert.ToInt32(item.Cells[4].Value)
                    };

                    line++;
                    newDetail.Add(newItem);

                    Bitacora detailItemMod = createLog(Log.Modify, Log.PurchaseDetail, "", newItem.ToString());
                    db.Bitacora.Add(detailItemMod);

                }

                saleHeaderModified.DetalleVenta = newDetail;
                db.SaveChanges();

                return result(Result.Processed, Result.Inserted, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Se ha producido un error: " + ex.Message, null);
            }

        }

        private bool hasChanges(

            Venta oldSaleHeader,
            Venta newSaleHeader,
            DataGridViewRowCollection oldSaleDetail,
            DataGridViewRowCollection newSaleDetail)
        {

            bool detailsHasChanges = false;
            bool headerHasChanges = false;

            if (oldSaleDetail.Count != newSaleDetail.Count)
            {
                detailsHasChanges = true;
            }
            else
            {
                for (int i = 0; i < newSaleDetail.Count; i++)
                {
                    if (!newSaleDetail[i].Cells[1].Value.Equals(oldSaleDetail[i].Cells[1].Value))
                    {
                        detailsHasChanges = true;
                    }
                    else
                    {
                        if (!newSaleDetail[i].Cells[4].Value.Equals(oldSaleDetail[i].Cells[4].Value))
                        {
                            detailsHasChanges = true;
                        }
                    }
                }
            }

            if (!newSaleHeader.IdTipoPago.Equals(oldSaleHeader.IdTipoPago) ||
                !newSaleHeader.FechaVenta.Equals(oldSaleHeader.FechaVenta) ||
                !newSaleHeader.Total.Equals(oldSaleHeader.Total) ||
                !newSaleHeader.Subtotal.Equals(oldSaleHeader.Subtotal) ||
                !newSaleHeader.Descuento.Equals(oldSaleHeader.Descuento) ||
                !newSaleHeader.Impuesto.Equals(oldSaleHeader.Impuesto) ||
                !newSaleHeader.IdCliente.Equals(oldSaleHeader.IdCliente) ||
                !newSaleHeader.IdEstado.Equals(oldSaleHeader.IdEstado))
            {
                headerHasChanges = true;
            }

            return headerHasChanges == true || detailsHasChanges == true;

        }

        public Venta createNewSale (Venta oldSale) {

            return new Venta()
            {
                IdVenta = oldSale.IdVenta,
                IdUsuario = oldSale.IdUsuario,
                Total = this.data["total"],
                Subtotal = this.data["subtotal"],
                Impuesto = this.data["tax"],
                Descuento = this.data["discount"],
                FechaAgrega = oldSale.FechaAgrega,
                FechaElimina = oldSale.FechaElimina,
                Eliminado = oldSale.Eliminado,
                IdEstado = this.data["statusId"],
                IdCliente = this.data["customerId"],
                IdTipoPago = this.data["paymentMethodId"],
                FechaVenta = this.data["saleDate"]
            };

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

        public Document createDocument() {

            DataTable items = this.createDataTable();
            return null;

        }

        public DataTable createDataTable() {

            DataGridViewRowCollection items = this.data["saleDetail"];

            DataTable itemsTable = new DataTable();
            itemsTable.Columns.Add("Id Producto");
            itemsTable.Columns.Add("Descripción");
            itemsTable.Columns.Add("Precio");
            itemsTable.Columns.Add("Cantidad");
            itemsTable.Columns.Add("Total");

            foreach (DataGridViewRow item in items) {
                itemsTable.Rows.Add(
                    Convert.ToString(item.Cells[1].Value),
                    Convert.ToString(item.Cells[2].Value),
                    Convert.ToString(item.Cells[3].Value),
                    Convert.ToString(item.Cells[4].Value),
                    Convert.ToString(Convert.ToInt32(item.Cells[3].Value) * Convert.ToDecimal(item.Cells[2].Value))
                    );
            }

            return itemsTable;

        }

        public void exportDataToPdf(DataTable dt, string path, string title) {

            System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.CreateNew);

        }

    }
}
