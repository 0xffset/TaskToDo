using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;
namespace CapaAccesoDatos
{
   public class datTask
   {
       #region sinle
       private static readonly datTask _instancia = new datTask();
       public static datTask Instancia
       {
           get
           {
               return datTask._instancia;
           }
       }
       #endregion

       public List<entTask> BuscarTask( String codtask)
       {
           SqlCommand cmd= null;
           SqlDataReader dr = null;
           List<entTask> Lista = null;
           try
           {
               SqlConnection conexion = Conexion.Instancia.conecta();
               cmd = new SqlCommand("spBuscarTask", conexion);
               
               cmd.Parameters.AddWithValue("@prmCodTask", codtask);
               cmd.CommandType = CommandType.StoredProcedure;
               conexion.Open();
               dr = cmd.ExecuteReader();
               Lista = new List<entTask>();
               if (dr.Read())
               {
                  entTask task = new entTask();
                   task.Id_Task = Convert.ToInt32(dr["Id_Task"].ToString());
                   task.Cod_Task =  dr["Cod_Task"].ToString();
                   task.Descrip_Task = dr["Descrip_Task"].ToString();
                   task.Date_StartTask = dr["Date_StartTask"].ToString();
                   task.Date_EndTask= dr["Date_EndTask"].ToString();
                   task.Status_Task = dr["Status_Task"].ToString();
                   Lista.Add(task);
               }
           }

           catch(Exception) { throw;}
           finally {cmd.Connection.Close();}
           return Lista;
       }

       public List<entTask> listartask()
       {
            SqlCommand cmd= null;
           SqlDataReader dr = null;
           List<entTask> Lista = null;
           try
           {
               SqlConnection conexion = Conexion.Instancia.conecta();
               cmd = new SqlCommand("spListarTask", conexion);
               
               cmd.CommandType = CommandType.StoredProcedure;
               conexion.Open();
               dr = cmd.ExecuteReader();
               Lista = new List<entTask>();
               while (dr.Read())
               {
                   entTask task = new entTask();
                   task.Id_Task = Convert.ToInt32(dr["Id_Task"].ToString());
                   task.Cod_Task =  dr["Cod_Task"].ToString();
                   task.Descrip_Task = dr["Descrip_Task"].ToString();
                   task.Date_StartTask = dr["Date_StartTask"].ToString();
                   task.Date_EndTask= dr["Date_EndTask"].ToString();
                   task.Status_Task = dr["Status_Task"].ToString();
                   Lista.Add(task);
               }
           }

           catch(Exception) { throw;}
           finally {cmd.Connection.Close();}
           return Lista;
       }
       public int taskrealizada(int idtask)
       {
            SqlCommand cmd = null;
            var retorno = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.conecta();
                cmd = new SqlCommand("spAnularTask", cn);
                cmd.Parameters.AddWithValue("@prmId_Task", idtask);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                retorno = cmd.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception) { throw; }
            finally { cmd.Connection.Close(); }
       }

       public int mantenimientotask(String cadxml)
       {
           SqlCommand cmd = null;
           var resultado = 0;
           try
           {
               SqlConnection c = Conexion.Instancia.conecta();
               cmd = new SqlCommand("spInsElimEditTask", c);
               cmd.Parameters.AddWithValue("@prmCadxml", cadxml);
               cmd.CommandType = CommandType.StoredProcedure;
               c.Open();
               resultado = cmd.ExecuteNonQuery();
               return resultado;
           }
           catch (Exception) {throw;}
           finally {cmd.Connection.Close();}
       }

       public entTask BuscarTask2(int idtask)
       {
           SqlCommand cmd = null;
           SqlDataReader dr = null;
           entTask task = null;

           try
           {
               SqlConnection cn = Conexion.Instancia.conecta();
              cmd = new SqlCommand("spBuscarTask2", cn);
              cmd.Parameters.AddWithValue("@prmidTask", idtask);
              cmd.CommandType = CommandType.StoredProcedure;
              cn.Open();
             dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                 task = new entTask();
                 task.Id_Task = Convert.ToInt32(dr["Id_Task"]);
                task.Cod_Task = dr["Cod_Task"].ToString();
                task.Descrip_Task = dr["Descrip_Task"].ToString();
                task.Date_StartTask = dr["Date_StartTask"].ToString();
                task.Date_EndTask = dr["Date_EndTask"].ToString();
                task.Status_Task = dr["Status_Task"].ToString();
            }
           }
           catch (Exception) { throw; }
          finally {cmd.Connection.Close();}
           return task;
       }
   }
}
