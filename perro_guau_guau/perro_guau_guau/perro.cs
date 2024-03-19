using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perro_guau_guau
{
    //propiedades
    public class Perro {
        private String nombre;
        private String raza;
        private String altura;

        //get y set
        public String Nombre
        {
            //get y set son dos palabras clave para crear get, set.
            get { return this.nombre; } 
            set { this.nombre = value; } //asumo que exite una variable llamada "value" que no se de donde aparece
        }

        public String Altura
        {
            //get y set son dos palabras clave para crear get, set.
            get { return this.altura; }
            set { this.altura= value; } //asumo que exite una variable llamada "value" que no se de donde aparece
        }

        public String Raza
        {
            //get y set son dos palabras clave para crear get, set.
            get { return this.raza; }
            set { this.raza= value; } //asumo que exite una variable llamada "value" que no se de donde aparece
        }

        //metodos
        public String comer(String comida){
            return this.nombre + " mide " + this.altura + ", va a comer " + comida;
        }

        public void dormir(){

        }

        public void ladrar(){

        }

        //Constructor
        public Perro(String nombre, String raza, String altura){
            this.nombre = nombre;
            this.raza = raza;
            this.altura = altura;
        }
    }

    
}
