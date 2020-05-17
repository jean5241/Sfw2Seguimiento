using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class PacienteModel
    {
        public string MostrarPaciente(int cedula, string nombre)
        {
            string Paciente = "";

            if (cedula == 1026163147 && nombre == "Sura")
            {
                Paciente = Pacientes("Juan", "Vélez", 1026163147, 2654897, "Caldas", "Sura");
            }
            else
            {
                if (cedula == 15429219 && nombre == "Sabia")
                {

                    Paciente = Pacientes("Brian", "Mesa", 15429219, 3658972, "Itaguí", "Sabia");
                }

            }
            return Paciente;
        }
        public string MostrarPaciente1(string nombre)
        {
            StringBuilder sb = new StringBuilder();

            if (nombre == "Sura")
            {
                sb.Append(Pacientes("Juan", "Vélez", 1026163147, 2654897, "Caldas", "Sura"));
                sb.Append(Pacientes("Luis", "Sánchez", 1026163147, 2654897, "Medellín", "Sura"));
            }
            else
            {
                if (nombre == "Sabia")
                {

                    sb.Append(Pacientes("Brian", "Mesa", 15429219, 3658972, "Itaguí", "Sabia"));
                    sb.Append(Pacientes("Juana", "Henao", 43216588, 3654562, "Envigado", "Sabia"));
                }

            }
            return sb.ToString();
        }
        public bool ValidarPaciente(int usuario, string contrasena)
        {
            bool Paciente = false;
            if (usuario == 1026163147 && contrasena == "szs1")
            {
                Paciente = true;
            }
            else
            {
                if (usuario == 43683565 && contrasena == "szs2")
                {
                    Paciente = true;
                }
                else
                {
                    if (usuario == 15429219 && contrasena == "szs3")
                    {
                        Paciente = true;
                    }
                }
            }
            return Paciente;

        }

        public string Pacientes(string nombre, string apellido, int cedula, int telefono, string direccion, string eps)
        {
            var jsonObject = new Paciente()
            {
                nombre = nombre,
                apellido = apellido,
                cedula = cedula,
                telefono = telefono,
                direccion = direccion,
                eps = eps

            };
            string json = JsonConvert.SerializeObject(jsonObject);
            return json;
        }
    }
    



    public class Paciente
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int cedula { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public string eps { get; set; }

    }
}

