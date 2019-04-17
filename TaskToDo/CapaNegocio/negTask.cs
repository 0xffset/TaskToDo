using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaAccesoDatos;

namespace CapaNegocio
{
    public class negTask
    {
        #region single
        private static readonly negTask _instancia = new negTask();
        public static negTask Instancia
        {
            get { return negTask._instancia; }
        }
        #endregion

        public int mantenimientotask(entTask t, int tipoedicion)
        {
            try 
            {
                String CadXml = "";
                CadXml += "<task ";
                CadXml += "idtask='" + t.Id_Task + "' ";
                CadXml += "descriptask='" + t.Descrip_Task + "' ";
                CadXml += "datestarttask='" + t.Date_StartTask + "' ";
                CadXml += "dateendtask='" + t.Date_EndTask + "' ";
                CadXml += "statustask='" + t.Status_Task + "' ";
                CadXml += "tipoedicion='" + tipoedicion + "' /> ";

                CadXml = "<root>" + CadXml + "</root>";
                int resultado = datTask.Instancia.mantenimientotask(CadXml);
                if (resultado <= 0) throw new ApplicationException("Error al cargar las tareas");
                return resultado;


            }
            catch (Exception) { throw;}

        }


        public int taskrealizada(int idtask)
        {
            try
            {
                int retorno = datTask.Instancia.taskrealizada(idtask);
                if (retorno == 0) throw new ApplicationException("Error al anular la tarea");
                return retorno;
            }
            catch (Exception) { throw; }
        }
        public List<entTask> ListarTask()
        {
            try
            {
                List<entTask> Lista = datTask.Instancia.listartask();
                if (Lista.Count <= 0) throw new ApplicationException("Lista de las tareas vacias");
                else if (Lista == null) throw new ApplicationException("Error al cargar las task");
                return Lista;
            }
            catch (Exception) { throw; }
        }

        public List<entTask> BuscarTask(string codtask)
        {
            try
            {
                List<entTask> Lista = null;
                Lista = datTask.Instancia.BuscarTask( codtask);
                if (Lista == null) throw new ApplicationException("La tareano no existe");
                return Lista;
            }
            catch (Exception) { throw; }
        }

        public entTask BuscarTask2(int idtask)
        {
            try
            {
                entTask task = null;
                task = datTask.Instancia.BuscarTask2(idtask);
                if (task == null) throw new ApplicationException("No hay registros");
                return task;
            }
            catch (Exception) { throw;}
            
           

            
        }
        }
}
