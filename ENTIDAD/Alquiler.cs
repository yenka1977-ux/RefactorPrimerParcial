namespace ENTIDAD
{
    public class Alquiler
    {
        public int Id {  get; set; }
        public TipoBicicleta TipoBicicleta { get; set; } = new TipoBicicleta();
        public string Dni { get; set; } = string.Empty;
        public decimal ImporteTotal {  get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaAlquiler { get; set;  }


    }
}
