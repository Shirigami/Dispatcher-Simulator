using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuladorDispatcher.SolucionPackage;

namespace SimuladorDispatcher.SolucionPackage
{

    class ProcesoA : Proceso
    {
        static int cantidadInstancias = 1;
        int var = 0;
        int varSumar;
        
        public ProcesoA(int tiempo) : base (tiempo)
        {
            base.id = "A" + cantidadInstancias;
            cantidadInstancias++;
            Random rnd = new Random();
            varSumar = rnd.Next(1, 5);
            Estado = "Listo";

        }

        public override void ejecutar()
        {

            this.tiemposDispatcher ++;
            var =+ varSumar;

        }

        public override String toStrig()
        {
              return "Proceso"+ "\n ID: " + this.id.ToString() +
                    "\nEstado: " + this.estado + "\nTiempo: " + this.tiempo +
                    "\nVeces ejecutadas" + this.tiemposDispatcher + 
                    "\nOperación realizada: " + this.varSumar; 
        }

    }
}
