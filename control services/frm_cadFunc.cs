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
    public partial class frm_cadFunc : Form
    {
        public frm_cadFunc()
        {
            InitializeComponent();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tabControl1.Enabled == true)
            {
                
            }

            if ( chkbx_UmDep.Checked == true )
            {
                chkbx_DoisDep.Enabled = false;
                chkbx_TresDep.Enabled = false;
            }

            else if (chkbx_DoisDep.Checked == true)
            {
                chkbx_UmDep.Enabled = false;
                chkbx_TresDep.Enabled = false;
            }

            else if (chkbx_TresDep.Checked == true)
            {
                chkbx_UmDep.Enabled = false;
                chkbx_DoisDep.Enabled = false;
            }

            else
            {
                chkbx_UmDep.Enabled = true;
                chkbx_DoisDep.Enabled = true;
                chkbx_TresDep.Enabled = true;
            }
        }

        private void frm_cadFunc_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.cad_login'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_loginTableAdapter.Fill(this.glturfreDeployDataSet.cad_login);
            // TODO: esta linha de código carrega dados na tabela 'glturfreDeployDataSet.cad_fun'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_funTableAdapter.Fill(this.glturfreDeployDataSet.cad_fun);

        }

        private void group_DadosPessoais_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (msktxtbx_cpf.Text == "" && txtbx_nome.Text == "") 
            {
                MessageBox.Show("O campo NOME precisa ser preenchido\nO campo CPF precisa ser preenchido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (msktxtbx_cpf.Text == "")
            {
                MessageBox.Show("O campo CPF precisa ser preenchido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtbx_nome.Text == "")
            {
                MessageBox.Show("O campo NOME precisa ser preenchido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                this.Validate();
                this.cadfunBindingSource.EndEdit();
                this.cad_loginBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.glturfreDeployDataSet);
                MessageBox.Show("Funcionario Cadastrado com Sucesso", "Sucesso", MessageBoxButtons.OK);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadfunBindingSource.AddNew();
            tabControl1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_consult_cadFunc consult_CadFunc = new frm_consult_cadFunc();
            consult_CadFunc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.Enabled == true)
            {
                if(MessageBox.Show("Deseja realmente sair?\nDados nao salvos serao perdidos", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                }
            }

            else
            {
                this.Close();
            }
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timersnh_Tick(object sender, EventArgs e)
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
    }
}
