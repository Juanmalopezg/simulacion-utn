using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using MetroFramework;


namespace Ejercicio40
{

    public partial class Sim : MetroFramework.Forms.MetroForm
    {
        //Para testear
        Stopwatch sw = new Stopwatch();

        //Declaro variables globales auxiliares
        public TimeSpan? reloj; 
        public String evento, atencion;
        public int indiceEvento;
        Double pi = Math.PI;
        bool isChecked = true;
        TimeSpan? c_tiempoEntreLLeg, c_proxLlegada;
        int validador;

        //Random de atención prara ver a donde va a ser derivado el cliente
        Double a_rand;


        public Sim()
        {
            InitializeComponent();
        }
        
        private void btn_simular_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                iniciarSim();
            }
            
        }
        private void rbDefault_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rbDefault.Checked;

            //Habilito/desabilito parámetros
            txDc.Enabled = !isChecked;
            txDi.Enabled = !isChecked;
            txDp.Enabled = !isChecked;
            txDs.Enabled = !isChecked;
            txMc.Enabled = !isChecked;
            txMi.Enabled = !isChecked;
            txMp.Enabled = !isChecked;
            txMs.Enabled = !isChecked;
            txL.Enabled = !isChecked;
        }
        private void rbDefault_Click(object sender, EventArgs e)
        {
            if (rbDefault.Checked && !isChecked)
                rbDefault.Checked = false;
            else
            {
                rbDefault.Checked = true;
                isChecked = false;
               
            }
        }
        private void txMinutosSim_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txMinutosSim.Text))
            {
                e.Cancel = true;
                txMinutosSim.Focus();
                errorProvider.SetError(txMinutosSim, "Ingrese cantidad de minutos a simular.");
                return;
            }
            if(!int.TryParse(txMinutosSim.Text, out validador))
            {
                e.Cancel = true;
                txMinutosSim.Focus();
                errorProvider.SetError(txMinutosSim, "Ingrese un valor numerico entero para la cantidad expresada en minutos.");
                return;

            }
            if (validador<=0||validador>87600)
            {
                e.Cancel = true;
                txMinutosSim.Focus();
                errorProvider.SetError(txMinutosSim, "Ingrese una cantidad menor a 87600 minutos (simulación equivalente a 2 meses completos sin parar).");
                return;

            }
             else
            {
                e.Cancel = false;
                errorProvider.SetError(txMinutosSim,null);
            }
        }

        #region Validadores de parámetros
        private void txMc_Validating(object sender, CancelEventArgs e)
        {
            if (!isChecked)
             {
                if (!string.IsNullOrWhiteSpace(txMc.Text))
                {
                    if(!int.TryParse(txMc.Text,out validador))
                    {
                        e.Cancel = true;
                        txMc.Focus();
                        errorProvider.SetError(txMc, "Ingrese un valor numerico para la cantidad expresada en minutos.");
                        return;
                    }
                    if (validador <= 0)
                    {
                        e.Cancel = true;
                        txMc.Focus();
                        errorProvider.SetError(txMc, "Ingrese una cantidad positiva expresada en minutos, o vacío para usar valor original.");
                        return;
                    }
                }

            }

            e.Cancel = false;
            errorProvider.SetError(txMc, null);
            
  
        }
        private void txMi_Validating(object sender, CancelEventArgs e)
        {
            if (!isChecked)
            {
                if (!string.IsNullOrWhiteSpace(txMi.Text))
                {
                    if (!int.TryParse(txMi.Text, out validador))
                    {
                        e.Cancel = true;
                        txMi.Focus();
                        errorProvider.SetError(txMi, "Ingrese un valor numerico para la cantidad expresada en minutos.");
                        return;
                    }
                    if (validador <= 0)
                    {
                        e.Cancel = true;
                        txMi.Focus();
                        errorProvider.SetError(txMi, "Ingrese una cantidad positiva expresada en minutos, o vacío para usar valor original.");
                        return;
                    }
                }

            }

            e.Cancel = false;
            errorProvider.SetError(txMi, null);


        }
        private void txMp_Validating(object sender, CancelEventArgs e)
        {
            if (!isChecked)
            {
                if (!string.IsNullOrWhiteSpace(txMp.Text))
                {
                    if (!int.TryParse(txMp.Text, out validador))
                    {
                        e.Cancel = true;
                        txMp.Focus();
                        errorProvider.SetError(txMp, "Ingrese un valor numerico para la cantidad expresada en minutos.");
                        return;
                    }
                    if (validador <= 0)
                    {
                        e.Cancel = true;
                        txMp.Focus();
                        errorProvider.SetError(txMp, "Ingrese una cantidad positiva expresada en minutos, o vacío para usar valor original.");
                        return;
                    }
                }

            }

            e.Cancel = false;
            errorProvider.SetError(txMp, null);


        }
        private void txMs_Validating(object sender, CancelEventArgs e)
        {
            if (!isChecked)
            {
                if (!string.IsNullOrWhiteSpace(txMs.Text))
                {
                    if (!int.TryParse(txMs.Text, out validador))
                    {
                        e.Cancel = true;
                        txMs.Focus();
                        errorProvider.SetError(txMs, "Ingrese un valor numerico para la cantidad expresada en minutos.");
                        return;
                    }
                    if (validador <= 0)
                    {
                        e.Cancel = true;
                        txMs.Focus();
                        errorProvider.SetError(txMs, "Ingrese una cantidad positiva expresada en minutos, o vacío para usar valor original.");
                        return;
                    }
                }

            }

            e.Cancel = false;
            errorProvider.SetError(txMs, null);


        }
        private void txDc_Validating(object sender, CancelEventArgs e)
        {
            if (!isChecked)
            {
                if (!string.IsNullOrWhiteSpace(txDc.Text))
                {
                    if (!int.TryParse(txDc.Text, out validador))
                    {
                        e.Cancel = true;
                        txDc.Focus();
                        errorProvider.SetError(txDc, "Ingrese un valor numerico para la cantidad expresada en minutos.");
                        return;
                    }
                    if (validador < 0)
                    {
                        e.Cancel = true;
                        txDc.Focus();
                        errorProvider.SetError(txDc, "Ingrese una cantidad positiva expresada en minutos, o vacío para usar valor original.");
                        return;
                    }
                }

            }

            e.Cancel = false;
            errorProvider.SetError(txDc, null);


        }
        private void txDi_Validating(object sender, CancelEventArgs e)
        {
            if (!isChecked)
            {
                if (!string.IsNullOrWhiteSpace(txDi.Text))
                {
                    if (!int.TryParse(txDi.Text, out validador))
                    {
                        e.Cancel = true;
                        txDi.Focus();
                        errorProvider.SetError(txDi, "Ingrese un valor numerico para la cantidad expresada en minutos.");
                        return;
                    }
                    if (validador < 0)
                    {
                        e.Cancel = true;
                        txDi.Focus();
                        errorProvider.SetError(txDi, "Ingrese una cantidad positiva expresada en minutos, o vacío para usar valor original.");
                        return;
                    }
                }

            }

            e.Cancel = false;
            errorProvider.SetError(txDi, null);


        }
        private void txDp_Validating(object sender, CancelEventArgs e)
        {
            if (!isChecked)
            {
                if (!string.IsNullOrWhiteSpace(txDp.Text))
                {
                    if (!int.TryParse(txDp.Text, out validador))
                    {
                        e.Cancel = true;
                        txDp.Focus();
                        errorProvider.SetError(txDp, "Ingrese un valor numerico para la cantidad expresada en minutos.");
                        return;
                    }
                    if (validador < 0)
                    {
                        e.Cancel = true;
                        txDp.Focus();
                        errorProvider.SetError(txDp, "Ingrese una cantidad positiva expresada en minutos, o vacío para usar valor original.");
                        return;
                    }
                }

            }

            e.Cancel = false;
            errorProvider.SetError(txDp, null);


        }
        private void txDs_Validating(object sender, CancelEventArgs e)
        {
            if (!isChecked)
            {
                if (!string.IsNullOrWhiteSpace(txDs.Text))
                {
                    if (!int.TryParse(txDs.Text, out validador))
                    {
                        e.Cancel = true;
                        txDs.Focus();
                        errorProvider.SetError(txDs, "Ingrese un valor numerico para la cantidad expresada en minutos.");
                        return;
                    }
                    if (validador < 0)
                    {
                        e.Cancel = true;
                        txDs.Focus();
                        errorProvider.SetError(txDs, "Ingrese una cantidad positiva expresada en minutos, o vacío para usar valor original.");
                        return;
                    }
                }

            }

            e.Cancel = false;
            errorProvider.SetError(txDs, null);


        }
        private void txMl_Validating(object sender, CancelEventArgs e)
        {
            if (!isChecked)
            {
                if (!string.IsNullOrWhiteSpace(txMl.Text))
                {
                    if (!int.TryParse(txMl.Text, out validador))
                    {
                        e.Cancel = true;
                        txMl.Focus();
                        errorProvider.SetError(txMl, "Ingrese un valor numerico para la cantidad expresada en minutos.");
                        return;
                    }
                    if (validador <= 0)
                    {
                        e.Cancel = true;
                        txMl.Focus();
                        errorProvider.SetError(txMl, "Ingrese una cantidad positiva expresada en minutos, o vacío para usar valor original.");
                        return;
                    }
                }

            }

            e.Cancel = false;
            errorProvider.SetError(txMl, null);


        }
        private void txDl_Validating(object sender, CancelEventArgs e)
        {
            if (!isChecked)
            {
                if (!string.IsNullOrWhiteSpace(txDl.Text))
                {
                    if (!int.TryParse(txDl.Text, out validador))
                    {
                        e.Cancel = true;
                        txDl.Focus();
                        errorProvider.SetError(txDl, "Ingrese un valor numerico para la cantidad expresada en minutos.");
                        return;
                    }
                    if (validador < 0)
                    {
                        e.Cancel = true;
                        txDl.Focus();
                        errorProvider.SetError(txDl, "Ingrese una cantidad positiva expresada en minutos, o vacío para usar valor original.");
                        return;
                    }
                }

            }

            e.Cancel = false;
            errorProvider.SetError(txDl, null);


        }
        private void txL_Validating(object sender, CancelEventArgs e)
        {
            if (!isChecked)
            {
                if (!string.IsNullOrWhiteSpace(txL.Text))
                {
                    if (!int.TryParse(txL.Text, out validador))
                    {
                        e.Cancel = true;
                        txL.Focus();
                        errorProvider.SetError(txL, "Ingrese un valor numerico para la cantidad expresada en minutos.");
                        return;
                    }
                    if (validador <= 0)
                    {
                        e.Cancel = true;
                        txL.Focus();
                        errorProvider.SetError(txL, "Ingrese una cantidad positiva expresada en minutos, o vacío para usar valor original.");
                        return;
                    }
                }

            }

            e.Cancel = false;
            errorProvider.SetError(txL, null);


        }
        #endregion


        public void iniciarSim()
        {
            //Incia test
            sw.Start();

            int iteraciones = int.Parse(txMinutosSim.Text);
            reloj = TimeSpan.Parse("00:00:00");

            //Limpio grilla y doy colores de columna
            gvSimulacion.Rows.Clear();
            gvSimulacion.Columns[5].DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            gvSimulacion.Columns[6].DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            gvSimulacion.Columns[7].DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            gvSimulacion.Columns[8].DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            gvSimulacion.Columns[9].DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            gvSimulacion.Columns[10].DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            gvSimulacion.Columns[14].DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            gvSimulacion.Columns[15].DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            gvSimulacion.Columns[16].DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            gvSimulacion.Columns[17].DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            gvSimulacion.Columns[18].DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));

            //Creo los Servidores(nombre,media,desviación,indice de evento asociado,personal libre)
            Servidor insumos = new Servidor("Insumos",3,1,2,1);
            Servidor telefono = new Servidor("Telefono", 1,0.5,3,0);
            Servidor presupuesto = new Servidor("Presupuesto",7,2,4,0);
            Servidor servTecnico = new Servidor("Servicio Tecnico",3,1,5,2);

            //Auxiliares de simulación
            Random rnd = new Random();
            Double c_media = 5;
            Double c_desv = 1;
            TimeSpan? servTecnico2_atencion = null;
            insumos.eventoAsociado2 = "Atiende Tel";
            insumos.indiceEvento2 = 6;
            telefono.tiempoConstanteAsociado = TimeSpan.FromMinutes(5);
            telefono.proximoEventoAsociado2 = reloj + telefono.tiempoConstanteAsociado;
            telefono.indiceEvento2 = 6;
            servTecnico.indiceEvento2 = servTecnico.indiceEvento;
            servTecnico.eventoAsociado2 = "Fin Atencion "+servTecnico.nombre;
            evento = "Inicio";
            indiceEvento = 0;

            //Arranco SIM
            while (reloj.Value.TotalMinutes<iteraciones)
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
                            if (presupuesto.estado == "Libre")
                            {
                                //Atiendo presupuesto solo si tengo personal disponible
                                if (servTecnico.personalLibre > 0)
                                {
                                    if (presupuesto.inicioOcio != null)
                                    {
                                        presupuesto.ocioTotal += reloj - presupuesto.inicioOcio;
                                        presupuesto.inicioOcio = null;
                                    }
                                    presupuesto.estado = "Ocupado";
                                    presupuesto.tiempoAtencion = TimeSpan.FromMinutes(proxEventoNormal(presupuesto.media, presupuesto.desv, rnd));
                                    presupuesto.finAtencion = reloj + presupuesto.tiempoAtencion;
                                    servTecnico.personalLibre--;
                                }
                                else
                                {
                                    if (insumos.personalLibre > 0)
                                    {
                                        if (presupuesto.inicioOcio != null)
                                        {
                                            presupuesto.ocioTotal += reloj - presupuesto.inicioOcio;
                                            presupuesto.inicioOcio = null;
                                        }
                                        presupuesto.estado = "Ocupado";
                                        presupuesto.tiempoAtencion = TimeSpan.FromMinutes(proxEventoNormal(presupuesto.media, presupuesto.desv, rnd));
                                        presupuesto.finAtencion = reloj + presupuesto.tiempoAtencion;
                                        servTecnico.personalLibre--;
                                    }
                                    else presupuesto.cola++;
                                }

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
                                insumos.personalLibre--;

                            }
                            else { insumos.cola++; }
                        }
                        else
                        {
                            atencion = servTecnico.nombre;
                            if (servTecnico.estado == "Libre")
                            {
                                if (servTecnico.inicioOcio != null)
                                {
                                    servTecnico.ocioTotal += reloj - servTecnico.inicioOcio;
                                    servTecnico.inicioOcio = null;
                                }

                                //Asigno la atencion a alguno de los técnicos disponibles
                                switch (servTecnico.personalLibre)
                                {
                                    case 2:
                                            servTecnico.estado = "Ocupado";
                                            servTecnico.tiempoAtencion = TimeSpan.FromMinutes(proxEventoNormal(servTecnico.media, servTecnico.desv, rnd));
                                            servTecnico.finAtencion = reloj + servTecnico.tiempoAtencion;
                                        servTecnico.personalLibre--;
                                        
                                        break;
                                    case 1:
                                        servTecnico.estado = "Ocupado";
                                        servTecnico2_atencion = TimeSpan.FromMinutes(proxEventoNormal(servTecnico.media, servTecnico.desv, rnd));
                                        servTecnico.proximoEventoAsociado2 = reloj + servTecnico2_atencion;
                                        servTecnico.personalLibre--;
                                        break;
                                }

                            }
                            else {
                                if (servTecnico.personalLibre.Equals(1))
                                {
                                    servTecnico.estado = "Ocupado";
                                    servTecnico2_atencion = TimeSpan.FromMinutes(proxEventoNormal(servTecnico.media, servTecnico.desv, rnd));
                                    servTecnico.proximoEventoAsociado2 = reloj + servTecnico2_atencion;
                                    servTecnico.personalLibre--;
                                }
                                else servTecnico.cola++;
                            } 
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
                            insumos.personalLibre++;
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
                            //Atiendo prox cliente de la cola
                            insumos.tiempoAtencion = TimeSpan.FromMinutes(proxEventoNormal(insumos.media, insumos.desv, rnd));
                            insumos.finAtencion = reloj + insumos.tiempoAtencion;
                            insumos.estado = "Ocupado";
                            insumos.cola--;
                        }
                        else
                        {
                            insumos.tiempoAtencion = null;
                            insumos.finAtencion = null;
                            insumos.inicioOcio = reloj;
                            insumos.estado = "Libre";
                            insumos.personalLibre++;
                        }
                        telefono.proximoEventoAsociado2 += telefono.tiempoConstanteAsociado;
                        telefono.finAtencion = null;
                        telefono.tiempoAtencion = null;
                        telefono.estado = "Libre";
                        break;

                    //Fin de atencion de servidor presupuesto
                    case 4:
                        atencion = null;

                        if (insumos.estado == "Libre" && insumos.personalLibre.Equals(0))
                        {
                            insumos.personalLibre++;
                        }
                        else servTecnico.personalLibre++;

                        if (presupuesto.cola != 0)
                        {
                            //Atiendo presupuesto solo si tengo personal disponible
                            if (servTecnico.personalLibre > 0)
                            {
                                if (presupuesto.inicioOcio != null)
                                {
                                    presupuesto.ocioTotal += reloj - presupuesto.inicioOcio;
                                    presupuesto.inicioOcio = null;
                                }
                                presupuesto.estado = "Ocupado";
                                presupuesto.tiempoAtencion = TimeSpan.FromMinutes(proxEventoNormal(presupuesto.media, presupuesto.desv, rnd));
                                presupuesto.finAtencion = reloj + presupuesto.tiempoAtencion;
                                servTecnico.personalLibre--;
                                presupuesto.cola--;
                            }
                            else
                            {
                                if (insumos.personalLibre > 0)
                                {
                                    if (presupuesto.inicioOcio != null)
                                    {
                                        presupuesto.ocioTotal += reloj - presupuesto.inicioOcio;
                                        presupuesto.inicioOcio = null;
                                    }
                                    presupuesto.estado = "Ocupado";
                                    presupuesto.tiempoAtencion = TimeSpan.FromMinutes(proxEventoNormal(presupuesto.media, presupuesto.desv, rnd));
                                    presupuesto.finAtencion = reloj + presupuesto.tiempoAtencion;
                                    servTecnico.personalLibre--;
                                    presupuesto.cola--;
                                }
                            }
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
                                servTecnico.tiempoAtencion = TimeSpan.FromMinutes(proxEventoNormal(servTecnico.media, servTecnico.desv, rnd));
                                servTecnico.finAtencion = reloj + servTecnico.tiempoAtencion;
                            }
                            else
                            {
                                servTecnico2_atencion = TimeSpan.FromMinutes(proxEventoNormal(servTecnico.media, servTecnico.desv, rnd));
                                servTecnico.proximoEventoAsociado2 = reloj + servTecnico2_atencion;
                            }
                            

                            servTecnico.cola--;
                        }
                        else
                        {
                            servTecnico.tiempoAtencion = null;
                            servTecnico.finAtencion = null;
                            servTecnico2_atencion = null;
                            servTecnico.proximoEventoAsociado2 = null;
                            servTecnico.inicioOcio = reloj;
                            servTecnico.estado = "Libre";
                            servTecnico.personalLibre++;
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
                            insumos.personalLibre--;
                        }
                        break;
                }
                
                List<TimeSpan?> listaProximos = new List<TimeSpan?>();
                if(c_proxLlegada!=null) listaProximos.Add(c_proxLlegada);
                if (insumos.finAtencion != null) listaProximos.Add(insumos.finAtencion);
                if (telefono.proximoEventoAsociado2 != null) listaProximos.Add(telefono.proximoEventoAsociado2);
                if (telefono.finAtencion != null) listaProximos.Add(telefono.finAtencion);
                if (presupuesto.finAtencion != null) listaProximos.Add(presupuesto.finAtencion);
                if (servTecnico.finAtencion != null) listaProximos.Add(servTecnico.finAtencion);
                if (servTecnico.proximoEventoAsociado2 != null) listaProximos.Add(servTecnico.proximoEventoAsociado2);
                
                List<Servidor> listServidores = new List<Servidor>();
                    listServidores.Add(insumos);
                    listServidores.Add(telefono);
                    listServidores.Add(presupuesto);
                    listServidores.Add(servTecnico);

                    //Agrego iteración a la grilla
                    gvSimulacion.Rows.Add(reloj, evento, c_tiempoEntreLLeg, c_proxLlegada, atencion,
                        insumos.estado, insumos.tiempoAtencion, insumos.finAtencion,insumos.personalLibre, insumos.inicioOcio, insumos.cola,
                        telefono.estado, telefono.tiempoAtencion, telefono.finAtencion,
                        presupuesto.estado, presupuesto.tiempoAtencion, presupuesto.finAtencion, presupuesto.inicioOcio, presupuesto.cola,
                        servTecnico.estado, servTecnico.tiempoAtencion, servTecnico.finAtencion,servTecnico2_atencion,servTecnico.proximoEventoAsociado2,servTecnico.personalLibre, servTecnico.inicioOcio, servTecnico.cola);

                //Se actualiza el reloj con el horario del proximo evento
                reloj = TimeSpan.FromMinutes(proxEventoReloj(listaProximos));

                //Valido si el proximo evento es una llamada telefonica y si se puede atender, sino recalculo el reloj
                if (reloj.Equals(telefono.proximoEventoAsociado2) && insumos.personalLibre.Equals(0))
                {
                    listaProximos.Remove(telefono.proximoEventoAsociado2);
                    reloj = TimeSpan.FromMinutes(proxEventoReloj(listaProximos));
                }

                //Actualizo el próximo evento
                indiceEvento = proxIndiceEvento(reloj, c_proxLlegada, listServidores);
                evento = proxNombreEvento(indiceEvento, listServidores);

                //Actualizo la hora del proximo llamado
                telefono.proximoEventoAsociado2 = actualizarProximoLLamado(reloj,telefono);

                //if (i.Equals(iteraciones-1))
                if(reloj.Value.TotalMinutes>=iteraciones)
                {
                    foreach(Servidor s in listServidores)
                    {
                        if (s.inicioOcio != null)
                        {
                            s.ocioTotal += reloj - s.inicioOcio;
                        }
                    }
                    
                }             
            }

            int i_colamax = gvSimulacion.Rows.Cast<DataGridViewRow>()
                        .Max(r => Convert.ToInt32(r.Cells["I_cola"].Value));
            int p_colamax = gvSimulacion.Rows.Cast<DataGridViewRow>()
            .Max(r => Convert.ToInt32(r.Cells["P_cola"].Value));
            int st_colamax = gvSimulacion.Rows.Cast<DataGridViewRow>()
            .Max(r => Convert.ToInt32(r.Cells["S_cola"].Value));

            //Graficos
            graficar(reloj, insumos.ocioTotal, presupuesto.ocioTotal, servTecnico.ocioTotal);

            //Muestro colas máximas
            mostrarColasMaximas(i_colamax, p_colamax, st_colamax);
            
            sw.Stop();
            Console.WriteLine("Elapsed={0}", sw.Elapsed);


        }

        void graficar(TimeSpan? r, TimeSpan? ins, TimeSpan? pr, TimeSpan? sv)
        {
            grTI.Series.Clear();
            grTP.Series.Clear();
            grTS.Series.Clear();

            grTI.Series.Add("Insumos");
            grTP.Series.Add("Presupuesto");
            grTS.Series.Add("Servicio tecnico");
            grTI.Series["Insumos"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            grTP.Series["Presupuesto"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            grTS.Series["Servicio tecnico"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;


            grTI.Series["Insumos"].Points.AddXY("Atención", reloj.Value.TotalMinutes- ins.Value.TotalMinutes);
            grTI.Series["Insumos"].Points.AddXY("Ocio", ins.Value.TotalMinutes);
            grTI.Series["Insumos"].Label = "#VALX #PERCENT{P0}";
            grTI.Series["Insumos"].LabelForeColor = Color.White;

            grTP.Series["Presupuesto"].Points.AddXY("Atención", reloj.Value.TotalMinutes - pr.Value.TotalMinutes);
            grTP.Series["Presupuesto"].Points.AddXY("Ocio", pr.Value.TotalMinutes);
            grTP.Series["Presupuesto"].Label = "#VALX #PERCENT{P0}";
            grTP.Series["Presupuesto"].LabelForeColor = Color.White;


            grTS.Series["Servicio tecnico"].Points.AddXY("Atención", reloj.Value.TotalMinutes - sv.Value.TotalMinutes);
            grTS.Series["Servicio tecnico"].Points.AddXY("Ocio", sv.Value.TotalMinutes);
            grTS.Series["Servicio tecnico"].Label = "#VALX #PERCENT{P0}";
            grTS.Series["Servicio tecnico"].LabelForeColor = Color.White;

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

        void mostrarColasMaximas(int i, int p, int s)
        {
            lbcM1.Visible = true;
            lbcM2.Visible = true;
            lbcM3.Visible = true;
            lbColaMI.Visible = true;
            lbColaMP.Visible = true;
            lbColaMS.Visible = true;
            lbColaMI.ForeColor= Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));

            lbColaMI.Text = i.ToString();
            lbColaMP.Text = p.ToString();
            lbColaMS.Text = s.ToString();
            
        }

    }
}
