﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3_Gmap
{
    class Modelo
    {
        public String temp = "";
        public int[] posDatos = { 2, 3, 4, 6, 5, 8, 11, 12 };
        private List<String> grupos  = new List<String>();
        private List<String> gruposCiudad = new List<String>();
        public Modelo()
        {
            cargarDatos();
        }
        public void cargarDatos()
        {
            string[] text = System.IO.File.ReadAllLines(@"./GRUPOS_DE_INVES.csv");
           
            foreach(var f in text)
            {
                string[] text2 = f.Split(',');
                String grupo ="";
                gruposCiudad.Add(text2[6]);
                foreach (var g in posDatos)
                {
                    grupo += text2[g]+",";
                }
                grupos.Add(grupo);
            }

        }
        public String grupo(String cod)
        {
            String grupo = "";
            foreach (var g in grupos)
            {
                String[] gs = g.Split(',');
                if (gs[0].Equals(cod))
                {
                    return g;
                }
            }
            return grupo;
        }
        public void guardarDatos(String[] GrupoNuevo, Boolean nuevo)
        {

            if (nuevo)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"./GRUPOS_DE_INVES.csv", true))
                {
                    String[] datosGrupo = GrupoNuevo;
                    file.WriteLine(" , ," + datosGrupo[0] + "," + datosGrupo[1] + "," + datosGrupo[2] + "," + datosGrupo[4] + "," + datosGrupo[3] + ", ," + datosGrupo[5] + ", , ," + datosGrupo[6] + "," + datosGrupo[7] + ", , , ");
                }
            }
            else
            {
                string[] text = System.IO.File.ReadAllLines(@"./GRUPOS_DE_INVES.csv");
                
                System.IO.File.WriteAllText(@"./GRUPOS_DE_INVES.csv", "");
                String[] datosGrupo = GrupoNuevo;
                foreach (var tex in text)
                {
                    String[] substrings = tex.Split(',');
                    
                    if (!datosGrupo[0].Equals(substrings[2]))
                    {
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"./GRUPOS_DE_INVES.csv", true))
                        {
                            file.WriteLine(tex);
                        }
                    }
                    else
                    {
                        Console.WriteLine(datosGrupo[0] + "a ver que pasa" + substrings[2]);
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"./GRUPOS_DE_INVES.csv", true))
                        {
                            file.WriteLine(substrings[0]+","+ substrings[1]+"," + datosGrupo[0] + "," + datosGrupo[1] + "," + datosGrupo[2] + "," + datosGrupo[4] + "," + datosGrupo[3] + ","+ substrings[7]+"," + datosGrupo[5] + ","+ substrings[9]+ ","+ substrings[10]+"," + datosGrupo[6] + "," + datosGrupo[7] + ","+ substrings[13]+","+ substrings[14]+ ","+ substrings[5]);
                        }
                    }

                }
            }
        }
       
        public List<String> getListaGrupos()
        {
            return grupos;
        }
        public List<String> getListaCiudades()
        {
            return gruposCiudad;
        }
    }
}
