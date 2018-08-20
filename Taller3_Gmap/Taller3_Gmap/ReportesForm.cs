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
       
        public ReportesForm()
        {
            //dt = datos;
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
            //chartRegiones.DataSource = dt;
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void infoxRegionesBtn_Click(object sender, EventArgs e)
        {//mibarChart1.Series[0].Points.Add(Convert.ToInt32(textBoxValor.Text));
            
             //falta tomar los valores de cada grupo de investigación para cambiar el número
             this.chartRegiones.Series["Región"].Points.AddXY("Región 1", 10);
             
                                
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
