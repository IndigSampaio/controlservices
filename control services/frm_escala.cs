using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            // Carrega os dados das tabelas
            this.veiculoTableAdapter.Fill(this.gldturfreDeployDataSet.veiculo);
            this.motoristaTableAdapter.Fill(this.gldturfreDeployDataSet.motorista);
            this.viagem_fechadaTableAdapter.Fill(this.gldturfreDeployDataSet.viagem_fechada);

            // Obtém a categoria do veículo selecionado
            string categoria = categ_veiculoLabel2.Text;

            // Filtra e preenche o ComboBox com os veículos correspondentes à categoria
            PreencherVeiculos(categoria, veiculoComboBox);
        }

        private void PreencherVeiculos(string categoria, ComboBox comboBox)
        {
            // Obtém a categoria do veículo selecionado
            categoria = categ_veiculoLabel2.Text;

            // Define a string de conexão com o banco de dados
            string connectionString = "Data Source=mssql-115648-0.cloudclusters.net,10046; Initial Catalog=gldturfreDeploy;User ID=PedroSampaio;Password=DanielePedro1!";

            // Define a consulta SQL para selecionar os veículos correspondentes à categoria
            string comando = $"SELECT veiculo FROM veiculo WHERE categ_veiculo = '{categoria}' AND ativo = 1";

            // Cria uma conexão com o banco de dados
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                // Cria um comando para executar a consulta SQL
                using (SqlCommand cmd = new SqlCommand(comando, conexao))
                {
                    // Abre a conexão com o banco de dados
                    conexao.Open();

                    // Executa a consulta SQL e obtém um leitor de dados
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Limpa o ComboBox
                        comboBox.Items.Clear();

                        // Preenche o ComboBox com os veículos correspondentes à categoria
                        while (reader.Read())
                        {
                            comboBox.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }

            // Seleciona o primeiro item do ComboBox, se houver
            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
            else
            {
                comboBox.Text = "";
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.viagem_fechadaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gldturfreDeployDataSet);
        }

    }
}
