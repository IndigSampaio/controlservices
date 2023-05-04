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
    public partial class frm_escala2 : Form
    {
        public frm_escala2()
        {
            InitializeComponent();
        }

        private void frm_escala2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.motorista'. Você pode movê-la ou removê-la conforme necessário.
            this.motoristaTableAdapter.Fill(this.gldturfreDeployDataSet.motorista);
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.categ_veiculo'. Você pode movê-la ou removê-la conforme necessário.
            this.categ_veiculoTableAdapter.Fill(this.gldturfreDeployDataSet.categ_veiculo);
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.veiculo'. Você pode movê-la ou removê-la conforme necessário.
            this.veiculoTableAdapter.Fill(this.gldturfreDeployDataSet.veiculo);
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.viagem_fechada'. Você pode movê-la ou removê-la conforme necessário.
            this.viagem_fechadaTableAdapter.Fill(this.gldturfreDeployDataSet.viagem_fechada);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {        

           
        }

        private void veiculoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.veiculoTableAdapter.FillByCategVeiculo_Disponivel(this.gldturfreDeployDataSet.veiculo, categ_veiculoLabel1.Text);
        }

        private void fillByCategVeiculo_DisponivelToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
