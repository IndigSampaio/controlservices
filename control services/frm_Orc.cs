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
    public partial class frm_Orc : Form
    {
        public frm_Orc()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void cad_cliBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cad_cliBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glturfreDeployDataSet);

        }

        private void frm_Orc_Load(object sender, EventArgs e)
        {
            lbl_totalKm.Text = "";
            lbl_ValorCalculo.Text = "";


            if (txtbx_VlrFinal.Text == "")
                {
                chkbx_NotaFiscal.Enabled = false;
            }
            
            else
            {
                chkbx_NotaFiscal.Enabled = true;
            }

            label2.Text = "";
            label4.Text = "";
            label14.Text = "";

            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.orcamento'. Você pode movê-la ou removê-la conforme necessário.
            this.orcamentoTableAdapter.Fill(this.glturfreDeployDataSet.orcamento);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.fimsem_carro'. Você pode movê-la ou removê-la conforme necessário.
            this.fimsem_carroTableAdapter.Fill(this.glturfreDeployDataSet.fimsem_carro);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.fimsem_van15L'. Você pode movê-la ou removê-la conforme necessário.
            this.fimsem_van15LTableAdapter.Fill(this.glturfreDeployDataSet.fimsem_van15L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.fimsem_van18L'. Você pode movê-la ou removê-la conforme necessário.
            this.fimsem_van18LTableAdapter.Fill(this.glturfreDeployDataSet.fimsem_van18L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.fimsem_micro32L'. Você pode movê-la ou removê-la conforme necessário.
            this.fimsem_micro32LTableAdapter.Fill(this.glturfreDeployDataSet.fimsem_micro32L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.fimsem_conv47L'. Você pode movê-la ou removê-la conforme necessário.
            this.fimsem_conv47LTableAdapter.Fill(this.glturfreDeployDataSet.fimsem_conv47L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.fimsem_exec46L'. Você pode movê-la ou removê-la conforme necessário.
            this.fimsem_exec46LTableAdapter.Fill(this.glturfreDeployDataSet.fimsem_exec46L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.fimsem_exec50L'. Você pode movê-la ou removê-la conforme necessário.
            this.fimsem_exec50LTableAdapter.Fill(this.glturfreDeployDataSet.fimsem_exec50L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.fimsem_semi46L'. Você pode movê-la ou removê-la conforme necessário.
            this.fimsem_semi46LTableAdapter.Fill(this.glturfreDeployDataSet.fimsem_semi46L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.fimsem_dd60L'. Você pode movê-la ou removê-la conforme necessário.
            this.fimsem_dd60LTableAdapter.Fill(this.glturfreDeployDataSet.fimsem_dd60L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.fimsem_dd64L'. Você pode movê-la ou removê-la conforme necessário.
            this.fimsem_dd64LTableAdapter.Fill(this.glturfreDeployDataSet.fimsem_dd64L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.ferpro_carro'. Você pode movê-la ou removê-la conforme necessário.
            this.ferpro_carroTableAdapter.Fill(this.glturfreDeployDataSet.ferpro_carro);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.ferpro_van15L'. Você pode movê-la ou removê-la conforme necessário.
            this.ferpro_van15LTableAdapter.Fill(this.glturfreDeployDataSet.ferpro_van15L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.ferpro_van18L'. Você pode movê-la ou removê-la conforme necessário.
            this.ferpro_van18LTableAdapter.Fill(this.glturfreDeployDataSet.ferpro_van18L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.ferpro_micro32L'. Você pode movê-la ou removê-la conforme necessário.
            this.ferpro_micro32LTableAdapter.Fill(this.glturfreDeployDataSet.ferpro_micro32L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.ferpro_conv47L'. Você pode movê-la ou removê-la conforme necessário.
            this.ferpro_conv47LTableAdapter.Fill(this.glturfreDeployDataSet.ferpro_conv47L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.ferpro_exec50L'. Você pode movê-la ou removê-la conforme necessário.
            this.ferpro_exec50LTableAdapter.Fill(this.glturfreDeployDataSet.ferpro_exec50L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.ferpro_exec46L'. Você pode movê-la ou removê-la conforme necessário.
            this.ferpro_exec46LTableAdapter.Fill(this.glturfreDeployDataSet.ferpro_exec46L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.ferpro_semi46L'. Você pode movê-la ou removê-la conforme necessário.
            this.ferpro_semi46LTableAdapter.Fill(this.glturfreDeployDataSet.ferpro_semi46L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.ferpro_dd60L'. Você pode movê-la ou removê-la conforme necessário.
            this.ferpro_dd60LTableAdapter.Fill(this.glturfreDeployDataSet.ferpro_dd60L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.ferpro_dd64L'. Você pode movê-la ou removê-la conforme necessário.
            this.ferpro_dd64LTableAdapter.Fill(this.glturfreDeployDataSet.ferpro_dd64L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.batevolta_carro'. Você pode movê-la ou removê-la conforme necessário.
            this.batevolta_carroTableAdapter.Fill(this.glturfreDeployDataSet.batevolta_carro);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.batevolta_van15L'. Você pode movê-la ou removê-la conforme necessário.
            this.batevolta_van15LTableAdapter.Fill(this.glturfreDeployDataSet.batevolta_van15L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.batevolta_van18L'. Você pode movê-la ou removê-la conforme necessário.
            this.batevolta_van18LTableAdapter.Fill(this.glturfreDeployDataSet.batevolta_van18L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.batevolta_micro32L'. Você pode movê-la ou removê-la conforme necessário.
            this.batevolta_micro32LTableAdapter.Fill(this.glturfreDeployDataSet.batevolta_micro32L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.batevolta_conv47L'. Você pode movê-la ou removê-la conforme necessário.
            this.batevolta_conv47LTableAdapter.Fill(this.glturfreDeployDataSet.batevolta_conv47L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.batevolta_exec46L'. Você pode movê-la ou removê-la conforme necessário.
            this.batevolta_exec46LTableAdapter.Fill(this.glturfreDeployDataSet.batevolta_exec46L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.batevolta_exec50L'. Você pode movê-la ou removê-la conforme necessário.
            this.batevolta_exec50LTableAdapter.Fill(this.glturfreDeployDataSet.batevolta_exec50L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.batevolta_semi46L'. Você pode movê-la ou removê-la conforme necessário.
            this.batevolta_semi46LTableAdapter.Fill(this.glturfreDeployDataSet.batevolta_semi46L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.batevolta_dd60L'. Você pode movê-la ou removê-la conforme necessário.
            this.batevolta_dd60LTableAdapter.Fill(this.glturfreDeployDataSet.batevolta_dd60L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.batevolta_dd64L'. Você pode movê-la ou removê-la conforme necessário.
            this.batevolta_dd64LTableAdapter.Fill(this.glturfreDeployDataSet.batevolta_dd64L);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.cad_cli'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_cliTableAdapter.Fill(this.glturfreDeployDataSet.cad_cli);

        }

        private void msktxbx_CpfCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
                this.cad_cliTableAdapter.FillByCpfCliente(this.glturfreDeployDataSet.cad_cli, msktxbx_CpfCnpj.Text);   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chkbx_UsarValorTabela.Checked == true)
            {
                txtbx_VlrFinal.Text = label14.Text;
            }

            if (cmbbx_mask_CpfCnpj.Text == "CPF")
            {
                msktxbx_CpfCnpj.Mask = "999.999.999-99";
            }

            else if (cmbbx_mask_CpfCnpj.Text == "CNPJ")
            {
                msktxbx_CpfCnpj.Mask = "99.999.999/9999-99";
            }

            if(chkbx_NotaFiscal.Checked == true)
            {
                if (chkbx_UsarValorTabela.Checked == true)
                {
                    if (label14.Text != "")
                    {
                        int valor, conta;
                        string resultado;


                        valor = Convert.ToInt32(label14.Text);
                        conta = valor + (valor * (10 / 100));
                        resultado = Convert.ToString(conta);

                        txtbx_VlrFinal.Text = resultado;
                    }
                }

                else
                {
                    int valor, conta;
                    string resultado;


                    valor = Convert.ToInt32(txtbx_VlrFinal.Text);
                    conta = valor + (valor * (10 / 100));
                    resultado = Convert.ToString(conta);

                    txtbx_VlrFinal.Text = resultado;
                }

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (msktxbx_CpfCnpj.Text == "")
            {
                label2.Text = "";
                label4.Text = "";
            }

            else
            {
                label2.Text = nome_razao_socialTextBox.Text;
                label4.Text = telefoneTextBox.Text;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_cadCli cadCli = new frm_cadCli();
            cadCli.ShowDialog();
        }

        private void btn_ProcurarDestino_Click(object sender, EventArgs e)
        {
            if (cmbbx_Periodo.Text == "FIM DE SEMANA")
            {
                switch (cmbbx_Categoria.Text)
                {
                    case "DD 64L":
                        this.fimsem_dd64LTableAdapter.FillByFimSem_DD64(this.glturfreDeployDataSet.fimsem_dd64L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_FimSemDD64.Text + ",00";
                        break;

                    case "DD 60L":
                        this.fimsem_dd60LTableAdapter.FillByFimSem_DD60(this.glturfreDeployDataSet.fimsem_dd60L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_FimSemDD60.Text + ",00";
                        break;

                    case "CONV 47L":
                        this.fimsem_conv47LTableAdapter.FillByFimSem_Conv47(this.glturfreDeployDataSet.fimsem_conv47L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_FimSemConv47.Text + ",00";
                        break;

                    case "SEMI 46L":
                        this.fimsem_semi46LTableAdapter.FillByFimSem_Semi46(this.glturfreDeployDataSet.fimsem_semi46L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_FimSem46.Text + ",00";
                        break;

                    case "MICRO 32L":
                        this.fimsem_micro32LTableAdapter.FillByFimSem_Micro32(this.glturfreDeployDataSet.fimsem_micro32L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_BateVoltaMicro32.Text + ",00";
                        break;

                    case "VAN 18L":
                        this.fimsem_van18LTableAdapter.FillByFimSem_Van18(this.glturfreDeployDataSet.fimsem_van18L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_BateVoltaVan18.Text + ",00";
                        break;

                    case "VAN 15L":
                        this.fimsem_van15LTableAdapter.FillByFimSem_Van15(this.glturfreDeployDataSet.fimsem_van15L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_BateVoltaVan15.Text + ",00";
                        break;

                    case "CARRO":
                        this.fimsem_carroTableAdapter.FillByFimSem_Carro(this.glturfreDeployDataSet.fimsem_carro, txtbx_Destino.Text);
                        label14.Text = valorTextBox_BateVoltaCarro.Text + ",00";
                        break;

                    case "EXEC 46L":
                        this.fimsem_exec46LTableAdapter.FillByFimSem_Exec46(this.glturfreDeployDataSet.fimsem_exec46L, txtbx_Destino.Text);
                        label4.Text = valorTextBox_BateVoltaExec46.Text + ",00";
                        break;

                    case "EXEC 50L":
                        this.fimsem_exec50LTableAdapter.FillByFimSem_Exec50(this.glturfreDeployDataSet.fimsem_exec50L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_BateVoltaExec50.Text + ",00";
                        break;

                }


            }

            else if (cmbbx_Periodo.Text == "FERIADO PROLONGADO")
            {
                switch (cmbbx_Categoria.Text)
                {
                    case "DD 64L":
                        this.ferpro_dd64LTableAdapter.FillByFerPro_DD64(this.glturfreDeployDataSet.ferpro_dd64L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_FerProDD64.Text + ",00";
                        break;

                    case "DD 60L":
                        this.ferpro_dd60LTableAdapter.FillByFerPro_DD60(this.glturfreDeployDataSet.ferpro_dd60L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_FerProDD60.Text + ",00";
                        break;

                    case "CONV 47L":
                        this.ferpro_conv47LTableAdapter.FillByFerPro_Conv47(this.glturfreDeployDataSet.ferpro_conv47L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_FerProConv47.Text + ",00";
                        break;

                    case "SEMI 46L":
                        this.ferpro_semi46LTableAdapter.FillByFerPro_Semi46(this.glturfreDeployDataSet.ferpro_semi46L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_FerProConv47.Text + ",00";
                        break;

                    case "MICRO 32L":
                        this.ferpro_micro32LTableAdapter.FillByFerPro_Micro32(this.glturfreDeployDataSet.ferpro_micro32L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_FerProMicro32.Text + ",00";
                        break;

                    case "VAN 18L":
                        this.ferpro_van18LTableAdapter.FillByFerPro_Van18(this.glturfreDeployDataSet.ferpro_van18L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_FerProVan18.Text + ",00";
                        break;

                    case "VAN 15L":
                        this.ferpro_van15LTableAdapter.FillByFerPro_Van15(this.glturfreDeployDataSet.ferpro_van15L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_FerProVan15.Text + ",00";
                        break;

                    case "CARRO":
                        this.ferpro_carroTableAdapter.FillByFerPro_Carro(this.glturfreDeployDataSet.ferpro_carro, txtbx_Destino.Text);
                        label14.Text = valorTextBox_FerProCarro.Text + ",00";
                        break;

                    case "EXEC 46L":
                        this.ferpro_exec46LTableAdapter.FillByFerPro_Exec46(this.glturfreDeployDataSet.ferpro_exec46L, txtbx_Destino.Text);
                        label4.Text = valorTextBox_FerProExec46.Text + ",00";
                        break;

                    case "EXEC 50L":
                        this.ferpro_exec50LTableAdapter.FillByFerPro_Exec50(this.glturfreDeployDataSet.ferpro_exec50L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_FerProExec50.Text + ",00";
                        break;
                }
            }

            else if (cmbbx_Periodo.Text == "BATE E VOLTA")
            {
                switch (cmbbx_Categoria.Text)
                {

                    case "DD 64L":
                        this.batevolta_dd64LTableAdapter.FillByBateVolta_DD64(this.glturfreDeployDataSet.batevolta_dd64L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_BateVoltaDD64.Text + ",00";
                        break;

                    case "DD 60L":
                        this.batevolta_dd60LTableAdapter.FillByBateVolta_DD60(this.glturfreDeployDataSet.batevolta_dd60L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_BateVoltaDD60.Text + ",00";
                        break;

                    case "CONV 47L":
                        this.batevolta_conv47LTableAdapter.FillByBateVolta_Conv47(this.glturfreDeployDataSet.batevolta_conv47L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_BateVoltaConv47.Text + ",00";
                        break;

                    case "SEMI 46L":
                        this.batevolta_semi46LTableAdapter.FillByBateVolta_Semi46(this.glturfreDeployDataSet.batevolta_semi46L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_BateVoltaConv47.Text + ",00";
                        break;

                    case "MICRO 32L":
                        this.batevolta_micro32LTableAdapter.FillByBateVolta_Micro32(this.glturfreDeployDataSet.batevolta_micro32L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_BateVoltaMicro32.Text + ",00";
                        break;

                    case "VAN 18L":
                        this.batevolta_van18LTableAdapter.FillByBateVolta_Van18(this.glturfreDeployDataSet.batevolta_van18L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_BateVoltaVan18.Text + ",00";
                        break;

                    case "VAN 15L":
                        this.batevolta_van15LTableAdapter.FillByBateVolta_Van15(this.glturfreDeployDataSet.batevolta_van15L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_BateVoltaVan15.Text + ",00";
                        break;

                    case "CARRO":
                        this.batevolta_carroTableAdapter.FillByBateVolta_Carro(this.glturfreDeployDataSet.batevolta_carro, txtbx_Destino.Text);
                        label14.Text = valorTextBox_BateVoltaCarro.Text + ",00";
                        break;

                    case "EXEC 46L":
                        this.batevolta_exec46LTableAdapter.FillByBateVolta_Exec46(this.glturfreDeployDataSet.batevolta_exec46L, txtbx_Destino.Text);
                        label4.Text = valorTextBox_BateVoltaExec46.Text + ",00";
                        break;

                    case "EXEC 50L":
                        this.batevolta_exec50LTableAdapter.FillByBateVolta_Exec50(this.glturfreDeployDataSet.batevolta_exec50L, txtbx_Destino.Text);
                        label14.Text = valorTextBox_BateVoltaExec50.Text + ",00";
                        break;
                }
            }

            else
            {
                txtbx_Destino.Text = "";
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void grpbx_InfCliente_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (grpbx_InfCliente.Enabled == true)
            {
                MessageBox.Show("Para adicionar um novo registro, é necessario finalizar o atual", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                grpbx_InfCliente.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (grpbx_InfCliente.Enabled == true)
            {
                if (MessageBox.Show("Deseja realmente sair?\nRegistro não salvos serão perdidos", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)== DialogResult.Yes)
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
                this.Validate();
                this.orcamentoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.glturfreDeployDataSet);
                MessageBox.Show("Orcamento salvo com sucesso!", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                grpbx_InfCliente.Enabled = false;
            }
        }

        private void chkbx_UsarValorTabela_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_consultCli consultCli = new frm_consultCli();
            consultCli.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frm_consultCidade consultCidade = new frm_consultCidade();
            consultCidade.ShowDialog();

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double km_ida, km_volta, km_total, valor_calc, conta;



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
                            valor_calc = (km_total * 60) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 40) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 30) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 27) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 22) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 16) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 14.5) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 12.5) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 12.5) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 10) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
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

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 38) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 27) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 25) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 20) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 14) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 12.5) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 12) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 12) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 9.5) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
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

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 30) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 25) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 23) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 17) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 13) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 11) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 11.5) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 11.5) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 9) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
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

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 27) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 23) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 20) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 15) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 12.5) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 10.5) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 11) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 11) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 8.5) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
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

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 25) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 20) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 18) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 14) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 12) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 10) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 10) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 10) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 8) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
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

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 22) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 18) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 15) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 12) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 11) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 9) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 9) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 9) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 7.5) + 1500;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
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
                            valor_calc = (km_total * 30) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 20) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 14) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 12) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 10) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 9) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 8) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 7.5) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 6.5) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 6) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
                        {
                            valor_calc = (km_total * 5) + 1200;
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

                    case "VAN 18L":
                        if (km_total <= 30)
                        {
                            valor_calc = (km_total * 18) + 900;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 15) + 900;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 10) + 900;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 8) + 900;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 7) + 900;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 6) + 900;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 5.5) + 900;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 5.5) + 900;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 5.5) + 900;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 5) + 900;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
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

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 13) + 900;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 9) + 900;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 7) + 900;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 6) + 900;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 5) + 900;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 5) + 900;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 5) + 900;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 5) + 900;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 4.5) + 900;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
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

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 3);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 3);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 3);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 3);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 2.5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 2.1);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 2);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 2);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 1.8);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
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
                            valor_calc = (km_total * 60) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 40) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 30) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 27) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 22) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 16) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 14.5) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 12.5) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 12.5) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 10) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
                        {
                            valor_calc = (km_total * 9.5) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 400)
                        {
                            valor_calc = (km_total * 9) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else
                        {

                        }

                        break;

                    case "DD 60L":

                        if (km_total <= 30)
                        {
                            valor_calc = (km_total * 55) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 38) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 27) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 25) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 20) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 14) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 12.5) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 12) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 12) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 9.5) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
                        {
                            valor_calc = (km_total * 9) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 400)
                        {
                            valor_calc = (km_total * 8.5) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else
                        {

                        }

                        break;


                    case "SEMI 46L":
                        if (km_total <= 30)
                        {
                            valor_calc = (km_total * 50) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 30) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 25) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 23) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 17) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 13) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 11) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 11.5) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 11.5) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 9) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
                        {
                            valor_calc = (km_total * 8.5) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 400)
                        {
                            valor_calc = (km_total * 8) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else
                        {

                        }
                        break;

                    case "EXEC 50L":
                        if (km_total <= 30)
                        {
                            valor_calc = (km_total * 43) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 27) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 23) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 20) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 15) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 12.5) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 10.5) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 11) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 11) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 8.5) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
                        {
                            valor_calc = (km_total * 8) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 400)
                        {
                            valor_calc = (km_total * 7.5) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else
                        {

                        }
                        break;

                    case "EXEC 46L":
                        if (km_total <= 30)
                        {
                            valor_calc = (km_total * 40) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 25) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 20) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 18) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 14) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 12) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 10) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 10) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 10) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 8) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
                        {
                            valor_calc = (km_total * 7.5) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 400)
                        {
                            valor_calc = (km_total * 7) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else
                        {

                        }
                        break;

                    case "CONV 47L":
                        if (km_total <= 30)
                        {
                            valor_calc = (km_total * 35) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 22) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 18) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 15) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 12) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 11) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 9) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 9) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 9) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 7.5) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
                        {
                            valor_calc = (km_total * 7) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 400)
                        {
                            valor_calc = (km_total * 6.5) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else
                        {

                        }
                        break;

                    case "MICRO 32L":

                        if (km_total <= 30)
                        {
                            valor_calc = (km_total * 30) + 2000;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 20) + 1600;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 14) + 1600;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 12) + 1600;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 10) + 1600;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 9) + 1600;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 8) + 1600;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 7.5) + 1600;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 6.5) + 1600;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 6) + 1600;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
                        {
                            valor_calc = (km_total * 5) + 1600;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 400)
                        {
                            valor_calc = (km_total * 8.5) + 1600;
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

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 15) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 10) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 8) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 7) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 6) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 5.5) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 5.5) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 5.5) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 5) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
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

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 13) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 9) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 7) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 6) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 5) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 5) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 5) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 5) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 4.5) + 1200;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
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

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 3);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 3);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 3);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 3);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 2.5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 2.1);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 2);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 2);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 1.8);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
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

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 40);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 30);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 27);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 22);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 16);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 14.5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 12.5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 12.5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 10);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
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

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 38);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 27);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 25);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 20);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 14);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 12.5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 12);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 12);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 9.5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
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

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 30);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 25);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 23);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 17);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 13);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 11);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 11.5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 11.5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 9);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
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

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 27);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 23);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 20);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 15);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 12.5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 10.5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 11);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 11);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 8.5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
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

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 25);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 20);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 18);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 14);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 12);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 10);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 10);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 10);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 8);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
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

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 22);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 18);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 15);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 12);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 11);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 9);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 9);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 9);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 7.5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
                        {
                            valor_calc = (km_total * 7);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 400)
                        {
                            valor_calc = (km_total * 6.5) ;
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

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 20);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 14);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 12);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 10);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 9);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 8);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 7.5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 6.5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 6);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
                        {
                            valor_calc = (km_total * 5);
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

                    case "VAN 18L":
                        if (km_total <= 30)
                        {
                            valor_calc = (km_total * 18) + 900;
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 15);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 10);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 8);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 7);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 6);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 5.5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 5.5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 5.5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
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

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 13);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 9);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 7);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 6);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 4.5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
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

                        else if (km_total >= 31 || km_total == 50)
                        {
                            valor_calc = (km_total * 3);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 51 || km_total == 75)
                        {
                            valor_calc = (km_total * 3);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 76 || km_total == 100)
                        {
                            valor_calc = (km_total * 3);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 101 || km_total == 125)
                        {
                            valor_calc = (km_total * 3);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 126 || km_total == 150)
                        {
                            valor_calc = (km_total * 2.5);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 151 || km_total == 175)
                        {
                            valor_calc = (km_total * 2.1);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 176 || km_total == 200)
                        {
                            valor_calc = (km_total * 2);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 201 || km_total == 250)
                        {
                            valor_calc = (km_total * 2);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 251 || km_total == 300)
                        {
                            valor_calc = (km_total * 1.8);
                            lbl_ValorCalculo.Text = Convert.ToString(valor_calc) + ",00";
                        }

                        else if (km_total >= 301 || km_total == 400)
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

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm_consultDistancia consultDistancia = new frm_consultDistancia();
            consultDistancia.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            frm_consultDistancia consultDistancia = new frm_consultDistancia();
            consultDistancia.Show();
        }
    }
}
