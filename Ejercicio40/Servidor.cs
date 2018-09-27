using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio40
{
    public class Servidor
    {
        //String nombre;
        //string lista_Estados;


        public Servidor(string name)
        {
            nombre = name;
            estado = "Libre";
        }

        public String nombre { get; set; }
        public String estado { get; set; }
        public int cola { get; set; }
        public long? finAtencion { get; set; }
        public long? tiempoAtencion { get; set; }
        public long? inicioOcio { get; set; }
        public long media { get; set; }
        public long desv { get; set; }
    }
}
