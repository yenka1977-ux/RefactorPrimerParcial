using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using ENTIDAD;

namespace MAPPER
{
    public class TipoBicicletaMAP
    {
       
            public static TipoBicicleta Map(SqlDataReader lector)
            {
                TipoBicicleta tipo = new TipoBicicleta();

                tipo.Id = Convert.ToInt32(lector["ID_TIPO_BICICLETA"]);

                tipo.Descripcion = Convert.ToString(lector["DESCRIPCION"]);

                return tipo;
            }
        
    }
}
