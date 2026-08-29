using Estudiantes2M7.Apartado_interno;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Estudiantes2M7
{
    public partial class FormInicioRegistroEstudiante : Form
    {
        private readonly string cadenaConeccion = "Data Source = PC15;" +
            "Initial catalog = RegistroEstudiantesDB;" +
            "Integrated Security = true;" + "TrustServerCertificate = true;";

        private bool ValidarFormulario()
        {
            bool validar = true;
            if (string.IsNullOrEmpty(textBoxCarnet.Text))
            {
                errorProvider1.SetError(textBoxCarnet, "El carnet es obligatorio");
                validar = false;
            }
            if (string.IsNullOrEmpty(textBoxNombreCompleto.Text))
            {
                errorProvider1.SetError(textBoxNombreCompleto, "El nombre completo es obligatorio");
                validar = false;
            }
            if (comboBoxSexo.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxSexo, "Seleccione el genero del estudiante");
                validar = false;
            }

            return validar;
        }

        private Estudiante CrearRegistro()
        {
            return new Estudiante
            {
                Carnet = textBoxCarnet.Text.Trim().ToUpper(),
                NombreCompleto = textBoxNombreCompleto.Text.Trim(),
                Sexo = comboBoxSexo.Text,
                FechaNacimiento = dateTimePickerFechaNacimiento.Value.Date,
                Correo = textBoxCorreo.Text.Trim(),
            };
        }

        private void GuardarEstudiante(Estudiante estudiante)
        {
            string sql = @"
                           Insert into Estudiantes (Id, Carnet, NombreCompleto, Sexo, FechaNacimiento, Correo)
                           values (@Id, @Carnet, @NombreCompleto, @Sexo, @FechaNacimiento, @Correo ;";

            using SqlConnection connect = new SqlConnection(cadenaConeccion);

            using SqlCommand cmd = new SqlCommand(sql, connect);

            cmd.Parameters.AddWithValue("@Id", estudiante.Id);
            cmd.Parameters.AddWithValue("@Carnet", estudiante.Carnet);
            cmd.Parameters.AddWithValue("@NombreCompleto", estudiante.NombreCompleto);
            cmd.Parameters.AddWithValue("@Sexo", estudiante.Sexo);
            cmd.Parameters.AddWithValue("@FechaNacimiento", estudiante.FechaNacimiento);
            cmd.Parameters.AddWithValue("@Correo", estudiante.Correo);

            connect.Open();
            cmd.ExecuteNonQuery();
        }

        public void CargarEstudiante()
        {
            string sql = @"
                         Select Carnet, NombreCompleto, Sexo, Correo
                         from Estudiantes
                         order by NombreCompleto;";
            using SqlConnection connect = new SqlConnection(cadenaConeccion);
            using SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dataGridViewEstudiantes.DataSource = tabla;
        }
        public FormInicioRegistroEstudiante()
        {
            InitializeComponent();
            CargarEstudiante();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarFormulario())
                    return;
                Estudiante estudiante = CrearRegistro();
                GuardarEstudiante(estudiante);
                MessageBox.Show("Estudiante guardado con exito");
                CargarEstudiante();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errpr");
            }
        }

        private void Limpiar()
        {
            textBoxCarnet.Clear();
            textBoxCorreo.Clear();
            textBoxNombreCompleto.Clear();
            comboBoxSexo.SelectedIndex = -1;
            errorProvider1.Clear();
            textBoxCarnet.Focus();
        }

        private void Salir()
        {
            Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }
    }
}
