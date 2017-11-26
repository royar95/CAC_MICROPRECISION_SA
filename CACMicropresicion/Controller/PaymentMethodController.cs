using CACMicropresicion.Globals;
using CACMicropresicion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACMicropresicion.Controller
{
    class PaymentMethodController : BaseController
    {
        public Dictionary<string, dynamic> data { get; set; }
        private CAC_MICROPRECISION_SAEntities db = new CAC_MICROPRECISION_SAEntities();

        public PaymentMethodController() { }

        public TipoPago CreatePaymentMethod()
        {
            return new TipoPago()
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

        public Dictionary<Object, dynamic> insertPaymentMethodFromMaintenance()
        {

            if (String.IsNullOrEmpty(data["description"]))
            {
                return result(Result.Failed, Result.Empty, null);
            }

            try
            {

                string oldContent, newContent;

                TipoPago paymentMethod = CreatePaymentMethod();
                oldContent = "";
                newContent = paymentMethod.toString();

                Bitacora paymentMethodLog = createLog(Log.Insert, Log.PaymentMethods, oldContent, newContent);

                db.TipoPago.Add(paymentMethod);
                db.Bitacora.Add(paymentMethodLog);
                db.SaveChanges();

                return result(Result.Processed, Result.Inserted, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Se ha generado un error: " + ex.Message, null);
            }

        }


        public Dictionary<Object, dynamic> deletePaymentMethod(TipoPago registeredPayment)
        {
            try
            {

                TipoPago delPaymentMethod = db.TipoPago.Find(data["id"]);

                string oldContent = delPaymentMethod.toString();
                delPaymentMethod.Eliminado = 1;
                string newContent = delPaymentMethod.toString();

                db.Entry(delPaymentMethod).State = System.Data.Entity.EntityState.Modified;

                Bitacora paymentLog = createLog(Log.Delete, Log.PaymentMethods, oldContent, newContent);
                db.Bitacora.Add(paymentLog);

                db.SaveChanges();

                return result(Result.Processed, Result.Deleted, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al eliminar el registro: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> getDataToFillPaymentsCombo()
        {

            try
            {

                var query = from t in db.TipoPago
                            where t.Eliminado == 0
                            orderby t.IdTipoPago
                            select t;

                return result(Result.Processed, null, query.ToList());

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> modifyPaymentMethod(TipoPago registeredPayment, TipoPago modifiedPayment)
        {

            if (String.IsNullOrEmpty(modifiedPayment.Descripcion))
            {
                return result(Result.Failed, Result.Empty, null);
            }

            if (registeredPayment.Descripcion.Equals(registeredPayment.Descripcion))
            {
                return result(Result.Failed, Result.Same, null);
            }

            try
            {

                string oldContent = registeredPayment.toString();
                string newContent = modifiedPayment.toString();

                TipoPago newPayment = db.TipoPago.Find(modifiedPayment.IdTipoPago);
                db.Entry(newPayment).CurrentValues.SetValues(modifiedPayment);
                db.Entry(newPayment).State = System.Data.Entity.EntityState.Modified;

                Bitacora paymentLog = createLog(Log.Modify, Log.PaymentMethods, oldContent, newContent);
                db.Bitacora.Add(paymentLog);

                db.SaveChanges();

                return result(Result.Processed, Result.Modified, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al modificar el registro: " + ex.Message, null);
            }

        }


        public Dictionary<Object, dynamic> getAllPaymentMethods()
        {
            try
            {

                var query = from t in db.TipoPago
                            where t.Eliminado == 0
                            select new
                            {
                                idState = t.IdTipoPago,
                                description = t.Descripcion
                            };

                var users = query.ToList();
                return result(Result.Processed, null, users);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }


    }
}
