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
    public partial class frm_novo_orcamento : Form
    {
        public frm_novo_orcamento()
        {
            InitializeComponent();
        }

        private void batevolta_dd64LBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.batevolta_dd64LBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glturfreDeployDataSet);
            MessageBox.Show("Contato salvo com sucesso", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void frm_novo_orcamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.batevolta_dd64L'. Você pode movê-la ou removê-la conforme necessário.
            this.batevolta_dd64LTableAdapter.Fill(this.glturfreDeployDataSet.batevolta_dd64L);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
