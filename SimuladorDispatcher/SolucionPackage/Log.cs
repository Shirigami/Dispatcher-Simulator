
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
        private static String pathXML = "Registro_Procesos.xml";
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
            XmlTextWriter docXML = new XmlTextWriter(pathXML, null);
            docXML.Formatting = Formatting.Indented;
            docXML.WriteStartDocument(false);
            docXML.WriteStartElement("Registro_Procesos");
            docXML.WriteEndElement();
            docXML.Flush();
            docXML.Close();
        }

        //Llama a validar el archivo y crea un nuevo log 
        public void addLog(Proceso proceso)
        {
            if (!validateFile(pathXML))
            {
                createFile();
            }
            createNewLog(proceso);

        }

        //Introduce los nuevos datos en la ultima línea del archivo
        public void createNewLog(Proceso proceso)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(pathXML); // cargar archivo

            //creacion de nodos con su respectivo valor
            XmlNode node = doc.CreateNode(XmlNodeType.Element, "Regitro", null);

            XmlNode nodoPID = doc.CreateElement("PID");
            nodoPID.InnerText = proceso.Id;

            XmlNode nodoEstado = doc.CreateElement("Estado");
            nodoEstado.InnerText = proceso.Estado;

            XmlNode nodoDuracion = doc.CreateElement("Duracion");
            nodoDuracion.InnerText = Convert.ToString(proceso.Tiempo);

            //añadir al nodo raíz
            node.AppendChild(nodoPID);
            node.AppendChild(nodoEstado);
            node.AppendChild(nodoDuracion);

            // añadir al documento
            doc.DocumentElement.AppendChild(node);

            //salvar el archivo
            doc.Save(pathXML);
        }
       
    }
}