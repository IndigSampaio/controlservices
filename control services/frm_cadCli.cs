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
    public partial class frm_cadCli : Form
    {
        public frm_cadCli()
        {
            InitializeComponent();
        }

        private void cad_cliBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void frm_cadCli_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet1.estados'. Você pode movê-la ou removê-la conforme necessário.
            this.estadosTableAdapter.Fill(this.glturfreDeployDataSet1.estados);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.cad_cli'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_cliTableAdapter.Fill(this.glturfreDeployDataSet.cad_cli);

            txtbx_email.Text = "";
            txtbx_endereco.Text = "";
            txtbx_nome.Text = "";
            txtbx_num_ende.Text = "";
            maskedTextBox1.Text = "";
            msktxbx_tel.Text = "";
            txtbx_bairro.Text = "";
            txtbx_cidade.Text = "";
            txtbx_compl.Text = "";
            comboBox1.Text = "";

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txtbx_nome.Text == "" || maskedTextBox1.Text == "" )
            {
                MessageBox.Show("Os campos:\n NOME/RAZAO SOCIAL e CPF/CNPJ\n Nao podem estar vazios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtbx_nome.Text == "")
            {
                MessageBox.Show("O campo: \n NOME/RAZAO SOCIAL\n Nao pode estar vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("O campo: \n CPF/CNPJ \n Nao pode estar vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                this.Validate();
                this.cad_cliBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.glturfreDeployDataSet);
                MessageBox.Show("Cadastro Salvo com sucesso!", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (panel_cadastro.Enabled == false)
            {
                this.Validate();
                this.cad_cliBindingSource.AddNew();
                panel_cadastro.Enabled = true;
            }

            else if (panel_cadastro.Enabled == true)
            {
                MessageBox.Show("Para inserir um novo cadastro, e necessario finalizar o atual", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (panel_cadastro.Enabled == true)
            {
                if(MessageBox.Show(" Os dados ainda nao foram salvos.\n DESEJA REALMENTE SAIR?\n Os dados nao salvos serao perdidos", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                }
            }

            else
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cmbbx_cpf_cnpj.Text == "CPF")
            {
                maskedTextBox1.Mask = ("999.999.999-99");
            }

            else if (cmbbx_cpf_cnpj.Text == "CNPJ")
            {
                maskedTextBox1.Mask = ("99.999.999/9999-99");
            }
        }

        private void btn_consulta_cliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Area em desenvolvimento");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
