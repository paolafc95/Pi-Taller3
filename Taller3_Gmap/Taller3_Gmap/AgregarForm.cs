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
    public partial class AgregarForm : Form
    {
        GmapForm GMF;

        public AgregarForm(GmapForm gm)
        {
            GMF = gm;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string fecha = dtpFecha.Text.ToString();
            string departamento = txtDepartamento.Text;
            string municipio = txtMunicipio.Text;
            string region = txtRegion.Text;
            string areaC = txtAC.Text;
            string granAC = txtGAC.Text;

            if(!string.IsNullOrWhiteSpace(codigo) && !string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(fecha)
                && !string.IsNullOrWhiteSpace(departamento) && !string.IsNullOrWhiteSpace(municipio) && !string.IsNullOrWhiteSpace(region)
                && !string.IsNullOrWhiteSpace(areaC) && !string.IsNullOrWhiteSpace(granAC))
            {
                string[] datos = { codigo, nombre, fecha, departamento, municipio, region, areaC, granAC };
                GMF.agregarGrupo(datos);

                MessageBox.Show("El grupo ha sido agregdo satisfactoriamente", "Agregar grupo",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();
            }
            else
            {
                MessageBox.Show("Complete todos los campos.", "Agregar grupo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
