﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio40
{
    using MathNet.Numerics;


    public partial class Form1 : Form
    {
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
            //creo los Servidores(nombre,media,desviación,indice de evento asociado)
             Servidor insumos = new Servidor("Insumos",3,1,2);
            Servidor telefono = new Servidor("Telefono", 1,0.5,3);
            Servidor presupuesto = new Servidor("Presupuesto",7,2,4);
         Servidor servTecnico = new Servidor("Servicio Tecnico",3,1,5);
            Random rnd = new Random();


            Double c_media = 5;
            Double c_desv = 1;
            evento = "Inicio";
            indiceEvento = 0;

            //Arranco SIM
            for (int i=0;i<6;i++) {


                switch (indiceEvento)
                {
                    case 0:
                        {
                            c_proxLlegada = TimeSpan.FromMinutes(proxEventoNormal(c_media, c_desv, rnd));
                            
                            //gvSimulacion.Rows.Add(reloj, evento, null, c_proxLlegada, null,
                            //    insumos.estado, null, null, null, insumos.cola,
                            //    telefono.estado, null, null,
                            //    presupuesto.estado, null, null, null, presupuesto.cola,
                            //    servTecnico.estado, null, null, null, servTecnico.cola);
                            break;
                        }
  

                    case 1:

                        //Calculo proxima llegada 
                        c_tiempoEntreLLeg = TimeSpan.FromMinutes(proxEventoNormal(c_media, c_desv, rnd));
                        c_proxLlegada = reloj + c_tiempoEntreLLeg;


                        //Derivo el cliente al servidor, segun corresponda el random atencion 'a_rand'
                        a_rand = rnd.NextDouble();
                        if (a_rand < 0.55) {
                            atencion = presupuesto.nombre;
                            if (presupuesto.estado=="Libre" && presupuesto.cola.Equals(0))
                            {
                                presupuesto.estado = "Ocupado";
                                presupuesto.finAtencion = reloj + TimeSpan.FromMinutes(proxEventoNormal(presupuesto.media, presupuesto.desv, rnd));

                            }
                            else { presupuesto.cola++; }
                        }
                        else if(0.55< a_rand && a_rand < 0.95) {
                            atencion = insumos.nombre;
                            if (insumos.estado == "Libre" && insumos.cola.Equals(0))
                            {
                                insumos.estado = "Ocupado";
                                insumos.finAtencion = reloj + TimeSpan.FromMinutes(proxEventoNormal(insumos.media, insumos.desv, rnd));


                            }
                            else { insumos.cola++; }
                        }
                        else {
                            atencion = servTecnico.nombre;
                            if (servTecnico.estado == "Libre" && servTecnico.cola.Equals(0))
                            {
                                servTecnico.estado = "Ocupado";
                                servTecnico.finAtencion = reloj + TimeSpan.FromMinutes(proxEventoNormal(servTecnico.media, servTecnico.desv, rnd));
                            }
                            else servTecnico.cola++;
                        }
                            break;
                    case 2:
                        break;
                }
                List<TimeSpan?> listaProximos = new List<TimeSpan?>();
                    listaProximos.Add(c_proxLlegada);
                    listaProximos.Add(insumos.finAtencion);
                    listaProximos.Add(telefono.finAtencion);
                    listaProximos.Add(presupuesto.finAtencion);
                    listaProximos.Add(servTecnico.finAtencion);
                    listaProximos.RemoveAll(x => x == null);

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

                    //Actualizo el próximo evento
                    indiceEvento = proxIndiceEvento(reloj, c_proxLlegada, listServidores);
                    evento = proxNombreEvento(indiceEvento, listServidores);

                    //Actualizo atenciones
                    proximaAtencion(evento);
                
            }

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

        void proximaAtencion(String ev)
        {
            if(ev== "Llegada cliente")
            {

            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
