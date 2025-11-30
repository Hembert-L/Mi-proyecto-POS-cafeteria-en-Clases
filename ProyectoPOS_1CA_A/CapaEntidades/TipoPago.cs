using ProyectoPOS_1CA_A.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOS_1CA_A.CapaEntidades
{
    public class TipoPago
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    // Este método también servirá para llenar el ComboBox de Tipos de Pago. 
    public class TipoPagoDAL
    {
        public static List<TipoPago> Listar()
        {
            List<TipoPago> lista = new List<TipoPago>();
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string sql = "SELECT * FROM TipoPago";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new TipoPago
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                Nombre = dr["Nombre"].ToString()
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}