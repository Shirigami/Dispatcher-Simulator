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
using System.Threading;
namespace SolucionPackage
{
    public partial class VentanaPrincipal : Form
    {
        bool isRecursoOccup;
        Proceso dequ;
        Queue<Proceso> ready;
        Queue<Proceso> blocked;
        public VentanaPrincipal()
        {
            InitializeComponent();
            ready = new Queue<Proceso>();
            blocked = new Queue<Proceso>();
            isRecursoOccup = false;
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
            
            dequ = ready.Dequeue();
            this.procesos.Rows.RemoveAt(0);
            if (dequ is ProcesoC && this.isRecursoOccup == true)
            {
                this.dataGridView1.Rows.Add(dequ.Id, dequ.Tiempo);
                dequ = ready.Dequeue();
            }                      
            timer1.Enabled = true;
            timer1.Start();
            reinit();
            this.label7.Text = dequ.Id;              
           
        }

        int segundos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            progreso(Convert.ToInt32(dequ.Tiempo), sender, e);
        }

        private void progreso(int valor, object sender, EventArgs e)
        {
            tiempo.Text = Convert.ToString(segundos++);
            barraProgreso.Minimum = 1;
            barraProgreso.Maximum = Convert.ToInt32(valor);
            barraProgreso.Step = 1;
            barraProgreso.PerformStep();
            if (segundos > valor)
            {
                //this.dequ.ejecutar();
                tiempo.Text = "Proceso " + dequ.Id + " terminado";
                
                timer1.Stop();
                reinit();
                if (dequ is ProcesoB && 5>Convert.ToInt32(this.dequ.ejecutar()))
                {
                                    
                    this.procesos.Rows.Add(dequ.Id, dequ.Tiempo);
                    ready.Enqueue(dequ);
                   // this.ejecutar_Click(sender, e);
                } 
                if (ready.Count != 0)
                {
                    this.ejecutar_Click(sender, e);
                }

            }
        }
        private void reinit()
        {
            segundos = 0;
            tiempo.Text = "0";
            this.segundos = 1;
            barraProgreso.Minimum = 0;
            barraProgreso.Value = 0;
            this.label7.Text = "";
        }
        private void progressColor(Proceso x)
        {
            if (x is ProcesoA)
            {
                this.barraProgreso.ForeColor = Color.Red;
            } 

        }

    }
}
