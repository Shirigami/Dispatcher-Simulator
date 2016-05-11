using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using SimuladorDispatcher.SolucionPackage; 
namespace SolucionPackage
{
    public partial class VentanaPrincipal : Form
    {

        Queue<Proceso> ready;
        Queue<Proceso> blocked;
        public VentanaPrincipal()
        {
            InitializeComponent();
            ready = new Queue<Proceso>();
            blocked = new Queue<Proceso>();
        }

        private void btnCrearProceso_Click(object sender, EventArgs e)
        {
            Proceso prcs;
            MessageBox.Show(this.nombreProceso.SelectedIndex.ToString());
            if (this.nombreProceso.SelectedIndex == 0)
            {
                prcs = new ProcesoA((int)this.duracion.Value);
            }

            else if (this.nombreProceso.SelectedIndex == 1)
            {
                prcs = new ProcesoB((int)this.duracion.Value);
            }
            else
            {
                prcs = new ProcesoC((int)this.duracion.Value);
            }
            ready.Enqueue(prcs);
            procesos.Rows.Add(prcs.Id, prcs.Tiempo);
        }

        private void ejecutar_Click(object sender, EventArgs e)
        {
            tiempo.Text = "0";
            this.segundos = 1;
            timer1.Enabled = true;
            timer1.Start();
            barraProgreso.Minimum = 0;
            barraProgreso.Value = 0;

            this.dataGridView1.RowCount = this.ready.Count+1;
            MessageBox.Show("Proceso: "+ ready.Dequeue().ToString()+" en ejecución.");
          //  this.dataGridView1.Rows.RemoveAt(this.dataGridView1.Rows.IndexOf());
            MessageBox.Show(ready.Count.ToString());

        }

        int segundos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            progreso(Convert.ToInt32(duracion.Value));
        }

        private void progreso(int valor) {
            tiempo.Text = Convert.ToString(segundos++);
            barraProgreso.Minimum = 1;
            barraProgreso.Maximum = Convert.ToInt32(duracion.Value);
            barraProgreso.Step = 1;
            barraProgreso.PerformStep();
            if (segundos > valor)
            {
                tiempo.Text = "Proseso " + nombreProceso.SelectedItem + " terminado";
                timer1.Stop();
            }
        }


    }
}
