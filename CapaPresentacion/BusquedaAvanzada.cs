using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class BusquedaAvanzada : Form

    {
        private List<ArticuloEscolar> TodosLosArticulos;
        public BusquedaAvanzada()
        {
            InitializeComponent();

            DatosArticulos datos = new DatosArticulos();
            TodosLosArticulos = datos.MostrarTodos(); //Cargar todos los articulos del inicio

            btnBuscar.Click += btnBuscar_Click;
            btnVolver.Click += btnVolver_Click;
            txtMarca.Enter += txt_BorrarTexto;
            txtPrecioMin.Enter += txt_BorrarTexto;
            txtPrecioMax.Enter += txt_BorrarTexto;
            txtPrecioMin.KeyPress += SoloEnteros_KeyPress;
            txtPrecioMax.KeyPress += SoloEnteros_KeyPress;
            this.FormClosing += BusquedaAvanzada_FormClosing;

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string marcaFiltro = txtMarca.Text.ToLower().Trim();
            string tipoSeleccionado = cbTipo.SelectedItem.ToString();

            bool tienePrecioMin = int.TryParse(txtPrecioMin.Text, out int precioMin);
            bool tienePrecioMax = int.TryParse(txtPrecioMax.Text, out int precioMax);

            var resultado = TodosLosArticulos
                .Where(a =>
                    (tipoSeleccionado == "Todos" || a.Tipo == tipoSeleccionado) &&
                    (string.IsNullOrWhiteSpace(marcaFiltro) || a.Marca.ToLower().Contains(marcaFiltro)) &&
                    (!tienePrecioMin || a.Precio >= precioMin) &&
                    (!tienePrecioMax || a.Precio <= precioMax)
                )
                .ToList();

            lstResultado.Items.Clear();

            if (resultado.Count == 0)
            {
                MessageBox.Show("No se encontraron artículos con esos criterios.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lstResultado.Items.Add("No se encontraron resultados.");
                return;
            }

            foreach (var articulo in resultado)
            {
                string descripcion = articulo.ObtenerDescripcion(); // Método Virtual
                string categoria = articulo.ObtenerCategoria();     // Método Abstracto
                lstResultado.Items.Add($"{descripcion} | Categoría: {categoria}");
            }
        }

        private void txt_BorrarTexto(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.Clear();
        }
        private void SoloEnteros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            GestionArticulos gestionArticulos = new GestionArticulos();
            gestionArticulos.FormClosed += (s, args) => this.Close(); // Cierra el anterior cuando el nuevo se cierre
            gestionArticulos.Show();
        }
        private void BusquedaAvanzada_Load(object sender, EventArgs e)
        {
            cbTipo.Items.Add("Todos");
            cbTipo.Items.Add("Cuaderno");
            cbTipo.Items.Add("Lapicero");
            cbTipo.Items.Add("Regla");
            cbTipo.SelectedIndex = 0; // Para que "Todos" esté seleccionado por defecto
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanelPrincipal ventanaPanelPrincial = new PanelPrincipal();
            ventanaPanelPrincial.FormClosed += (s, args) => this.Close();
            ventanaPanelPrincial.Show();
        }

        private void btnVerGraficas_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            Analisis analisis = new Analisis(this);
            analisis.FormClosed += (s, args) => this.Close(); // Cierra el anterior cuando el nuevo se cierre
            analisis.Show();
        }

        private void BusquedaAvanzada_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cuando se cierre GestionArticulos, abre PanelPrincipal si no ya está abierto
            if (Application.OpenForms.OfType<PanelPrincipal>().Count() == 0)
            {
                PanelPrincipal menu = new PanelPrincipal();
                menu.Show();
            }
        }

    }
}
