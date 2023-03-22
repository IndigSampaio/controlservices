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
    public partial class frm_escala : Form
    {
        public frm_escala()
        {
            InitializeComponent();
        }

        private void viagem_fechadaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.viagem_fechadaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gldturfreDeployDataSet);

        }

        private void frm_escala_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.viagem_fechada'. Você pode movê-la ou removê-la conforme necessário.
            this.viagem_fechadaTableAdapter.Fill(this.gldturfreDeployDataSet.viagem_fechada);

        }

        private void viagem_fechadaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByCategVeiculo_DisponivelToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.veiculoTableAdapter.FillByCategVeiculo_Disponivel(this.gldturfreDeployDataSet.veiculo, param1ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
