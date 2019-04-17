using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CapaPresentacion
{
   public  class AccionBotones
    {
       public void limpiartxt(Control control)
       {
           try
           {
               foreach (Control txt in control.Controls)
               {
                   if (txt is TextBox)
                   {
                       
                      
                           ((TextBox)txt).Clear();
                      
                   }
                   else if (txt is GroupBox)
                   {
                       foreach (Control txtgb in txt.Controls)
                       {
                           if (txtgb is TextBox)
                           {
                               ((TextBox)txtgb).Clear();
                           }
                       }
                   }
               }
           }
           catch (Exception) { throw; }
       }


      

       public void bloqueardtp(Control control, Boolean estado)
       {
           try
           {
                foreach (Control dtp in control.Controls)
                {
                    if (dtp is GroupBox)
                    {
                        foreach (Control h in dtp.Controls)
                        {
                            if(h is DateTimePicker)
                            {
                                ((DateTimePicker)h).Enabled = estado;
                            }
                        }
                    }
                }
           }
           catch(Exception) {throw;}
       }
       public void bloquartxt(Control control, Boolean estado)
       {
           try 
           {
               foreach (Control txt in control.Controls)
               {
                   if (txt is TextBox)
                   {
                       ((TextBox)txt).Enabled = estado;
                       if (txt.Name == "txtCodigoTask" || txt.Name == "txtIdTask" || txt.Name == "txtEstadoTask" )
                       {
                           ((TextBox)txt).Enabled = false;
                       }

                       if (txt.Name == "txtBuscarTask")
                       {
                           ((TextBox)txt).Enabled = true;
                       }
                   }
                    else if (txt is GroupBox)
                   {
                       foreach (Control txtgb in txt.Controls)
                       {
                           if (txtgb is TextBox)
                           {
                               ((TextBox)txtgb).Enabled = estado;
                               if (txtgb.Name == "txtCodigoTask" || txtgb.Name == "txtIdTask" || txtgb.Name == "txtEstadoTask")
                               {
                                   ((TextBox)txtgb).Enabled = false;
                               }
                           }
                       }
                         }
               }

           }
           catch (Exception) { throw; }
       }
       
    }
}
