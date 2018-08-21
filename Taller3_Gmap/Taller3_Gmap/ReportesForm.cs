using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Taller3_Gmap
{
    public partial class ReportesForm : Form
    {
        //DataTable dt;
        GmapForm GMF;
        public ReportesForm(GmapForm gm)
        {
            //dt = datos;
            GMF = gm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GMF.Show();
            this.Close();
        }      

        private void ReportesForm_Load(object sender, EventArgs e)
        {
            //chartRegiones.DataSource = dt;
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void infoxRegionesBtn_Click(object sender, EventArgs e)
        {

            //intento No. 3000
            String[] Región = {"Centro Oriente", "Caribe", "D.C", "Centro Sur", "Eje Cafetero", "Llano","Pacífico","San Andrés, Providencia y Sta. Catalina" };
            int[] puntos = {662,712,1837,188,1111,83,617, 10 };

            chartRegiones.Titles.Add("Regiones");

            for (int i = 0; i < Región.Length; i++)
            {
                //titulos
                Series serie = chartRegiones.Series.Add(Región[i]);
                //cantidades
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
                
            }
            infoxRegionesBtn.Enabled = false;
             
                                
        }

        private void áreaInvesBtn_Click(object sender, EventArgs e)
        {
            String[] Ainvestigación = { "", "Caribe", "D.C", "Centro Sur", "Eje Cafetero", "Llano", "Pacífico", "San Andrés, Providencia y Sta. Catalina" };
            int[] puntos = { 662, 712, 1837, 188, 1111, 83, 617, 10 };

            chartRegiones.Titles.Add("Regiones");

            for (int i = 0; i < Ainvestigación.Length; i++)
            {
                //titulos
                Series serie = chartRegiones.Series.Add(Ainvestigación[i]);
                //cantidades
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);

            }
            infoxRegionesBtn.Enabled = false;


        }

        private void clasificaciónBtn_Click(object sender, EventArgs e)
        {
            //falta tomar los valores de cada grupo de investigación para cambiar el número
            this.chartClasificación.Series["Clasificación"].Points.AddXY("Clasificación 1", 450);

        }

        private void ciudadesBtn_Click(object sender, EventArgs e)
        {
            String[] Ciudades = { "Aguachica", "Agustín Codazi", "Apartadó","Arauca","Armenia","Barrancabermeja","Barranquilla","Bogotá D.C",
            "Bucaramanga", "Buenaventura", "Cali","Cartagena","Chía","Cúcuta","Distracción","Florencia","Floridablanca","Ibagué","Manizales","Medellín",
            "Montería","Neiva","Palmira","Pamplona","Pasto","Pereira","Popayán","Quibdó","Rionegro","Riohacha","Santa Marta","Sincelejo","Soacha","Socorro",
            "Tunja","Valledupar","Villavicencio","Yopal","Zipaquirá","Zona Bananera"};
            int[] puntos = { 1, 1, 1,4,72,8,235,1837,186,3,400,185,53,59,1,28,32,74,143,699,62,63,35,50,98,177,117,16,13,41,68,39,1,3,143,43,61,16,1,1 };

            chartCiudades.Titles.Add("Ciudad");

            for (int i = 0; i < Ciudades.Length; i++)
            {
                //titulos
                Series serie = chartCiudades.Series.Add(Ciudades[i]);
                //cantidades
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);

            }
            ciudadesBtn.Enabled = false;
        }

        private void chartCiudades_Click(object sender, EventArgs e)
        {

        }

        private void chartRegiones_Click(object sender, EventArgs e)
        {

        }
    }
}
