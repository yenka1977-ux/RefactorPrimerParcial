using ENTIDAD;
using MAPPER;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class AlquilerDAL
    {
        private string cadenaConexion =
           ConfigurationManager.ConnectionStrings["BDBicicletas"].ConnectionString;

        public List<Alquiler> ObtenerAlquileres()
        {
            List<Alquiler> lista = new List<Alquiler>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"SELECT
                                        A.ID_ALQUILER,
                                        A.DNI_CLIENTE,
                                        A.IMPORTE_TOTAL,
                                        A.FECHA_REGISTRO,
                                        A.FECHA_ALQUILER,
                                        T.ID_TIPO_BICICLETA,
                                        T.DESCRIPCION
                                     FROM ALQUILER A
                                     INNER JOIN TIPO_BICICLETA T
                                     ON A.ID_TIPO_BICICLETA = T.ID_TIPO_BICICLETA";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                Alquiler alquiler = AlquilerMAP.Map(lector);

                                lista.Add(alquiler);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al obtener los alquileres: " + ex.Message, ex);
            }

            return lista;
        }

        public Alquiler ObtenerAlquilerPorId(int id)
        {
            Alquiler alquiler = null;

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"SELECT
                                A.ID_ALQUILER,
                                A.DNI_CLIENTE,
                                A.IMPORTE_TOTAL,
                                A.FECHA_REGISTRO,
                                A.FECHA_ALQUILER,
                                T.ID_TIPO_BICICLETA,
                                T.DESCRIPCION
                             FROM ALQUILER A
                             INNER JOIN TIPO_BICICLETA T
                             ON A.ID_TIPO_BICICLETA = T.ID_TIPO_BICICLETA
                             WHERE A.ID_ALQUILER = @Id";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                alquiler = AlquilerMAP.Map(lector);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al buscar el alquiler: " + ex.Message);
            }

            return alquiler;
        }

        public void AgregarAlquiler(Alquiler alquiler)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"INSERT INTO ALQUILER
                             (ID_TIPO_BICICLETA,
                              DNI_CLIENTE,
                              IMPORTE_TOTAL,
                              FECHA_REGISTRO,
                              FECHA_ALQUILER)
                             VALUES
                             (@IdTipoBicicleta,
                              @Dni,
                              @ImporteTotal,
                              @FechaRegistro,
                              @FechaAlquiler)";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdTipoBicicleta", alquiler.TipoBicicleta.Id);

                        comando.Parameters.AddWithValue("@Dni", alquiler.Dni);

                        comando.Parameters.AddWithValue("@ImporteTotal", alquiler.ImporteTotal);

                        comando.Parameters.AddWithValue("@FechaRegistro", alquiler.FechaRegistro);

                        comando.Parameters.AddWithValue("@FechaAlquiler", alquiler.FechaAlquiler);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el alquiler: " + ex.Message);
            }
        }

        public void ModificarAlquiler(Alquiler alquiler)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"UPDATE ALQUILER
                             SET IMPORTE_TOTAL = @ImporteTotal,
                                 FECHA_ALQUILER = @FechaAlquiler
                             WHERE ID_ALQUILER = @Id";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@ImporteTotal", alquiler.ImporteTotal);

                        comando.Parameters.AddWithValue("@FechaAlquiler", alquiler.FechaAlquiler);

                        comando.Parameters.AddWithValue("@Id", alquiler.Id);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            throw new Exception("No se encontró el alquiler para modificar.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el alquiler: " + ex.Message);
            }
        }

        public void EliminarAlquiler(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"DELETE FROM ALQUILER
                             WHERE ID_ALQUILER = @Id";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@Id", id);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            throw new Exception("No se encontró el alquiler para eliminar.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el alquiler: " + ex.Message, ex);
            }
        }

    }
}
