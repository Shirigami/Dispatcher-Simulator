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
        int cantidadInstancias = 0;

        
        public ProcesoA(int tiempo) : base (tiempo)
        {
            base.id = "A" + cantidadInstancias;
            cantidadInstancias++;
        }

        public override string ejecutar()
        {
            int x = 3;
            int y = 5;
            return (x + y).ToString() ;
        }


    }
}
