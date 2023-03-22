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


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

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

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm_cadCli cadCli = new frm_cadCli();
            cadCli.ShowDialog();
        }

        private void funcionarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_cadFunc cadFunc = new frm_cadFunc();
            cadFunc.ShowDialog();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cadastrar um cliente antes?", "Cadastrar um cliente?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frm_cadCli cadCli = new frm_cadCli();
                cadCli.ShowDialog();
            }

            else
            {
                frm_consultOrc orcNovo = new frm_consultOrc();
                orcNovo.ShowDialog();
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadCli cadCli = new frm_cadCli();
            cadCli.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_consultOrc orcNovo= new frm_consultOrc();
            orcNovo.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadLgn cadLgn = new frm_cadLgn();
            cadLgn.ShowDialog();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"Chrome.exe", "https://web.whatsapp.com/send?phone=5511984062207");
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
