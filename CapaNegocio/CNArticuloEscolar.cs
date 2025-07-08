using Microsoft.Data.SqlClient;
using CapaDatos;
using Microsoft.Identity.Client;
using System.Linq;



namespace CapaNegocio
{
    //clase abstracta   
    public abstract class ArticuloEscolar
    {
        //atributos de la clase "articulos" para ser heredados en las demas
        public int IdArticulo { get; set; }
        public string Marca { get; set; }
        public int Precio { get; set; }
        public string Tipo { get; set; }
        public ArticuloEscolar() { }



        //Constructor para crear objetos con todos los datos
        public ArticuloEscolar(int id, string marca, int precio, string tipo) 
        { 


            IdArticulo = id;
            Marca = marca;
            Precio = precio; 
            Tipo = tipo; 

           
        }
        //Metodo virtual que puede ser sobreescrito por las clases hijas
        public virtual string ObtenerDescripcion()
        {
            return $"{Tipo} {Marca} - Precio: {Precio}";
        }
        //Metodo abstracto para implementarse en cada herencia
        public abstract string ObtenerCategoria();
    }
    

    
    

    

    


}
