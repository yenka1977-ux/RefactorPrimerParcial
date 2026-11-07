using ENTIDAD;
using MAPPER;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DAL
{
    public class TipoBicicletaDAL
    {
        private string cadenaConexion =
           ConfigurationManager.ConnectionStrings["BDBicicletas"].ConnectionString;

        public List<TipoBicicleta> ObtenerTiposBicicleta()
        {
            List<TipoBicicleta> lista = new List<TipoBicicleta>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = "SELECT * FROM TIPO_BICICLETA";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                TipoBicicleta tipo = TipoBicicletaMAP.Map(lector);

                                lista.Add(tipo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al obtener los tipos de bicicleta: " + ex.Message);
            }

            return lista;
        }
    }
}
