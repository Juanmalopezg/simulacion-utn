using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace Ejercicio40
{

    public partial class Form1 : Form
    {
        //para testear
        Stopwatch sw = new Stopwatch();


        //Inicio Columnas
        // TimeSpan? reloj;
        public TimeSpan? reloj = TimeSpan.Parse("00:00:00");

        public String evento, atencion, i_estado, t_estado, p_esado, s_estado;
        public int indiceEvento;
        Double pi = Math.PI;
        //randoms
        Double c_rand, a_rand, i_rand, t_rand, p_rand, s_rand;

        //clientes
        TimeSpan? c_tiempoEntreLLeg, c_proxLlegada;

        public Form1()
        {
            InitializeComponent();
            iniciarSim();

        }

        public void iniciarSim()
        {
            //p testear
            //sw.Start();

            //creo los Servidores(nombre,media,desviación,indice de evento asociado)
            Servidor insumos = new Servidor("Insumos",3,1,2);
            Servidor telefono = new Servidor("Telefono", 1,0.5,3);
            Servidor presupuesto = new Servidor("Presupuesto",7,2,4);
            Servidor servTecnico = new Servidor("Servicio Tecnico",3,1,5);

            //defino evento de atencion de telefono en el servidor de insumos
            insumos.eventoAsociado2 = "Atiende Tel";
            insumos.indiceEvento2 = 6;
            telefono.tiempoConstanteAsociado = TimeSpan.FromMinutes(5);
            telefono.proximoEventoAsociado2 = reloj + telefono.tiempoConstanteAsociado;
            telefono.indiceEvento2 = 6;

            Random rnd = new Random();


            Double c_media = 5;
            Double c_desv = 1;
            evento = "Inicio";
            indiceEvento = 0;

            //Arranco SIM
            for (int i=0;i<20000;i++)
            {
                switch (indiceEvento)
                {
                    //Inicio
                    case 0:
                        {
                            c_proxLlegada = TimeSpan.FromMinutes(proxEventoNormal(c_media, c_desv, rnd));
                            insumos.inicioOcio = reloj;
                            insumos.ocioTotal = reloj;
                            presupuesto.inicioOcio = reloj;
                            presupuesto.ocioTotal = reloj;
                            servTecnico.inicioOcio = reloj;
                            servTecnico.ocioTotal = reloj;
                            break;
                        }

                    //Proxima llegada cliente
                    case 1:

                        //Calculo proxima llegada 
                        c_tiempoEntreLLeg = TimeSpan.FromMinutes(proxEventoNormal(c_media, c_desv, rnd));
                        c_proxLlegada = reloj + c_tiempoEntreLLeg;


                        //Derivo el cliente al servidor, segun corresponda el random atencion 'a_rand'
                        a_rand = rnd.NextDouble();
                        if (a_rand < 0.55)
                        {
                            atencion = presupuesto.nombre;
                            if (presupuesto.estado == "Libre" && presupuesto.cola.Equals(0))
                            {

                                if (presupuesto.inicioOcio != null)
                                {
                                    presupuesto.ocioTotal += reloj - presupuesto.inicioOcio;
                                    presupuesto.inicioOcio = null;
                                }
                                presupuesto.estado = "Ocupado";
                                presupuesto.tiempoAtencion = TimeSpan.FromMinutes(proxEventoNormal(presupuesto.media, presupuesto.desv, rnd));
                                presupuesto.finAtencion = reloj + presupuesto.tiempoAtencion;
                            }
                            else { presupuesto.cola++; }
                        }
                        else if (0.55 < a_rand && a_rand < 0.95)
                        {
                            atencion = insumos.nombre;
                            if (insumos.estado == "Libre" && insumos.cola.Equals(0))
                            {
                                if (insumos.inicioOcio != null)
                                {
                                    insumos.ocioTotal += reloj - insumos.inicioOcio;
                                    insumos.inicioOcio = null;
                                }
                                insumos.estado = "Ocupado";
                                insumos.tiempoAtencion = TimeSpan.FromMinutes(proxEventoNormal(insumos.media, insumos.desv, rnd));
                                insumos.finAtencion = reloj + insumos.tiempoAtencion;

                            }
                            else { insumos.cola++; }
                        }
                        else
                        {
                            atencion = servTecnico.nombre;
                            if (servTecnico.estado == "Libre" && servTecnico.cola.Equals(0))
                            {
                                if (servTecnico.inicioOcio != null)
                                {
                                    servTecnico.ocioTotal += reloj - servTecnico.inicioOcio;
                                    servTecnico.inicioOcio = null;
                                }
                                servTecnico.estado = "Ocupado";
                                servTecnico.tiempoAtencion = TimeSpan.FromMinutes(proxEventoNormal(servTecnico.media, servTecnico.desv, rnd));
                                servTecnico.finAtencion = reloj + servTecnico.tiempoAtencion;
                            }
                            else servTecnico.cola++;
                        }
                        break;
                    //Fin de atencion de servidor insumos
                    case 2:
                        atencion = null;
                        if (insumos.cola != 0)
                        {
                            if (insumos.inicioOcio != null)
                            {
                                insumos.ocioTotal = reloj - insumos.inicioOcio;
                                insumos.inicioOcio = null;
                            }
                            insumos.tiempoAtencion = TimeSpan.FromMinutes(proxEventoNormal(insumos.media, insumos.desv, rnd));
                            insumos.finAtencion = reloj + insumos.tiempoAtencion;
                            insumos.cola--;
                        }
                        else
                        {
                            insumos.tiempoAtencion = null;
                            insumos.finAtencion = null;
                            insumos.inicioOcio = reloj;
                            insumos.estado = "Libre";
                        }

                        break;

                    //Fin de atencion telefonica
                    case 3:
                        atencion = null;
                        if (insumos.cola != 0)
                        {
                            if (insumos.inicioOcio != null)
                            {
                                insumos.ocioTotal = reloj - insumos.inicioOcio;
                                insumos.inicioOcio = null;
                            }
                            insumos.tiempoAtencion = TimeSpan.FromMinutes(proxEventoNormal(insumos.media, insumos.desv, rnd));
                            insumos.finAtencion = reloj + insumos.tiempoAtencion;
                            insumos.cola--;
                        }
                        else
                        {
                            insumos.tiempoAtencion = null;
                            insumos.finAtencion = null;
                            insumos.inicioOcio = reloj;
                            insumos.estado = "Libre";
                        }
                        telefono.proximoEventoAsociado2 += telefono.tiempoConstanteAsociado;
                        telefono.finAtencion = null;
                        telefono.tiempoAtencion = null;
                        telefono.estado = "Libre";
                        break;

                    //Fin de atencion de servidor presupuesto
                    case 4:
                        atencion = null;
                        if (presupuesto.cola != 0)
                        {
                            if (presupuesto.inicioOcio != null)
                            {
                                presupuesto.ocioTotal = reloj - presupuesto.inicioOcio;
                                presupuesto.inicioOcio = null;
                            }
                            presupuesto.tiempoAtencion = TimeSpan.FromMinutes(proxEventoNormal(presupuesto.media, presupuesto.desv, rnd));
                            presupuesto.finAtencion = reloj + presupuesto.tiempoAtencion;
                            presupuesto.cola--;
                        }
                        else
                        {
                            presupuesto.tiempoAtencion = null;
                            presupuesto.finAtencion = null;
                            presupuesto.inicioOcio = reloj;
                            presupuesto.estado = "Libre";
                        }
                        break;

                    //Fin de atencion de servidor servicio tecnico
                    case 5:
                        atencion = null;
                        if (servTecnico.cola != 0)
                        {
                            if (servTecnico.inicioOcio != null)
                            {
                                servTecnico.ocioTotal = reloj - servTecnico.inicioOcio;
                                servTecnico.inicioOcio = null;
                            }
                            servTecnico.tiempoAtencion = TimeSpan.FromMinutes(proxEventoNormal(servTecnico.media, servTecnico.desv, rnd));
                            servTecnico.finAtencion = reloj + servTecnico.tiempoAtencion;
                            servTecnico.cola--;
                        }
                        else
                        {
                            servTecnico.tiempoAtencion = null;
                            servTecnico.finAtencion = null;
                            servTecnico.inicioOcio = reloj;
                            servTecnico.estado = "Libre";
                        }
                        break;
                    //Suena el telefono y el servidor de insumos esta libre
                    case 6:
                        atencion = null;
                        telefono.tiempoAtencion = TimeSpan.FromMinutes(proxEventoNormal(telefono.media, telefono.desv, rnd));
                        telefono.finAtencion = reloj + telefono.tiempoAtencion;
                        telefono.estado = "Ocupado";

                        if (insumos.estado == "Libre" && insumos.cola.Equals(0))
                        {
                            if (insumos.inicioOcio != null)
                            {
                                insumos.ocioTotal += reloj - insumos.inicioOcio;
                                insumos.inicioOcio = null;
                            }
                            insumos.estado = "Al Telefono";
                        }
                        break;
                }
                sw.Start();
                List<TimeSpan?> listaProximos = new List<TimeSpan?>();
                if(c_proxLlegada!=null) listaProximos.Add(c_proxLlegada);
                if (insumos.finAtencion != null) listaProximos.Add(insumos.finAtencion);
                if (telefono.proximoEventoAsociado2 != null) listaProximos.Add(telefono.proximoEventoAsociado2);
                if (telefono.finAtencion != null) listaProximos.Add(telefono.finAtencion);
                if (presupuesto.finAtencion != null) listaProximos.Add(presupuesto.finAtencion);
                if (servTecnico.finAtencion != null) listaProximos.Add(servTecnico.finAtencion);
                //listaProximos.RemoveAll(x => x == null);
                sw.Stop();

                List<Servidor> listServidores = new List<Servidor>();
                    listServidores.Add(insumos);
                    listServidores.Add(telefono);
                    listServidores.Add(presupuesto);
                    listServidores.Add(servTecnico);

                    //Agrego iteración a la grilla
                    gvSimulacion.Rows.Add(reloj, evento, c_tiempoEntreLLeg, c_proxLlegada, atencion,
                        insumos.estado, insumos.tiempoAtencion, insumos.finAtencion, insumos.inicioOcio, insumos.cola,
                        telefono.estado, telefono.tiempoAtencion, telefono.finAtencion,
                        presupuesto.estado, presupuesto.tiempoAtencion, presupuesto.finAtencion, presupuesto.inicioOcio, presupuesto.cola,
                        servTecnico.estado, servTecnico.tiempoAtencion, servTecnico.finAtencion, servTecnico.inicioOcio, servTecnico.cola);

                //Se actualiza el reloj con el horario del proximo evento
                reloj = TimeSpan.FromMinutes(proxEventoReloj(listaProximos));

                //Valido si el proximo evento es una llamada telefonica y si se puede atender, sino recalculo el reloj
                if (reloj.Equals(telefono.proximoEventoAsociado2) && insumos.estado!="Libre")
                {
                    listaProximos.Remove(telefono.proximoEventoAsociado2);
                    reloj = TimeSpan.FromMinutes(proxEventoReloj(listaProximos));
                }

                //Actualizo el próximo evento
                indiceEvento = proxIndiceEvento(reloj, c_proxLlegada, listServidores);
                evento = proxNombreEvento(indiceEvento, listServidores);

                //Actualizo la hora del proximo llamado
                telefono.proximoEventoAsociado2 = actualizarProximoLLamado(reloj,telefono);               
            }

            int i_colamax = gvSimulacion.Rows.Cast<DataGridViewRow>()
                        .Max(r => Convert.ToInt32(r.Cells["I_cola"].Value));
            int p_colamax = gvSimulacion.Rows.Cast<DataGridViewRow>()
            .Max(r => Convert.ToInt32(r.Cells["P_cola"].Value));
            int st_colamax = gvSimulacion.Rows.Cast<DataGridViewRow>()
            .Max(r => Convert.ToInt32(r.Cells["S_cola"].Value));

            //sw.Stop();
            Console.WriteLine("Elapsed={0}", sw.Elapsed);

            Console.WriteLine("Insumos: " + i_colamax + " " + insumos.ocioTotal);
            Console.WriteLine("Presupuestos: " + p_colamax + " " + presupuesto.ocioTotal);
            Console.WriteLine("S. Tecnico: " + st_colamax+ " " +servTecnico.ocioTotal);

        }

        public double proxEventoReloj(List<TimeSpan?> list)
        {
            double minimo = list.Where(x => x != null).Min(s => s.Value.TotalMinutes);
            return minimo;
        
        }

        public int proxIndiceEvento(TimeSpan? reloj, TimeSpan? llegadaCli, List<Servidor>listServ)
        {
            int proxEvento = 0;
            if (reloj.Equals(llegadaCli))
            {
                return proxEvento=1;
            }
            else
            {
                foreach (Servidor s in listServ)
                {
                    if (s.proximoEventoAsociado2 != null)
                    {
                        if (reloj.Equals(s.proximoEventoAsociado2)) return proxEvento = s.indiceEvento2;
                    }
                    if (s.finAtencion != null)
                    {
                        if (s.finAtencion.Equals(reloj))
                        {
                           return proxEvento = s.indiceEvento;
                        }
                    }

                }
            }
            return proxEvento;
        }

        String proxNombreEvento(int indice, List<Servidor> listServ)
        {
            String proxNombreEvento = "";
            if (indice.Equals(1)) return proxNombreEvento="Llegada Cliente";
            foreach (Servidor s in listServ)
            {
                if (s.indiceEvento2.Equals(indice)) return proxNombreEvento = s.eventoAsociado2;
                if (s.indiceEvento.Equals(indice)) return proxNombreEvento = s.eventoAsociado;
            }
            return proxNombreEvento;
        }

        Double proxEventoNormal(Double media, Double desv, Random rnd)
        {
            //Box-Muller
            Double x1= rnd.NextDouble();
            Double x2 = rnd.NextDouble();
            Double rnd2 = Math.Cos(2 * pi * x2) * Math.Sqrt(-2 * Math.Log(x1));

            Double random = media + desv * rnd2;
            return random;
        }

        TimeSpan? actualizarProximoLLamado(TimeSpan? r, Servidor t)
        {
            while (t.proximoEventoAsociado2 < reloj)
            {
                t.proximoEventoAsociado2 += t.tiempoConstanteAsociado;
            }
            return t.proximoEventoAsociado2;

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
