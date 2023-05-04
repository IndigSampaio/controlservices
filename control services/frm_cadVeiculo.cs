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
    public partial class frm_cadVeiculo : Form
    {
        public frm_cadVeiculo()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_CatVeiculo.Enabled == true)
                {
                    if (cmb_CatVeiculo.Text != "" && txtbx_Placa.Text != "" && txtbx_PrefixoVeiculo.Text != "")
                    {
                        this.Validate();
                        this.veiculoBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.gldturfreDeployDataSet);

                        MessageBox.Show("Registro salvo com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        cmb_CatVeiculo.Text = null;
                        cmb_CatVeiculo.Enabled = false;

                        txtbx_Placa.Text = null;
                        txtbx_Placa.Enabled = false;

                        txtbx_PrefixoVeiculo.Text = null;
                        txtbx_PrefixoVeiculo.Enabled = false;

                        chkbx_Ativo.Checked = false;
                        chkbx_Ativo.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Preencha os campos vazios para finalizar o registro", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //------------------------------------------------------------
                        // Esse bloco serve para alertar o usuario que o combo box não foi selecionado
                        if (cmb_CatVeiculo.Text == "")
                        {
                            cmb_CatVeiculo.BackColor = Color.Red;
                        }

                        else
                        {
                            cmb_CatVeiculo.BackColor = Color.White;
                        }

                        //------------------------------------------------------------
                        // Esse bloco serve para informar o usuario que o txtbx Placa não foi preenchido

                        if (txtbx_Placa.Text == "")
                        {
                            txtbx_Placa.BackColor = Color.Red;
                        }

                        else
                        {
                            txtbx_Placa.BackColor = Color.White;
                        }

                        //------------------------------------------------------------
                        // Esse bloco serve para informar o usuario que o txtbx Prefixo não foi preenchido

                        if(txtbx_PrefixoVeiculo.Text == "")
                        {
                            txtbx_PrefixoVeiculo.BackColor = Color.Red;
                        }

                        else
                        {
                            txtbx_PrefixoVeiculo.BackColor = Color.White;
                        }


                    }
                }
                else
                {
                    MessageBox.Show("Inicie um novo registro para poder salvar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar o registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void veiculoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_cadVeiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.categ_veiculo'. Você pode movê-la ou removê-la conforme necessário.
            this.categ_veiculoTableAdapter.Fill(this.gldturfreDeployDataSet.categ_veiculo);
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.veiculo'. Você pode movê-la ou removê-la conforme necessário.
            this.veiculoTableAdapter.Fill(this.gldturfreDeployDataSet.veiculo);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (cmb_CatVeiculo.Enabled == false)
            {
                this.Validate();
                this.veiculoBindingSource.AddNew();

                //----------------------------------------------
                //Apartir deste ponto, os campos de cadastro ficam ativos, lembrando que só pode ser liberado, caso eles estejam desativodos, do contrario, bloqueia e notifica o erro ao usuario
                cmb_CatVeiculo.Enabled = true;
                txtbx_Placa.Enabled = true;
                txtbx_PrefixoVeiculo.Enabled = true;
                chkbx_Ativo.Enabled = true;
            }

            else
            {
                MessageBox.Show("É necessario finalizar o atual cadastro, ants de iniciar um novo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(cmb_CatVeiculo.Enabled == true)
            {
                if(MessageBox.Show("DESEJA REALMENTE SAIR? \n\nO registro não salvo sera perdido", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                }
            }

            else
            {
                this.Close();
            }
        }
    }
}
