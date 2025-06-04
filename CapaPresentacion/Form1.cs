using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            //Obtener lo seleccioando
            string TipoSeleccionado = cbarticulo.SelectedItem.ToString();

            //Crear la instancia de capa de negocio
            DatosArticulos datos = new DatosArticulos();

            //Obtener la lista
            List<ArticuloEscolar> lista = datos.MostrarPorTipo(TipoSeleccionado);

            //Asignar al DataGrieView
            dataGProduct.DataSource = null;
            dataGProduct.DataSource = lista;



        }
    }
}
