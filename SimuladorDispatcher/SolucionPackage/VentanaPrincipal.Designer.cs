namespace SolucionPackage
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
            this.label3 = new System.Windows.Forms.Label();
            this.recurso = new System.Windows.Forms.Label();
            this.barraProgreso = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tiempo = new System.Windows.Forms.Label();
            this.duracionPBloqueado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePBloqueado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.duracionP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procesos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearProceso
            // 
            this.btnCrearProceso.Location = new System.Drawing.Point(454, 29);
            this.btnCrearProceso.Name = "btnCrearProceso";
            this.btnCrearProceso.Size = new System.Drawing.Size(132, 33);
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
            this.groupBox1.Location = new System.Drawing.Point(64, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 96);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Proceso";
            // 
            // nombreProceso
            // 
            this.nombreProceso.FormattingEnabled = true;
            this.nombreProceso.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.nombreProceso.Location = new System.Drawing.Point(92, 36);
            this.nombreProceso.Name = "nombreProceso";
            this.nombreProceso.Size = new System.Drawing.Size(121, 26);
            this.nombreProceso.TabIndex = 3;
            // 
            // duracion
            // 
            this.duracion.Location = new System.Drawing.Point(377, 34);
            this.duracion.Name = "duracion";
            this.duracion.Size = new System.Drawing.Size(59, 25);
            this.duracion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duración del Proceso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proceso: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ejecutar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ejecutar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Recurso Asignado al Proceso";
            // 
            // recurso
            // 
            this.recurso.AutoSize = true;
            this.recurso.Location = new System.Drawing.Point(358, 217);
            this.recurso.Name = "recurso";
            this.recurso.Size = new System.Drawing.Size(46, 13);
            this.recurso.TabIndex = 7;
            this.recurso.Text = "Proceso";
            // 
            // barraProgreso
            // 
            this.barraProgreso.Location = new System.Drawing.Point(526, 169);
            this.barraProgreso.Name = "barraProgreso";
            this.barraProgreso.Size = new System.Drawing.Size(149, 23);
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
            this.tiempo.Location = new System.Drawing.Point(523, 150);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(13, 13);
            this.tiempo.TabIndex = 9;
            this.tiempo.Text = "0";
            // 
            // duracionPBloqueado
            // 
            this.duracionPBloqueado.HeaderText = "Duración";
            this.duracionPBloqueado.Name = "duracionPBloqueado";
            // 
            // NombrePBloqueado
            // 
            this.NombrePBloqueado.HeaderText = "ID";
            this.NombrePBloqueado.Name = "NombrePBloqueado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombrePBloqueado,
            this.duracionPBloqueado});
            this.dataGridView1.Location = new System.Drawing.Point(52, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // duracionP
            // 
            this.duracionP.HeaderText = "Duración";
            this.duracionP.Name = "duracionP";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "ID";
            this.Nombre.Name = "Nombre";
            // 
            // procesos
            // 
            this.procesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.procesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.duracionP});
            this.procesos.Location = new System.Drawing.Point(52, 169);
            this.procesos.Name = "procesos";
            this.procesos.Size = new System.Drawing.Size(244, 140);
            this.procesos.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cola de procesos listos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cola de procesos bloqueados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 505);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.barraProgreso);
            this.Controls.Add(this.recurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.procesos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Simulación de Procesos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesos)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label recurso;
        private System.Windows.Forms.ProgressBar barraProgreso;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionPBloqueado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePBloqueado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridView procesos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

