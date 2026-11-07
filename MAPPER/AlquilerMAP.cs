using ENTIDAD;
using Microsoft.Data.SqlClient;

namespace MAPPER
{
    public class AlquilerMAP
    {

        public static Alquiler Map(SqlDataReader lector)
        {
            Alquiler alquiler = new Alquiler();

            alquiler.Id = Convert.ToInt32(lector["ID_ALQUILER"]);

            alquiler.Dni = Convert.ToString(lector["DNI_CLIENTE"]);

            alquiler.ImporteTotal = Convert.ToDecimal(lector["IMPORTE_TOTAL"]);

            alquiler.FechaRegistro = Convert.ToDateTime(lector["FECHA_REGISTRO"]);

            alquiler.FechaAlquiler = Convert.ToDateTime(lector["FECHA_ALQUILER"]);

            alquiler.TipoBicicleta = TipoBicicletaMAP.Map(lector);

            return alquiler;
        }
    }
}
