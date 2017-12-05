using CACMicropresicion.Globals;
using CACMicropresicion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACMicropresicion.Controller
{

    class MaterialTypeController : BaseController
    {
        public Dictionary<string, dynamic> data { get; set; }

        public MaterialTypeController() { }

        public Dictionary<Object, dynamic> insertMaterialTypeFromMaintenance()
        {

            if (String.IsNullOrEmpty(data["description"]))
            {
                return result(Result.Failed, Result.Empty, null);
            }

            try
            {

                string oldContent, newContent;

                TipoMaterial materialType = CreateMaterialType();
                oldContent = "";
                newContent = materialType.toString();

                Bitacora materialTypeLog = createLog(Log.Insert, Log.MaterialType, oldContent, newContent);

                db.TipoMaterial.Add(materialType);
                db.Bitacora.Add(materialTypeLog);
                db.SaveChanges();

                return result(Result.Processed, Result.Inserted, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Se ha generado un error: " + ex.Message, null);
            }

        }

        

        public TipoMaterial CreateMaterialType()
        {
            return new TipoMaterial()
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

        public Dictionary<Object, dynamic> getDataToFillMaterialsCombo()
        {
            try
            {
                var query = from t in db.TipoMaterial
                            where t.Eliminado == 0
                            orderby t.IdTipoMaterial
                            select t;

                return result(Result.Processed, null, query.ToList());

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }


        public Dictionary<Object, dynamic> deleteMaterialType(TipoMaterial registeredMaterialType)
        {
            try
            {

                TipoMaterial delMaterialType = db.TipoMaterial.Find(data["id"]);

                string oldContent = delMaterialType.toString();
                delMaterialType.Eliminado = 1;
                delMaterialType.IdEstado = Status.Inactive;
                string newContent = delMaterialType.toString();

                db.Entry(delMaterialType).State = System.Data.Entity.EntityState.Modified;

                Bitacora paymentLog = createLog(Log.Delete, Log.MaterialType, oldContent, newContent);
                db.Bitacora.Add(paymentLog);

                db.SaveChanges();

                return result(Result.Processed, Result.Deleted, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al eliminar el registro: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> modifyMaterialType(TipoMaterial registeredMaterial, TipoMaterial modifiedMaterial)
        {

            if (String.IsNullOrEmpty(modifiedMaterial.Descripcion))
            {
                return result(Result.Failed, Result.Empty, null);
            }

            if (registeredMaterial.Descripcion.Equals(modifiedMaterial.Descripcion) &&
                registeredMaterial.IdEstado.Equals(modifiedMaterial.IdEstado))
            {
                return result(Result.Failed, Result.Same, null);
            }

            try
            {

                string oldContent = registeredMaterial.toString();
                string newContent = modifiedMaterial.toString();

                TipoMaterial newMaterialType = db.TipoMaterial.Find(modifiedMaterial.IdTipoMaterial);
                db.Entry(newMaterialType).CurrentValues.SetValues(modifiedMaterial);
                db.Entry(newMaterialType).State = System.Data.Entity.EntityState.Modified;

                Bitacora MaterialTypeLog = createLog(Log.Modify, Log.MaterialType, oldContent, newContent);
                db.Bitacora.Add(MaterialTypeLog);

                db.SaveChanges();

                return result(Result.Processed, Result.Modified, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al modificar el registro: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> getAllMaterialTypes()
        {
            try
            {

                var query = from t in db.TipoMaterial
                            join status in db.Estado on t.IdEstado equals status.IdEstado
                            where t.Eliminado == 0
                            select new
                            {
                                Código = t.IdTipoMaterial,
                                Descripción = t.Descripcion,
                                Estado = status.Descripcion
                            };

                var users = query.ToList();
                return result(Result.Processed, null, users);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> getMaterialTypeById(int id) {

            try
            {

                TipoMaterial type = (from t in db.TipoMaterial
                                     where t.IdTipoMaterial == id
                                     where t.Eliminado == 0
                                     select t).FirstOrDefault();

                return result(Result.Processed, null, type);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }
        
        }



    }
}
