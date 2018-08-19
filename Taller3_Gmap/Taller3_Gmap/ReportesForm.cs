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
        public ReportesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GmapForm gmapForm = new GmapForm();
            gmapForm.Show();
            this.Close();
        }      

        private void ReportesForm_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCargarGráfico_Click(object sender, EventArgs e)
        {
            //falta tomar los valores de cada grupo de investigación para cambiar el número
            this.chartTest.Series["Grupos"].Points.AddXY("Grupo 1", 90);
            this.chartTest.Series["Grupos"].Points.AddXY("Grupo 2",40);
            this.chartTest.Series["Grupos"].Points.AddXY("Grupo 3", 52);
        }

        private void infoxRegionesBtn_Click(object sender, EventArgs e)
        {   
            //falta tomar los valores de cada grupo de investigación para cambiar el número
            this.chartTest.Series["Región"].Points.AddXY("Region 1", 10);
        }

        private void áreaInvesBtn_Click(object sender, EventArgs e)
        {
            //falta tomar los valores de cada grupo de investigación para cambiar el número
            this.chartTest.Series["Área de investigación"].Points.AddXY("Área investigación 1", 2435);
        }

        private void clasificaciónBtn_Click(object sender, EventArgs e)
        {
            //falta tomar los valores de cada grupo de investigación para cambiar el número
            this.chartTest.Series["Clasificación"].Points.AddXY("Clasificación 1", 450);
        }

        private void ciudadesBtn_Click(object sender, EventArgs e)
        {
            //falta tomar los valores de cada grupo de investigación para cambiar el número
            this.chartTest.Series["Ciudades"].Points.AddXY("Ciudad 1", 50);
        }
    }
}
