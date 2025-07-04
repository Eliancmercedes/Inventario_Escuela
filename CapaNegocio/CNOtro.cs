using System;
using CapaDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Otro : ArticuloEscolar
    {
        public Otro(string tipo) : base(0, "Desconocida", 0, tipo) { }

        public override string ObtenerCategoria()
        {
            return "Varios";
        }

        public override string ObtenerDescripcion()
        {
            return $"Artículo de tipo {Tipo}";
        }
    }

}
