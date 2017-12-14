using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CACMicropresicion.Globals;
using CACMicropresicion.Model;

namespace CACMicropresicion.Controller
{
    class MaterialController : BaseController
    {
        private string oldContent, newContent;
        public Dictionary<Object, dynamic> data { get; set; }

        public MaterialController() { 
        }

        public Dictionary<Object, dynamic> insertMaterial() {

            if (String.IsNullOrEmpty(data["description"]))
            {
                return result(Result.Failed, Result.Empty, null);
            }

            try
            {

                Material material = createMaterial();
                this.oldContent = "";
                this.newContent = material.toString();

                Bitacora materialLog = createLog(Log.Insert, Log.Material, this.oldContent, this.newContent);

                db.Material.Add(material);
                db.Bitacora.Add(materialLog);
                db.SaveChanges();

                return result(Result.Processed, Result.Inserted, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Se ha generado un error: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> modifyUser() {

            Material registeredMaterial = this.data["registeredMaterial"];
            Material modifiedMaterial = this.data["modifiedMaterial"];



            if (String.IsNullOrEmpty(modifiedMaterial.Descripcion))
            {
                return result(Result.Failed, Result.Empty, null);
            }

            if (registeredMaterial.Descripcion.Equals(modifiedMaterial.Descripcion) &&
                registeredMaterial.IdTipoMaterial.Equals(modifiedMaterial.IdTipoMaterial) &&
                registeredMaterial.IdProveedor.Equals(modifiedMaterial.IdProveedor) &&
                registeredMaterial.IdEstado.Equals(modifiedMaterial.IdEstado))
            {
                return result(Result.Failed, Result.Same, null);
            }

            try
            {

                this.oldContent = registeredMaterial.toString();
                this.newContent = modifiedMaterial.toString();

                Material newMaterial = db.Material.Find(modifiedMaterial.IdMaterial);
                db.Entry(newMaterial).CurrentValues.SetValues(modifiedMaterial);
                db.Entry(newMaterial).State = System.Data.Entity.EntityState.Modified;

                Bitacora userLog = createLog(Log.Modify, Log.Material, this.oldContent, this.newContent);
                db.Bitacora.Add(userLog);

                db.SaveChanges();

                return result(Result.Processed, Result.Modified, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al modificar el registro: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> deleteMaterial() {

            try
            {

                Material deleteMaterial = db.Material.Find(((Material)this.data["materialToDelete"]).IdMaterial);

                this.oldContent = deleteMaterial.toString();
                deleteMaterial.Eliminado = 1;
                deleteMaterial.FechaElimina = this.data["deletedDate"];
                this.newContent = deleteMaterial.toString();

                db.Entry(deleteMaterial).State = System.Data.Entity.EntityState.Modified;

                Bitacora userLog = createLog(Log.Delete, Log.Material, this.oldContent, this.newContent);
                db.Bitacora.Add(userLog);

                db.SaveChanges();

                return result(Result.Processed, Result.Deleted, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al modificar el registro: " + ex.Message, null);
            }

        }

        private Material createMaterial() {

            int idMaterialType = data["type"];
            int idProvider = data["provider"];

            var queryType = from type in db.TipoMaterial
                        where type.IdTipoMaterial == idMaterialType
                        select type;

            var queryProvider = from prov in db.Proveedor
                                where prov.IdProveedor == idProvider
                                select prov;

            TipoMaterial materialType = queryType.FirstOrDefault();
            Proveedor provider = queryProvider.FirstOrDefault();

            return new Material()
            {
                Descripcion = data["description"],
                FechaAgrega = DateTime.Now,
                FechaElimina = null,
                UsuarioAgrega = data["user"],
                Eliminado = data["deleted"],
                IdEstado = data["status"],
                TipoMaterial = materialType,
                Proveedor = provider
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

        public Dictionary<Object, dynamic> getMaterialsToPopulate() {

            try
            {

                var query = from material in db.Material
                            join status in db.Estado on material.IdEstado equals status.IdEstado

                            where material.Eliminado == 0
                            orderby material.Descripcion
                            select new
                            {
                                Código = material.IdMaterial,
                                Descripción = material.Descripcion,
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

        public Dictionary<Object, dynamic> getMaterials() {

            try
            {

                var query = from material in db.Material
                            where material.Eliminado == 0
                            orderby material.Descripcion
                            select material;

                return result(Result.Processed, null, query.ToList());

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> getMaterialTypes() {

            try
            {

                var query = from type in db.TipoMaterial
                            where type.IdEstado == Status.Active
                            where type.Eliminado == 0
                            orderby type.Descripcion
                            select type;

                return result(Result.Processed, null, query.ToList());

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> getAllProviders()
        {

            try
            {

                var query = from provider in db.Proveedor
                            where provider.IdEstado == Status.Active
                            where provider.Eliminado == 0
                            orderby provider.Descripcion
                            select provider;

                return result(Result.Processed, null, query.ToList());

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }

        public Dictionary<Object, dynamic> getMaterialById(int id)
        {

            try
            {

                Material material = (from m in db.Material
                                  where m.IdMaterial == id
                                  where m.Eliminado == 0
                                  select m).FirstOrDefault();

                return result(Result.Processed, null, material);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }  

    }
}
