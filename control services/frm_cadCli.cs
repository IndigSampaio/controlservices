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

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"Chrome.exe", "https://web.whatsapp.com/send?phone=5511984062207");
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (panel_cadastro.Enabled == true)
            {
                if (MessageBox.Show(" Os dados ainda nao foram salvos.\n DESEJA REALMENTE SAIR?\n Os dados nao salvos serao perdidos", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                }
            }

            else
            {
                this.Close();
            }
        }

        private void cad_clieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cad_cliBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gldturfreDeployDataSet);

        }

        private void frm_cadCli2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.estado'. Você pode movê-la ou removê-la conforme necessário.
            this.estadoTableAdapter.Fill(this.gldturfreDeployDataSet.estado);
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.cad_cli'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_cliTableAdapter.Fill(this.gldturfreDeployDataSet.cad_cli);
            txtbx_nome.Text = "";
            maskedTextBox1.Text = "";
            txtbx_email.Text = "";
            txtbx_endereco.Text = "";
            txtbx_num_ende.Text = "";
            txtbx_bairro.Text = "";
            txtbx_cidade.Text = "";
            comboBox1.Text = "";
            msktxbx_tel.Text = "";
            txtbx_compl.Text = "";
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

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txtbx_nome.Text == "" || maskedTextBox1.Text == "" || msktxbx_tel.Text == "")
            {
                MessageBox.Show("Os campos:\n NOME/RAZAO SOCIAL, CPF/CNPJ e Telefone\n Nao podem estar vazios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                this.tableAdapterManager.UpdateAll(this.gldturfreDeployDataSet);
                MessageBox.Show("Cadastro Salvo com sucesso!", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbx_nome.Text = "";
                maskedTextBox1.Text = "";
                txtbx_email.Text = "";
                txtbx_endereco.Text = "";
                txtbx_num_ende.Text = "";
                txtbx_bairro.Text = "";
                txtbx_cidade.Text = "";
                comboBox1.Text = "";
                msktxbx_tel.Text = "";
                txtbx_compl.Text = "";
                panel_cadastro.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cmbbx_cpf_cnpj.Text == "CPF")
            {
                maskedTextBox1.Mask = ("999,999,999-99");
            }

            else if (cmbbx_cpf_cnpj.Text == "CNPJ")
            {
                maskedTextBox1.Mask = ("99,999,999/9999-99");
            }
        }

        private void cad_cliBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
