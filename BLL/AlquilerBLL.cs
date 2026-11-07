using DAL;
using ENTIDAD;
using System.Transactions;

namespace BLL
{
    public class AlquilerBLL
    {
        private AlquilerDAL alquilerDAL = new AlquilerDAL();
        public void ValidarAlquiler(Alquiler alquiler)
        {
            // Validar que el alquiler no sea nulo
            if (alquiler == null)
            {
                throw new Exception("El alquiler no puede ser nulo.");
            }

            // Validar DNI
            if (string.IsNullOrWhiteSpace(alquiler.Dni))
            {
                throw new Exception("Debe ingresar el DNI del cliente.");
            }

            if (alquiler.Dni.Trim().Length <= 5)
            {
                throw new Exception("El DNI debe tener más de 5 caracteres.");
            }

            // Validar tipo de bicicleta
            if (alquiler.TipoBicicleta == null || alquiler.TipoBicicleta.Id <= 0)
            {
                throw new Exception("Debe seleccionar un tipo de bicicleta válido.");
            }

            // Validar importe
            if (alquiler.ImporteTotal <= 0)
            {
                throw new Exception("El importe total debe ser mayor que cero.");
            }

            // Validar fecha del alquiler
            if (alquiler.FechaAlquiler.Date < DateTime.Today)
            {
                throw new Exception("La fecha del alquiler no puede ser anterior a hoy.");
            }
        }


        public List<Alquiler> ObtenerAlquileres()
        {
            return alquilerDAL.ObtenerAlquileres();
        }

        public Alquiler BuscarAlquiler(int id)
        {
            if (id <= 0)
            {
                throw new Exception("El ID debe ser mayor que cero.");
            }

            Alquiler alquiler = alquilerDAL.ObtenerAlquilerPorId(id);

            if (alquiler == null)
            {
                throw new Exception("No existe un alquiler con ese ID.");
            }

            return alquiler;
        }

        public void AgregarMultiplesAlquileres(List<Alquiler> alquileres)
        {
            if (alquileres == null || alquileres.Count == 0)
            {
                throw new Exception("Debe agregar al menos un alquiler.");
            }

            // Validamos todos los alquileres antes de guardarlos
            foreach (Alquiler alquiler in alquileres)
            {
                ValidarAlquiler(alquiler);
            }

            try
            {
                using (var trx = new TransactionScope())
                {
                    foreach (var alquiler in alquileres)
                    {
                        alquiler.FechaRegistro = DateTime.Now;

                        alquilerDAL.AgregarAlquiler(alquiler);
                    }

                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al guardar los alquileres: " + ex.Message);
            }
        }

        public void ModificarAlquiler(Alquiler alquiler)
        {
            if (alquiler == null)
            {
                throw new Exception("El alquiler no puede ser nulo.");
            }

            if (alquiler.Id <= 0)
            {
                throw new Exception("El ID debe ser mayor que cero.");
            }

            // Verificamos que el alquiler exista
            BuscarAlquiler(alquiler.Id);

            // Validamos el nuevo importe
            if (alquiler.ImporteTotal <= 0)
            {
                throw new Exception("El importe total debe ser mayor que cero.");
            }

            // Validamos la nueva fecha
            if (alquiler.FechaAlquiler.Date < DateTime.Today)
            {
                throw new Exception(
                    "La fecha del alquiler no puede ser anterior a hoy.");
            }

            // Enviamos el alquiler a DAL para modificarlo
            alquilerDAL.ModificarAlquiler(alquiler);
        }


        public void EliminarAlquiler(int id)
        {
            // Verificamos que el alquiler exista
            BuscarAlquiler(id);

            // Si existe, lo eliminamos
            alquilerDAL.EliminarAlquiler(id);
        }

    }
}
