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
    public partial class frm_consultaValor : Form
    {
        public frm_consultaValor()
        {
            InitializeComponent();
        }

        private void batevolta_dd64LBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.batevolta_dd64LBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glturfreDeployDataSet);

        }

        private void frm_consultaValor_Load(object sender, EventArgs e)
        {
            
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.batevolta_dd60L'. Você pode movê-la ou removê-la conforme necessário.
            this.batevolta_dd60LTableAdapter.Fill(this.glturfreDeployDataSet.batevolta_dd60L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.batevolta_dd64L'. Você pode movê-la ou removê-la conforme necessário.
            this.batevolta_dd64LTableAdapter.Fill(this.glturfreDeployDataSet.batevolta_dd64L);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //essa parte do codigo pode ser refaturado depois, usando um Switch/Case, mas nao farei isso agora. Entao deixa assim por enquanto
            if (chkBx_BateVolta_DD64L.Checked == true)
            {
                txtbx_valorBateVolta.Text = valorTextBox.Text;
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_BateVolta_DD60L.Checked == true)
            {
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_BateVolta_Semi46L.Checked == true)
            {
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_BateVolta_Exec50L.Checked == true)
            {
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_BateVolta_Exec46L.Checked == true)
            {
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_BateVolta_Conv47L.Checked == true)
            {
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_BateVolta_Micro32L.Checked == true)
            {
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_BateVolta_Van18L.Checked == true)
            {
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_BateVolta_Van15L.Checked == true)
            {

                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_BateVolta_Carro.Checked == true)
            {
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_DD60L.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_FimSem_DD64L.Checked == true)
            {
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                // chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_FimSem_DD60L.Checked == true)
            {
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                // chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_FimSem_Semi46L.Checked == true)
            {
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                //chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_FimSem_Exec50L.Checked == true)
            {

                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                //chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_FimSem_Exec46L.Checked == true)
            {
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                //chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_FimSem_Conv47L.Checked == true)
            {
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                //chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;

            }

            else if (chkBx_FimSem_Micro32L.Checked == true)
            {
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                //chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_FimSem_Van18L.Checked == true)
            {
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                //chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_FimSem_Van15L.Checked == true)
            {
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                //chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_FimSem_Carro.Checked == true)
            {
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                //chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_FerPro_DD64L.Checked == true)
            {
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                //chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_FerPro_DD60L.Checked == true)
            {
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                //chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_FerPro_Semi46L.Checked == true)
            {
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                //chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_FerPro_Exec50L.Checked == true)
            {
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                //chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_FerPro_Exec46L.Checked == true)
            {
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                //chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_FerPro_Conv47L.Checked == true)
            {
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                //chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_FerPro_Micro32L.Checked == true)
            {
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                //chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_FerPro_Van18L.Checked == true)
            {
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                //chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_FerPro_Van15L.Checked == true)
            {
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                //chkBx_FerPro_Van15L.Enabled = false;
                chkBx_FerPro_Carro.Enabled = false;
            }

            else if (chkBx_FerPro_Carro.Checked == true)
            {
                chkBx_BateVolta_DD60L.Enabled = false;
                chkBx_BateVolta_DD64L.Enabled = false;
                chkBx_BateVolta_Semi46L.Enabled = false;
                chkBx_BateVolta_Exec50L.Enabled = false;
                chkBx_BateVolta_Exec46L.Enabled = false;
                chkBx_BateVolta_Conv47L.Enabled = false;
                chkBx_BateVolta_Micro32L.Enabled = false;
                chkBx_BateVolta_Van18L.Enabled = false;
                chkBx_BateVolta_Van15L.Enabled = false;
                chkBx_BateVolta_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = false;
                chkBx_FimSem_DD60L.Enabled = false;
                chkBx_FimSem_Semi46L.Enabled = false;
                chkBx_FimSem_Exec50L.Enabled = false;
                chkBx_FimSem_Exec46L.Enabled = false;
                chkBx_FimSem_Conv47L.Enabled = false;
                chkBx_FimSem_Micro32L.Enabled = false;
                chkBx_FimSem_Van18L.Enabled = false;
                chkBx_FimSem_Van15L.Enabled = false;
                chkBx_FimSem_Carro.Enabled = false;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = false;
                chkBx_FerPro_DD60L.Enabled = false;
                chkBx_FerPro_Semi46L.Enabled = false;
                chkBx_FerPro_Exec50L.Enabled = false;
                chkBx_FerPro_Exec46L.Enabled = false;
                chkBx_FerPro_Conv47L.Enabled = false;
                chkBx_FerPro_Micro32L.Enabled = false;
                chkBx_FerPro_Van18L.Enabled = false;
                chkBx_FerPro_Van15L.Enabled = false;
                //chkBx_FerPro_Carro.Enabled = false;
            }

            else
            {

                txtbx_valorBateVolta.Text = "";
                //Nesse bloco estou ativando o bloco do bate volta
                chkBx_BateVolta_DD64L.Enabled = true;
                chkBx_BateVolta_DD60L.Enabled = true;
                chkBx_BateVolta_Semi46L.Enabled = true;
                chkBx_BateVolta_Exec50L.Enabled = true;
                chkBx_BateVolta_Exec46L.Enabled = true;
                chkBx_BateVolta_Conv47L.Enabled = true;
                chkBx_BateVolta_Micro32L.Enabled = true;
                chkBx_BateVolta_Van18L.Enabled = true;
                chkBx_BateVolta_Van15L.Enabled = true;
                chkBx_BateVolta_Carro.Enabled = true;

                //Nesse bloco estou ativando o bloco Fim de Semana
                chkBx_FimSem_DD64L.Enabled = true;
                chkBx_FimSem_DD60L.Enabled = true;
                chkBx_FimSem_Semi46L.Enabled = true;
                chkBx_FimSem_Exec50L.Enabled = true;
                chkBx_FimSem_Exec46L.Enabled = true;
                chkBx_FimSem_Conv47L.Enabled = true;
                chkBx_FimSem_Micro32L.Enabled = true;
                chkBx_FimSem_Van18L.Enabled = true;
                chkBx_FimSem_Van15L.Enabled = true;
                chkBx_FimSem_Carro.Enabled = true;

                //Nesse bloco estou ativando o bloco Feriado Prolongado
                chkBx_FerPro_DD64L.Enabled = true;
                chkBx_FerPro_DD60L.Enabled = true;
                chkBx_FerPro_Semi46L.Enabled = true;
                chkBx_FerPro_Exec50L.Enabled = true;
                chkBx_FerPro_Exec46L.Enabled = true;
                chkBx_FerPro_Conv47L.Enabled = true;
                chkBx_FerPro_Micro32L.Enabled = true;
                chkBx_FerPro_Van18L.Enabled = true;
                chkBx_FerPro_Van15L.Enabled = true;
                chkBx_FerPro_Carro.Enabled = true;

            }
        }

        private void chkBx_BateVolta_DD64L_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            this.batevolta_dd60LTableAdapter.FillByBateVolta_DD60(this.glturfreDeployDataSet.batevolta_dd60L, textBox1.Text);
            this.batevolta_dd64LTableAdapter.FillByBateVolta_DD64(this.glturfreDeployDataSet.batevolta_dd64L, textBox1.Text);
        }

        private void txtbx_valorBateVolta_TextChanged(object sender, EventArgs e)
        {

        }

        private void valorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_orcNovo testando = new frm_orcNovo();
            testando.ShowDialog();
        }
    }
}
