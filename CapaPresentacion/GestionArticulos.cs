using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class GestionArticulos : Form
    {
        DatosArticulos datos = new DatosArticulos();
        public GestionArticulos()
        {
            InitializeComponent();
            // Para btnAgregar
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // Para btnEliminar
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // Para btnMostrar
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);


        }

        private void GestionArticulos_Load(object sender, EventArgs e)
        {
            cbTipoArticulo.Items.AddRange(new string[] { "Cuaderno", "Lapicero", "Regla" });
            cbTipoArticulo.SelectedIndex = 0;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            int precio = int.Parse(txtPrecio.Text);
            string tipo = cbTipoArticulo.SelectedItem.ToString();

            ArticuloEscolar articulo;

            //Crear el tipo de articulo segun corresponda
            if (tipo == "Cuaderno")
                articulo = new Cuaderno(0, marca, precio);
            else if (tipo == "Lapicero")
                articulo = new Lapicero(0, marca, precio);
            else
                articulo = new Regla(0, marca, precio);

            datos.InsertarArticulo(articulo);
            MessageBox.Show("Articulo agregado correctamente");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdEliminar.Text);
            datos.EliminarArticulo(id);
            MessageBox.Show("Articulo eliminado correctamente");
        }
        private void btnMostrar_Click(Object sender, EventArgs e)
        {
            string tipo = cbTipoArticulo.SelectedItem.ToString();
            List<ArticuloEscolar> lista = datos.MostrarPorTipo(tipo);
            dgvArticulos.DataSource = lista;
        }

        private void btnVerGraficas_Click(object sender, EventArgs e)
        {
            Analisis ventanaGraficas = new Analisis();
            ventanaGraficas.ShowDialog();
        }
    }
}
