
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SimuladorDispatcher.SolucionPackage
{
    public class Log
    {
        private static String pathCSV = "Registro_Procesos.csv";
        //Constructor de la clase
        public Log(){}


        //Valida la existencia del archivo
        public Boolean validateFile(String path)
        {
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
        //Crea un archivo en la carpeta SistemaAhorroInversion\\bin\\Debug
        public void createFile()
        {
            pathCSV = "CSV_Registro_Histórico.csv";
            File.Create(pathCSV).Close();
        }

        //Llama a validar el archivo y crea un nuevo log 
        public void addLog(Proceso proceso)
        {
            if (!validateFile(pathCSV))
            {
                createFile();
            }
            createNewLog(proceso);
        }

        //Introduce los nuevos datos en la ultima línea del archivo
        public void createNewLog(Proceso proceso)
        {
            string delimiter = ":";
            string[][] output = new string[][]{
            new string[]{"/----------Registro_Procesos----------/"},
            new string[]{proceso.toString()},
            new string[]{"\n/-------------------------------------/"}
            };

            int length = output.GetLength(0);
            StringBuilder sb = new StringBuilder();

            for (int index = 0; index < length; index++)
                //agregar filas 
                sb.AppendLine(string.Join(delimiter, output[index]));
            // agregar texto a las filas creadas
            File.AppendAllText(pathCSV, sb.ToString());
        }
       
    }
}