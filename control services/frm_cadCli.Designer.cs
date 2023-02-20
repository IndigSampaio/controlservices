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
            this.glturfreDeployDataSet = new control_services.glturfreDeployDataSet();
            this.cad_cliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cad_cliTableAdapter = new control_services.glturfreDeployDataSetTableAdapters.cad_cliTableAdapter();
            this.tableAdapterManager = new control_services.glturfreDeployDataSetTableAdapters.TableAdapterManager();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.panel_cadastro = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_consulta_cliente = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.txtbx_nome = new System.Windows.Forms.TextBox();
            this.cmbbx_cpf_cnpj = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.glturfreDeployDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cad_cliBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // glturfreDeployDataSet
            // 
            this.glturfreDeployDataSet.DataSetName = "glturfreDeployDataSet";
            this.glturfreDeployDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cad_cliBindingSource
            // 
            this.cad_cliBindingSource.DataMember = "cad_cli";
            this.cad_cliBindingSource.DataSource = this.glturfreDeployDataSet;
            // 
            // cad_cliTableAdapter
            // 
            this.cad_cliTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.batevolta_dd64LTableAdapter = null;
            this.tableAdapterManager.cad_cliTableAdapter = this.cad_cliTableAdapter;
            this.tableAdapterManager.cad_funTableAdapter = null;
            this.tableAdapterManager.cad_loginTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = control_services.glturfreDeployDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.panel1.Size = new System.Drawing.Size(800, 85);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_sair);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(710, 0);
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
            this.panel_cadastro.Size = new System.Drawing.Size(800, 406);
            this.panel_cadastro.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(542, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Estado :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cidade :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Bairro :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Complemento :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Numero :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Endereco :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "E - mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Telefone :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome / Razao social :";
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
            this.btn_consulta_cliente.Click += new System.EventHandler(this.btn_consulta_cliente_Click);
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
            // txtbx_nome
            // 
            this.txtbx_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_cliBindingSource, "nome_razao_social", true));
            this.txtbx_nome.Location = new System.Drawing.Point(164, 68);
            this.txtbx_nome.Name = "txtbx_nome";
            this.txtbx_nome.Size = new System.Drawing.Size(542, 22);
            this.txtbx_nome.TabIndex = 20;
            // 
            // cmbbx_cpf_cnpj
            // 
            this.cmbbx_cpf_cnpj.FormattingEnabled = true;
            this.cmbbx_cpf_cnpj.Items.AddRange(new object[] {
            "CPF",
            "CNPJ"});
            this.cmbbx_cpf_cnpj.Location = new System.Drawing.Point(15, 107);
            this.cmbbx_cpf_cnpj.Name = "cmbbx_cpf_cnpj";
            this.cmbbx_cpf_cnpj.Size = new System.Drawing.Size(121, 24);
            this.cmbbx_cpf_cnpj.TabIndex = 21;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(164, 107);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(282, 22);
            this.maskedTextBox1.TabIndex = 22;
            // 
            // frm_cadCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.ControlBox = false;
            this.Controls.Add(this.panel_cadastro);
            this.Controls.Add(this.panel1);
            this.Name = "frm_cadCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_cadCli";
            this.Load += new System.EventHandler(this.frm_cadCli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glturfreDeployDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cad_cliBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel_cadastro.ResumeLayout(false);
            this.panel_cadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private glturfreDeployDataSet glturfreDeployDataSet;
        private System.Windows.Forms.BindingSource cad_cliBindingSource;
        private glturfreDeployDataSetTableAdapters.cad_cliTableAdapter cad_cliTableAdapter;
        private glturfreDeployDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_consulta_cliente;
        private System.Windows.Forms.Panel panel_cadastro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox cmbbx_cpf_cnpj;
        private System.Windows.Forms.TextBox txtbx_nome;
    }
}