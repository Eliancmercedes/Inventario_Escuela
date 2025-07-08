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
            this.FormClosing += GestionArticulos_FormClosing;


            txtPrecio.KeyPress += SoloEnteros_KeyPress;


        }

        private void GestionArticulos_Load(object sender, EventArgs e)
        {
            cbTipoArticulo.Items.AddRange(new string[] { "Cuaderno", "Lapicero", "Regla" });
            cbTipoArticulo.SelectedIndex = 0;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;

            string tipo = cbTipoArticulo.SelectedItem.ToString();

            if (!decimal.TryParse(txtPrecio.Text, out decimal precioDecimal))
            {
                MessageBox.Show("Por favor ingrese un precio valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int precio = (int)precioDecimal;

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
            if (!int.TryParse(txtIdEliminar.Text, out int id))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            try
            {
                datos.EliminarArticulo(id);
                MessageBox.Show("Articulo eliminado correctamente");
            }
            catch (Exception ex)


            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

            


        
        private void btnMostrar_Click(Object sender, EventArgs e)
        {
            string tipo = cbTipoArticulo.SelectedItem.ToString();
            List<ArticuloEscolar> lista = datos.MostrarPorTipo(tipo);
            dgvArticulos.DataSource = lista;
        }

        private void SoloEnteros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                MessageBox.Show("El precio debe ser un numero entero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        private void btnVerGraficas_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            Analisis analisis = new Analisis(this);
            analisis.FormClosed += (s, args) => this.Close(); // Cierra el anterior cuando el nuevo se cierre
            analisis.Show();
        }

        private void btnBusquedaAvz_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            BusquedaAvanzada busquedaAvanzada = new BusquedaAvanzada();
            busquedaAvanzada.FormClosed += (s, args) => this.Close(); // Cierra el anterior cuando el nuevo se cierre
            busquedaAvanzada.Show();
        }
        

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanelPrincipal ventanaPanelPrincial = new PanelPrincipal();
            ventanaPanelPrincial.FormClosed += (s, args) => this.Close();
            ventanaPanelPrincial.Show();

        }
        private void GestionArticulos_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cuando se cierre GestionArticulos, abre PanelPrincipal si no ya está abierto
            if (Application.OpenForms.OfType<PanelPrincipal>().Count() == 0)
            {
                PanelPrincipal menu = new PanelPrincipal();
                menu.Show();
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
