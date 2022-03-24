using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodos1
{
    public class Persona
    {
        private string dni;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string nombres;

        public Persona()
        {
        }

        public Persona(string dni)
        {
            this.Dni = dni;
        }

        public Persona(string dni, string apellidoPaterno, string apellidoMaterno, string nombres) : this(dni)
        {
            this.ApellidoPaterno = apellidoPaterno;
            this.ApellidoMaterno = apellidoMaterno;
            this.Nombres = nombres;
        }

        public string Dni { get => dni; set => dni = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string Nombres { get => nombres; set => nombres = value; }

        public override string ToString()
        {
            return ("DNI:" + this.dni + "-" +
                    "ApellidoPaterno:" + this.apellidoPaterno + "-" +
                    "ApellidoMaterno:" + this.apellidoMaterno + "-" +
                    "Nombres:" + this.nombres);
        }

        public override bool Equals(object obj)
        {
            return dni.Equals(((Persona)obj).Dni);
        }
    }
}
