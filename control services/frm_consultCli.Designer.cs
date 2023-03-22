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
            System.Windows.Forms.Label id_cliLabel;
            System.Windows.Forms.Label nome_razao_socialLabel;
            System.Windows.Forms.Label cpf_cnpjLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telefoneLabel;
            this.glturfreDeployDataSet = new control_services.glturfreDeployDataSet();
            this.cad_cliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cad_cliTableAdapter = new control_services.glturfreDeployDataSetTableAdapters.cad_cliTableAdapter();
            this.tableAdapterManager = new control_services.glturfreDeployDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_CpfCnpj = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkbx_PesquisaCPF = new System.Windows.Forms.CheckBox();
            this.chkbx_PesquisaNome = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbx_nome = new System.Windows.Forms.TextBox();
            this.msktxbx_CpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.cmb_CpfCnpj = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            id_cliLabel = new System.Windows.Forms.Label();
            nome_razao_socialLabel = new System.Windows.Forms.Label();
            cpf_cnpjLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.glturfreDeployDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cad_cliBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_cliLabel
            // 
            id_cliLabel.AutoSize = true;
            id_cliLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_cliLabel.Location = new System.Drawing.Point(12, 44);
            id_cliLabel.Name = "id_cliLabel";
            id_cliLabel.Size = new System.Drawing.Size(53, 24);
            id_cliLabel.TabIndex = 11;
            id_cliLabel.Text = "id cli:";
            // 
            // nome_razao_socialLabel
            // 
            nome_razao_socialLabel.AutoSize = true;
            nome_razao_socialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_razao_socialLabel.Location = new System.Drawing.Point(6, 88);
            nome_razao_socialLabel.Name = "nome_razao_socialLabel";
            nome_razao_socialLabel.Size = new System.Drawing.Size(171, 24);
            nome_razao_socialLabel.TabIndex = 13;
            nome_razao_socialLabel.Text = "Nome razao social:";
            // 
            // cpf_cnpjLabel
            // 
            cpf_cnpjLabel.AutoSize = true;
            cpf_cnpjLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpf_cnpjLabel.Location = new System.Drawing.Point(228, 44);
            cpf_cnpjLabel.Name = "cpf_cnpjLabel";
            cpf_cnpjLabel.Size = new System.Drawing.Size(132, 24);
            cpf_cnpjLabel.TabIndex = 15;
            cpf_cnpjLabel.Text = "CPF ou CNPJ:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(12, 132);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(60, 24);
            emailLabel.TabIndex = 17;
            emailLabel.Text = "email:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefoneLabel.Location = new System.Drawing.Point(540, 44);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(90, 24);
            telefoneLabel.TabIndex = 19;
            telefoneLabel.Text = "Telefone:";
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
            this.tableAdapterManager.batevolta_carroTableAdapter = null;
            this.tableAdapterManager.batevolta_conv47LTableAdapter = null;
            this.tableAdapterManager.batevolta_dd60LTableAdapter = null;
            this.tableAdapterManager.batevolta_dd64LTableAdapter = null;
            this.tableAdapterManager.batevolta_exec46LTableAdapter = null;
            this.tableAdapterManager.batevolta_exec50LTableAdapter = null;
            this.tableAdapterManager.batevolta_micro32LTableAdapter = null;
            this.tableAdapterManager.batevolta_semi46LTableAdapter = null;
            this.tableAdapterManager.batevolta_van15LTableAdapter = null;
            this.tableAdapterManager.batevolta_van18LTableAdapter = null;
            this.tableAdapterManager.cad_cliTableAdapter = this.cad_cliTableAdapter;
            this.tableAdapterManager.cad_funTableAdapter = null;
            this.tableAdapterManager.cad_loginTableAdapter = null;
            this.tableAdapterManager.categ_veiculoTableAdapter = null;
            this.tableAdapterManager.estadosTableAdapter = null;
            this.tableAdapterManager.ferpro_carroTableAdapter = null;
            this.tableAdapterManager.ferpro_conv47LTableAdapter = null;
            this.tableAdapterManager.ferpro_dd60LTableAdapter = null;
            this.tableAdapterManager.ferpro_dd64LTableAdapter = null;
            this.tableAdapterManager.ferpro_exec46LTableAdapter = null;
            this.tableAdapterManager.ferpro_exec50LTableAdapter = null;
            this.tableAdapterManager.ferpro_micro32LTableAdapter = null;
            this.tableAdapterManager.ferpro_semi46LTableAdapter = null;
            this.tableAdapterManager.ferpro_van15LTableAdapter = null;
            this.tableAdapterManager.ferpro_van18LTableAdapter = null;
            this.tableAdapterManager.fimsem_carroTableAdapter = null;
            this.tableAdapterManager.fimsem_conv47LTableAdapter = null;
            this.tableAdapterManager.fimsem_dd60LTableAdapter = null;
            this.tableAdapterManager.fimsem_dd64LTableAdapter = null;
            this.tableAdapterManager.fimsem_exec46LTableAdapter = null;
            this.tableAdapterManager.fimsem_exec50LTableAdapter = null;
            this.tableAdapterManager.fimsem_micro32LTableAdapter = null;
            this.tableAdapterManager.fimsem_semi46LTableAdapter = null;
            this.tableAdapterManager.fimsem_van15LTableAdapter = null;
            this.tableAdapterManager.fimsem_van18LTableAdapter = null;
            this.tableAdapterManager.orcamentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = control_services.glturfreDeployDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veiculoTableAdapter = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(id_cliLabel);
            this.groupBox1.Controls.Add(this.lbl_id);
            this.groupBox1.Controls.Add(nome_razao_socialLabel);
            this.groupBox1.Controls.Add(this.lbl_nome);
            this.groupBox1.Controls.Add(cpf_cnpjLabel);
            this.groupBox1.Controls.Add(this.lbl_CpfCnpj);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(telefoneLabel);
            this.groupBox1.Controls.Add(this.lbl_tel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro do Cliente";
            // 
            // lbl_id
            // 
            this.lbl_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_cliBindingSource, "id_cli", true));
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(80, 44);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(100, 23);
            this.lbl_id.TabIndex = 12;
            // 
            // lbl_nome
            // 
            this.lbl_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_cliBindingSource, "nome_razao_social", true));
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(180, 88);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(584, 23);
            this.lbl_nome.TabIndex = 14;
            // 
            // lbl_CpfCnpj
            // 
            this.lbl_CpfCnpj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_cliBindingSource, "cpf_cnpj", true));
            this.lbl_CpfCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CpfCnpj.Location = new System.Drawing.Point(366, 44);
            this.lbl_CpfCnpj.Name = "lbl_CpfCnpj";
            this.lbl_CpfCnpj.Size = new System.Drawing.Size(168, 23);
            this.lbl_CpfCnpj.TabIndex = 16;
            // 
            // lbl_email
            // 
            this.lbl_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_cliBindingSource, "email", true));
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(78, 132);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(686, 23);
            this.lbl_email.TabIndex = 18;
            // 
            // lbl_tel
            // 
            this.lbl_tel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_cliBindingSource, "telefone", true));
            this.lbl_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tel.Location = new System.Drawing.Point(628, 44);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(176, 23);
            this.lbl_tel.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkbx_PesquisaCPF);
            this.groupBox2.Controls.Add(this.chkbx_PesquisaNome);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtbx_nome);
            this.groupBox2.Controls.Add(this.msktxbx_CpfCnpj);
            this.groupBox2.Controls.Add(this.cmb_CpfCnpj);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(810, 147);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar";
            // 
            // chkbx_PesquisaCPF
            // 
            this.chkbx_PesquisaCPF.AutoSize = true;
            this.chkbx_PesquisaCPF.Location = new System.Drawing.Point(333, 90);
            this.chkbx_PesquisaCPF.Name = "chkbx_PesquisaCPF";
            this.chkbx_PesquisaCPF.Size = new System.Drawing.Size(187, 21);
            this.chkbx_PesquisaCPF.TabIndex = 6;
            this.chkbx_PesquisaCPF.Text = "Pesquisar por CPF/CNPJ";
            this.chkbx_PesquisaCPF.UseVisualStyleBackColor = true;
            // 
            // chkbx_PesquisaNome
            // 
            this.chkbx_PesquisaNome.AutoSize = true;
            this.chkbx_PesquisaNome.Location = new System.Drawing.Point(485, 42);
            this.chkbx_PesquisaNome.Name = "chkbx_PesquisaNome";
            this.chkbx_PesquisaNome.Size = new System.Drawing.Size(159, 21);
            this.chkbx_PesquisaNome.TabIndex = 5;
            this.chkbx_PesquisaNome.Text = "Pesquisar por Nome";
            this.chkbx_PesquisaNome.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::control_services.Properties.Resources.lupa;
            this.button1.Location = new System.Drawing.Point(723, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 72);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbx_nome
            // 
            this.txtbx_nome.Enabled = false;
            this.txtbx_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_nome.Location = new System.Drawing.Point(129, 39);
            this.txtbx_nome.Name = "txtbx_nome";
            this.txtbx_nome.Size = new System.Drawing.Size(350, 28);
            this.txtbx_nome.TabIndex = 3;
            this.txtbx_nome.TextChanged += new System.EventHandler(this.txtbx_nome_TextChanged);
            // 
            // msktxbx_CpfCnpj
            // 
            this.msktxbx_CpfCnpj.Enabled = false;
            this.msktxbx_CpfCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxbx_CpfCnpj.Location = new System.Drawing.Point(129, 83);
            this.msktxbx_CpfCnpj.Name = "msktxbx_CpfCnpj";
            this.msktxbx_CpfCnpj.Size = new System.Drawing.Size(198, 28);
            this.msktxbx_CpfCnpj.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_consultCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 334);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_consultCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Cliente";
            this.Load += new System.EventHandler(this.frm_consultCli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glturfreDeployDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cad_cliBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private glturfreDeployDataSet glturfreDeployDataSet;
        private System.Windows.Forms.BindingSource cad_cliBindingSource;
        private glturfreDeployDataSetTableAdapters.cad_cliTableAdapter cad_cliTableAdapter;
        private glturfreDeployDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_CpfCnpj;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_CpfCnpj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkbx_PesquisaCPF;
        private System.Windows.Forms.CheckBox chkbx_PesquisaNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbx_nome;
        private System.Windows.Forms.MaskedTextBox msktxbx_CpfCnpj;
        private System.Windows.Forms.Timer timer1;
    }
}