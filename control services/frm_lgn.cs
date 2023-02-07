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
    public partial class frm_lgn : Form
    {

        int cont = 3;

        public frm_lgn()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ver_senha.Checked == false)
            {
                txtbx_snh.PasswordChar = '*';
            }

            else
            {
                txtbx_snh.PasswordChar = '\0';
            }


        }

        private void frm_lgn_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair?", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtbx_lgn.Text == "ADMIN" && txtbx_snh.Text == "123456")
            {
                frm_menu menu = new frm_menu();
                menu.ShowDialog();
                this.Visible = false;
            }

            if (txtbx_lgn.Text != "ADMIN")
            {
                cont = cont - 1;
                MessageBox.Show("Login incorreto. \n Tentativas restantes: " + cont, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (txtbx_snh.Text != "123456")
            {
                cont = cont - 1;
                MessageBox.Show("Senha incorreta. \n Tentativas restantes: " + cont, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (cont == 0)
            {
                MessageBox.Show("Limite de tentativas atigindo.\nContato o administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ver_senha.Checked = false;
                button1.Enabled = false;
                ver_senha.Enabled = false;
                txtbx_lgn.Enabled = false;
                txtbx_snh.Enabled = false;
            }


        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"Chrome.exe", "https://web.whatsapp.com/send?phone=5511984062207");
        }
    }
}
