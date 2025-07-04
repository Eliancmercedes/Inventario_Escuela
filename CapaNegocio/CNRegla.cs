using System;
using CapaNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{


    public class Regla : ArticuloEscolar
    {
        //Constructores
        public Regla() : base() { }
        public Regla(int id, string marca, int precio) : base(id, marca, precio, "Regla") { }

        //Implementacion del metodo abstracto
        public override string ObtenerCategoria()
        {
            return "Papeleria";
        }

        //Sobreescribir metodo virtual

        public override string ObtenerDescripcion()
        {
            return $"Regla {Marca} - Precio: {Precio}";
        }
    }

}
