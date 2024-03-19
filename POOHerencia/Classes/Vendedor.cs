using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Vendedor:Persona
    {
        //attributes
        private String tipoContrato;
        private Double sueldo;

        //properties
        public String TipoContrato
        {
            get { return this.tipoContrato; }
            set { this.tipoContrato= value; }
        }

        public Double Sueldo
        {
            get { return this.sueldo; }
            set { this.sueldo= value; }
        }

        public void calcularSueldo(Double sueldoBase)
        {
            if(this.TipoContrato == "C")
            {
                this.Sueldo = sueldoBase + 350;
            }
            else if (this.TipoContrato == "N")
            {
                this.Sueldo = sueldoBase + 750;
            }
            else
            {
                this.Sueldo = 0;
            }
        }
    }
}
