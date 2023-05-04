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
    public partial class frm_cadLgn : Form
    {
        public frm_cadLgn()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"Chrome.exe", "https://web.whatsapp.com/send?phone=5511984062207");
        }

        private void lgn_usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void frm_cadLgn_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.lgn_users'. Você pode movê-la ou removê-la conforme necessário.
            this.lgn_usersTableAdapter.Fill(this.gldturfreDeployDataSet.lgn_users);
            ativoCheckBox.Checked = false;
            txtbx_Lgn.Text = "";
            txtbx_Snh.Text = "";
            txtbx_ConfSnh.Text = "";

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (panel3.Enabled == false)
            {
                panel3.Enabled = true;
                this.Validate();
                this.lgn_usersBindingSource.AddNew();
                ativoCheckBox.Checked = false;
            }
            
            else
            {
                MessageBox.Show("Para inserir um novo cadastro, e necessario finalizar o atual", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txtbx_Snh.Text == "" || txtbx_Lgn.Text == "")
            {
                MessageBox.Show("Os campos:\n login ou senha\n Nao podem estar vazios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if(txtbx_Snh.Text != txtbx_ConfSnh.Text)
                {
                    MessageBox.Show("O campo de senha e confirmacao de senha nao coincidem ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (txtbx_Snh.Text == txtbx_ConfSnh.Text)
                {
                    this.Validate();
                    this.lgn_usersBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.gldturfreDeployDataSet);
                    MessageBox.Show("Registro Salvo com Sucesso", "Salvo com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    panel3.Enabled = false;
                    txtbx_Lgn.Text = "";
                    txtbx_Snh.Text = "";
                    txtbx_ConfSnh.Text = "";
                }
            }

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if(panel3.Enabled == true)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(txtbx_Snh.Text != "" && txtbx_ConfSnh.Text != "")
            {
                if (txtbx_ConfSnh.Text != txtbx_Snh.Text)
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
                txtbx_Snh.PasswordChar = '\0';
            }

            else
            {
                txtbx_Snh.PasswordChar = '*';
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

        private void btn_consulta_cliente_Click(object sender, EventArgs e)
        {
            frm_consultLgn consultLgn = new frm_consultLgn();
            consultLgn.ShowDialog();
        }
    }
}
