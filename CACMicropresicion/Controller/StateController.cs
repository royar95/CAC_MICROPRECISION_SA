using CACMicropresicion.Globals;
using CACMicropresicion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACMicropresicion.Controller
{
    class StateController : BaseController
    {
        public Dictionary<string, dynamic> data { get; set; }

        public StateController() { }



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


        private bool StateExists(int identification)
        {

            var query = from e in db.Estado
                        where e.IdEstado == identification
                        select e;

            Estado state = query.FirstOrDefault<Estado>();

            return state != null;
        }

        public Dictionary<Object, dynamic> insertStateFromMaintenance()
        {

            if (String.IsNullOrEmpty(data["description"]) || data["id"]<0 )
            {
                return result(Result.Failed, Result.Empty, null);
            }
            if (StateExists(data["id"]))
            {
                return result(Result.Failed, Result.Exist, null);
            }
            try
            {

                string oldContent, newContent;

                Estado state = CreateState();
                oldContent = "";
                newContent = state.toString();

                Bitacora stateLog = createLog(Log.Insert, Log.State, oldContent, newContent);

                db.Estado.Add(state);
                db.Bitacora.Add(stateLog);
                db.SaveChanges();

                return result(Result.Processed, Result.Inserted, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Se ha generado un error: " + ex.Message, null);
            }
        }


         public Estado CreateState() {
            return new Estado()
            {
                IdEstado = data["id"],
                Descripcion = data["description"],
                FechaAgrega = DateTime.Now,
                FechaElimina = null,
                UsuarioAgrega = data["user"],
                Eliminado = 0,
            };
        }



        public Dictionary<Object, dynamic> getAllStates()
        {
            try
            {

                var query = from s in db.Estado
                            where s.Eliminado == 0
                            select new
                            {
                                idState = s.IdEstado,
                                description = s.Descripcion
                            };

                var users = query.ToList();
                return result(Result.Processed, null, users);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }


        public Dictionary<Object, dynamic> modifyState(Estado registeredState, Estado modifiedState)
        {

            if (String.IsNullOrEmpty(modifiedState.Descripcion))
            {
                return result(Result.Failed, Result.Empty, null);
            }

            if (registeredState.Descripcion.Equals(modifiedState.Descripcion))
            {
                return result(Result.Failed, Result.Same, null);
            }

            try
            {

                string oldContent = registeredState.toString();
                string newContent = modifiedState.toString();

                Estado newState = db.Estado.Find(modifiedState.IdEstado);
                db.Entry(newState).CurrentValues.SetValues(modifiedState);
                db.Entry(newState).State = System.Data.Entity.EntityState.Modified;

                Bitacora clientLog = createLog(Log.Modify, Log.State, oldContent, newContent);
                db.Bitacora.Add(clientLog);

                db.SaveChanges();

                return result(Result.Processed, Result.Modified, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al modificar el registro: " + ex.Message, null);
            }

        }


        public Dictionary<Object, dynamic> deleteState(Estado registeredState)
        {
            try
            {

                Estado delState = db.Estado.Find(data["id"]);

                string oldContent = delState.toString();
                delState.Eliminado = 1;
                string newContent = delState.toString();

                db.Entry(delState).State = System.Data.Entity.EntityState.Modified;

                Bitacora stateLog = createLog(Log.Delete, Log.State, oldContent, newContent);
                db.Bitacora.Add(stateLog);

                db.SaveChanges();

                return result(Result.Processed, Result.Deleted, null);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al eliminar el registro: " + ex.Message, null);
            }

        }



    }
}
