using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes2M7.Apartado_interno
{
    public class Estudiante
    {
        //Atributos
        private Guid _id = Guid.NewGuid();
        private string _carnet = string.Empty;
        private string _nombreCompleto = string.Empty;
        private string _sexo = string.Empty;
        private DateTime _fechaNacimiento;
        private string _correo = string.Empty;

        public Estudiante()
        {
        }

        //Propiedades
        public Guid Id
        {
            get { return _id; }
            set
            {
                if (value == Guid.Empty)
                    throw new ArgumentException("El ID no puede estar vacío.");

                _id = value;
            }
        }

        public string Carnet
        {
            get { return _carnet; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El carnet es obligatorio.");

                if (value.Length < 5 || value.Length > 20)
                    throw new ArgumentException("El carnet debe tener entre 5 y 20 caracteres.");

                _carnet = value.Trim();
            }
        }

        public string NombreCompleto
        {
            get { return _nombreCompleto; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre completo es obligatorio.");

                if (value.Length < 3)
                    throw new ArgumentException("El nombre debe tener al menos 3 caracteres.");

                if (value.Length > 120)
                    throw new ArgumentException("El nombre no puede superar los 100 caracteres.");

                _nombreCompleto = value.Trim();
            }
        }

        public string Sexo
        {
            get { return _sexo; }
            set
            {
                _sexo = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set
            {
                _fechaNacimiento = value;
            }
        }

        public string Correo
        {
            get { return _correo; }
            set
            {
                _correo = value.Trim();
            }
        }

    }
}
