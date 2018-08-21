using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Taller3_Gmap
{

    
    public partial class GmapForm : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverLay;
        DataTable dt;

        private Modelo model;
        int filaSeleccionada = 0;
      
        double LatitudInicial = 4.692683;
        double LongitudInicial = -74.065076;
        public GmapForm()
        {
            InitializeComponent();

            model = new Modelo();

            controladorPuntos();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt = new DataTable();

            dt.Columns.Add(new DataColumn("Código", typeof(string)));
            dt.Columns.Add(new DataColumn("Nombre", typeof(string)));
            dt.Columns.Add(new DataColumn("Fecha Creación", typeof(string)));
            dt.Columns.Add(new DataColumn("Departamento", typeof(string)));
            dt.Columns.Add(new DataColumn("Municipio", typeof(string)));
            dt.Columns.Add(new DataColumn("Región", typeof(string)));
            dt.Columns.Add(new DataColumn("Área Conocimiento", typeof(string)));
            dt.Columns.Add(new DataColumn("Gran área conocimiento", typeof(string)));
            dt.Columns.Add(new DataColumn("Latitud", typeof(double)));
            dt.Columns.Add(new DataColumn("Longitud", typeof(double)));


            //Datos al dt para mostrar en la lista

            foreach (var g in model.getListaGrupos())
            {
                String[] dats = g.Split(',');
                if (!dats[0].Equals("COD_GRUPO_GR"))
                {
                    dt.Rows.Add(dats[0], dats[1], dats[2], dats[3], dats[4], dats[5], dats[6], dats[7]);
                }
            }

            /*
            dt.Rows.Add(001,"Grupo 1", LatitudInicial, LongitudInicial);
            dt.Rows.Add(002, "Grupo 2", LatitudInicial, LongitudInicial);
            dt.Rows.Add(003, "Grupo 3", LatitudInicial, LongitudInicial);
            dt.Rows.Add(004, "Grupo 4", LatitudInicial, LongitudInicial);
            dt.Rows.Add(005, "Grupo 5", LatitudInicial, LongitudInicial);
            dt.Rows.Add(006, "Grupo 6", LatitudInicial, LongitudInicial);
            dt.Rows.Add(007, "Grupo 7", LatitudInicial, LongitudInicial);
            dt.Rows.Add(008, "Grupo 8", LatitudInicial, LongitudInicial);
            */

            dataGridView1.DataSource = dt;

            // desactivar columnas de latitud y longitud
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;



            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.SetPositionByKeywords("Bogota, Colombia");
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 6;
            gMapControl1.AutoScroll = true;

            //Marcador
           // markerOverLay = new GMapOverlay("Marcador");
           // marker = new GMarkerGoogle(new PointLatLng(LatitudInicial, LongitudInicial), GMarkerGoogleType.blue_small);
            //markerOverLay.Markers.Add(marker);

            //Se le pone un tooltip de texto a los marcadores
          // marker.ToolTipMode = MarkerTooltipMode.Always;
          //  marker.ToolTipText = string.Format("Ubicación: \n Latitud:{0} \nLongitud:{1}", LatitudInicial, LongitudInicial);

            //Agregamos el OverLay y el marcador al mapcontrol
          //  gMapControl1.Overlays.Add(markerOverLay);

            
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }
        private void controladorPuntos()
        {
            List<String> ciudades = model.getListaGrupos();
            List<String> longitudes = new List<String>();
            List<String> latitudes = new List<String>();
            foreach(var g in ciudades)
            {
                String[] grupo = g.Split(',');
                String temp = PuntosRandom(grupo[3]);
                String[] temp1 = temp.Split(',');
                longitudes.Add(temp1[0]);
                latitudes.Add(temp1[1]);

            }
        }
        private String PuntosRandom(String ciudad)
        {
            // cree los decimales aleatorios para poner el punto
            Random aleatorio = new Random();
            String Srandomx = 0 +",0" +aleatorio.Next(0, 99999).ToString();
            double randomX = Convert.ToDouble(Srandomx);
         

            Random aleatorio2 = new Random();
            String SrandomY = 0 + ",0" + aleatorio.Next(0, 99999).ToString();
            double randomY = Convert.ToDouble(SrandomY);
           
            

            // elimina decimales de las cordenada de las ciudaded

            gMapControl1.SetPositionByKeywords(ciudad);
      
            double ciudadX = gMapControl1.Position.Lat + randomX;
            double ciudadY = gMapControl1.Position.Lng +randomY;
            String coordenadas =  "" + ciudadX+ "," + ciudadY ;
        

            //crea el punto aleatorio
            GMapOverlay punto = new GMapOverlay("marcador");
            GMarkerGoogle nMarker = new GMarkerGoogle(new PointLatLng(ciudadX, ciudadY),GMarkerGoogleType.green_pushpin);
            punto.Markers.Add(nMarker);
            gMapControl1.Overlays.Add(punto);
            return coordenadas;
        }

        private void SeleccionarRegistro(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex; //fila selecionada
            //tomamos datos del grid y los asignamos a los textBox
            txtNombre.Text= dataGridView1.Rows[filaSeleccionada].Cells[1].Value.ToString();
            txtLatitud.Text= dataGridView1.Rows[filaSeleccionada].Cells[0].Value.ToString();
            txtLong.Text= dataGridView1.Rows[filaSeleccionada].Cells[2].Value.ToString();

            string latitud = dataGridView1.Rows[filaSeleccionada].Cells[8].Value.ToString();
            string longitud= dataGridView1.Rows[filaSeleccionada].Cells[9].Value.ToString();

            //Se asignan los valores del grid al marcador
           // marker.Position = new PointLatLng(Convert.ToDouble(latitud), Convert.ToDouble(longitud));
            
            //El mapa se posiiona en la ubicación del marcador
            //gMapControl1.Position = marker.Position;
            //gMapControl1.Zoom = 9;

        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
         /*   //Obtiene los datos de donde el usuario interactuó
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng= gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            //Se le muestra la lat y la lng en los txt
            txtLatitud.Text = lat.ToString();
            txtLong.Text = lng.ToString();

            //Creamos el marcador en el lugar indicado por el usuario
            marker.Position = new PointLatLng(lat,lng);
            //Se le agrega el tooltip
            marker.ToolTipText = string.Format("Ubicación; \n Latitud: {0}\n Longitud:{1}",lat, lng);
        */
            }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(filaSeleccionada);
        }

        private void btnModificarInfo_Click(object sender, EventArgs e)
        {
            String cod = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();

            ModificarForm modificar = new ModificarForm(this, model.grupo(cod));
            this.Hide();
            modificar.Show();
           
        }
        public void modificar(String[] datos)
        {
            model.guardarDatos(datos, false);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ReportesForm reporte = new ReportesForm(this);
            reporte.Show();
            this.Hide();
        }

        private void MostrarInfoBtn_Click(object sender, EventArgs e)
        {
            filaSeleccionada = dataGridView1.SelectedCells[0].RowIndex;
            InfoForm informacion = new InfoForm(this,dt,filaSeleccionada);
            informacion.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarForm af = new AgregarForm(this);
            af.Show();
        }

        public void agregarGrupo(string[] datos)
        {
            dt.Rows.Add(datos[0],datos[1],datos[2], datos[3], datos[4], datos[5], datos[6], datos[7]);
            model.guardarDatos(datos,true);
        }
    }
}
