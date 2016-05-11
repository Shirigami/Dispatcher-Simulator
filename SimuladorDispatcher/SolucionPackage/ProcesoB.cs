using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDispatcher.SolucionPackage
{
    class ProcesoB : Proceso
    {
        int cantidadInstancias = 0;

        public ProcesoB(int tiempo) : base (tiempo)
        {
            base.id = "B" + cantInstancias;
            cantInstancias++;
        }

        public override string ejecutar()
        {
            string x = "";
            return x;

        }


    }
}
