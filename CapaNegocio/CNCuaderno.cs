using System;
using CapaNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   
    
 public class Cuaderno : ArticuloEscolar
    {

        //Constructores
        public Cuaderno() : base() { }
        public Cuaderno(int id, string marca, int precio) : base(id, marca, precio, "Cuaderno") { }

        //Implementacion del metodo abstracto
        public override string ObtenerCategoria()
        {
            return "Papeleria";
        }

        //Sobreescribir metodo virtual

        public override string ObtenerDescripcion()
        {
            return $"Cuaderno {Marca} - Precio: {Precio}";
        }
    }

    
}
