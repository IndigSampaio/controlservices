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
    public partial class frm_menu : Form
    {
        bool sidebarExpand;
        public frm_menu()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show("Deseja realmente sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadfun cadfun = new frm_cadfun();
            cadfun.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

      /*  private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                toolStrip1.Width -= 10;
                if(toolStrip1.Width == toolStrip1.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                toolStrip1.Width += 10;

                if(toolStrip1.Width == toolStrip1.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }*/

        private void sidebarbutton_menu_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja realmente sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
