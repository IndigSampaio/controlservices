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
    public partial class frm_calendario : Form
    {
        public frm_calendario()
        {
            InitializeComponent();
        }

        private void viagem_fechadaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            /*
            this.Validate();
            this.viagem_fechadaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gldturfreDeployDataSet);
            */

        }

        private void viagem_fechadaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }

        private void frm_calendario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.viagem_fechada'. Você pode movê-la ou removê-la conforme necessário.
            this.viagem_fechadaTableAdapter.Fill(this.gldturfreDeployDataSet.viagem_fechada);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
