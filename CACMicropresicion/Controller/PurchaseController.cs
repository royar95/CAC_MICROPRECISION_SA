using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CACMicropresicion.Globals;
using CACMicropresicion.Model;

namespace CACMicropresicion.Controller
{
    class PurchaseController : BaseController
    {
        private DataGridViewRowCollection items;
        public PurchaseController() {
        }

        public Dictionary<Object, dynamic> data { get; set; }
 
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

        public Dictionary<Object, dynamic> getPurchasesByDate (DateTime purchaseDate) {

            try
            {

                var query = from purchase in db.Compra
                            join user in db.Usuario on purchase.IdUsuario equals user.IdUsuario
                            join status in db.Estado on purchase.IdEstado equals status.IdEstado
                            join paymentMethod in db.TipoPago on purchase.IdTipoPago equals paymentMethod.IdTipoPago
                            where purchase.FechaCompra == purchaseDate
                            where purchase.Eliminado == 0
                            select new {
                                Id = purchase.IdCompra,
                                Fecha = purchase.FechaCompra,
                                Total = purchase.TotalCompra,
                                Pago = paymentMethod.Descripcion,
                                Usuario = (user.NombreCompleto + " " + user.PrimerApellido + " " + user.SegundoApellido),
                                Estado = status.Descripcion,
                                Agregada = purchase.FechaAgrega
                            };

                var purchases = query.ToList();
                return result(Result.Processed, null, purchases);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> getPurchaseById(int id) {

            try
            {

                Compra purchaseHeader = (from c in db.Compra
                                  where c.IdCompra == id
                                  where c.Eliminado == 0
                                  select c).FirstOrDefault();

                var purchaseDetail = (from d in db.DetalleCompra
                                                    join m in db.Material on d.IdMaterial equals m.IdMaterial
                                                    where d.IdCompra == id
                                                    orderby d.Renglon
                                                    select new {
                                                        d.IdMaterial,
                                                        m.Descripcion,
                                                        d.Cantidad
                                                    }
                                                    ).ToList();

                Dictionary<Object, dynamic> purchase = new Dictionary<object, dynamic>();
                purchase["header"] = purchaseHeader;
                purchase["detail"] = purchaseDetail;

                return result(Result.Processed, null, purchase);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        #endregion

        #region ManipulatePurchase

        public Dictionary<Object, dynamic> insertNewPurchase() {

            try
            {

                this.items = this.data["purchaseDetail"];
                var total = this.data["total"];

                if (items.Count == 0)
                {
                    return result(Result.Failed, Result.NoItemsPurchase, null);
                }

                foreach (DataGridViewRow item in this.items)
                {
                    if (item.Cells[2].Value == null)
                    {
                        return result(Result.Failed, Result.NoQuantity, null);
                    }
                }

                if (total.Equals(String.Empty))
                {
                    return result(Result.Failed, Result.Empty, null);
                }

                total = Decimal.Parse(total);

                if (total <= 0)
                {
                    return result(Result.Failed, Result.CeroOrLess, null);
                }

                Compra purchase = this.createsPurchase(total);
                Bitacora purchaseLog = this.createLog(Log.Insert, Log.Purchase, "", purchase.toString());
                db.Bitacora.Add(purchaseLog);

                ICollection<DetalleCompra> detail = this.createsPurchaseDetail();
                purchase.DetalleCompra = detail;

                db.Compra.Add(purchase);
                db.SaveChanges();

                return result(Result.Processed, Result.Inserted, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Se ha generado un error: " + ex.Message, null);
            }

        }

        private Compra createsPurchase (Decimal total)
        {
            return new Compra()
            {
                IdUsuario = this.data["userId"],
                FechaAgrega = DateTime.Now,
                FechaElimina = null,
                Eliminado = (byte)0,
                IdEstado = (int)this.data["status"],
                TotalCompra = total,
                IdTipoPago = this.data["paymentMethod"],
                FechaCompra = this.data["date"]
            };
        }

        private ICollection<DetalleCompra> createsPurchaseDetail() {
            List<DetalleCompra> purchaseDetail = new List<DetalleCompra>();

            short line = 1;
            foreach (DataGridViewRow item in this.items) {

                DetalleCompra newItem = new DetalleCompra();
                newItem.Renglon = line;
                newItem.Cantidad = Int32.Parse(item.Cells[2].Value.ToString());
                newItem.IdMaterial = Int32.Parse(item.Cells[0].Value.ToString());
                purchaseDetail.Add(newItem);

                Bitacora itemLog = this.createLog(Log.Insert, Log.PurchaseDetail, "", newItem.toString());
                db.Bitacora.Add(itemLog);

                line++;
            }

            return purchaseDetail;

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
