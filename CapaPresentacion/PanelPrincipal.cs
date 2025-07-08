using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class PanelPrincipal : Form
    {
        public PanelPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            BusquedaAvanzada busquedaAvanzada = new BusquedaAvanzada();
            busquedaAvanzada.FormClosed += (s, args) => this.Close(); // Cierra el anterior cuando el nuevo se cierre
            busquedaAvanzada.Show();
        }

        private void PN1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIrGestion_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            GestionArticulos gestionArticulos = new GestionArticulos();
            gestionArticulos.FormClosed += (s, args) => this.Close(); // Cierra el anterior cuando el nuevo se cierre
            gestionArticulos.Show();
        }

        private void btnIrAnalisis_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            Analisis analisis = new Analisis(this);
            analisis.FormClosed += (s, args) => this.Close(); // Cierra el anterior cuando el nuevo se cierre
            analisis.Show();
        }

        private void PNContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
