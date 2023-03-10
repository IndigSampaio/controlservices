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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (panel_cadLgn.Enabled == false)
            {
                panel_cadLgn.Enabled = true;
                this.Validate();
                this.cad_loginBindingSource.AddNew();
            }

            else
            {
                MessageBox.Show("Para iniciar um novo registro, e necessario finalizar o atual", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (panel_cadLgn.Enabled == false)
            {
                MessageBox.Show("Nao ha registro para ser salvo", "Impossivel salver", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (txtbx_lgn.Text == "" || txtbx_snh.Text == "")
                {
                    MessageBox.Show("Para salvar o registro, preencha os campos de Login e Senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (txtbx_snh.Text != txtbx_ConfSnh.Text)
                {
                    MessageBox.Show("Senhas nao sao iguais", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    this.Validate();
                    this.cad_loginBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.glturfreDeployDataSet);
                    MessageBox.Show("Login cadastrado com sucesso!", "Confirmacao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                    panel_cadLgn.Enabled = false;
                }
            }

        }

        private void cad_loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void frm_cadLgn_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.cad_login'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_loginTableAdapter.Fill(this.glturfreDeployDataSet.cad_login);
            panel_cadLgn.Enabled = false;
            txtbx_lgn.Text = "";
            txtbx_snh.Text = "";
            txtbx_ConfSnh.Text = "";
            chkbx_ativo.Checked = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtbx_snh.Text != "")
            {
                if (txtbx_ConfSnh.Text != txtbx_snh.Text)
                {
                    txtbx_ConfSnh.BackColor = Color.LightSalmon;
                }
                else
                {
                    txtbx_ConfSnh.BackColor = Color.White;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel_cadLgn.Enabled == true)
            {
                if (MessageBox.Show("Deseja realmente sair?\n O registro nao foi salvo e sera perdido", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }         
            }

            else
            {
                this.Close();
            }
        }

        private void timer_VerSnh_Tick(object sender, EventArgs e)
        {
            if (chkbx_VerSnh.Checked == false)
            {
                txtbx_snh.PasswordChar = '*';
            }

            else
            {
                txtbx_snh.PasswordChar = '\0';
            }

        }

        private void timer_ConfVerSnh_Tick(object sender, EventArgs e)
        {
            if (chkbx_VerConfSnh.Checked == false)
            {
                txtbx_ConfSnh.PasswordChar = '*';
            }

            else
            {
                txtbx_ConfSnh.PasswordChar = '\0';
            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"Chrome.exe", "https://web.whatsapp.com/send?phone=5511984062207");
        }

        private void panel_cadLgn_Paint(object sender, PaintEventArgs e)
        {


        }
    }
}
