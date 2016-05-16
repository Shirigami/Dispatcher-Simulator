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
            if (tiemposDispatcher > 3)
            {
                Estado = "Terminado";
                return;
            }

            Estado = "Reservado";
            tiemposDispatcher++;

     
        }

        public override String toStrig()
        {
            return "Proceso" + "\n ID: " + this.id.ToString() +
                  "\nEstado: " + this.estado + "\nTiempo: " + this.tiempo +
                  "\nVeces ejecutadas" + this.tiemposDispatcher;
        }

    }
    
}
