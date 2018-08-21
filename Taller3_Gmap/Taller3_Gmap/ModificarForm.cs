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
    public partial class ModificarForm : Form
    {
        GmapForm GMF;
        private String Codigo;
        public ModificarForm(GmapForm gm,String cod) 
        {
            GMF = gm;
            Codigo = cod;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text =Codigo.Split(',')[1];
            textBox2.Text = Codigo.Split(',')[2];
            textBox3.Text = Codigo.Split(',')[3];
            textBox4.Text = Codigo.Split(',')[4];
            textBox5.Text = Codigo.Split(',')[5];
            textBox6.Text = Codigo.Split(',')[6];
            textBox7.Text = Codigo.Split(',')[7];
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GMF.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GMF.Show();
            String[] d= { Codigo.Split(',')[0], textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text}
            GMF.modificar(d);
            this.Close();
        }
    }
}
