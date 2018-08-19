using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3_Gmap
{
    class Modelo
    {
        public String temp = "";
        public String temp2 = "";
        public Modelo()
        {
            cargarDatos();
        }
        public void cargarDatos()
        {
            string[] text = System.IO.File.ReadAllLines(@"./TransaccionesGruposArticulos.csv");
            Console.WriteLine("Funciona el cargar :v");


        }
        public void guardarDatos()
        {
            if (temp.Equals(""))
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"./Archivo", true))
                {

                }
            }
            else
            {
                string[] text = System.IO.File.ReadAllLines(@"./Archivo");
                string temp = "";
                System.IO.File.WriteAllText(@"./Archivo2", temp);
            }
        }
        public void cargarDatosSecundarios()
        {
            string[] text = System.IO.File.ReadAllLines(@"./archivo");


        }
        public void guardarDatosSecundarios()
        {
            if (temp2.Equals(""))
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"./Archivo2", true))
                {

                }
            }
            else
            {
                string[] text = System.IO.File.ReadAllLines(@"./Archivo2");
                string temp2 = "";
                System.IO.File.WriteAllText(@"./Archivo2", temp2);
            }
        }
    }
}
