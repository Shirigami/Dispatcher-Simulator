using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDispatcher.SolucionPackage
{
    class ProcesoB : Proceso
    {
        static int cantidadInstancias = 1;

        public ProcesoB(int tiempo) : base (tiempo)
        {
            base.id = "B" + cantidadInstancias;
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

            tiemposDispatcher++;

        }

        public override String toStrig()
        {
            return "Proceso" + "\n ID: " + this.id.ToString() +
                  "\nEstado: " + this.estado + "\nTiempo: " + this.tiempo +
                  "\nVeces ejecutadas:" + this.tiemposDispatcher;
        }

    }
}
