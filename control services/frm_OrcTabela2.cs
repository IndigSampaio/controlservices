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

namespace control_services
{
    public partial class frm_OrcTabela2 : Form
    {
        public frm_OrcTabela2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                
            if(msktxbx_CpfCnpj.Enabled == false)
            {
                string dirSalvar;
                sfdSalvar.Title = "Salvar Documento";
                sfdSalvar.Filter = "txt (.txt) | *.txt | HTML (.html) |*.html";

                if (sfdSalvar.ShowDialog() == DialogResult.OK)
                {
                    dirSalvar = sfdSalvar.FileName;
                    StreamWriter sr = new StreamWriter(dirSalvar);

                    sr.WriteLine("Segue seu orçamento baseado nos dados enviados:");
                    //sr.WriteLine("Numero do orcamento: " + id_orcamentoTextBox.Text);
                    sr.WriteLine("Data de ida: " + txtbx_DataPartida.Text);
                    sr.WriteLine("Horario: " + txtbx_HoraPartida.Text);
                    sr.WriteLine("Data de retorno: " + txtbx_DataRetorno.Text);
                    sr.WriteLine("Horario: " + txtbx_HoraRetorno.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Locais de embarque: " + cmbbx_Partida.Text);
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
                    sr.WriteLine("Roteiro do Dia 1: " + txtbx_localRoteiro2.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 2: " + txtbx_localRoteiro2.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 3: " + txtbx_localRoteiro3.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 4: " + txtbx_localRoteiro4.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 5: " + txtbx_localRoteiro5.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Valor R$ " + txtbx_VlrFinal.Text);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (msktxbx_CpfCnpj.Enabled == true)
            {
                MessageBox.Show("Para adicionar um novo registro, é necessario finalizar o atual", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                msktxbx_CpfCnpj.Enabled = true;
                txtbx_idString.Text = id_orcamentoTextBox.Text;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (msktxbx_CpfCnpj.Text == "" || txtbx_VlrFinal.Text == "")
            {
                MessageBox.Show("Não é possivel salvar um orcamento sem um cliente vinculado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                this.Validate();
                this.orcamento2BindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gldturfreDeployDataSet);
                MessageBox.Show("Orcamento salvo com sucesso!", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                string dirSalvar;
                sfdSalvar.Title = "Salvar Documento";
                sfdSalvar.Filter = "txt (.txt) | *.txt | PDF (.PDF) |*.pdf";

                if (sfdSalvar.ShowDialog() == DialogResult.OK)
                {
                    dirSalvar = sfdSalvar.FileName;
                    StreamWriter sr = new StreamWriter(dirSalvar);

                    sr.WriteLine("Segue seu orçamento baseado nos dados enviados:");
                    sr.WriteLine("Numero do orcamento: " + id_orcamentoTextBox.Text);
                    sr.WriteLine("Data de ida: " + txtbx_DataPartida.Text);
                    sr.WriteLine("Horario: " + txtbx_HoraPartida.Text);
                    sr.WriteLine("Data de retorno: " + txtbx_DataRetorno.Text);
                    sr.WriteLine("Horario: " + txtbx_HoraRetorno.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Locais de embarque: " + cmbbx_Partida.Text);
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
                    sr.WriteLine("Roteiro do Dia 1: " + txtbx_localRoteiro2.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 2: " + txtbx_localRoteiro2.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 3: " + txtbx_localRoteiro3.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 4: " + txtbx_localRoteiro4.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Roteiro do Dia 5: " + txtbx_localRoteiro5.Text);
                    sr.WriteLine("");
                    sr.WriteLine("Valor R$ " + txtbx_VlrFinal.Text);
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
                msktxbx_CpfCnpj.Enabled = false;
            }

        }

        private void frm_OrcTabela2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gldturfreDeployDataSet.cad_clie'. Você pode movê-la ou removê-la conforme necessário.
            //this.cad_clieTableAdapter.Fill(this.gldturfreDeployDataSet.cad_clie);

            if (txtbx_VlrFinal.Text == "")
            {
                chkbx_NotaFiscal.Enabled = false;
            }

            else
            {
                chkbx_NotaFiscal.Enabled = true;
            }

            label2.Text = "";
            label4.Text = "";
            lbl_valorTabela.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chkbx_UsarValorTabela.Checked == true)
            {
                txtbx_VlrFinal.Text = lbl_valorTabela.Text;
            }

            if (cmbbx_mask_CpfCnpj.Text == "CPF")
            {
                msktxbx_CpfCnpj.Mask = "999,999,999-99";
            }

            else if (cmbbx_mask_CpfCnpj.Text == "CNPJ")
            {
                msktxbx_CpfCnpj.Mask = "99,999,999/9999-99";
            }

            if (chkbx_NotaFiscal.Checked == true)
            {
                if (chkbx_UsarValorTabela.Checked == true)
                {
                    if (lbl_valorTabela.Text != "")
                    {
                        int valor, conta;
                        string resultado;


                        valor = Convert.ToInt32(lbl_valorTabela.Text);
                        conta = valor + (valor * (10 / 100));
                        resultado = Convert.ToString(conta);

                        txtbx_VlrFinal.Text = resultado;
                    }
                }

                else
                {
                    int valor, conta;
                    string resultado;


                    valor = Convert.ToInt32(txtbx_VlrFinal.Text);
                    conta = valor + (valor * (10 / 100));
                    resultado = Convert.ToString(conta);

                    txtbx_VlrFinal.Text = resultado;
                }

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

        private void button7_Click(object sender, EventArgs e)
        {
            frm_OrcForaTabela orcForaTabela = new frm_OrcForaTabela();
            orcForaTabela.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_SelecionarCliente_Click(object sender, EventArgs e)
        {
            this.cad_cliTableAdapter.FillByConsultaCpfCnpj(this.gldturfreDeployDataSet.cad_cli, msktxbx_CpfCnpj.Text);
            label2.Text = nome_razao_socialTextBox.Text;
            label4.Text = telefoneTextBox.Text;
        }

        private void btn_ProcurarDestino_Click(object sender, EventArgs e)
        {
            
        }

        private void cad_clieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void orcamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void btn_ProcurarDestino_Click_1(object sender, EventArgs e)
        {

        }
        

        private void msktxbx_CpfCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_cadCli cadCli = new frm_cadCli();
            cadCli.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btn_SelecionarCliente_Click_1(object sender, EventArgs e)
        {
            this.cad_cliTableAdapter.FillByConsultaCpfCnpj(this.gldturfreDeployDataSet.cad_cli, msktxbx_CpfCnpj.Text);
            label2.Text = nome_razao_socialTextBox.Text;
            label4.Text = telefoneTextBox.Text;
               
        }

        private void btn_ProcurarDestino_Click_2(object sender, EventArgs e)
        {
            {
                if (cmbbx_Periodo.Text == "FIM DE SEMANA")
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
                            label4.Text = valorTextBox_FimSemExec46.Text + ",00";
                            break;

                        case "EXEC 50L":
                            this.tabela_FimSemTableAdapter.FillByFimSem_Exec50(this.gldturfreDeployDataSet.tabela_FimSem, txtbx_Destino.Text);
                            lbl_valorTabela.Text = valorTextBox_FimSemExec50.Text + ",00";
                            break;

                    }


                }

                else if (cmbbx_Periodo.Text == "FERIADO PROLONGADO")
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

                else if (cmbbx_Periodo.Text == "BATE E VOLTA")
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
                            label4.Text = valorTextBox_BateVoltaExec46.Text + ",00";
                            break;

                        case "EXEC 50L":
                            this.tabela_BateVoltaTableAdapter.FillByBateVolta_DD64(this.gldturfreDeployDataSet.tabela_BateVolta, txtbx_Destino.Text);
                            lbl_valorTabela.Text = valorTextBox_BateVoltaExec50.Text + ",00";
                            break;
                    }
                }

                else
                {
                    txtbx_Destino.Text = "";
                }
            }
        }

        private void orcamentoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
