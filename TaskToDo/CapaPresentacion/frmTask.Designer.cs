namespace CapaPresentacion
{
    partial class frmTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRealizada = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEstadoTask = new System.Windows.Forms.TextBox();
            this.dtpFechFinTask = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechInicioTask = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescriptTask = new System.Windows.Forms.TextBox();
            this.txtIdTask = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoTask = new System.Windows.Forms.TextBox();
            this.btnBuscarTask = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarTask = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1083, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "TASK TO DO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1040, 800);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnActualizar);
            this.tabPage1.Controls.Add(this.btnSalir);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnRealizada);
            this.tabPage1.Controls.Add(this.btnGrabar);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.btnNuevo);
            this.tabPage1.Controls.Add(this.dgvTask);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnBuscarTask);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtBuscarTask);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1032, 772);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tareas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(732, 210);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(80, 29);
            this.btnActualizar.TabIndex = 49;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_2);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(926, 410);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 38);
            this.btnSalir.TabIndex = 48;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(926, 367);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 38);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRealizada
            // 
            this.btnRealizada.Location = new System.Drawing.Point(926, 323);
            this.btnRealizada.Name = "btnRealizada";
            this.btnRealizada.Size = new System.Drawing.Size(80, 38);
            this.btnRealizada.TabIndex = 46;
            this.btnRealizada.Text = "Realizada";
            this.btnRealizada.UseVisualStyleBackColor = true;
            this.btnRealizada.Click += new System.EventHandler(this.btnRealizada_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(926, 279);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(80, 38);
            this.btnGrabar.TabIndex = 45;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click_2);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(926, 235);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 38);
            this.btnEditar.TabIndex = 44;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(926, 191);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(80, 38);
            this.btnNuevo.TabIndex = 43;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // dgvTask
            // 
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.Location = new System.Drawing.Point(41, 245);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.Size = new System.Drawing.Size(771, 185);
            this.dgvTask.TabIndex = 42;
            this.dgvTask.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTask_CellClick_2);
            this.dgvTask.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTask_CellContentClick_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEstadoTask);
            this.groupBox1.Controls.Add(this.dtpFechFinTask);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpFechInicioTask);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDescriptTask);
            this.groupBox1.Controls.Add(this.txtIdTask);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodigoTask);
            this.groupBox1.Location = new System.Drawing.Point(41, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 192);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Estado ";
            // 
            // txtEstadoTask
            // 
            this.txtEstadoTask.Location = new System.Drawing.Point(94, 149);
            this.txtEstadoTask.Name = "txtEstadoTask";
            this.txtEstadoTask.Size = new System.Drawing.Size(83, 21);
            this.txtEstadoTask.TabIndex = 14;
            // 
            // dtpFechFinTask
            // 
            this.dtpFechFinTask.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechFinTask.Location = new System.Drawing.Point(94, 122);
            this.dtpFechFinTask.Name = "dtpFechFinTask";
            this.dtpFechFinTask.Size = new System.Drawing.Size(97, 21);
            this.dtpFechFinTask.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fech. Fin";
            // 
            // dtpFechInicioTask
            // 
            this.dtpFechInicioTask.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechInicioTask.Location = new System.Drawing.Point(94, 95);
            this.dtpFechInicioTask.Name = "dtpFechInicioTask";
            this.dtpFechInicioTask.Size = new System.Drawing.Size(97, 21);
            this.dtpFechInicioTask.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fech. Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descripcion";
            // 
            // txtDescriptTask
            // 
            this.txtDescriptTask.Location = new System.Drawing.Point(94, 59);
            this.txtDescriptTask.Name = "txtDescriptTask";
            this.txtDescriptTask.Size = new System.Drawing.Size(300, 21);
            this.txtDescriptTask.TabIndex = 8;
            // 
            // txtIdTask
            // 
            this.txtIdTask.Location = new System.Drawing.Point(254, 29);
            this.txtIdTask.Name = "txtIdTask";
            this.txtIdTask.Size = new System.Drawing.Size(20, 21);
            this.txtIdTask.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo";
            // 
            // txtCodigoTask
            // 
            this.txtCodigoTask.Location = new System.Drawing.Point(94, 29);
            this.txtCodigoTask.Name = "txtCodigoTask";
            this.txtCodigoTask.Size = new System.Drawing.Size(154, 21);
            this.txtCodigoTask.TabIndex = 5;
            // 
            // btnBuscarTask
            // 
            this.btnBuscarTask.Location = new System.Drawing.Point(294, 3);
            this.btnBuscarTask.Name = "btnBuscarTask";
            this.btnBuscarTask.Size = new System.Drawing.Size(80, 29);
            this.btnBuscarTask.TabIndex = 40;
            this.btnBuscarTask.Text = "Buscar";
            this.btnBuscarTask.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Codigo";
            // 
            // txtBuscarTask
            // 
            this.txtBuscarTask.Location = new System.Drawing.Point(121, 3);
            this.txtBuscarTask.Name = "txtBuscarTask";
            this.txtBuscarTask.Size = new System.Drawing.Size(154, 21);
            this.txtBuscarTask.TabIndex = 38;
            this.txtBuscarTask.TextChanged += new System.EventHandler(this.txtBuscarTask_TextChanged);
            this.txtBuscarTask.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarTask_KeyUp);
            // 
            // frmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1076, 541);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Name = "frmTask";
            this.Text = "TaskToDo";
            this.Load += new System.EventHandler(this.frmTask_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRealizada;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvTask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEstadoTask;
        private System.Windows.Forms.DateTimePicker dtpFechFinTask;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechInicioTask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescriptTask;
        private System.Windows.Forms.TextBox txtIdTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoTask;
        private System.Windows.Forms.Button btnBuscarTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarTask;
    }
}

