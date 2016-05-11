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
        int tiemposDispatcher = 0;

        public ProcesoB(int tiempo) : base (tiempo)
        {
            base.id = "B" + cantidadInstancias;
            cantidadInstancias++;
        }

        public override string ejecutar()
        {
            if (tiemposDispatcher == 5)
            {
                Estado = "Terminado";
                return "-1";
            }

            tiemposDispatcher++;
            return tiemposDispatcher.ToString();

        }


    }
}
