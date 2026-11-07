using BLL;
using ENTIDAD;
using System.Linq;

namespace UI
{
    public partial class Form1 : Form
    {
        private AlquilerBLL alquilerBLL = new AlquilerBLL();
        private TipoBicicletaBLL tipoBicicletaBLL = new TipoBicicletaBLL();
        private List<Alquiler> alquileresPendientes = new List<Alquiler>();
        public Form1()
        {
            InitializeComponent();
            CargarTiposBicicleta();

            dtpFechaAlquiler.Value = DateTime.Today;
        }

        private void CargarTiposBicicleta()
        {
            try
            {
                cmbTipoBicicleta.DataSource = tipoBicicletaBLL.ObtenerTiposBicicleta();

                cmbTipoBicicleta.DisplayMember = "Descripcion";
                cmbTipoBicicleta.ValueMember = "Id";

                cmbTipoBicicleta.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show( "Error", ex.Message );
            }
        }

        private void MostrarAlquileresPendientes()
        {
            dgvAlquileresPendientes.DataSource = null;

            dgvAlquileresPendientes.DataSource =
                alquileresPendientes.Select(a => new
                {
                    DNI = a.Dni,
                    TipoBicicleta = a.TipoBicicleta.Descripcion,
                    Importe = a.ImporteTotal,
                    FechaAlquiler = a.FechaAlquiler
                }).ToList();
        }
        private void btnAgregarLista_Click(object sender, EventArgs e)
        {
            try
            {
                decimal importe;

                if (!decimal.TryParse(txtImporte.Text, out importe))
                {
                    throw new Exception("Debe ingresar un importe válido.");
                }

                Alquiler alquiler = new Alquiler();

                alquiler.Dni = txtDni.Text.Trim();

                alquiler.TipoBicicleta = cmbTipoBicicleta.SelectedItem as TipoBicicleta;

                alquiler.ImporteTotal = importe;

                alquiler.FechaAlquiler = dtpFechaAlquiler.Value;

                // Validamos los datos mediante BLL
                alquilerBLL.ValidarAlquiler(alquiler);

                // Agregamos el alquiler a la lista temporal
                alquileresPendientes.Add(alquiler);

                // Actualizamos el DataGridView
                MostrarAlquileresPendientes();

                MessageBox.Show("Alquiler agregado a la lista correctamente.");

                // Limpiamos los controles
                txtDni.Clear();
                txtImporte.Clear();
                cmbTipoBicicleta.SelectedIndex = -1;
                dtpFechaAlquiler.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                int id;

                if (!int.TryParse(txtId.Text, out id))
                {
                    throw new Exception("Debe ingresar un ID numérico.");
                }

                Alquiler alquiler = alquilerBLL.BuscarAlquiler(id);

                dgvAlquileresRegistrados.DataSource = null;

                dgvAlquileresRegistrados.DataSource = new List<Alquiler>
        {
            alquiler
        }
                .Select(a => new
                {
                    Id = a.Id,
                    DNI = a.Dni,
                    TipoBicicleta = a.TipoBicicleta.Descripcion,
                    Importe = a.ImporteTotal,
                    FechaRegistro = a.FechaRegistro,
                    FechaAlquiler = a.FechaAlquiler
                }).ToList();

                MessageBox.Show("Alquiler encontrado correctamente.");
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontrar el alquiler", ex.Message);
                   
            }
        }

        private void btnQuitarLista_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvAlquileresPendientes.CurrentRow == null)
                {
                    throw new Exception("Debe seleccionar un alquiler de la lista.");
                }

                int indice = dgvAlquileresPendientes.CurrentRow.Index;

                alquileresPendientes.RemoveAt(indice);

                MostrarAlquileresPendientes();

                MessageBox.Show("Alquiler quitado de la lista correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
                  
            }
        }
        private void MostrarAlquileresRegistrados()
        {
            dgvAlquileresRegistrados.DataSource = null;

            dgvAlquileresRegistrados.DataSource = alquilerBLL.ObtenerAlquileres().Select(a => new
                {
                    Id = a.Id,
                    DNI = a.Dni,
                    TipoBicicleta = a.TipoBicicleta.Descripcion,
                    Importe = a.ImporteTotal,
                    FechaRegistro = a.FechaRegistro,
                    FechaAlquiler = a.FechaAlquiler
                }).ToList();
        }
        private void btnGuardarTodos_Click(object sender, EventArgs e)
        {

            try
            {
                if (alquileresPendientes.Count == 0)
                {
                    throw new Exception("No hay alquileres pendientes para guardar.");
                }

                alquilerBLL.AgregarMultiplesAlquileres(alquileresPendientes);

                MessageBox.Show("Todos los alquileres se guardaron correctamente.");
                alquileresPendientes.Clear();

                MostrarAlquileresPendientes();

                MostrarAlquileresRegistrados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron registrar los alquileres", ex.Message);
                    
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarAlquileresRegistrados();

                MessageBox.Show("Consulta realizada correctamente");


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar los alquileres registrados", ex.Message);
            }     
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                decimal importe;

                if (!int.TryParse(txtId.Text, out id))
                {
                    throw new Exception("Debe ingresar un ID numérico.");
                }

                if (!decimal.TryParse(txtImporte.Text, out importe))
                {
                    throw new Exception("Debe ingresar un importe válido.");
                }

                Alquiler alquiler = new Alquiler();

                alquiler.Id = id;
                alquiler.ImporteTotal = importe;
                alquiler.FechaAlquiler = dtpFechaAlquiler.Value;

                alquilerBLL.ModificarAlquiler(alquiler);

                MessageBox.Show("Alquiler modificado correctamente.");
                   

                MostrarAlquileresRegistrados();

                txtId.Clear();
                txtImporte.Clear();
                dtpFechaAlquiler.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar el alquiler");
                   
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                int id;

                if (!int.TryParse(txtId.Text, out id))
                {
                    throw new Exception("Debe ingresar un ID numérico.");
                }

                // Verificamos que el alquiler exista
                Alquiler alquiler = alquilerBLL.BuscarAlquiler(id);

                // Solicitamos confirmación
                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de que desea eliminar el alquiler?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    alquilerBLL.EliminarAlquiler(id);

                    MessageBox.Show(
                        "Alquiler eliminado correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    MostrarAlquileresRegistrados();

                    txtId.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el alquiler", ex.Message);
                   
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
