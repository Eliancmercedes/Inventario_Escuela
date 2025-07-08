using System;
using CapaNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    
    
   public class Lapicero : ArticuloEscolar
    {
        //Constructores
        public Lapicero() : base() { }
        public Lapicero(int id, string marca, int precio) : base(id, marca, precio, "Lapicero") { }

        //Implementacion del metodo abstracto
        public override string ObtenerCategoria()
        {
            return "Escritura";
        }

        //Sobreescribir metodo virtual

        public override string ObtenerDescripcion()
        {
            return $"Lapicero {Marca} - Precio: {Precio}";
        }
    }

}
