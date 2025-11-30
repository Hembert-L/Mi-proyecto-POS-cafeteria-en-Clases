using ProyectoPOS_1CA_A.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOS_1CA_A.CapaDatos
{
    public class ClienteDAL
    {
        public DataTable Listar()
        {
            DataTable dt = new DataTable();//Crea una tabla en memoria
            using (SqlConnection cn = new SqlConnection(Conexion.cadena))
            //SQLConnection: representa la conexion a una base de datos SQL Server usando la cadena de conexion
            {
                string sql = "SELECT Id, Nombre, Dui, Telefono, Correo, Estado from Cliente";
                //Consulta SQL para obtener los datos de la tabla Cliente
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                //SqlCommand: prepara el comando sql que se enviara al servidor
                {
                    cn.Open(); //Abre la conexion a la base de datos
                    new SqlDataAdapter(cmd).Fill(dt);
                    //sqlDataAdapter: Ejecuta SELECT y llena el DataTable con los resultados
                }
            }
            return dt; //Retorna la tabla con los datos obtenidos
        }
        public int Insertar(Cliente2 c)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.cadena))
            {
                string sql = @"INSERT INTO Cliente(Nombre, Dui, Telefono, Correo, Estado) VALUES (@nombre, @dui, @telefono, @Correo, @Estado) SELECT SCOPE_IDENTITY()";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                    cmd.Parameters.AddWithValue("@dui", c.Dui);
                    cmd.Parameters.AddWithValue("@telefono", c.Telefono);
                    cmd.Parameters.AddWithValue("@correo", c.Correo);
                    cmd.Parameters.AddWithValue("@estado", c.Estado);
                    cn.Open();
                    //ExecuteScalar: Ejecuta la consulta y retorna el primer valor de la primera fila del resultado
                    //Valor de la primera columna de la primera fila (ID generado)
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public bool Actualizar(Cliente2 c)

        {
            using (SqlConnection cn = new SqlConnection(Conexion.cadena))

            {
                string sql = @"UPDATE Cliente SET Nombre=@nombre, Dui=@dui,
                                 Telefono=@telefono, Correo=@correo, Estado=@estado WHERE Id=@id";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", c.Id);
                    cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                    cmd.Parameters.AddWithValue("@dui", c.Dui);
                    cmd.Parameters.AddWithValue("@telefono", c.Telefono);
                    cmd.Parameters.AddWithValue("@correo", c.Correo);
                    cmd.Parameters.AddWithValue("@estado", c.Estado);
                    cn.Open();
                    //ExecuteNonQuery: Ejecuta la consulta y retorna el numero de filas afectadas
                    return cmd.ExecuteNonQuery() > 0;
                }

            }

        }

        public bool Eliminar(int id)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.cadena))
            {
                string sql = "DELETE FROM Cliente WHERE Id=@id";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cn.Open();
                    //ExecuteNonQuery: Ejecuta la consulta y retorna el numero de filas afectadas
                    return cmd.ExecuteNonQuery() > 0;

                    //Elimina y devuelve true si se elimino al menos una fila
                }
            }
        }
        public DataTable Buscar(String filtro)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.cadena))
            {
                string sql = "SELECT Id, Nombre, Dui, Telefono, Correo, Estado" +
                    " from Cliente WHERE Nombre LIKE @filtro OR Dui LIKE @filtro OR Telefono LIKE @filtro";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    cn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                    //Lena el DataTable con los resultados de la busqueda
                }
            }
            return dt;
        }
    }
}
