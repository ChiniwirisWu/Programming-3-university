using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cliente : Persona
    {
        //attributes    
        private String categoria;
        private String codigo;

        //properties
        public String Categoria
        {
            get { return this.categoria; }
            set { this.categoria= value; }
        }

        public String Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        // methods
        public void generarCodigo()  
        {
            this.Codigo = "(" + this.Apellido.Substring(0, 3) + "16";
        }
    }
}
