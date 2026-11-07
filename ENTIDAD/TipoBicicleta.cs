using System;
using System.Collections.Generic;
using System.Text;

namespace ENTIDAD
{
    public class TipoBicicleta
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;

        public override string ToString()
        {
            return Descripcion;
        }

    }
}
