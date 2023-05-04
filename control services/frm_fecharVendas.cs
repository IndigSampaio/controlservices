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
    public partial class frm_fecharVendas : Form
    {
        public frm_fecharVendas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cmbbx_cpf_cnpj.Text == "CPF")
            {
                msktxbx_CpfCnpj.Mask = ("999,999,999-99");
            }

            else if (cmbbx_cpf_cnpj.Text == "CNPJ")
            {
                msktxbx_CpfCnpj.Mask = ("99,999,999/9999-99");
            }

            if (rdbt_codOrc.Checked == true)
            {
                rdbt_CpfCnpj.Enabled = false;
                rdbt_nome.Enabled = false;
            }

        }

        private void orcamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orcamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gldturfreDeployDataSet);

        }

        private void frm_fecharVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.orcamento'. Você pode movê-la ou removê-la conforme necessário.
            this.orcamentoTableAdapter.Fill(this.gldturfreDeployDataSet.orcamento);

        }

        private void id_orcamentoLabel1_Click(object sender, EventArgs e)
        {

        }

        private void id_orcamentoLabel_Click(object sender, EventArgs e)
        {

        }

        private void nome_clienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void nome_clienteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void cpf_cnpj_clienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void cpf_cnpj_clienteLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tel_clienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void tel_clienteLabel1_Click(object sender, EventArgs e)
        {

        }

        private void valorLabel_Click(object sender, EventArgs e)
        {

        }

        private void valorLabel1_Click(object sender, EventArgs e)
        {

        }

        private void motoristaLabel_Click(object sender, EventArgs e)
        {

        }

        private void motoristaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void partidaLabel_Click(object sender, EventArgs e)
        {

        }

        private void partidaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void data_partidaLabel_Click(object sender, EventArgs e)
        {

        }

        private void data_partidaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void hora_partidaLabel_Click(object sender, EventArgs e)
        {

        }

        private void hora_partidaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void destinoLabel_Click(object sender, EventArgs e)
        {

        }

        private void destinoLabel1_Click(object sender, EventArgs e)
        {

        }

        private void data_retornoLabel_Click(object sender, EventArgs e)
        {

        }

        private void data_retornoLabel1_Click(object sender, EventArgs e)
        {

        }

        private void embarque_umLabel_Click(object sender, EventArgs e)
        {

        }

        private void embarque_umLabel1_Click(object sender, EventArgs e)
        {

        }

        private void horario_embarque_umLabel_Click(object sender, EventArgs e)
        {

        }

        private void horario_embarque_umLabel1_Click(object sender, EventArgs e)
        {

        }

        private void embarque_doisLabel_Click(object sender, EventArgs e)
        {

        }

        private void embarque_doisLabel1_Click(object sender, EventArgs e)
        {

        }

        private void horario_embarque_doisLabel_Click(object sender, EventArgs e)
        {

        }

        private void horario_embarque_doisLabel1_Click(object sender, EventArgs e)
        {

        }

        private void embarque_tresLabel_Click(object sender, EventArgs e)
        {

        }

        private void embarque_tresLabel1_Click(object sender, EventArgs e)
        {

        }

        private void horario_embarque_tresLabel_Click(object sender, EventArgs e)
        {

        }

        private void horario_embarque_tresLabel1_Click(object sender, EventArgs e)
        {

        }

        private void embarque_quatroLabel_Click(object sender, EventArgs e)
        {

        }

        private void embarque_quatroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void horario_embarque_quatroLabel_Click(object sender, EventArgs e)
        {

        }

        private void horario_embarque_quatroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void embarque_cincoLabel_Click(object sender, EventArgs e)
        {

        }

        private void embarque_cincoLabel1_Click(object sender, EventArgs e)
        {

        }

        private void horario_embarque_cincoLabel_Click(object sender, EventArgs e)
        {

        }

        private void horario_embarque_cincoLabel1_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_um_dataLabel_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_um_dataLabel1_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_um_roteiroLabel_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_um_roteiroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_um_horarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_um_horarioLabel1_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_dois_dataLabel_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_dois_dataLabel1_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_dois_roteiroLabel_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_dois_roteiroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_dois_horarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_dois_horarioLabel1_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_tres_dataLabel_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_tres_dataLabel1_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_tres_roteiroLabel_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_tres_roteiroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_tres_horarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_tres_horarioLabel1_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_quatro_dataLabel_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_quatro_dataLabel1_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_quatro_roteiroLabel_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_quatro_roteiroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_quatro_horarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_quatro_horarioLabel1_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_cinco_dataLabel_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_cinco_dataLabel1_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_cinco_roteiroLabel_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_cinco_roteiroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_cinco_horarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void roteiro_dia_cinco_horarioLabel1_Click(object sender, EventArgs e)
        {

        }

        private void obsLabel_Click(object sender, EventArgs e)
        {

        }

        private void obsLabel1_Click(object sender, EventArgs e)
        {

        } 

        private void categ_veiculoLabel_Click(object sender, EventArgs e)
        {

        }

        private void categ_veiculoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void periodoLabel_Click(object sender, EventArgs e)
        {

        }

        private void periodoLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void horario_retornoLabel_Click(object sender, EventArgs e)
        {

        }

        private void horario_retornoLabel1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.orcamentoTableAdapter.FillByOrcamento_PorCod(this.gldturfreDeployDataSet.orcamento, txtbx_codOrc.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
