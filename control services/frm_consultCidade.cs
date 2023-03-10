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
    public partial class frm_consultCidade : Form
    {
        public frm_consultCidade()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_consultCidade_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.batevolta_dd64L'. Você pode movê-la ou removê-la conforme necessário.
            this.batevolta_dd64LTableAdapter.Fill(this.glturfreDeployDataSet.batevolta_dd64L);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.batevolta_dd64LTableAdapter.FillByBateVolta_DD64(this.glturfreDeployDataSet.batevolta_dd64L, textBox1.Text);
        }
    }
}
