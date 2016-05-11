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
            base.id = "C" + cantidadInstancias;
            cantidadInstancias++;
        }

        public override string ejecutar()
        {
            string x = "Usando el audio";
            return x;
        }


    }
}
