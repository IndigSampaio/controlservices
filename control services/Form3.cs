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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void teste_dataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teste_dataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gldturfreDeployDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.teste_data'. Você pode movê-la ou removê-la conforme necessário.
            //this.teste_dataTableAdapter.Fill(this.gldturfreDeployDataSet.teste_data);

        }
    }
}
