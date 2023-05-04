namespace control_services
{
    partial class frm_cadCli
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
            System.Windows.Forms.Label id_cliLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_consulta_cliente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.panel_cadastro = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.id_cliTextBox = new System.Windows.Forms.TextBox();
            this.msktxbx_tel = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cad_cliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gldturfreDeployDataSet = new control_services.gldturfreDeployDataSet();
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtbx_cidade = new System.Windows.Forms.TextBox();
            this.txtbx_bairro = new System.Windows.Forms.TextBox();
            this.txtbx_compl = new System.Windows.Forms.TextBox();
            this.txtbx_num_ende = new System.Windows.Forms.TextBox();
            this.txtbx_endereco = new System.Windows.Forms.TextBox();
            this.txtbx_email = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.cmbbx_cpf_cnpj = new System.Windows.Forms.ComboBox();
            this.txtbx_nome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cad_cliTableAdapter = new control_services.gldturfreDeployDataSetTableAdapters.cad_cliTableAdapter();
            this.tableAdapterManager = new control_services.gldturfreDeployDataSetTableAdapters.TableAdapterManager();
            this.estadoTableAdapter = new control_services.gldturfreDeployDataSetTableAdapters.estadoTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            id_cliLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_cadastro.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cad_cliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gldturfreDeployDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_cliLabel
            // 
            id_cliLabel.AutoSize = true;
            id_cliLabel.Location = new System.Drawing.Point(849, 164);
            id_cliLabel.Name = "id_cliLabel";
            id_cliLabel.Size = new System.Drawing.Size(40, 17);
            id_cliLabel.TabIndex = 36;
            id_cliLabel.Text = "id cli:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_consulta_cliente);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 85);
            this.panel1.TabIndex = 12;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_salvar.Image = global::control_services.Properties.Resources._003_ponto_de_verificacao;
            this.btn_salvar.Location = new System.Drawing.Point(180, 0);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(90, 85);
            this.btn_salvar.TabIndex = 3;
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_add
            // 
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_add.Image = global::control_services.Properties.Resources._002_inserir;
            this.btn_add.Location = new System.Drawing.Point(90, 0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(90, 85);
            this.btn_add.TabIndex = 2;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_consulta_cliente
            // 
            this.btn_consulta_cliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_consulta_cliente.Image = global::control_services.Properties.Resources._001_analytic;
            this.btn_consulta_cliente.Location = new System.Drawing.Point(0, 0);
            this.btn_consulta_cliente.Name = "btn_consulta_cliente";
            this.btn_consulta_cliente.Size = new System.Drawing.Size(90, 85);
            this.btn_consulta_cliente.TabIndex = 1;
            this.btn_consulta_cliente.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_sair);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(733, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 85);
            this.panel2.TabIndex = 0;
            // 
            // btn_sair
            // 
            this.btn_sair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_sair.Image = global::control_services.Properties.Resources._001_exit1;
            this.btn_sair.Location = new System.Drawing.Point(0, 0);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(90, 85);
            this.btn_sair.TabIndex = 0;
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // panel_cadastro
            // 
            this.panel_cadastro.Controls.Add(this.maskedTextBox2);
            this.panel_cadastro.Controls.Add(this.label2);
            this.panel_cadastro.Controls.Add(id_cliLabel);
            this.panel_cadastro.Controls.Add(this.statusStrip1);
            this.panel_cadastro.Controls.Add(this.id_cliTextBox);
            this.panel_cadastro.Controls.Add(this.msktxbx_tel);
            this.panel_cadastro.Controls.Add(this.comboBox1);
            this.panel_cadastro.Controls.Add(this.txtbx_cidade);
            this.panel_cadastro.Controls.Add(this.txtbx_bairro);
            this.panel_cadastro.Controls.Add(this.txtbx_compl);
            this.panel_cadastro.Controls.Add(this.txtbx_num_ende);
            this.panel_cadastro.Controls.Add(this.txtbx_endereco);
            this.panel_cadastro.Controls.Add(this.txtbx_email);
            this.panel_cadastro.Controls.Add(this.maskedTextBox1);
            this.panel_cadastro.Controls.Add(this.cmbbx_cpf_cnpj);
            this.panel_cadastro.Controls.Add(this.txtbx_nome);
            this.panel_cadastro.Controls.Add(this.label10);
            this.panel_cadastro.Controls.Add(this.label9);
            this.panel_cadastro.Controls.Add(this.label8);
            this.panel_cadastro.Controls.Add(this.label7);
            this.panel_cadastro.Controls.Add(this.label6);
            this.panel_cadastro.Controls.Add(this.label5);
            this.panel_cadastro.Controls.Add(this.label4);
            this.panel_cadastro.Controls.Add(this.label3);
            this.panel_cadastro.Controls.Add(this.label1);
            this.panel_cadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cadastro.Enabled = false;
            this.panel_cadastro.Location = new System.Drawing.Point(0, 85);
            this.panel_cadastro.Name = "panel_cadastro";
            this.panel_cadastro.Size = new System.Drawing.Size(823, 437);
            this.panel_cadastro.TabIndex = 13;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 412);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(823, 25);
            this.statusStrip1.TabIndex = 31;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(124, 20);
            this.toolStripStatusLabel2.Text = "Precisa de ajuda?";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // id_cliTextBox
            // 
            this.id_cliTextBox.Location = new System.Drawing.Point(895, 161);
            this.id_cliTextBox.Name = "id_cliTextBox";
            this.id_cliTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_cliTextBox.TabIndex = 37;
            // 
            // msktxbx_tel
            // 
            this.msktxbx_tel.Location = new System.Drawing.Point(452, 327);
            this.msktxbx_tel.Mask = "(99) 00000-9999";
            this.msktxbx_tel.Name = "msktxbx_tel";
            this.msktxbx_tel.Size = new System.Drawing.Size(254, 22);
            this.msktxbx_tel.TabIndex = 30;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_cliBindingSource, "estado", true));
            this.comboBox1.DataSource = this.estadoBindingSource;
            this.comboBox1.DisplayMember = "sigla_estado";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 327);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 24);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.ValueMember = "estado.id_estados";
            // 
            // cad_cliBindingSource
            // 
            this.cad_cliBindingSource.DataMember = "cad_cli";
            this.cad_cliBindingSource.DataSource = this.gldturfreDeployDataSet;
            // 
            // gldturfreDeployDataSet
            // 
            this.gldturfreDeployDataSet.DataSetName = "gldturfreDeployDataSet";
            this.gldturfreDeployDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadoBindingSource
            // 
            this.estadoBindingSource.DataMember = "estado";
            this.estadoBindingSource.DataSource = this.gldturfreDeployDataSet;
            // 
            // txtbx_cidade
            // 
            this.txtbx_cidade.Location = new System.Drawing.Point(452, 281);
            this.txtbx_cidade.Name = "txtbx_cidade";
            this.txtbx_cidade.Size = new System.Drawing.Size(254, 22);
            this.txtbx_cidade.TabIndex = 28;
            // 
            // txtbx_bairro
            // 
            this.txtbx_bairro.Location = new System.Drawing.Point(164, 281);
            this.txtbx_bairro.Name = "txtbx_bairro";
            this.txtbx_bairro.Size = new System.Drawing.Size(142, 22);
            this.txtbx_bairro.TabIndex = 27;
            // 
            // txtbx_compl
            // 
            this.txtbx_compl.Location = new System.Drawing.Point(452, 228);
            this.txtbx_compl.Name = "txtbx_compl";
            this.txtbx_compl.Size = new System.Drawing.Size(254, 22);
            this.txtbx_compl.TabIndex = 26;
            // 
            // txtbx_num_ende
            // 
            this.txtbx_num_ende.Location = new System.Drawing.Point(164, 228);
            this.txtbx_num_ende.Name = "txtbx_num_ende";
            this.txtbx_num_ende.Size = new System.Drawing.Size(142, 22);
            this.txtbx_num_ende.TabIndex = 25;
            // 
            // txtbx_endereco
            // 
            this.txtbx_endereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_cliBindingSource, "endereco", true));
            this.txtbx_endereco.Location = new System.Drawing.Point(164, 182);
            this.txtbx_endereco.Name = "txtbx_endereco";
            this.txtbx_endereco.Size = new System.Drawing.Size(542, 22);
            this.txtbx_endereco.TabIndex = 24;
            // 
            // txtbx_email
            // 
            this.txtbx_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_cliBindingSource, "email", true));
            this.txtbx_email.Location = new System.Drawing.Point(164, 127);
            this.txtbx_email.Name = "txtbx_email";
            this.txtbx_email.Size = new System.Drawing.Size(282, 22);
            this.txtbx_email.TabIndex = 23;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_cliBindingSource, "cpf_cnpj", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(164, 73);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(282, 22);
            this.maskedTextBox1.TabIndex = 22;
            // 
            // cmbbx_cpf_cnpj
            // 
            this.cmbbx_cpf_cnpj.FormattingEnabled = true;
            this.cmbbx_cpf_cnpj.Items.AddRange(new object[] {
            "CPF",
            "CNPJ"});
            this.cmbbx_cpf_cnpj.Location = new System.Drawing.Point(37, 73);
            this.cmbbx_cpf_cnpj.Name = "cmbbx_cpf_cnpj";
            this.cmbbx_cpf_cnpj.Size = new System.Drawing.Size(121, 24);
            this.cmbbx_cpf_cnpj.TabIndex = 21;
            // 
            // txtbx_nome
            // 
            this.txtbx_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_cliBindingSource, "nome_razao_social", true));
            this.txtbx_nome.Location = new System.Drawing.Point(164, 34);
            this.txtbx_nome.Name = "txtbx_nome";
            this.txtbx_nome.Size = new System.Drawing.Size(542, 22);
            this.txtbx_nome.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(98, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Estado :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(386, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cidade :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Bairro :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Complemento :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Numero :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Endereco :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "E - mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Telefone :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome / Razao social :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cad_cliTableAdapter
            // 
            this.cad_cliTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cad_cliTableAdapter = this.cad_cliTableAdapter;
            this.tableAdapterManager.cad_funTableAdapter = null;
            this.tableAdapterManager.categ_veiculoTableAdapter = null;
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
            // estadoTableAdapter
            // 
            this.estadoTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Data Nascimento: ";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(590, 73);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(116, 22);
            this.maskedTextBox2.TabIndex = 39;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // frm_cadCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 522);
            this.ControlBox = false;
            this.Controls.Add(this.panel_cadastro);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_cadCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.frm_cadCli2_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel_cadastro.ResumeLayout(false);
            this.panel_cadastro.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cad_cliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gldturfreDeployDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_consulta_cliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Panel panel_cadastro;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.MaskedTextBox msktxbx_tel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtbx_cidade;
        private System.Windows.Forms.TextBox txtbx_bairro;
        private System.Windows.Forms.TextBox txtbx_compl;
        private System.Windows.Forms.TextBox txtbx_num_ende;
        private System.Windows.Forms.TextBox txtbx_endereco;
        private System.Windows.Forms.TextBox txtbx_email;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox cmbbx_cpf_cnpj;
        private System.Windows.Forms.TextBox txtbx_nome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private gldturfreDeployDataSet gldturfreDeployDataSet;
        private System.Windows.Forms.BindingSource cad_cliBindingSource;
        private gldturfreDeployDataSetTableAdapters.cad_cliTableAdapter cad_cliTableAdapter;
        private gldturfreDeployDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource estadoBindingSource;
        private gldturfreDeployDataSetTableAdapters.estadoTableAdapter estadoTableAdapter;
        private System.Windows.Forms.TextBox id_cliTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label2;
    }
}