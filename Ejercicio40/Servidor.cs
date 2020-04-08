using System;

namespace Ejercicio40
{
    public class Servidor
    {

        public Servidor(string name,Double m, Double d,int i,int p)
        {
            nombre = name;
            estado = "Libre";
            eventoAsociado = "Fin Atencion " + name;
            media = m;
            desv = d;
            indiceEvento = i;
            personalLibre = p;
        }

        public String nombre { get; set; }
        public String estado { get; set; }
        public String eventoAsociado { get; set; }
        public String eventoAsociado2 { get; set; }
        public String eventoAsociado3 { get; set; }
        public int personalLibre { get; set; }
        public int cola { get; set; }
        public int indiceEvento { get; set; }
        public int indiceEvento2 { get; set; }
        public int indiceEvento3 { get; set; }
        public TimeSpan? finAtencion { get; set; }
        public TimeSpan? tiempoAtencion { get; set; }

        // tiempoConstanteAsociado guarda el intervalo de cada cuanto suena el telefono
        // proximoEventoAsociado2 indica cuando llega la proxima llamada
        public TimeSpan? tiempoConstanteAsociado { get; set; }
        public TimeSpan? proximoEventoAsociado2 { get; set; }
        public TimeSpan? proximoEventoAsociado3 { get; set; }

        public TimeSpan? inicioOcio { get; set; }
        public TimeSpan? ocioTotal { get; set; }
        public Double media { get; set; }
        public Double desv { get; set; }
    }
}
