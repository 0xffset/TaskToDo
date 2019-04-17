using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmTask : Form
    {
        

        public frmTask()
        {
            InitializeComponent();
        }
        AccionBotones accion = new AccionBotones();

        private void AccionBotones(Boolean nuevo, Boolean grabar ,Boolean realizar, Boolean cancelar, Boolean salir)
        {
            btnNuevo.Enabled = nuevo;
            btnGrabar.Enabled = grabar;
            btnRealizada.Enabled = realizar;
            btnCancelar.Enabled = cancelar;
            btnSalir.Enabled = salir;
        }

        private void CrearGrid()
        {
            try
            {
                dgvTask.Columns.Add("ColumnId", "Id");
                dgvTask.Columns.Add("ColumnNum", "#");
                dgvTask.Columns.Add("ColumnCodigo", "Codigo");
                dgvTask.Columns.Add("ColumnDescrip", "Descripcion");
                dgvTask.Columns.Add("ColumnFechInicio", "Fecha Inicio");
                dgvTask.Columns.Add("ColumnFechFin", "Fecha Fin");
                dgvTask.Columns.Add("ColumnEstado", "Estado");

                dgvTask.Columns[0].Visible = false;
                dgvTask.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvTask.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                DataGridViewCellStyle css = new DataGridViewCellStyle();
                css.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvTask.ColumnHeadersDefaultCellStyle = css;

                dgvTask.AllowUserToAddRows = false;
                dgvTask.MultiSelect = false;
                dgvTask.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception) { throw; }
        }

        private void frmTask_Load(object sender, EventArgs e)
        {
            
            CrearGrid();
            LlenarGrip();
            AccionBotones(true, false, false, true, false);
            accion.bloquartxt(this.tabPage1, false);
            accion.bloqueardtp(this.tabPage1, false);
            
        }

        private void LlenarGrip()
        {
            try 
            {
                int num = 0;
                dgvTask.Rows.Clear();
                List<entTask> Lista = negTask.Instancia.ListarTask();
                for (int i = 0; i < Lista.Count; i++)
                {
                    
                    
                    num++;
                    String[] fila = new string[] { Lista[i].Id_Task.ToString(), num.ToString(), 
                        Lista[i].Cod_Task, Lista[i].Descrip_Task, Lista[i].Date_StartTask.ToString(), Lista[i].Date_EndTask.ToString(), 
                        Lista[i].Status_Task };
                    dgvTask.Rows.Add(fila);
                }
            }
            catch (Exception) { throw; }
        }

      

      

        private void dgvTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void limpiartxt()
        {
           
        }

       

        private void btnBuscarTask_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

     



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click_2(object sender, EventArgs e)
        {
            LlenarGrip();
        }

        private void btnGrabar_Click_2(object sender, EventArgs e)
        {
            try
            {
                entTask t = new entTask();
                int tipoedicion = 1;
                if (txtIdTask.Text != "") { tipoedicion = 2; t.Id_Task = Convert.ToInt32(txtIdTask.Text); }

                t.Descrip_Task = txtDescriptTask.Text;
                t.Date_StartTask = Convert.ToString(dtpFechInicioTask.Value.ToString("yyyy/MM/dd"));
                t.Date_EndTask = Convert.ToString(dtpFechFinTask.Value.ToString("yyyy/MM/dd"));
                t.Status_Task = "A";
                int r = negTask.Instancia.mantenimientotask(t, tipoedicion);
                LlenarGrip();
                MessageBox.Show("Tarea insertada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
               AccionBotones(true, false, false, true, false);
            accion.bloquartxt(this.tabPage1, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgvTask_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTask_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idtask = Convert.ToInt32(dgvTask.CurrentRow.Cells[0].Value);
                entTask task = null;
                task = negTask.Instancia.BuscarTask2(idtask);
                txtIdTask.Text = task.Id_Task.ToString();
                txtCodigoTask.Text = task.Cod_Task.ToString();
                txtDescriptTask.Text = task.Descrip_Task.ToString();
                dtpFechInicioTask.Value = Convert.ToDateTime(task.Date_StartTask);
                dtpFechFinTask.Value = Convert.ToDateTime(task.Date_EndTask);
                txtEstadoTask.Text = task.Status_Task.ToString();
                txtBuscarTask.Text = "";
                if (task.Status_Task == "B") txtEstadoTask.BackColor = Color.Red;
                else txtEstadoTask.BackColor = Color.Green;
                AccionBotones(true, false, false, true, true);
                accion.bloquartxt(this.tabPage1, false);
                accion.bloqueardtp(this.tabPage1, false);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            accion.limpiartxt(this.tabPage1);
             accion.bloquartxt(this.tabPage1, true);
            AccionBotones(false, true, false, true, true);
            accion.bloqueardtp(this.tabPage1, true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            accion.bloquartxt(this.tabPage1, true);
            AccionBotones(true, false, true, false, true);
        }

        private void txtBuscarTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                accion.bloquartxt(this.tabPage1, true);
                accion.bloqueardtp(this.tabPage1, true);
                AccionBotones(false, true, true, true, true);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnRealizada_Click(object sender, EventArgs e)
        {
            try 
            {
                //Almacenamos el id en una variable
                int idtask = Convert.ToInt32(dgvTask.CurrentRow.Cells[0].Value);
                DialogResult res = MessageBox.Show("¿Desea dar por realizada esta tarea?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res==DialogResult.Yes)
                {
                    int i = negTask.Instancia.taskrealizada(idtask);
                    MessageBox.Show("La tarea ya fue dada como realizada", "bien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception) { throw; }
        }

        private void txtBuscarTask_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dgvTask.Rows.Clear();
                int numero = 0;
                String codigo = txtBuscarTask.Text;
                List<entTask> Lista = negTask.Instancia.BuscarTask(codigo);
                for (int i =0; i < Lista.Count; i++)
                {
                    numero++;
                    String[] fila = new String[] { Lista[i].Id_Task.ToString(), numero.ToString(), Lista[i].Cod_Task, Lista[i].Descrip_Task,
                        Lista[i].Date_StartTask.ToString(), 
                        Lista[i].Date_EndTask.ToString(), Lista[i].Status_Task };
                    dgvTask.Rows.Add(fila);

                }

            }
            catch (Exception) { throw; }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resu = MessageBox.Show("¿Esta seguro de que quiere salir?", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resu==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
