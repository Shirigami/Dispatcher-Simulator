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
        }

        public override string ejecutar()
        {
            string x = "Usando el audio";
            return x;
        }


    }
}
