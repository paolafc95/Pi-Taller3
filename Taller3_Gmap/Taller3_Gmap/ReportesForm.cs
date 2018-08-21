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
            //falta tomar los valores de cada grupo de investigación para cambiar el número
            this.chartAreaInv.Series["Área de investigación"].Points.AddXY("Área investigación 1", 567);
        }

        private void clasificaciónBtn_Click(object sender, EventArgs e)
        {
            //falta tomar los valores de cada grupo de investigación para cambiar el número
            this.chartClasificación.Series["Clasificación"].Points.AddXY("Clasificación 1", 450);

        }

        private void ciudadesBtn_Click(object sender, EventArgs e)
        {
            //falta tomar los valores de cada grupo de investigación para cambiar el número
            this.chartCiudades.Series["Ciudades"].Points.AddXY("Ciudad 1", 450);
        }

        private void chartCiudades_Click(object sender, EventArgs e)
        {

        }

        private void chartRegiones_Click(object sender, EventArgs e)
        {

        }
    }
}
