namespace control_services
{
    partial class frm_consultCli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cad_clieDataGridView = new System.Windows.Forms.DataGridView();
            this.cadcliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gldturfreDeployDataSet = new control_services.gldturfreDeployDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chkbx_PesquisaCPF = new System.Windows.Forms.CheckBox();
            this.chkbx_PesquisaNome = new System.Windows.Forms.CheckBox();
            this.txtbx_nome = new System.Windows.Forms.TextBox();
            this.msktxbx_CpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.cmb_CpfCnpj = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAdapterManager = new control_services.gldturfreDeployDataSetTableAdapters.TableAdapterManager();
            this.cad_cliTableAdapter = new control_services.gldturfreDeployDataSetTableAdapters.cad_cliTableAdapter();
            this.idcliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerazaosocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfcnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cad_clieDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadcliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gldturfreDeployDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cad_clieDataGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 374);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro do Cliente";
            // 
            // cad_clieDataGridView
            // 
            this.cad_clieDataGridView.AllowUserToAddRows = false;
            this.cad_clieDataGridView.AllowUserToDeleteRows = false;
            this.cad_clieDataGridView.AutoGenerateColumns = false;
            this.cad_clieDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.cad_clieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cad_clieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcliDataGridViewTextBoxColumn,
            this.nomerazaosocialDataGridViewTextBoxColumn,
            this.cpfcnpjDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.email});
            this.cad_clieDataGridView.DataSource = this.cadcliBindingSource;
            this.cad_clieDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cad_clieDataGridView.Location = new System.Drawing.Point(3, 18);
            this.cad_clieDataGridView.Name = "cad_clieDataGridView";
            this.cad_clieDataGridView.ReadOnly = true;
            this.cad_clieDataGridView.Size = new System.Drawing.Size(835, 353);
            this.cad_clieDataGridView.TabIndex = 0;
            // 
            // cadcliBindingSource
            // 
            this.cadcliBindingSource.DataMember = "cad_cli";
            this.cadcliBindingSource.DataSource = this.gldturfreDeployDataSet;
            // 
            // gldturfreDeployDataSet
            // 
            this.gldturfreDeployDataSet.DataSetName = "gldturfreDeployDataSet";
            this.gldturfreDeployDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.chkbx_PesquisaCPF);
            this.groupBox2.Controls.Add(this.chkbx_PesquisaNome);
            this.groupBox2.Controls.Add(this.txtbx_nome);
            this.groupBox2.Controls.Add(this.msktxbx_CpfCnpj);
            this.groupBox2.Controls.Add(this.cmb_CpfCnpj);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(841, 147);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar";
            // 
            // button1
            // 
            this.button1.Image = global::control_services.Properties.Resources.lupa;
            this.button1.Location = new System.Drawing.Point(551, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 11;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // chkbx_PesquisaCPF
            // 
            this.chkbx_PesquisaCPF.AutoSize = true;
            this.chkbx_PesquisaCPF.Location = new System.Drawing.Point(429, 90);
            this.chkbx_PesquisaCPF.Name = "chkbx_PesquisaCPF";
            this.chkbx_PesquisaCPF.Size = new System.Drawing.Size(18, 17);
            this.chkbx_PesquisaCPF.TabIndex = 10;
            this.chkbx_PesquisaCPF.UseVisualStyleBackColor = true;
            this.chkbx_PesquisaCPF.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkbx_PesquisaNome
            // 
            this.chkbx_PesquisaNome.AutoSize = true;
            this.chkbx_PesquisaNome.Location = new System.Drawing.Point(429, 44);
            this.chkbx_PesquisaNome.Name = "chkbx_PesquisaNome";
            this.chkbx_PesquisaNome.Size = new System.Drawing.Size(18, 17);
            this.chkbx_PesquisaNome.TabIndex = 9;
            this.chkbx_PesquisaNome.UseVisualStyleBackColor = true;
            // 
            // txtbx_nome
            // 
            this.txtbx_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_nome.Location = new System.Drawing.Point(16, 39);
            this.txtbx_nome.Name = "txtbx_nome";
            this.txtbx_nome.Size = new System.Drawing.Size(407, 26);
            this.txtbx_nome.TabIndex = 8;
            // 
            // msktxbx_CpfCnpj
            // 
            this.msktxbx_CpfCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxbx_CpfCnpj.Location = new System.Drawing.Point(129, 85);
            this.msktxbx_CpfCnpj.Name = "msktxbx_CpfCnpj";
            this.msktxbx_CpfCnpj.Size = new System.Drawing.Size(294, 26);
            this.msktxbx_CpfCnpj.TabIndex = 7;
            // 
            // cmb_CpfCnpj
            // 
            this.cmb_CpfCnpj.Enabled = false;
            this.cmb_CpfCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CpfCnpj.FormattingEnabled = true;
            this.cmb_CpfCnpj.Items.AddRange(new object[] {
            "CPF",
            "CPNJ"});
            this.cmb_CpfCnpj.Location = new System.Drawing.Point(16, 83);
            this.cmb_CpfCnpj.Name = "cmb_CpfCnpj";
            this.cmb_CpfCnpj.Size = new System.Drawing.Size(107, 30);
            this.cmb_CpfCnpj.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_cli";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_cli";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome_razao_social";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome_razao_social";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cpf_cnpj";
            this.dataGridViewTextBoxColumn3.HeaderText = "cpf_cnpj";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn4.HeaderText = "email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "telefone";
            this.dataGridViewTextBoxColumn5.HeaderText = "telefone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn6.HeaderText = "endereco";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "num_endereco";
            this.dataGridViewTextBoxColumn7.HeaderText = "num_endereco";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "complemento";
            this.dataGridViewTextBoxColumn8.HeaderText = "complemento";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "bairro";
            this.dataGridViewTextBoxColumn9.HeaderText = "bairro";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "cidade";
            this.dataGridViewTextBoxColumn10.HeaderText = "cidade";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn11.HeaderText = "estado";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cad_cliTableAdapter = null;
            this.tableAdapterManager.cad_funTableAdapter = null;
            this.tableAdapterManager.categ_veiculoTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.estadoTableAdapter = null;
            this.tableAdapterManager.lgn_usersTableAdapter = null;
            this.tableAdapterManager.orcamentoTableAdapter = null;
            this.tableAdapterManager.tabela_BateVoltaTableAdapter = null;
            this.tableAdapterManager.tabela_FerProTableAdapter = null;
            this.tableAdapterManager.tabela_FimSemTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = control_services.gldturfreDeployDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veiculoTableAdapter = null;
            this.tableAdapterManager.viagem_fechadaTableAdapter = null;
            // 
            // cad_cliTableAdapter
            // 
            this.cad_cliTableAdapter.ClearBeforeFill = true;
            // 
            // idcliDataGridViewTextBoxColumn
            // 
            this.idcliDataGridViewTextBoxColumn.DataPropertyName = "id_cli";
            this.idcliDataGridViewTextBoxColumn.HeaderText = "Codigo do Cliente";
            this.idcliDataGridViewTextBoxColumn.Name = "idcliDataGridViewTextBoxColumn";
            this.idcliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomerazaosocialDataGridViewTextBoxColumn
            // 
            this.nomerazaosocialDataGridViewTextBoxColumn.DataPropertyName = "nome_razao_social";
            this.nomerazaosocialDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomerazaosocialDataGridViewTextBoxColumn.Name = "nomerazaosocialDataGridViewTextBoxColumn";
            this.nomerazaosocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfcnpjDataGridViewTextBoxColumn
            // 
            this.cpfcnpjDataGridViewTextBoxColumn.DataPropertyName = "cpf_cnpj";
            this.cpfcnpjDataGridViewTextBoxColumn.HeaderText = "CPF / CNPJ";
            this.cpfcnpjDataGridViewTextBoxColumn.Name = "cpfcnpjDataGridViewTextBoxColumn";
            this.cpfcnpjDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // frm_consultCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_consultCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Cliente";
            this.Load += new System.EventHandler(this.frm_consultCli_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cad_clieDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadcliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gldturfreDeployDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private gldturfreDeployDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_CpfCnpj;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView cad_clieDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.MaskedTextBox msktxbx_CpfCnpj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkbx_PesquisaCPF;
        private System.Windows.Forms.CheckBox chkbx_PesquisaNome;
        private System.Windows.Forms.TextBox txtbx_nome;
        private gldturfreDeployDataSet gldturfreDeployDataSet;
        private System.Windows.Forms.BindingSource cadcliBindingSource;
        private gldturfreDeployDataSetTableAdapters.cad_cliTableAdapter cad_cliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerazaosocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfcnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}