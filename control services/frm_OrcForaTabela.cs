using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace control_services
{
    public partial class frm_OrcForaTabela : Form
    {   
        public frm_OrcForaTabela()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
           double km_ida, km_volta, km_total, valor_calc;
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

        private void button7_Click(object sender, EventArgs e)
        {
            frm_consultDistancia consultDistancia = new frm_consultDistancia();
            consultDistancia.Show();
    
        }

        private void btn_SelecionarCliente_Click(object sender, EventArgs e)
        {
            this.cad_cliTableAdapter.FillByConsultaCpfCnpj(this.gldturfreDeployDataSet.cad_cli, msktxbx_CpfCnpj.Text);
            nome_razao_socialLabel2.Text = nome_razao_socialTextBox.Text;
            telefoneLabel2.Text = telefoneTextBox.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (grpbx_InfCliente.Enabled == false)
            {
                string dirSalvar;
                sfdSalvar.Title = "Salvar Documento";
                sfdSalvar.Filter = "TXT (.txt) | *.txt | PDF (.pdf) |*.pdf";

                if (sfdSalvar.ShowDialog() == DialogResult.OK)
                {
                    dirSalvar = sfdSalvar.FileName;
                    StreamWriter sr = new StreamWriter(dirSalvar);

                    sr.WriteLine("Segue seu orçamento baseado nos dados enviados:");
                    //sr.WriteLine("Numero do orcamento: " + id_orcamentoTextBox.Text);
                    sr.WriteLine("Data de ida: " + txtbx_DataPartida.Text);
                    sr.WriteLine("Horario: " + txtbx_HoraPartida.Text);
                    sr.WriteLine("Data de retorno: " + txtbx_DataRetorno.Text);
                    sr.WriteLine("Horario: " + txtbx_HoraRetorno.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Locais de embarque: " + txtbx_cidadePartida.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Local 1° embarque: " + txtbx_embarque1.Text);
                    sr.WriteLine("Horario 1° embarque: " + msktxbx_Embarque1.Text);
                    sr.WriteLine("Local 2° embarque: " + txtbx_embarque2.Text);
                    sr.WriteLine("Horario 2° embarque: " + msktxbx_Embarque2.Text);
                    sr.WriteLine("Local 3° embarque: " + txtbx_embarque3.Text);
                    sr.WriteLine("Horario 3° embarque: " + msktxbx_Embarque3.Text);
                    sr.WriteLine("Local 4° embarque: " + txtbx_embarque4.Text);
                    sr.WriteLine("Horario 4° embarque: " + msktxbx_Embarque4.Text);
                    sr.WriteLine("Local 5° embarque: " + txtbx_embarque5.Text);
                    sr.WriteLine("Horario 5° embarque: " + msktxbx_Embarque5.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Destino: " + txtbx_CidadeDestino.Text);
                    sr.WriteLine("");
                    sr.WriteLine("City Tour / Passeios: ");
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 1: " + textBox5.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 2: " + textBox4.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 3: " + textBox3.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 4: " + textBox2.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 5: " + textBox1.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Valor R$ " + txtbx_Fechamento.Text);
                    sr.WriteLine("");
                    sr.WriteLine("🚨 ATENÇÃO 🚨");
                    sr.WriteLine("Orçamento com validade de 30 dias sujeito a alteração caso haja mudança no valor do diesel ou outras despesas da viagem.");
                    sr.WriteLine("Pedido de orçamento não é válido como viagem fechada, reserva será efetivada somente após assinatura do contrato mediante a apresentação do comprovante de sinal de 10%.");
                    sr.WriteLine("");
                    sr.WriteLine("🚨 ATENÇÃO 🚨");
                    sr.WriteLine("");
                    sr.WriteLine("Em algumas cidades, principalmente no litoral, é necessário autorização de entrada, é por conta do contratante fazer o pedido e a retirada da autorização. Pedimos que antes de fechar o serviço conosco entre em contato com a prefeitura da cidade de destino da viagem para que se informe sobre o assunto. ");
                    sr.WriteLine("");
                    sr.WriteLine("Qualquer dúvida estou a disposição ☺");
                    sr.WriteLine("");
                    sr.WriteLine("");

                    sr.Close();

                }
            }


        }

        private void cad_clieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cad_clieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gldturfreDeployDataSet);

        }

        private void cad_clieBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cad_clieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gldturfreDeployDataSet);

        }

        private void frm_OrcForaTabela_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.cad_cli'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_cliTableAdapter.Fill(this.gldturfreDeployDataSet.cad_cli);
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.orcamento'. Você pode movê-la ou removê-la conforme necessário.
            this.orcamentoTableAdapter.Fill(this.gldturfreDeployDataSet.orcamento);
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.cad_clie'. Você pode movê-la ou removê-la conforme necessário.

            if (grpbx_InfCliente.Enabled == false)
            {
                nome_razao_socialLabel2.Text = "";
                telefoneLabel2.Text = "";
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chkbx_UsarValorCalculo.Checked == true)
            {
                txtbx_Fechamento.Text = lbl_ValorCalculo.Text;
            }

            if (cmbbx_mask_CpfCnpj.Text == "CPF")
            {
                msktxbx_CpfCnpj.Mask = "999.999.999-99";
            }

            else if (cmbbx_mask_CpfCnpj.Text == "CNPJ")
            {
                msktxbx_CpfCnpj.Mask = "99.999.999/9999-99";
            }

            if (chkbx_NotaFiscal.Checked == true)
            {
                if (chkbx_UsarValorCalculo.Checked == true)
                {
                    if (lbl_ValorCalculo.Text != "")
                    {
                        int valor, conta;
                        string resultado;


                        valor = Convert.ToInt32(lbl_ValorCalculo.Text);
                        conta = valor + (valor * (10 / 100));
                        resultado = Convert.ToString(conta);

                        txtbx_Fechamento.Text = resultado;
                    }
                }

                else
                {
                    int valor, conta;
                    string resultado;


                    valor = Convert.ToInt32(txtbx_Fechamento.Text);
                    conta = valor + (valor * (10 / 100));
                    resultado = Convert.ToString(conta);

                    txtbx_Fechamento.Text = resultado;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (msktxbx_CpfCnpj.Enabled == true)
            {
                MessageBox.Show("Para adicionar um novo registro, é necessario finalizar o atual", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                grpbx_InfCliente.Enabled = true;
                txtbx_idOrcString.Text = id_orcamentoTextBox.Text;
            }
        }

        private void grpbx_InfCliente_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_consultCli consultCli = new frm_consultCli();
            consultCli.Show();

        }

        private void txtbx_DataRetorno_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (grpbx_InfCliente.Enabled == true)
            {
                if (MessageBox.Show("Deseja realmente sair?\nRegistro não salvos serão perdidos", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    this.Close();
                }
            }

            else
            {
                this.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (msktxbx_CpfCnpj.Text == "" || label4.Text == "")
            {
                MessageBox.Show("Não é possivel salvar um orcamento sem um cliente vinculado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                string dirSalvar;
                sfdSalvar.Title = "Salvar Documento";
                sfdSalvar.Filter = "TXT (.txt) | *.txt | HTML (.html) |*.html";
                sfdSalvar.FilterIndex = 2;
                sfdSalvar.RestoreDirectory = true;

                MessageBox.Show("Orcamento salvo com sucesso!", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sfdSalvar.Title = "Salvar Documento";
                sfdSalvar.Filter = "TXT (.txt) | *.txt | HTML (.html) |*.html";

                if (sfdSalvar.ShowDialog() == DialogResult.OK)
                {
                    dirSalvar = sfdSalvar.FileName;
                    StreamWriter sr = new StreamWriter(dirSalvar);

                    sr.WriteLine("Segue seu orçamento baseado nos dados enviados:");
                    sr.WriteLine("Numero do orcamento: " + id_orcamentoTextBox.Text);
                    sr.WriteLine("Data de ida: " + txtbx_DataPartida.Text);
                    sr.WriteLine("Horario: " + txtbx_HoraPartida.Text);
                    sr.WriteLine("Data de retorno: " + txtbx_DataRetorno.Text);
                    sr.WriteLine("Horario: " + txtbx_HoraRetorno.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Locais de embarque: " + txtbx_cidadePartida.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Local 1° embarque: " + txtbx_embarque1.Text);
                    sr.WriteLine("Horario 1° embarque: " + msktxbx_Embarque1.Text);
                    sr.WriteLine("Local 2° embarque: " + txtbx_embarque2.Text);
                    sr.WriteLine("Horario 2° embarque: " + msktxbx_Embarque2.Text);
                    sr.WriteLine("Local 3° embarque: " + txtbx_embarque3.Text);
                    sr.WriteLine("Horario 3° embarque: " + msktxbx_Embarque3.Text);
                    sr.WriteLine("Local 4° embarque: " + txtbx_embarque4.Text);
                    sr.WriteLine("Horario 4° embarque: " + msktxbx_Embarque4.Text);
                    sr.WriteLine("Local 5° embarque: " + txtbx_embarque5.Text);
                    sr.WriteLine("Horario 5° embarque: " + msktxbx_Embarque5.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Destino: " + txtbx_CidadeDestino.Text);
                    sr.WriteLine("");
                    sr.WriteLine("City Tour / Passeios: ");
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 1: " + textBox5.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 2: " + textBox4.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 3: " + textBox3.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 4: " + textBox2.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 5: " + textBox1.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Valor R$ " + txtbx_Fechamento.Text);
                    sr.WriteLine("");
                    sr.WriteLine("🚨 ATENÇÃO 🚨");
                    sr.WriteLine("Orçamento com validade de 30 dias sujeito a alteração caso haja mudança no valor do diesel ou outras despesas da viagem.");
                    sr.WriteLine("Pedido de orçamento não é válido como viagem fechada, reserva será efetivada somente após assinatura do contrato mediante a apresentação do comprovante de sinal de 10%.");
                    sr.WriteLine("");
                    sr.WriteLine("🚨 ATENÇÃO 🚨");
                    sr.WriteLine("");
                    sr.WriteLine("Em algumas cidades, principalmente no litoral, é necessário autorização de entrada, é por conta do contratante fazer o pedido e a retirada da autorização. Pedimos que antes de fechar o serviço conosco entre em contato com a prefeitura da cidade de destino da viagem para que se informe sobre o assunto. ");
                    sr.WriteLine("");
                    sr.WriteLine("Qualquer dúvida estou a disposição ☺");
                    sr.WriteLine("");
                    sr.WriteLine("");

                    sr.Close();

                }
                grpbx_InfCliente.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_cadCli cadCli = new frm_cadCli();
            cadCli.ShowDialog();
        }

        private void chkbx_UsarValorCalculo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sfdSalvar_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void lbl_totalKm_Click(object sender, EventArgs e)
        {

        }
    }
}