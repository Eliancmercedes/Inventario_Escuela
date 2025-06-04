using Microsoft.Data.SqlClient;
using CapaDatos;


namespace CapaNegocio
{
    public class ArticuloEscolar
    {
        //atributos de la clase "articulos" para ser heredados en las demas
        public int IdArticulo { get; set; }
        public string marca { get; set; }
        public int precio { get; set; }
        public string tipo { get; set; }
    }
    //clase "cuaderno" para ser heredado de la clase "ArticuloEscolar"
    public class Cuaderno : ArticuloEscolar { }

    public class Lapicero : ArticuloEscolar { }
    public class Regla : ArticuloEscolar { }

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
                    articuloEscolar.marca = (string)reader["Marca"];
                    articuloEscolar.precio = (int)reader["Precio"];
                    articuloEscolar.tipo = (string)reader["TipoArticulo"];

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
                    articulo.marca = reader["Marca"].ToString();
                    articulo.precio = (int)reader["Precio"];
                    articulo.tipo = tipo;

                    //Agregue el "lista.Add (Articulo) para ir llenando la lista de artículos que luego vas a mostrar en el DataGridView.
                    lista.Add(articulo);


                }
            }
            return lista;
        }
    }


}
