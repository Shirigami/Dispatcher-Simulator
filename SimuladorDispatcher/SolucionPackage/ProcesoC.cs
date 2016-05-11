using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDispatcher.SolucionPackage
{
    class ProcesoC : Proceso
    {
        int cantidadInstancias = 0;

        public ProcesoC(int tiempo) : base (tiempo)
        {
            base.id = "C" + cantInstancias;
            cantInstancias++;
        }

        public override string ejecutar()
        {

        }


    }
}
