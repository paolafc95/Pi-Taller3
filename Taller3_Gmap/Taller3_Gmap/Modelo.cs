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
        public int[] posDatos = { 2, 3, 4, 6, 5, 8, 11, 12 };
        private List<String> grupos  = new List<String>();
        public Modelo()
        {
            cargarDatos();
        }
        public void cargarDatos()
        {
            string[] text = System.IO.File.ReadAllLines(@"./GRUPOS_DE_INVEST.csv");
           
            foreach(var f in text)
            {
                string[] text2 = f.Split(',');
                String grupo ="";
                foreach (var g in posDatos)
                {
                    grupo += text2[g]+",";
                }
                grupos.Add(grupo);
            }

        }
        public void guardarDatos(String GrupoNuevo, Boolean nuevo)
        {

            if (nuevo)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"./GRUPOS_DE_INVES.csv", true))
                {
                    String[] datosGrupo = GrupoNuevo.Split(',');
                    file.WriteLine(" , ," + datosGrupo[1] + "," + datosGrupo[0] + "," + datosGrupo[2] + "," + datosGrupo[4] + "," + datosGrupo[3] + ", ," + datosGrupo[5] + ", , ," + datosGrupo[6] + "," + datosGrupo[7] + ", , , ");
                }
            }
            else
            {
                string[] text = System.IO.File.ReadAllLines(@"./GRUPOS_DE_INVES.csv");
                string temp3 = "";
                System.IO.File.WriteAllText(@"./Archivo2", temp3);
                String[] datosGrupo = GrupoNuevo.Split(',');
                foreach (var tex in text)
                {
                    String[] substrings = tex.Split(',');
                    if (!datosGrupo[1].Equals(substrings[2]))
                    {
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"./datos.txt", true))
                        {
                            file.WriteLine(tex);
                        }
                    }
                    else
                    {
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"./datos.txt", true))
                        {
                            file.WriteLine(substrings[0]+","+ substrings[1]+"," + datosGrupo[1] + "," + datosGrupo[0] + "," + datosGrupo[2] + "," + datosGrupo[4] + "," + datosGrupo[3] + ","+ substrings[7]+"," + datosGrupo[5] + ","+ substrings[9]+ ","+ substrings[10]+"," + datosGrupo[6] + "," + datosGrupo[7] + ","+ substrings[13]+","+ substrings[14]+ ","+ substrings[5]);
                        }
                    }

                }
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
        public List<String> getListaGrupos()
        {
            return grupos;
        }
    }
}
