using System;
using ScottPlot;
using CapaNegocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.ConstrainedExecution;

namespace CapaPresentacion
{
    public partial class Analisis : Form
    {
        private AnalisisArticulos analisis;

        public Analisis()
        {
            InitializeComponent();
            analisis = new AnalisisArticulos();
        }

        private void Analisis_Load(object sender, EventArgs e)
        {
            MostrarCantidadPorTipo();
            MostrarPrecioPromedioPorTipo();
            MostrarMarcaMasComunPorTipo();
        }
        private void MostrarCantidadPorTipo()
        {
            var datos = analisis.ObtenerCantidadPorTipo();
            var tipos = datos.Keys.ToArray();
            var valores = datos.Values.Select(v => (double)v).ToArray();

            var plt = formsPlotCantidad.Plot;
            plt.Clear();
            plt.Add.Bars(valores);
            var bar = plt.Add.Bars(valores);
            
            plt.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ScottPlot.Generate.Consecutive(tipos.Length), tipos);
            plt.Title("Cantidad por tipo", size: 18);
            
            plt.Axes.Left.Label.Text = "Cantidad";
            plt.Axes.Left.Label.FontSize = 14;
            plt.Axes.Bottom.Label.Text = "Tipo";
            plt.Axes.Left.Label.FontSize = 14;
            plt.Axes.Bottom.TickLabelStyle.FontSize = 12;
            formsPlotCantidad.Refresh();
        }
        private void MostrarPrecioPromedioPorTipo()
        {
            var datos = analisis.ObtenerPrecioPromedioPorTipo();
            var tipos = datos.Keys.ToArray();
            var valores = datos.Values.ToArray();

            var plt = formsPlotPromedio.Plot;
            plt.Clear();
            plt.Add.Bars(valores);
            plt.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ScottPlot.Generate.Consecutive(tipos.Length), tipos);
            plt.Title("Precio promedio \npor tipo");
            plt.Axes.Left.Label.Text = "Precio promedio";


            plt.Axes.Bottom.Label.Text = "Tipo";
            formsPlotPromedio.Refresh();
        }

        private void MostrarMarcaPorTipo()
        {
            var datos = analisis.ObtenerPrecioPromedioPorTipo();
            var tipos = datos.Keys.ToArray();
            var valores = datos.Values.ToArray();

            var plt = formsPlotPromedio.Plot;
            plt.Clear();
            plt.Add.Bars(valores);
            plt.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ScottPlot.Generate.Consecutive(tipos.Length), tipos);
            plt.Title("Precio promedio \npor tipo");
            plt.Axes.Left.Label.Text = "Precio promedio";
            plt.Axes.Bottom.Label.Text = "Tipo";

            plt.Axes.SetLimitsX(-0.5, tipos.Length - 0.5);

            formsPlotPromedio.Refresh();
        }

        private void MostrarMarcaMasComunPorTipo()
        {
            var datosMarcas = analisis.ObtenerMarcasComunPorTipo();
            var datosCantidades = analisis.ObtenerCantidadPorTipo();

            var tiposPresentes = datosCantidades.Keys.ToList();
            var valoresPie = new List<double>();
            var labelsPie = new List<string>();

            foreach (var tipo in tiposPresentes)
            {
                valoresPie.Add(datosCantidades[tipo]);
                if (datosMarcas.ContainsKey(tipo))
                {
                    labelsPie.Add($"{tipo}\n{datosMarcas[tipo]}");
                }
                else
                {
                    labelsPie.Add($"{tipo}\n(Marca no disponible)");
                }
            }


            var plt = formsPlotMarca.Plot;
            plt.Clear();

            var pie = plt.Add.Pie(values: valoresPie.ToArray());

            
            for (int i = 0; i < labelsPie.Count; i++)
            {
                if (i < pie.Slices.Count)
                {
                    pie.Slices[i].Label = labelsPie[i];
                    pie.Slices[i].LabelFontSize = 14; 

                    
                }
            }

            plt.Title("Marca más común \npor tipo", size: 20);

            double xMin = -1.1;
            double xMax = 1.1;
            double yMin = -1.5;
            double yMax = 1.0;

            plt.Axes.SetLimits(xMin, xMax, yMin, yMax);

            

            formsPlotMarca.Refresh();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

