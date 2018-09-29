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


        public Servidor(string name,Double m, Double d,int i)
        {
            nombre = name;
            estado = "Libre";
            eventoAsociado = "Fin Atencion " + name;
            media = m;
            desv = d;
            indiceEvento = i;
        }

        public String nombre { get; set; }
        public String estado { get; set; }
        public String eventoAsociado { get; set; }
        public int cola { get; set; }
        public int indiceEvento { get; set; }
        public TimeSpan? finAtencion { get; set; }
        public TimeSpan? tiempoAtencion { get; set; }
        public TimeSpan? inicioOcio { get; set; }
        public Double media { get; set; }
        public Double desv { get; set; }
    }
}
