using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDispatcher.SolucionPackage
{
    class ProcesoC : Proceso
    {
        static int cantidadInstancias = 1;

        public ProcesoC(int tiempo) : base (tiempo)
        {
            base.id = "C" + cantidadInstancias;
            cantidadInstancias++;
            Estado = "Listo";
        }

        public override void ejecutar()
        {
            tiemposDispatcher++;
            if (tiemposDispatcher > 4)
            {
                Estado = "Terminado";
                return;
            }

            Estado = "Reservado";
            

     
        }

        public override String toString()
        {
            return "Proceso" + " \n ID: " + this.id.ToString() +
                  " \nEstado: " + this.estado + " \nTiempo: " + this.tiempo +
                  " \nVeces ejecutadas: " + this.tiemposDispatcher;
        }

    }
    
}
