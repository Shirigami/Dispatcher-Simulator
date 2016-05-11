using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDispatcher.SolucionPackage
{
    public abstract class Proceso
    {
        protected string id;
        protected string estado;
        protected int tiempo;

        public Proceso(int tiempo)
        {

            this.Tiempo = tiempo;
            Estado = "Listo";

        }
        public string Id
        {
            get
            {
                return id;
            }

        }
        public string Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }

        }
        public int Tiempo
        {
            get
            {
                return tiempo;
            }
            set
            {
                tiempo = value;
            }

        }

        public abstract string ejecutar();

    }


}
