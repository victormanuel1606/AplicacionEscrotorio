using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace Portada
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            pInsertar.Visible = false;
            dgwCanciones.Visible = false;
            imgPedido.Visible = false;
            imgUbicasion.Visible = false;
            btnnuevo.Visible = false;
        }

        private void btnCanciones_Click(object sender, EventArgs e)
        {
            dgwCanciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            imgUbicasion.Visible = true;
            imgPedido.Visible = false;
            dgwCanciones.Visible = true;
            btnnuevo.Visible = true;
            logo.Visible = false;
            Servicio NuevoSer = new Servicio();
            ParamsUbicaciones parametros = new ParamsUbicaciones();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(parametros);
            string resultados = NuevoSer.llamarServicio(body);
            var Canciones = ser.Deserialize<List<ResultsUbicaciones>>(resultados);
            dgwCanciones.DataSource = null;
            dgwCanciones.DataSource = Canciones;
        }

        private void btnArtista_Click(object sender, EventArgs e)
        {
            dgwCanciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            imgUbicasion.Visible = false;
            imgPedido.Visible = true;
            dgwCanciones.Visible = true;
            btnnuevo.Visible = false;
            logo.Visible = false;
            Servicio NuevoSer = new Servicio();
            paramsPedidos parametros = new paramsPedidos();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(parametros);
            string Resultados = NuevoSer.llamarServicio(body);
            var Artista = ser.Deserialize<List<resultsPedidos>>(Resultados);
           
            dgwCanciones.DataSource = Artista;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Servicio NuevoSer = new Servicio();
            if (txtIdUbicasion.Text == "" || txtCiudad.Text == "" || txtProveedor.Text == "" || txtPedido.Text == "")
            {
                MessageBox.Show("Favor de Verificar Datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Insertar parametros = new Insertar(txtIdUbicasion.Text, txtCiudad.Text, txtProveedor.Text, dtFechallegada.Text, txtPedido.Text);
                JavaScriptSerializer ser = new JavaScriptSerializer();
                string body = ser.Serialize(parametros);
                string Resultados = NuevoSer.llamarServicio(body);
                pInsertar.Visible = false;
                pMenu.Visible = true;
                txtIdUbicasion.Text = "";
                txtCiudad.Text = "";
                txtProveedor.Text = "";
                txtPedido.Text = "";
                llamar();
            }
        }

        private void llamar()
        {
            Servicio NuevoSer = new Servicio();
            ParamsUbicaciones parametros = new ParamsUbicaciones();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(parametros);
            string resultados = NuevoSer.llamarServicio(body);
            var Canciones = ser.Deserialize<List<ResultsUbicaciones>>(resultados);
            dgwCanciones.DataSource = null;
            dgwCanciones.DataSource = Canciones;
        } 

        private void btnterminar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pMenu.Visible = false;
            pInsertar.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtIdUbicasion.Text = "";
            txtCiudad.Text = "";
            txtProveedor.Text = "";
            txtPedido.Text = "";
            pInsertar.Visible = false;
            pMenu.Visible = true;
        }
    }
}
