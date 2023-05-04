using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace control_services
{
    public partial class frm_testedata : Form
    {
        public frm_testedata()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            data_partida.MinDate = DateTime.Now;
            data_volta.MinDate = DateTime.Now;

            
            if(chkbx_FerPro.Checked == true)
            {
                chkbx_BateVolta.Enabled = false;
                chkbx_FimSem.Enabled = false;
            }

            else if (chkbx_BateVolta.Checked == true)
            {
                chkbx_FerPro.Enabled = false;
                chkbx_FimSem.Enabled = false;
            }

            else if (chkbx_FimSem.Checked == true)
            {
                chkbx_BateVolta.Enabled = false;
                chkbx_FerPro.Enabled = false;
            }

            else
            {
                chkbx_BateVolta.Enabled = true;
                chkbx_FerPro.Enabled = true;
                chkbx_FimSem.Enabled = true;
            }

            

            int quantDias, conta;

            string resultado;

            DateTime dataPartida = data_partida.Value;

            DateTime dataVolta = data_volta.Value;

            TimeSpan diferenca = dataVolta.Subtract(dataPartida);

            quantDias = diferenca.Days;

            conta = quantDias + 1;

            resultado = Convert.ToString(conta);

            lbl_quantosDias.Text = resultado;

            if (conta == 1)
            {
                chkbx_BateVolta.Checked = true;
                chkbx_FerPro.Enabled = false;
                chkbx_FimSem.Enabled = false;
            }

            else if (conta >= 2)
            {
                chkbx_BateVolta.Checked = false;
                chkbx_BateVolta.Enabled = false;
                chkbx_FerPro.Enabled = true;
                chkbx_FimSem.Enabled = true;

            }



            if (chkbx_FerPro.Checked == true)
            {
                chkbx_FimSem.Checked = false;
                chkbx_FimSem.Enabled = false;
                chkbx_BateVolta.Checked = false;
                chkbx_BateVolta.Enabled = false;
            }

            else if (chkbx_FerPro.Checked == false)
            {
                chkbx_FimSem.Checked = false;
                chkbx_FimSem.Enabled = true;
                chkbx_BateVolta.Checked = false;
                chkbx_BateVolta.Enabled = true;
            }


            //--------------------------------------------------------------------------------------------------------------
            /*      double km_ida, km_volta, km_total, valor_calc;
               lbl_totalKm.Text = "";
               lbl_ValorCalculo.Text = "";

               if (txtbx_kmIda.Text == "" && txtbx_kmVolta.Text == "")
               {
                   lbl_totalKm.Text = "";
               }

               else if (txtbx_kmVolta.Text == "")
               {
                   km_ida = Convert.ToDouble(txtbx_kmIda.Text);
                   km_total = km_ida * 2;
                   lbl_totalKm.Text = Convert.ToString(km_total);
               }

               else if (txtbx_kmIda.Text == "")
               {
                   km_volta = Convert.ToDouble(txtbx_kmVolta.Text);
                   km_total = km_volta * 2;
                   lbl_totalKm.Text = Convert.ToString(km_total);
               }

               else
               {
                   km_ida = Convert.ToDouble(txtbx_kmIda.Text);
                   km_volta = Convert.ToDouble(txtbx_kmVolta.Text);
                   km_total = km_ida + km_volta;
                   lbl_totalKm.Text = Convert.ToString(km_total);

               }

               if (cmbbx_PeriodoViagem.Text == "FIM DE SEMANA")
               {
                   km_total = Convert.ToInt16(lbl_totalKm.Text);

                   switch (cmbbx_CatVeiculo.Text)
                   {

                       case "DD 64L":
                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 60) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 40) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 30) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 27) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 22) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 16) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 14.5) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 12.5) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 12.5) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 10) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 9.5) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 401)
                           {
                               valor_calc = (km_total * 9) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }

                           break;

                       case "DD 60L":

                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 55) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 38) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 27) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 25) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 20) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 14) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 12.5) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 12) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 12) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 9.5) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 9) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 8.5) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }

                           break;


                       case "SEMI 46L":
                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 50) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 30) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 25) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 23) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 17) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 13) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 11) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 11.5) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 11.5) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 9) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 8.5) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 8) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }
                           break;

                       case "EXEC 50L":
                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 43) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 27) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 23) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 20) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 15) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 12.5) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 10.5) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 11) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 11) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 8.5) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 8) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 7.5) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }
                           break;

                       case "EXEC 46L":
                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 40) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 25) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 20) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 18) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 14) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 12) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 10) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 10) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 10) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 8) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 7.5) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 7) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }
                           break;

                       case "CONV 47L":
                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 35) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 22) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 18) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 15) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 12) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 11) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 9) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 9) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 9) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 7.5) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 7) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 6.5) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }
                           break;

                       case "MICRO 32L":

                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 30) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 20) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 14) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 12) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 10) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 9) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 8) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 8) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 7.5) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 6.5) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 6) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 5) + 500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }
                           break;

                       case "VAN 18L":
                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 18) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 15) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 10) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 8) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 7) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 6) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 5.5) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 5.5) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 5.5) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 5) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 4.8) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 4) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }

                           break;

                       case "VAN 15L":

                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 16) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 13) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 9) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 7) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 6) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 5) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 5) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 5) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 5) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 4.5) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 4.2) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 3.5) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           break;

                       case "CARRO":

                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 3);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 3);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 3);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 3);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 2.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 2.1);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 2);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 2);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 1.8);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 1.8);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 1.8);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           break;
                   }
               }

               else if (cmbbx_PeriodoViagem.Text == "FERIADO PROLONGADO")
               {
                   km_total = Convert.ToInt16(lbl_totalKm.Text);



                   switch (cmbbx_CatVeiculo.Text)
                   {

                       case "DD 64L":
                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 60) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 40) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 30) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 27) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 22) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 16) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 14.5) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 12.5) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 12.5) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 10) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 9.5) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 9) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }

                           break;

                       case "DD 60L":

                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 55) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 38) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 27) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 25) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 20) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 14) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 12.5) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 12) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 12) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 9.5) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 9) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 8.5) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }

                           break;


                       case "SEMI 46L":
                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 50) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 30) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 25) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 23) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 17) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 13) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 11) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 11.5) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 11.5) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 9) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 8.5) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 8) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }
                           break;

                       case "EXEC 50L":
                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 43) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 27) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 23) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 20) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 15) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 12.5) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 10.5) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 11) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 11) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 8.5) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 8) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 7.5) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }
                           break;

                       case "EXEC 46L":
                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 40) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 25) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 20) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 18) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 14) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 12) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 10) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 10) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 10) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 8) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 7.5) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 7) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }
                           break;

                       case "CONV 47L":
                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 35) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 22) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 18) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 15) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 12) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 11) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 9) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 9) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 9) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 7.5) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 7) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 6.5) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }
                           break;

                       case "MICRO 32L":

                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 30) + 1500;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 20) + 1600;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 14) + 1600;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 12) + 1600;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 10) + 1600;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 9) + 1600;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 8) + 1600;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 8) + 1600;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 7.5) + 1600;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 6.5) + 1600;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 6) + 1600;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 5) + 1600;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }
                           break;

                       case "VAN 18L":
                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 18) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 15) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 10) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 8) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 7) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 6) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 5.5) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 5.5) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 5.5) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 5) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 4.8) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 4) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }

                           break;

                       case "VAN 15L":

                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 16) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 13) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 9) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 7) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 6) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 5) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 5) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 5) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 5) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 4.5) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 4.2) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 3.5) + 1200;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           break;

                       case "CARRO":

                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 3);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 3);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 3);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 3);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 2.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 2.1);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 2);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 2);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 1.8);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 1.8);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 1.8);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           break;
                   }
               }

               else if (cmbbx_PeriodoViagem.Text == "BATE E VOLTA")
               {
                   km_total = Convert.ToInt16(lbl_totalKm.Text);

                   switch (cmbbx_CatVeiculo.Text)
                   {

                       case "DD 64L":
                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 60);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 40);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 30);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 27);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 22);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 16);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 14.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 12.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 12.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 10);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 9.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 9);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }

                           break;

                       case "DD 60L":

                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 55);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 38);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 27);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 25);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 20);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 14);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 12.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 12);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 12);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 9.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 9);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 8.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }

                           break;


                       case "SEMI 46L":
                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 50);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 30);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 25);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 23);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 17);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 13);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 11);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 11.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 11.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 9);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 8.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 8);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }
                           break;

                       case "EXEC 50L":
                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 43);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 27);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 23);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 20);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 15);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 12.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 10.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 11);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 11);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 8.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 8);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 7.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }
                           break;

                       case "EXEC 46L":
                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 40);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 25);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 20);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 18);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 14);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 12);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 10);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 10);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 10);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 8);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 7.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 7);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }
                           break;

                       case "CONV 47L":
                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 35);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 22);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 18);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 15);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 12);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 11);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 9);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 9);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 9);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 7.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 7);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 6.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }
                           break;

                       case "MICRO 32L":

                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 30);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 20);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 14);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 12);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 10);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 9);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 8);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 8);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 7.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 6.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 6);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }
                           break;

                       case "VAN 18L":
                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 18) + 900;
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 15);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 10);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 8);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 7);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 6);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 5.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 5.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 5.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 4.8);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 4);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else
                           {

                           }

                           break;

                       case "VAN 15L":

                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 16);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 13);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 9);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 7);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 6);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 4.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 4.2);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 3.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           break;

                       case "CARRO":

                           if (km_total <= 30)
                           {
                               valor_calc = (km_total * 5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 31 && km_total <= 50)
                           {
                               valor_calc = (km_total * 3);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 51 && km_total <= 75)
                           {
                               valor_calc = (km_total * 3);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 76 && km_total <= 100)
                           {
                               valor_calc = (km_total * 3);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 101 && km_total <= 125)
                           {
                               valor_calc = (km_total * 3);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 126 && km_total <= 150)
                           {
                               valor_calc = (km_total * 2.5);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 151 && km_total <= 175)
                           {
                               valor_calc = (km_total * 2.1);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 176 && km_total <= 200)
                           {
                               valor_calc = (km_total * 2);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 201 && km_total <= 250)
                           {
                               valor_calc = (km_total * 2);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 251 && km_total <= 300)
                           {
                               valor_calc = (km_total * 1.8);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 301 && km_total <= 400)
                           {
                               valor_calc = (km_total * 1.8);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           else if (km_total >= 400)
                           {
                               valor_calc = (km_total * 1.8);
                               lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                           }

                           break;
                   }
               }
           }


           }

           private void btn_calcular_Click(object sender, EventArgs e)
           {


           }

           private void data_volta_ValueChanged(object sender, EventArgs e)
           {

           }

           private void frm_testedata_Load(object sender, EventArgs e)
           {
               // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.orcamento'. Você pode movê-la ou removê-la conforme necessário.
               this.orcamentoTableAdapter.Fill(this.gldturfreDeployDataSet.orcamento);

           }

           private void orcamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
           {
               this.Validate();
               this.orcamentoBindingSource.EndEdit();
               this.tableAdapterManager.UpdateAll(this.gldturfreDeployDataSet);

           }
     */ }

        private void orcamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }
    }
}
