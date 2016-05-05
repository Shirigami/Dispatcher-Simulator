using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDispatcher.SolucionPackage
{
    public class Proceso
    {
        static int cantInstancias = 0;
        int id;
        string estado;
        int tiempo;
        string tipo;

        public Proceso(string estado, int tiempo, string tipo)
        {
            id = cantInstancias;
            cantInstancias++;
            this.Estado = estado;
            this.Tiempo = tiempo;
            this.Tipo = tipo;
        }
        public int Id
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
        public string Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }

        }
    }


}
