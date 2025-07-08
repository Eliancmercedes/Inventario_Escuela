using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;

namespace CapaNegocio
{
    public class AnalisisArticulos
    {
        private List<ArticuloEscolar> articulos;

        //contrcutor para caragr todos los articulos una sola vez
        public AnalisisArticulos()
        {
            DatosArticulos datos = new DatosArticulos();
            articulos = datos.MostrarTodos(); //metodo

        }
        // metodo obtener cantidad de articulo por precio
        public Dictionary<string, int> ObtenerCantidadPorTipo()
        {
            return articulos
                .GroupBy(a => a.Tipo)
                .ToDictionary(g => g.Key, g => g.Count());
        }
        //Metodo obtener precio promedio por tipo
        public Dictionary<string, double> ObtenerPrecioPromedioPorTipo()
        {
            return articulos
                .GroupBy(a => a.Tipo)
                .ToDictionary(g => g.Key, g => g.Average(x => x.Precio));
        }
        //Metodo para obtener marca mas comun por tipo
        public Dictionary<string, string> ObtenerMarcasComunPorTipo()
        {
            return articulos
                .GroupBy(a => a.Tipo)
                .ToDictionary(g => g.Key, g => g.GroupBy(x => x.Marca).OrderByDescending(x => x.Count())
                .First().Key
                );
        }

    }
}
