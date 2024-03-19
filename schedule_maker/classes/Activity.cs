using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Actividad {
        public string nombre;
        public List<float> minutos;
        public List<string> dias;
        public Actividad() {
            minutos = new List<float>();
            dias = new List<string>();
        }
}
