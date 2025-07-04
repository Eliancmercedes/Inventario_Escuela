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
    

    
    

    public class DatosArticulos
    {

        //Metodo "Mostrar Indormacion"
        public ArticuloEscolar MostrarInformacion(int idbusqueda)

        {
            //abrir la conexion
            using (SqlConnection conn = new SqlConnection(ConexionDatos.conexion))
            {
                //abrir la conexion a la base de datos
                conn.Open();

                //Consultar a Sql mostrar la informacion del articulo
                string query = "SELECT * FROM ArticuloEscolar WHERE IdArticulo = @IdArticulo";

                //Consulta a SQL
                SqlCommand cmd = new SqlCommand(query, conn);

                //agregar el parametro de busqueda
                cmd.Parameters.AddWithValue("@IdArticulo", idbusqueda);

                //Ejecucion de consulta
                SqlDataReader reader = cmd.ExecuteReader();

                //Veirificacion de resultado
                if (reader.Read())
                {
                    //Determinamos el tipo de articulo
                    string tipo = reader["TipoArticulo"].ToString();
                    ArticuloEscolar articuloEscolar;

                    //Si es un cuaderno se instancia en "Cuaderno"
                    if (tipo == "Cuaderno")
                        articuloEscolar = new Cuaderno();

                    //Si es un cuaderno se instancia en "Lapicero"
                    else if (tipo == "Lapicero")
                        articuloEscolar = new Lapicero();

                    //Si es un cuaderno se instancia en "Regla"
                    else articuloEscolar = new Regla();

                    //se asignan valores desde la base de datos a los atributos de las clases
                    articuloEscolar.IdArticulo = (int)reader["IdArticulo"];
                    articuloEscolar.Marca = (string)reader["Marca"];
                    articuloEscolar.Precio = (int)reader["Precio"];
                    articuloEscolar.Tipo = (string)reader["TipoArticulo"];

                    //devuelve el articulo encontrado
                    return articuloEscolar;

                }
                return null; //Esto es para que si no se encuentra no devuelva nada
            }

        }
        //Metodo para que el usuria puedo seleccioanr el tipo de producto deseado
        public List<ArticuloEscolar> MostrarPorTipo(string TipoSeleccionado)
        {
            List<ArticuloEscolar> lista = new List<ArticuloEscolar>();
            using (SqlConnection conn = new SqlConnection(ConexionDatos.conexion))
            {
                conn.Open();
                //Consultar a Sql mostrar la informacion del articulo
                string query = "SELECT * FROM ArticuloEscolar WHERE TipoArticulo = @Tipo";
                //Consulta a Sql
                SqlCommand cmd = new SqlCommand(query, conn);
                //Parametro de busqueda
                cmd.Parameters.AddWithValue("@Tipo", TipoSeleccionado);

                //Ejecucion de consulta
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ArticuloEscolar articulo;
                    string tipo = reader["TipoArticulo"].ToString();

                    if (tipo == "Cuaderno")
                        articulo = new Cuaderno();
                    else if (tipo == "Lapicero")
                        articulo = new Lapicero();
                    else articulo = new Regla();

                    articulo.IdArticulo = (int)reader["IdArticulo"];
                    articulo.Marca = reader["Marca"].ToString();
                    articulo.Precio = (int)reader["Precio"];
                    articulo.Tipo = tipo;

                    //Agregue el "lista.Add (Articulo) para ir llenando la lista de artículos que luego vas a mostrar en el DataGridView.
                    lista.Add(articulo);


                }
            }
            return lista;
        }
        // Método para mostrar todos los artículos
        public List<ArticuloEscolar> MostrarTodos()
        {
            List<ArticuloEscolar> lista = new List<ArticuloEscolar>();
            using (SqlConnection conn = new SqlConnection(ConexionDatos.conexion))
            {
                conn.Open();
                string query = "SELECT * FROM ArticuloEscolar";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string tipo = reader["TipoArticulo"].ToString();
                    ArticuloEscolar articulo;

                    if (tipo == "Cuaderno")
                        articulo = new Cuaderno();
                    else if (tipo == "Lapicero")
                        articulo = new Lapicero();
                    else if (tipo == "Regla")
                        articulo = new Regla();
                    else
                        articulo = new Otro(tipo); // Clase para artículos genéricos

                    articulo.IdArticulo = (int)reader["IdArticulo"];
                    articulo.Marca = reader["Marca"].ToString();
                    articulo.Precio = (int)reader["Precio"];
                    articulo.Tipo = tipo;

                    lista.Add(articulo);
                }
            }
            return lista;
        }


        //metodo insertarArticulos
        public void InsertarArticulo(ArticuloEscolar articulo)
        {
            using(SqlConnection conn = new SqlConnection(ConexionDatos.conexion))
            {
                conn.Open();
                string query = "INSERT INTO ArticuloEscolar (Marca, Precio, TipoArticulo) VALUES (@marca, @precio, @tipo)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@marca", articulo.Marca);
                cmd.Parameters.AddWithValue("@precio", articulo.Precio);
                cmd.Parameters.AddWithValue("@tipo", articulo.Tipo);
                cmd.ExecuteNonQuery();
            }
        }

        //Metodo eliminar articulo por ID
        public void EliminarArticulo(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConexionDatos.conexion))
            {
                conn.Open();
                string query = "DELETE FROM ArticuloEscolar WHERE IdArticulo = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }

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
        public Dictionary<string, int > ObtenerCantidadPorTipo()
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
                .ToDictionary(g => g.Key, g => g.GroupBy(x => x.Marca) .OrderByDescending(x=> x.Count())
                .First().Key
                );
        }

    }


}
