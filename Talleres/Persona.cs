using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Cesar San Miguel

namespace Talleres
{
    public class Persona
    {
        private int cedula;

        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public Persona(int cedula, string nombre, string apellido)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona()
        {

        }
    }
}
