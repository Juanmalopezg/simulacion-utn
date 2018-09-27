using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio40
{
    public partial class Form1 : Form
    {
        //Inicio Columnas
        TimeSpan? reloj;
        String evento, atencion, i_estado, t_estado, p_esado, s_estado;
        //randoms
        long c_rand, a_rand, i_rand, t_rand, p_rand, s_rand;
        //tiempos atencion
        //long i_tiempoAt, t_tiempoAt, p_tiempoAt, s_tiempoAt;
        //long i_finAt, t_finAt, p_finAt, s_finAt;
        //tiempos ociocios
        long i_iocio, t_iocio, p_iocio, s_iocio;
        //colas
        int i_cola, p_cola, s_cola;
        //clientes
        long c_tiempoEntreLLeg, c_proxLlegada;

        public Form1()
        {
            InitializeComponent();
            iniciarSim();

        }

        void iniciarSim()
        {
            //creo los Servidores
            Servidor insumos = new Servidor("Insumos");
            Servidor presupuesto = new Servidor("Presupuesto");
            Servidor servTecnico = new Servidor("Servicio Tecnico");
            reloj = TimeSpan.Parse("00:00:00");
            i_cola = 0;
            p_cola = 0;
            s_cola = 0;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
