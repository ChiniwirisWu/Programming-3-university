using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Persona
    {
        //attributes
        private String nombre;
        private String documento;
        private String apellido;
        private String tipo;
           
        //getters and setters (properties)
        public String Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public String Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public String Documento
        {
            get { return this.documento; }
            set { this.documento = value; }
        }

        public String Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }
    }
}
