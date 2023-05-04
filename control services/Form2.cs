using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace control_services
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int quantDias, conta, diaria_onibus = 500, diaria_micro = 400, diaria_van = 300;
        string resultado;
        double km_ida, km_volta, km_total, valor_calc;
        string data_partida, data_retorno;

        string connectionString = "Data Source=mssql-115648-0.cloudclusters.net,10046; Initial Catalog=gldturfreDeploy;User ID=PedroSampaio;Password=DanielePedro1!";



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (msktxbx_CpfCnpj.Enabled == true)
            {
                MessageBox.Show("Para adicionar um novo registro, é necessario finalizar o atual", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                msktxbx_CpfCnpj.Enabled = true;
                cmbbx_mask_CpfCnpj.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (msktxbx_CpfCnpj.Enabled == true)
            {
                if (MessageBox.Show("Deseja realmente sair?\nRegistro não salvos serão perdidos", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    this.Close();
                }
            }

            else
            {
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.cad_cli'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_cliTableAdapter.Fill(this.gldturfreDeployDataSet.cad_cli);
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.orcamento'. Você pode movê-la ou removê-la conforme necessário.
            this.orcamentoTableAdapter.Fill(this.gldturfreDeployDataSet.orcamento);
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.tabela_FimSem'. Você pode movê-la ou removê-la conforme necessário.
            this.tabela_FimSemTableAdapter.Fill(this.gldturfreDeployDataSet.tabela_FimSem);
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.tabela_BateVolta'. Você pode movê-la ou removê-la conforme necessário.
            this.tabela_BateVoltaTableAdapter.Fill(this.gldturfreDeployDataSet.tabela_BateVolta);
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.tabela_FerPro'. Você pode movê-la ou removê-la conforme necessário.
            this.tabela_FerProTableAdapter.Fill(this.gldturfreDeployDataSet.tabela_FerPro);
        }

        private void btn_SelecionarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnOrc_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void ContagemDias_Tick(object sender, EventArgs e)
        {
            dtp_DataPartida.MinDate = DateTime.Now;
            dtp_DataRetorno.MinDate = DateTime.Now;



            DateTime dataPartida = dtp_DataPartida.Value;

            DateTime dataVolta = dtp_DataRetorno.Value;

            TimeSpan diferenca = dataVolta.Subtract(dataPartida);

            quantDias = diferenca.Days;

            conta = quantDias + 1;

            resultado = Convert.ToString(conta);

            lbl_quantosDias.Text = resultado;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(cmbbx_mask_CpfCnpj.Text == "CPF")
            {
                msktxbx_CpfCnpj.Enabled = true;
                msktxbx_CpfCnpj.Mask = "999,999,999-99";
            }

            else if (cmbbx_mask_CpfCnpj.Text == "CNPJ")
            {
                msktxbx_CpfCnpj.Enabled = true;
                msktxbx_CpfCnpj.Mask = "99,999,999/9999-99";
            }

            else
            {   
                msktxbx_CpfCnpj.Enabled = false;
            }
        }

        private void timer_ConsultaCliente_Tick(object sender, EventArgs e)
        {
            this.cad_cliTableAdapter.FillByConsultaCpfCnpj(this.gldturfreDeployDataSet.cad_cli, msktxbx_CpfCnpj.Text);
            lbl_NomeCliente.Text = nome_razao_socialTextBox.Text;
            lbl_telCli.Text = telefoneTextBox.Text;
        }

        private void timer_Dentro_ForaTabela_Tick(object sender, EventArgs e)
        {
            if(cmb_DentroForaTabela.Text == "Tabela")
            {
                cmb_PartidaDentroTabela.Visible = true;
                txtbx_partida.Visible = false;
                lbl_partida.Visible = false;
                btn_ConsultDistancia.Visible = false;
                timer_foraTabela.Enabled = false;
                timer_dentroTabela.Enabled = true;
                //-----------------------------------------------------------------
                lbl_kmIda.Visible = false;
                txtbx_kmIda.Visible = false;
                lbl_kmVolta.Visible = false;
                txtbx_kmVolta.Visible = false;
                lbl_totalContaKM.Visible = false;
                lbl_totalKm.Visible = false;

                if(progressBar1.Value == 100)
                {
                    progressBar1.Value = 0;
                }
                else
                {
                    progressBar1.Value = progressBar1.Value + 2;
                }
            }
            else if (cmb_DentroForaTabela.Text == "Fora da Tabela")
            {
                cmb_PartidaDentroTabela.Visible = false;
                txtbx_partida.Visible = true;
                lbl_partida.Visible = true;
                btn_ConsultDistancia.Visible = true;
                timer_foraTabela.Enabled = true;
                timer_dentroTabela.Enabled = false;
                //-----------------------------------------------------------------
                lbl_kmIda.Visible = true;
                txtbx_kmIda.Visible = true;
                lbl_kmVolta.Visible = true;
                txtbx_kmVolta.Visible = true;
                lbl_totalContaKM.Visible = true;
                lbl_totalKm.Visible = true;

                if(progressBar2.Value == 100)
                {
                    progressBar2.Value = 0;
                }
                else
                {
                    progressBar2.Value = progressBar2.Value + 2;
                }
            }
            else
            {
                cmb_PartidaDentroTabela.Visible = false;
                txtbx_partida.Visible = false;
                lbl_partida.Visible = false;
                btn_ConsultDistancia.Visible = false;
                timer_foraTabela.Enabled = false;
                timer_dentroTabela.Enabled = false;
                //-----------------------------------------------------------------
                lbl_kmIda.Visible = false;
                txtbx_kmIda.Visible = false;
                lbl_kmVolta.Visible = false;
                txtbx_kmVolta.Visible = false;
                lbl_totalContaKM.Visible = false;
                lbl_totalKm.Visible = false;

            }
        }

        private void btn_ConsultDistancia_Click(object sender, EventArgs e)
        {
            frm_consultDistancia consultDistancia = new frm_consultDistancia();
            consultDistancia.Show();
        }

        private void tabela_BateVoltaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabela_BateVoltaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gldturfreDeployDataSet);

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(connectionString);
            string instrucaoSQL = "INSERT INTO orcamento (id_orcamento, id_str, nome_cliente, cpf_cnpj_cliente, tel_cliente, valor, categ_veiculo, partida, data_partida, hora_partida, destino, data_retorno, horario_retorno, embarque_um, horario_embarque_um, embarque_dois, horario_embarque_dois, embarque_tres, horario_embarque_tres, embarque_quatro, horario_embarque_quatro, embarque_cinco, horario_embarque_cinco, roteiro_dia_um_data, roteiro_dia_um_roteiro, roteiro_dia_um_horario, roteiro_dia_dois_data, roteiro_dia_dois_roteiro, roteiro_dia_dois_horario, roteiro_dia_tres_data, roteiro_dia_tres_roteiro, roteiro_dia_tres_horario, roteiro_dia_quatro_data, roteiro_dia_quatro_roteiro, roteiro_dia_quatro_horario, roteiro_dia_cinco_data, roteiro_dia_cinco_roteiro, roteiro_dia_cinco_horario) " +
                "VALUES  " +
                "(@valor2, @valor3, @valor4, @valor5, @valor6, @valor8, @valor10, @valor11, @valor12, @valor13, @valor14, @valor15, @valor16, @valor17, @valor18, @valor19, @valor20, @valor21, @valor22, @valor23, @valor24, @valor25, @valor26, @valor27, @valor28, @valor29, @valor30, @valor31, @valor32, @valor33, @valor34, @valor35, @valor36, @valor37, @valor38, @valor39, @valor40)";
                

            DateTime data_partida = dtp_DataPartida.Value;
            string data_partidaString = data_partida.ToString("dd-MM-yyyy;");
            
            SqlCommand comando = new SqlCommand(instrucaoSQL, conexao);

            lbl_idOrc.Text = id_orcamentoLabel1.Text;

            
            comando.Parameters.AddWithValue("@valor2", lbl_idOrc.Text); //id do orçamento em string
            comando.Parameters.AddWithValue("@valor3", lbl_NomeCliente.Text); // nome do cliente
            comando.Parameters.AddWithValue("@valor4", msktxbx_CpfCnpj.Text); // cpf ou cnpj do clinte
            comando.Parameters.AddWithValue("@valor5", lbl_telCli.Text); // telefone do cliente
            comando.Parameters.AddWithValue("@valor6", lbl_valorTabela.Text); // valor da viagem
            comando.Parameters.AddWithValue("@valor8", cmbbx_Categoria.Text); //categoria do veiculo
            
            
            //------------------------------------------------------------------------

            //esse bloco define se vai salvar a partida de dentro ou de fora da tabela



            if (cmb_DentroForaTabela.Text == "Tabela")
            {
                comando.Parameters.AddWithValue("@valor10", cmb_PartidaDentroTabela.Text);
            }

            else if (cmb_PartidaDentroTabela.Text == "Fora da Tabela")
            {
                comando.Parameters.AddWithValue("@valor10", txtbx_partida.Text);
            }


            
            //-----------------------------------------------------------------------


            
            comando.Parameters.AddWithValue("@valor11", data_partidaString); // data de partida da viagem
            comando.Parameters.AddWithValue("@valor12", dtp_HoraPartida.Text); // hora de partida da viagem
            comando.Parameters.AddWithValue("@valor13", txtbx_Destino.Text); // destino da viagem
            comando.Parameters.AddWithValue("@valor14", dtp_DataRetorno); // data de retorno
            comando.Parameters.AddWithValue("@valor15", dtp_HoraRetorno); // horario de retorno
            comando.Parameters.AddWithValue("@valor16", txtbx_embarque1); // local do primeiro embarque
            comando.Parameters.AddWithValue("@valor17", msktxbx_Embarque1); // horario do primeiro embarque
            comando.Parameters.AddWithValue("@valor18", txtbx_embarque2); // local do segundo embarque
            comando.Parameters.AddWithValue("@valor19", msktxbx_Embarque2); // horario do segundo embarque
            comando.Parameters.AddWithValue("@valor20", txtbx_embarque3); // local do terceiro embarque
            comando.Parameters.AddWithValue("@valor21", msktxbx_Embarque3); // horario do terceiro embarque
            comando.Parameters.AddWithValue("@valor22", txtbx_embarque4);  // local do quarto embarque
            comando.Parameters.AddWithValue("@valor23", msktxbx_Embarque4); // horario do quarto embarque
            comando.Parameters.AddWithValue("@valor24", txtbx_embarque5); // local do quinto embarque
            comando.Parameters.AddWithValue("@valor25", msktxbx_Embarque5); // horario do quinto embarque
            comando.Parameters.AddWithValue("@valor26", maskedTextBox5); // data do primeiro roteiro
            comando.Parameters.AddWithValue("@valor27", txtbx_localRoteiro1); // local do primeiro roteiro
            comando.Parameters.AddWithValue("@valor28", maskedTextBox6); // horario do primeiro roteiro
            comando.Parameters.AddWithValue("@valor29", maskedTextBox4); // data do segundo roteiro
            comando.Parameters.AddWithValue("@valor30", txtbx_localRoteiro2); // local do segundo roteiro
            comando.Parameters.AddWithValue("@valor31", maskedTextBox7); // horario do segundo roteiro
            comando.Parameters.AddWithValue("@valor32", maskedTextBox3); // data do terceiro roteiro
            comando.Parameters.AddWithValue("@valor33", txtbx_localRoteiro3); // local do terceiro roteiro
            comando.Parameters.AddWithValue("@valor34", maskedTextBox8); //horario do terceiro roteiro
            comando.Parameters.AddWithValue("@valor35", maskedTextBox2); // data do quarto roteiro
            comando.Parameters.AddWithValue("@valor36", txtbx_localRoteiro4); // local do quarto roteiro
            comando.Parameters.AddWithValue("@valor37", maskedTextBox9); // horario do quarto roteiro
            comando.Parameters.AddWithValue("@valor38", maskedTextBox1); // data do quinto roteiro
            comando.Parameters.AddWithValue("@valor39", txtbx_localRoteiro5); // local do quinto roteiro
            comando.Parameters.AddWithValue("@valor40", maskedTextBox10); // horario do quinto embarque
            
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Orçamento salvo com sucesso!");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao inserir o registro: " + ex.Message);
            }
            finally
            {
                conexao.Close();
                comando.Dispose();
            }

        }   

        private void btnAdd_Click_1(object sender, EventArgs e)
        {   
            if (msktxbx_CpfCnpj.Enabled == false)
            {
                this.Validate();
                this.orcamentoBindingSource.AddNew();
                this.tableAdapterManager.UpdateAll(this.gldturfreDeployDataSet);

                cmbbx_mask_CpfCnpj.Enabled = true;
                msktxbx_CpfCnpj.Enabled = true;
            }

            else
            {
                MessageBox.Show("Para começar um novo orçamento, é necessario finalizar o atual", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void v_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_cadCli cadCli = new frm_cadCli();
            cadCli.Show();
        }

        private void timer_foraTabela_Tick_1(object sender, EventArgs e)
        {
            if (txtbx_kmIda.Text == "" && txtbx_kmVolta.Text == "")
            {
                lbl_totalKm.Text = "";
                lbl_valorTabela.Text = "";
            }

            else if (txtbx_kmVolta.Text == "")
            {
                km_ida = Convert.ToDouble(txtbx_kmIda.Text);
                km_total = km_ida * 2;
                lbl_totalKm.Text = Convert.ToString(km_total);
            }

            else if (txtbx_kmIda.Text == "")
            {
                km_volta = Convert.ToDouble(txtbx_kmVolta.Text);
                km_total = km_volta * 2;
                lbl_totalKm.Text = Convert.ToString(km_total);
            }   

            else
            {
                km_ida = Convert.ToDouble(txtbx_kmIda.Text);
                km_volta = Convert.ToDouble(txtbx_kmVolta.Text);
                km_total = km_ida + km_volta;
                lbl_totalKm.Text = Convert.ToString(km_total);
            }

            switch (cmbbx_Categoria.Text)
            {
                case "DD 64L":
                    if (km_total <= 30)
                    {
                        valor_calc = (km_total * 60) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 31 && km_total <= 50)
                    {
                        valor_calc = (km_total * 40) + (conta * diaria_onibus);

                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 51 && km_total <= 75)
                    {
                        valor_calc = (km_total * 30) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 76 && km_total <= 100)
                    {
                        valor_calc = (km_total * 27) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 101 && km_total <= 125)
                    {
                        valor_calc = (km_total * 22) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 126 && km_total <= 150)
                    {
                        valor_calc = (km_total * 16) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 151 && km_total <= 175)
                    {
                        valor_calc = (km_total * 14.5) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }
    
                    else if (km_total >= 176 && km_total <= 200)
                    {
                        valor_calc = (km_total * 12.5) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 201 && km_total <= 250)
                    {
                        valor_calc = (km_total * 12.5) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 251 && km_total <= 300)
                    {
                        valor_calc = (km_total * 10) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 301 && km_total <= 400)
                    {
                        valor_calc = (km_total * 9.5) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 400)
                    {
                        valor_calc = (km_total * 9) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else
                    {
                        lbl_valorTabela.Text = "";
                    }


                    break;

                case "DD 60L":

                    if (km_total <= 30)
                    {
                        valor_calc = (km_total * 55) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 31 && km_total <= 50)
                    {
                        valor_calc = (km_total * 38) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 51 && km_total <= 75)
                    {
                        valor_calc = (km_total * 27) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 76 && km_total <= 100)
                    {
                        valor_calc = (km_total * 25) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 101 && km_total <= 125)
                    {
                        valor_calc = (km_total * 20) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 126 && km_total <= 150)
                    {
                        valor_calc = (km_total * 14) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 151 && km_total <= 175)
                    {
                        valor_calc = (km_total * 12.5) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 176 && km_total <= 200)
                    {
                        valor_calc = (km_total * 12) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 201 && km_total <= 250)
                    {
                        valor_calc = (km_total * 12) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 251 && km_total <= 300)
                    {
                        valor_calc = (km_total * 9.5) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 301 && km_total <= 400)
                    {
                        valor_calc = (km_total * 9) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 400)
                    {
                        valor_calc = (km_total * 8.5) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else
                    {
                        lbl_valorTabela.Text = "";
                    }

                    break;

                case "SEMI 46L":
                    if (km_total <= 30)
                    {
                        valor_calc = (km_total * 50) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 31 && km_total <= 50)
                    {
                        valor_calc = (km_total * 30) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 51 && km_total <= 75)
                    {
                        valor_calc = (km_total * 25) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 76 && km_total <= 100)
                    {
                        valor_calc = (km_total * 23) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 101 && km_total <= 125)
                    {
                        valor_calc = (km_total * 17) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 126 && km_total <= 150)
                    {
                        valor_calc = (km_total * 13) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 151 && km_total <= 175)
                    {
                        valor_calc = (km_total * 11) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 176 && km_total <= 200)
                    {
                        valor_calc = (km_total * 11.5) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 201 && km_total <= 250)
                    {
                        valor_calc = (km_total * 11.5) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 251 && km_total <= 300)
                    {
                        valor_calc = (km_total * 9) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 301 && km_total <= 400)
                    {
                        valor_calc = (km_total * 8.5) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 400)
                    {
                        valor_calc = (km_total * 8) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else
                    {
                        lbl_valorTabela.Text = "";
                    }
                    break;

                case "EXEC 50L":
                    if (km_total <= 30)
                    {
                        valor_calc = (km_total * 43) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 31 && km_total <= 50)
                    {
                        valor_calc = (km_total * 27) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 51 && km_total <= 75)
                    {
                        valor_calc = (km_total * 23) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 76 && km_total <= 100)
                    {
                        valor_calc = (km_total * 20) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 101 && km_total <= 125)
                    {
                        valor_calc = (km_total * 15) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 126 && km_total <= 150)
                    {
                        valor_calc = (km_total * 12.5) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 151 && km_total <= 175)
                    {
                        valor_calc = (km_total * 10.5) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 176 && km_total <= 200)
                    {
                        valor_calc = (km_total * 11) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 201 && km_total <= 250)
                    {
                        valor_calc = (km_total * 11) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 251 && km_total <= 300)
                    {
                        valor_calc = (km_total * 8.5) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 301 && km_total <= 400)
                    {
                        valor_calc = (km_total * 8) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 400)
                    {
                        valor_calc = (km_total * 7.5) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else
                    {
                        lbl_valorTabela.Text = "";
                    }
                    break;

                case "EXEC 46L":
                    if (km_total <= 30)
                    {
                        valor_calc = (km_total * 40) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 31 && km_total <= 50)
                    {
                        valor_calc = (km_total * 25) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 51 && km_total <= 75)
                    {
                        valor_calc = (km_total * 20) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 76 && km_total <= 100)
                    {
                        valor_calc = (km_total * 18) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 101 && km_total <= 125)
                    {
                        valor_calc = (km_total * 14) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 126 && km_total <= 150)
                    {
                        valor_calc = (km_total * 12) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 151 && km_total <= 175)
                    {
                        valor_calc = (km_total * 10) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 176 && km_total <= 200)
                    {
                        valor_calc = (km_total * 10) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 201 && km_total <= 250)
                    {
                        valor_calc = (km_total * 10) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 251 && km_total <= 300)
                    {
                        valor_calc = (km_total * 8) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 301 && km_total <= 400)
                    {
                        valor_calc = (km_total * 7.5) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 400)
                    {
                        valor_calc = (km_total * 7) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else
                    {
                        lbl_valorTabela.Text = "";
                    }
                    break;

                case "CONV 47L":
                    if (km_total <= 30)
                    {
                        valor_calc = (km_total * 35) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 31 && km_total <= 50)
                    {
                        valor_calc = (km_total * 22) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 51 && km_total <= 75)
                    {
                        valor_calc = (km_total * 18) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 76 && km_total <= 100)
                    {
                        valor_calc = (km_total * 15) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 101 && km_total <= 125)
                    {
                        valor_calc = (km_total * 12) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 126 && km_total <= 150)
                    {
                        valor_calc = (km_total * 11) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 151 && km_total <= 175)
                    {
                        valor_calc = (km_total * 9) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 176 && km_total <= 200)
                    {
                        valor_calc = (km_total * 9) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 201 && km_total <= 250)
                    {
                        valor_calc = (km_total * 9) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 251 && km_total <= 300)
                    {
                        valor_calc = (km_total * 7.5) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 301 && km_total <= 400)
                    {
                        valor_calc = (km_total * 7) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 400)
                    {
                        valor_calc = (km_total * 6.5) + (conta * diaria_onibus);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else
                    {
                        lbl_valorTabela.Text = "";
                    }
                    break;

                case "MICRO 32L":

                    if (km_total <= 30)
                    {
                        valor_calc = (km_total * 30) + (conta * diaria_micro);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 31 && km_total <= 50)
                    {
                        valor_calc = (km_total * 20) + (conta * diaria_micro);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 51 && km_total <= 75)
                    {
                        valor_calc = (km_total * 14) + (conta * diaria_micro);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 76 && km_total <= 100)
                    {
                        valor_calc = (km_total * 12) + (conta * diaria_micro);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 101 && km_total <= 125)
                    {
                        valor_calc = (km_total * 10) + (conta * diaria_micro);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 126 && km_total <= 150)
                    {
                        valor_calc = (km_total * 9) + (conta * diaria_micro);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 151 && km_total <= 175)
                    {
                        valor_calc = (km_total * 8) + (conta * diaria_micro);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 176 && km_total <= 200)
                    {
                        valor_calc = (km_total * 8) + (conta * diaria_micro);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 201 && km_total <= 250)
                    {
                        valor_calc = (km_total * 7.5) + (conta * diaria_micro);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 251 && km_total <= 300)
                    {
                        valor_calc = (km_total * 6.5) + (conta * diaria_micro);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 301 && km_total <= 400)
                    {
                        valor_calc = (km_total * 6) + (conta * diaria_micro);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 400)
                    {
                        valor_calc = (km_total * 5) + (conta * diaria_micro);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else
                    {
                        lbl_valorTabela.Text = "";
                    }
                    break;

                case "VAN 18L":
                    if (km_total <= 30)
                    {
                        valor_calc = (km_total * 18) + (conta * diaria_van);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 31 && km_total <= 50)
                    {
                        valor_calc = (km_total * 15) + (conta * diaria_van);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 51 && km_total <= 75)
                    {
                        valor_calc = (km_total * 10) + (conta * diaria_van);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 76 && km_total <= 100)
                    {
                        valor_calc = (km_total * 8) + (conta * diaria_van);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 101 && km_total <= 125)
                    {
                        valor_calc = (km_total * 7) + (conta * diaria_van);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 126 && km_total <= 150)
                    {
                        valor_calc = (km_total * 6) + (conta * diaria_van);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 151 && km_total <= 175)
                    {
                        valor_calc = (km_total * 5.5) + (conta * diaria_van);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 176 && km_total <= 200)
                    {
                        valor_calc = (km_total * 5.5) + (conta * diaria_van);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 201 && km_total <= 250)
                    {
                        valor_calc = (km_total * 5.5) + (conta * diaria_van);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 251 && km_total <= 300)
                    {
                        valor_calc = (km_total * 5) + (conta * diaria_van);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 301 && km_total <= 400)
                    {
                        valor_calc = (km_total * 4.8) + (conta * diaria_van);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else if (km_total >= 400)
                    {
                        valor_calc = (km_total * 4) + (conta * diaria_van);
                        lbl_valorTabela.Text = Convert.ToString(valor_calc) + ",00";
                    }

                    else
                    {
                        lbl_valorTabela.Text = "";
                    }
                    break;  

            }
        }

        private void btnOrc_Click_1(object sender, EventArgs e)
        {
            string dirSalvar;
            SaveFileDialog sfdSalvar2 = new SaveFileDialog();
            sfdSalvar2.Title = "Salvar Documento";
            sfdSalvar2.Filter = "TXT (.txt) | *.txt | PDF (.pdf) |*.pdf";
            sfdSalvar2.FilterIndex = 1;
            sfdSalvar2.RestoreDirectory = true;

            if (cmbbx_mask_CpfCnpj.Enabled == false)
            {

                if (cmb_DentroForaTabela.Text == "Fora da Tabela")
                {
                    if (sfdSalvar2.ShowDialog() == DialogResult.OK)
                    {
                        dirSalvar = sfdSalvar2.FileName;
                        StreamWriter sr = new StreamWriter(dirSalvar);

                        sr.WriteLine("Segue seu orçamento baseado nos dados enviados:");
                        sr.WriteLine("Data de ida: " + dtp_DataPartida.Text);
                        sr.WriteLine("Horario: " + dtp_HoraPartida.Text);
                        sr.WriteLine("Data de retorno: " + dtp_DataRetorno.Text);
                        sr.WriteLine("Horario: " + dtp_HoraRetorno.Text);
                        sr.WriteLine("");
                        sr.WriteLine("Locais de embarque: " + txtbx_partida.Text);
                        sr.WriteLine("");
                        sr.WriteLine("Local 1° embarque: " + txtbx_embarque1.Text);
                        sr.WriteLine("Horario 1° embarque: " + msktxbx_Embarque1.Text);
                        sr.WriteLine("Local 2° embarque: " + txtbx_embarque2.Text);
                        sr.WriteLine("Horario 2° embarque: " + msktxbx_Embarque2.Text);
                        sr.WriteLine("Local 3° embarque: " + txtbx_embarque3.Text);
                        sr.WriteLine("Horario 3° embarque: " + msktxbx_Embarque3.Text);
                        sr.WriteLine("Local 4° embarque: " + txtbx_embarque4.Text);
                        sr.WriteLine("Horario 4° embarque: " + msktxbx_Embarque4.Text);
                        sr.WriteLine("Local 5° embarque: " + txtbx_embarque5.Text);
                        sr.WriteLine("Horario 5° embarque: " + msktxbx_Embarque5.Text);
                        sr.WriteLine("");
                        sr.WriteLine("Destino: " + txtbx_Destino.Text);
                        sr.WriteLine("");
                        sr.WriteLine("City Tour / Passeios: ");
                        sr.WriteLine("");
                        sr.WriteLine("Roteiro do Dia 1: " + txtbx_localRoteiro1.Text);
                        sr.WriteLine("");
                        sr.WriteLine("Roteiro do Dia 2: " + txtbx_localRoteiro2.Text);
                        sr.WriteLine("");
                        sr.WriteLine("Roteiro do Dia 3: " + txtbx_localRoteiro3.Text);
                        sr.WriteLine("");
                        sr.WriteLine("Roteiro do Dia 4: " + txtbx_localRoteiro4.Text);
                        sr.WriteLine("");
                        sr.WriteLine("Roteiro do Dia 5: " + txtbx_localRoteiro5.Text);
                        sr.WriteLine("");
                        sr.WriteLine("Valor R$ " + lbl_valorTabela.Text);
                        sr.WriteLine("");
                        sr.WriteLine("🚨 ATENÇÃO 🚨");
                        sr.WriteLine("Orçamento com validade de 30 dias sujeito a alteração caso haja mudança no valor do diesel ou outras despesas da viagem.");
                        sr.WriteLine("Pedido de orçamento não é válido como viagem fechada, reserva será efetivada somente após assinatura do contrato mediante a apresentação do comprovante de sinal de 10%.");
                        sr.WriteLine("");
                        sr.WriteLine("🚨 ATENÇÃO 🚨");
                        sr.WriteLine("");
                        sr.WriteLine("Em algumas cidades, principalmente no litoral, é necessário autorização de entrada, é por conta do contratante fazer o pedido e a retirada da autorização. Pedimos que antes de fechar o serviço conosco entre em contato com a prefeitura da cidade de destino da viagem para que se informe sobre o assunto. ");
                        sr.WriteLine("");
                        sr.WriteLine("Qualquer dúvida estou a disposição ☺");
                        sr.WriteLine("");
                        sr.WriteLine("");

                        sr.Close();

                    }
                }

                else if (cmb_DentroForaTabela.Text == "Tabela")
                {
                    dirSalvar = sfdSalvar2.FileName;
                    StreamWriter sr = new StreamWriter(dirSalvar);

                    sr.WriteLine("Segue seu orçamento baseado nos dados enviados:");
                    sr.WriteLine("Data de ida: " + dtp_DataPartida.Text);
                    sr.WriteLine("Horario: " + dtp_HoraPartida.Text);
                    sr.WriteLine("Data de retorno: " + dtp_DataRetorno.Text);
                    sr.WriteLine("Horario: " + dtp_HoraRetorno.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Locais de embarque: " + cmb_PartidaDentroTabela.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Local 1° embarque: " + txtbx_embarque1.Text);
                    sr.WriteLine("Horario 1° embarque: " + msktxbx_Embarque1.Text);
                    sr.WriteLine("Local 2° embarque: " + txtbx_embarque2.Text);
                    sr.WriteLine("Horario 2° embarque: " + msktxbx_Embarque2.Text);
                    sr.WriteLine("Local 3° embarque: " + txtbx_embarque3.Text);
                    sr.WriteLine("Horario 3° embarque: " + msktxbx_Embarque3.Text);
                    sr.WriteLine("Local 4° embarque: " + txtbx_embarque4.Text);
                    sr.WriteLine("Horario 4° embarque: " + msktxbx_Embarque4.Text);
                    sr.WriteLine("Local 5° embarque: " + txtbx_embarque5.Text);
                    sr.WriteLine("Horario 5° embarque: " + msktxbx_Embarque5.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Destino: " + txtbx_Destino.Text);
                    sr.WriteLine("");
                    sr.WriteLine("City Tour / Passeios: ");
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 1: " + txtbx_localRoteiro1.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 2: " + txtbx_localRoteiro2.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 3: " + txtbx_localRoteiro3.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 4: " + txtbx_localRoteiro4.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 5: " + txtbx_localRoteiro5.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Valor R$ " + lbl_valorTabela.Text);
                    sr.WriteLine("");
                    sr.WriteLine("🚨 ATENÇÃO 🚨");
                    sr.WriteLine("Orçamento com validade de 30 dias sujeito a alteração caso haja mudança no valor do diesel ou outras despesas da viagem.");
                    sr.WriteLine("Pedido de orçamento não é válido como viagem fechada, reserva será efetivada somente após assinatura do contrato mediante a apresentação do comprovante de sinal de 10%.");
                    sr.WriteLine("");
                    sr.WriteLine("🚨 ATENÇÃO 🚨");
                    sr.WriteLine("");
                    sr.WriteLine("Em algumas cidades, principalmente no litoral, é necessário autorização de entrada, é por conta do contratante fazer o pedido e a retirada da autorização. Pedimos que antes de fechar o serviço conosco entre em contato com a prefeitura da cidade de destino da viagem para que se informe sobre o assunto. ");
                    sr.WriteLine("");
                    sr.WriteLine("Qualquer dúvida estou a disposição ☺");
                    sr.WriteLine("");
                    sr.WriteLine("");

                    sr.Close();
                }
            }
        }

        private void teste_data_Tick(object sender, EventArgs e)
        {
            maskedTextBox1.Text = dtp_DataPartida.Text;
        }

        private void btnSalvar_Click_2(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_2(object sender, EventArgs e)
        {

        }

        private void sfdSalvar2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnOrc_Click_2(object sender, EventArgs e)
        {

        }

        private void lbl_quantosDias_Click(object sender, EventArgs e)
        {

        }

        private void tabela_FerProBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabela_FerProBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gldturfreDeployDataSet);

        }

        private void timer_foraTabela_Tick(object sender, EventArgs e)
        {
            if (txtbx_kmIda.Text == "" && txtbx_kmVolta.Text == "")
            {
                lbl_totalKm.Text = "";
            }

            else if (txtbx_kmVolta.Text == "")
            {
                km_ida = Convert.ToDouble(txtbx_kmIda.Text);
                km_total = km_ida * 2;
                lbl_totalKm.Text = Convert.ToString(km_total);
            }

            else if (txtbx_kmIda.Text == "")
            {
                km_volta = Convert.ToDouble(txtbx_kmVolta.Text);
                km_total = km_volta * 2;
                lbl_totalKm.Text = Convert.ToString(km_total);
            }

            else
            {
                km_ida = Convert.ToDouble(txtbx_kmIda.Text);
                km_volta = Convert.ToDouble(txtbx_kmVolta.Text);
                km_total = km_ida + km_volta;
                lbl_totalKm.Text = Convert.ToString(km_total);

            }

        }

        private void timer_dentroTabela_Tick(object sender, EventArgs e)
        {

        }

        private void lbl_totalKm_Click(object sender, EventArgs e)
        {

        }

        private void lbl_valorTabela_Click(object sender, EventArgs e)
        {

        }

        private void timer_valorNaoAtende_Tick(object sender, EventArgs e)
        {
            if(lbl_valorTabela.Text == "9999999,00")
            {
                lbl_valorTabela.Text = "NAO ATENDE";
            }
        }

        private void timer_consultTabela_Tick(object sender, EventArgs e)
        {

            if(cmb_DentroForaTabela.Text == "Tabela")
            {
                if(chkbx_feriado.Checked == true)
                {
                    switch (cmbbx_Categoria.Text)
                    {
                        case "DD 64L":
                            this.tabela_FerProTableAdapter.FillByFerPro_DD64(this.gldturfreDeployDataSet.tabela_FerPro, txtbx_Destino.Text);
                            lbl_valorTabela.Text = valorTextBox_FerProDD64.Text + ",00";
                            break;

                        case "DD 60L":
                            this.tabela_FerProTableAdapter.FillByFerPro_DD60(this.gldturfreDeployDataSet.tabela_FerPro, txtbx_Destino.Text);
                            lbl_valorTabela.Text = valorTextBox_FerProDD60.Text + ",00";
                            break;

                        case "CONV 47L":
                            this.tabela_FerProTableAdapter.FillByFerPro_Conv47(this.gldturfreDeployDataSet.tabela_FerPro, txtbx_Destino.Text);
                            lbl_valorTabela.Text = valorTextBox_FerProConv47.Text + ",00";
                            break;

                        case "SEMI 46L":
                            this.tabela_FerProTableAdapter.FillByFerPro_Semi46(this.gldturfreDeployDataSet.tabela_FerPro, txtbx_Destino.Text);
                            lbl_valorTabela.Text = valorTextBox_FerProSemi46.Text + ",00";
                            break;

                        case "MICRO 32L":
                            this.tabela_FerProTableAdapter.FillByFerPro_Micro32(this.gldturfreDeployDataSet.tabela_FerPro, txtbx_Destino.Text);
                            lbl_valorTabela.Text = valorTextBox_FerProMicro32.Text + ",00";
                            break;

                        case "VAN 18L":
                            this.tabela_FerProTableAdapter.FillByFerPro_Van18(this.gldturfreDeployDataSet.tabela_FerPro, txtbx_Destino.Text);
                            lbl_valorTabela.Text = valorTextBox_FerProVan18.Text + ",00";
                            break;

                        case "VAN 15L":
                            this.tabela_FerProTableAdapter.FillByFerPro_Van15(this.gldturfreDeployDataSet.tabela_FerPro, txtbx_Destino.Text);
                            lbl_valorTabela.Text = valorTextBox_FerProVan15.Text + ",00";
                            break;

                        case "CARRO":
                            this.tabela_FerProTableAdapter.FillByFerPro_Carro(this.gldturfreDeployDataSet.tabela_FerPro, txtbx_Destino.Text);
                            lbl_valorTabela.Text = valorTextBox_FerProCarro.Text + ",00";
                            break;

                        case "EXEC 46L":
                            this.tabela_FerProTableAdapter.FillByFerPro_Exec46(this.gldturfreDeployDataSet.tabela_FerPro, txtbx_Destino.Text);
                            lbl_valorTabela.Text = valorTextBox_FerProExec46.Text + ",00";
                            break;

                        case "EXEC 50L":
                            this.tabela_FerProTableAdapter.FillByFerPro_Exec50(this.gldturfreDeployDataSet.tabela_FerPro, txtbx_Destino.Text);
                            lbl_valorTabela.Text = valorTextBox_FerProExec50.Text + ",00";
                            break;
                    }
                }

                else
                {
                    if (conta == 1)
                    {
                        switch (cmbbx_Categoria.Text)
                        {

                            case "DD 64L":

                                this.tabela_BateVoltaTableAdapter.FillByBateVolta_DD64(this.gldturfreDeployDataSet.tabela_BateVolta, txtbx_Destino.Text);
                                lbl_valorTabela.Text = valorTextBox_BateVoltaDD64.Text + ",00";
                                break;

                            case "DD 60L":
                                this.tabela_BateVoltaTableAdapter.FillByBateVolta_DD60(this.gldturfreDeployDataSet.tabela_BateVolta, txtbx_Destino.Text);
                                lbl_valorTabela.Text = valorTextBox_BateVoltaDD60.Text + ",00";
                                break;

                            case "CONV 47L":
                                this.tabela_BateVoltaTableAdapter.FillByBateVolta_Conv47(this.gldturfreDeployDataSet.tabela_BateVolta, txtbx_Destino.Text);
                                lbl_valorTabela.Text = valorTextBox_BateVoltaConv47.Text + ",00";
                                break;

                            case "SEMI 46L":
                                this.tabela_BateVoltaTableAdapter.FillByBateVolta_Semi46(this.gldturfreDeployDataSet.tabela_BateVolta, txtbx_Destino.Text);
                                lbl_valorTabela.Text = valorTextBox_BateVoltaConv47.Text + ",00";
                                break;

                            case "MICRO 32L":
                                this.tabela_BateVoltaTableAdapter.FillByBateVolta_Micro32(this.gldturfreDeployDataSet.tabela_BateVolta, txtbx_Destino.Text);
                                lbl_valorTabela.Text = valorTextBox_BateVoltaMicro32.Text + ",00";
                                break;

                            case "VAN 18L":
                                this.tabela_BateVoltaTableAdapter.FillByBateVolta_Van18(this.gldturfreDeployDataSet.tabela_BateVolta, txtbx_Destino.Text);
                                lbl_valorTabela.Text = valorTextBox_BateVoltaVan18.Text + ",00";
                                break;

                            case "VAN 15L":
                                this.tabela_BateVoltaTableAdapter.FillByBateVolta_Van15(this.gldturfreDeployDataSet.tabela_BateVolta, txtbx_Destino.Text);
                                lbl_valorTabela.Text = valorTextBox_BateVoltaVan15.Text + ",00";
                                break;

                            case "CARRO":
                                this.tabela_BateVoltaTableAdapter.FillByBateVolta_Carro(this.gldturfreDeployDataSet.tabela_BateVolta, txtbx_Destino.Text);
                                lbl_valorTabela.Text = valorTextBox_BateVoltaCarro.Text + ",00";
                                break;

                            case "EXEC 46L":
                                this.tabela_BateVoltaTableAdapter.FillByBateVolta_Exec46(this.gldturfreDeployDataSet.tabela_BateVolta, txtbx_Destino.Text);
                                lbl_valorTabela.Text = valorTextBox_BateVoltaExec46.Text + ",00";
                                break;

                            case "EXEC 50L":
                                this.tabela_BateVoltaTableAdapter.FillByBateVolta_DD64(this.gldturfreDeployDataSet.tabela_BateVolta, txtbx_Destino.Text);
                                lbl_valorTabela.Text = valorTextBox_BateVoltaExec50.Text + ",00";
                                break;
                        }
                    }

                    else if (conta == 2)
                    {
                        switch (cmbbx_Categoria.Text)
                        {
                            case "DD 64L":
                                this.tabela_FimSemTableAdapter.FillByFimSem_DD64(this.gldturfreDeployDataSet.tabela_FimSem, txtbx_Destino.Text);
                                lbl_valorTabela.Text = valorTextBox_FimSemDD64.Text + ",00";
                                break;

                            case "DD 60L":
                                this.tabela_FimSemTableAdapter.FillByFimSem_DD60(this.gldturfreDeployDataSet.tabela_FimSem, txtbx_Destino.Text);
                                lbl_valorTabela.Text = valorTextBox_FimSemDD60.Text + ",00";
                                break;

                            case "CONV 47L":
                                this.tabela_FimSemTableAdapter.FillByFimSem_Conv47(this.gldturfreDeployDataSet.tabela_FimSem, txtbx_Destino.Text);
                                lbl_valorTabela.Text = valorTextBox_FimSemConv47.Text + ",00";
                                break;

                            case "SEMI 46L":
                                this.tabela_FimSemTableAdapter.FillByFimSem_Semi46(this.gldturfreDeployDataSet.tabela_FimSem, txtbx_Destino.Text);
                                lbl_valorTabela.Text = valorTextBox_FimSemSemi46.Text + ",00";
                                break;

                            case "MICRO 32L":
                                this.tabela_FimSemTableAdapter.FillByFimSem_Micro32(this.gldturfreDeployDataSet.tabela_FimSem, txtbx_Destino.Text);
                                lbl_valorTabela.Text = valorTextBox_FimSemMicro32.Text + ",00";
                                break;

                            case "VAN 18L":
                                this.tabela_FimSemTableAdapter.FillByFimSem_Van18(this.gldturfreDeployDataSet.tabela_FimSem, txtbx_Destino.Text);
                                lbl_valorTabela.Text = valorTextBox_FimSemVan18.Text + ",00";
                                break;

                            case "VAN 15L":
                                this.tabela_FimSemTableAdapter.FillByFimSem_Van15(this.gldturfreDeployDataSet.tabela_FimSem, txtbx_Destino.Text);
                                lbl_valorTabela.Text = valorTextBox_FimSemVan15.Text + ",00";
                                break;

                            case "CARRO":
                                this.tabela_FimSemTableAdapter.FillByFimSem_Carro(this.gldturfreDeployDataSet.tabela_FimSem, txtbx_Destino.Text);
                                lbl_valorTabela.Text = valorTextBox_FimSemExec46.Text + ",00";
                                break;

                            case "EXEC 46L":
                                this.tabela_FimSemTableAdapter.FillByFimSem_Exec46(this.gldturfreDeployDataSet.tabela_FimSem, txtbx_Destino.Text);
                                lbl_valorTabela.Text = valorTextBox_FimSemExec46.Text + ",00";
                                break;

                            case "EXEC 50L":
                                this.tabela_FimSemTableAdapter.FillByFimSem_Exec50(this.gldturfreDeployDataSet.tabela_FimSem, txtbx_Destino.Text);
                                lbl_valorTabela.Text = valorTextBox_FimSemExec50.Text + ",00";
                                break;

                        }
                    }

                    else
                    {
                        lbl_valorTabela.Text = "";
                    }
                }


            }

        }
    }
}

