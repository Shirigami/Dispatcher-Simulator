﻿namespace SolucionPackage
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        /// 
       

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCrearProceso = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nombreProceso = new System.Windows.Forms.ComboBox();
            this.duracion = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.barraProgreso = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tiempo = new System.Windows.Forms.Label();
            this.duracionPBloqueado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePBloqueado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.procesos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vecesDispatcher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.semaforo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semaforo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearProceso
            // 
            this.btnCrearProceso.Location = new System.Drawing.Point(605, 36);
            this.btnCrearProceso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrearProceso.Name = "btnCrearProceso";
            this.btnCrearProceso.Size = new System.Drawing.Size(176, 41);
            this.btnCrearProceso.TabIndex = 0;
            this.btnCrearProceso.Text = "Crear Proceso";
            this.btnCrearProceso.UseVisualStyleBackColor = true;
            this.btnCrearProceso.Click += new System.EventHandler(this.btnCrearProceso_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nombreProceso);
            this.groupBox1.Controls.Add(this.duracion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCrearProceso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11F);
            this.groupBox1.Location = new System.Drawing.Point(179, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(815, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Proceso";
            // 
            // nombreProceso
            // 
            this.nombreProceso.AllowDrop = true;
            this.nombreProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nombreProceso.FormattingEnabled = true;
            this.nombreProceso.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.nombreProceso.Location = new System.Drawing.Point(123, 44);
            this.nombreProceso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombreProceso.Name = "nombreProceso";
            this.nombreProceso.Size = new System.Drawing.Size(160, 30);
            this.nombreProceso.TabIndex = 3;
            // 
            // duracion
            // 
            this.duracion.Location = new System.Drawing.Point(503, 42);
            this.duracion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.duracion.Name = "duracion";
            this.duracion.Size = new System.Drawing.Size(79, 30);
            this.duracion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duración del Proceso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proceso: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(584, 242);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ejecutar_Click);
            // 
            // barraProgreso
            // 
            this.barraProgreso.Location = new System.Drawing.Point(852, 255);
            this.barraProgreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barraProgreso.Name = "barraProgreso";
            this.barraProgreso.Size = new System.Drawing.Size(269, 28);
            this.barraProgreso.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tiempo
            // 
            this.tiempo.AutoSize = true;
            this.tiempo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempo.Location = new System.Drawing.Point(973, 294);
            this.tiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(20, 23);
            this.tiempo.TabIndex = 9;
            this.tiempo.Text = "0";
            // 
            // duracionPBloqueado
            // 
            this.duracionPBloqueado.HeaderText = "Duración";
            this.duracionPBloqueado.Name = "duracionPBloqueado";
            this.duracionPBloqueado.ReadOnly = true;
            // 
            // NombrePBloqueado
            // 
            this.NombrePBloqueado.HeaderText = "ID";
            this.NombrePBloqueado.Name = "NombrePBloqueado";
            this.NombrePBloqueado.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombrePBloqueado,
            this.duracionPBloqueado});
            this.dataGridView1.Location = new System.Drawing.Point(73, 459);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(328, 185);
            this.dataGridView1.TabIndex = 5;
            // 
            // procesos
            // 
            this.procesos.AllowUserToAddRows = false;
            this.procesos.AllowUserToDeleteRows = false;
            this.procesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.procesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.duracionP,
            this.vecesDispatcher});
            this.procesos.Location = new System.Drawing.Point(69, 208);
            this.procesos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.procesos.Name = "procesos";
            this.procesos.ReadOnly = true;
            this.procesos.Size = new System.Drawing.Size(457, 172);
            this.procesos.TabIndex = 3;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "ID";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // duracionP
            // 
            this.duracionP.HeaderText = "Duración";
            this.duracionP.Name = "duracionP";
            this.duracionP.ReadOnly = true;
            // 
            // vecesDispatcher
            // 
            this.vecesDispatcher.HeaderText = "Veces Ejecutadas";
            this.vecesDispatcher.Name = "vecesDispatcher";
            this.vecesDispatcher.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cola de procesos listos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 422);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cola de procesos bloqueados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(848, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Proceso en ejecución:  ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1039, 226);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "0";
            // 
            // semaforo
            // 
            this.semaforo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.semaforo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.semaforo.Location = new System.Drawing.Point(977, 364);
            this.semaforo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.semaforo.Name = "semaforo";
            this.semaforo.Size = new System.Drawing.Size(52, 52);
            this.semaforo.TabIndex = 15;
            this.semaforo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(948, 337);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Semáforo";
            // 
            // Output
            // 
            this.Output.FormattingEnabled = true;
            this.Output.ItemHeight = 16;
            this.Output.Location = new System.Drawing.Point(440, 459);
            this.Output.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(800, 180);
            this.Output.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(436, 420);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Output";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(584, 340);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 41);
            this.button2.TabIndex = 19;
            this.button2.Text = "Detener";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 688);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.semaforo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.barraProgreso);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.procesos);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VentanaPrincipal";
            this.Text = "Simulación de Procesos";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semaforo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearProceso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox nombreProceso;
        private System.Windows.Forms.NumericUpDown duracion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar barraProgreso;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionPBloqueado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePBloqueado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView procesos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox semaforo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionP;
        private System.Windows.Forms.DataGridViewTextBoxColumn vecesDispatcher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Output;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}

