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
    public partial class frm_consultLgn : Form
    {
        public frm_consultLgn()
        {
            InitializeComponent();
        }

        private void lgn_usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lgn_usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gldturfreDeployDataSet);

        }

        private void frm_consultLgn_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.lgn_users'. Você pode movê-la ou removê-la conforme necessário.
            this.lgn_usersTableAdapter.Fill(this.gldturfreDeployDataSet.lgn_users);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lgnLabel_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (snhTextBox.Text != txtbx_ConfSnh.Text)
            {
                MessageBox.Show("O campo de senha e confirmacao de senha nao coincidem ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (snhTextBox.Text == txtbx_ConfSnh.Text)
            {
                this.Validate();
                this.lgn_usersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gldturfreDeployDataSet);
                MessageBox.Show("Registro Salvo com Sucesso", "Salvo com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                panel1.Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"Chrome.exe", "https://web.whatsapp.com/send?phone=5511984062207");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            if (rdbtID.Checked == true)
            {
                txtbx_procuarID.Enabled = false;
                rdbtLgn.Enabled = false;
            }

            if (rdbtLgn.Checked == true)
            {
                txtbx_procuarID.Enabled = false;
                rdbtID.Enabled = false;
            }
            */

            if (snhTextBox.Text != "" && txtbx_ConfSnh.Text != "")
            {
                if (txtbx_ConfSnh.Text != snhTextBox.Text)
                {
                    txtbx_ConfSnh.BackColor = Color.Red;
                }
                else
                {
                    txtbx_ConfSnh.BackColor = Color.LightGreen;
                }
            }

            //
            if (rdbt_Senha.Checked == true)
            {
                snhTextBox.PasswordChar = '\0';
            }

            else
            {
                snhTextBox.PasswordChar = '*';
            }

            if (rdbt_ConfSenha.Checked == true)
            {
                txtbx_ConfSnh.PasswordChar = '\0';
            }

            else
            {
                txtbx_ConfSnh.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if(txtbx_procuarLogin.Enabled == true)
            {
                this.lgn_usersTableAdapter.FillByProcurarLgn(this.gldturfreDeployDataSet.lgn_users, txtbx_procuarLogin.Text);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(panel1.Enabled == false)
            {
                panel1.Enabled = true;
            }

            else
            {
                MessageBox.Show("Para inserir um novo cadastro, e necessario finalizar o atual", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (panel1.Enabled == true)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.lgn_usersTableAdapter.FillByProcurarLgn(this.gldturfreDeployDataSet.lgn_users, txtbx_procuarLogin.Text);
        }

        private void ativoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
