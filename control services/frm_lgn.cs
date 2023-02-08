﻿using System;
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
            // TODO: esta linha de código carrega dados na tabela 'gldturDataSet.tst_lgn'. Você pode movê-la ou removê-la conforme necessário.
            this.tst_lgnTableAdapter.Fill(this.gldturDataSet.tst_lgn);
            // TODO: esta linha de código carrega dados na tabela 'gldturDataSet.usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.gldturDataSet.usuarios);

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
            //  int result = usuariosTableAdapter.FillByLgnFunc(gldturDataSet.usuarios, txtbx_lgn.Text, txtbx_snh.Text);
            int result = tst_lgnTableAdapter.FillByLgnUser(gldturDataSet.tst_lgn, txtbx_lgn.Text, txtbx_snh.Text);

            if (result == 1)
            {
                frm_menu menu = new frm_menu();
                this.Visible = false;
                menu.ShowDialog();
            }

            else if (cont <= 3 )
            {
                cont = cont - 1;
                MessageBox.Show("Usuario ou senha incorreto!\n Tentativas restante: " + cont , "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
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

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gldturDataSet);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void usuariosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
