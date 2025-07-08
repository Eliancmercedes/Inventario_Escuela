using System;
using CapaNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace CapaNegocio
{
   
    
 public class Cuaderno : ArticuloEscolar
    {

        //Constructores sin parametros
        public Cuaderno() : base() { }
        //Constructor con parametros
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
