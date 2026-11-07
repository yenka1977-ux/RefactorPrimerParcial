using DAL;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class TipoBicicletaBLL
    {
        private TipoBicicletaDAL tipoBicicletaDAL =new TipoBicicletaDAL();

        public List<TipoBicicleta> ObtenerTiposBicicleta()
        {
            return tipoBicicletaDAL.ObtenerTiposBicicleta();
        }
    }
}
