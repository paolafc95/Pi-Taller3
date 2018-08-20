using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller3_Gmap
{
    public partial class InfoForm : Form
    {
        DataTable dt;
        int posBuscada;
        GmapForm GMF;
        public InfoForm(GmapForm gm,DataTable datos, int pos)
        {
            dt = datos;
            posBuscada = pos;
            GMF = gm;
            InitializeComponent();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;


            dataGridView1.Rows[0].Selected = false;
            dataGridView1.Rows[posBuscada].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[posBuscada].Cells[0];

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            GMF.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
