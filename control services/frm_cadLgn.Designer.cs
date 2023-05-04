namespace control_services
{
    partial class frm_cadLgn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_consulta_cliente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gldturfreDeployDataSet = new control_services.gldturfreDeployDataSet();
            this.lgn_usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lgn_usersTableAdapter = new control_services.gldturfreDeployDataSetTableAdapters.lgn_usersTableAdapter();
            this.tableAdapterManager = new control_services.gldturfreDeployDataSetTableAdapters.TableAdapterManager();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdbt_ConfSenha = new System.Windows.Forms.RadioButton();
            this.rdbt_Senha = new System.Windows.Forms.RadioButton();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.txtbx_ConfSnh = new System.Windows.Forms.TextBox();
            this.txtbx_Snh = new System.Windows.Forms.TextBox();
            this.txtbx_Lgn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gldturfreDeployDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgn_usersBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(476, 85);
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
            this.btn_consulta_cliente.Click += new System.EventHandler(this.btn_consulta_cliente_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_sair);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(386, 0);
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
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 352);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(476, 25);
            this.statusStrip1.TabIndex = 32;
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
            // gldturfreDeployDataSet
            // 
            this.gldturfreDeployDataSet.DataSetName = "gldturfreDeployDataSet";
            this.gldturfreDeployDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lgn_usersBindingSource
            // 
            this.lgn_usersBindingSource.DataMember = "lgn_users";
            this.lgn_usersBindingSource.DataSource = this.gldturfreDeployDataSet;
            // 
            // lgn_usersTableAdapter
            // 
            this.lgn_usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cad_cliTableAdapter = null;
            this.tableAdapterManager.cad_funTableAdapter = null;
            this.tableAdapterManager.categ_veiculoTableAdapter = null;
            this.tableAdapterManager.estadoTableAdapter = null;
            this.tableAdapterManager.lgn_usersTableAdapter = this.lgn_usersTableAdapter;
            this.tableAdapterManager.orcamentoTableAdapter = null;
            this.tableAdapterManager.tabela_BateVoltaTableAdapter = null;
            this.tableAdapterManager.tabela_FerProTableAdapter = null;
            this.tableAdapterManager.tabela_FimSemTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = control_services.gldturfreDeployDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veiculoTableAdapter = null;
            this.tableAdapterManager.viagem_fechadaTableAdapter = null;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdbt_ConfSenha);
            this.panel3.Controls.Add(this.rdbt_Senha);
            this.panel3.Controls.Add(this.ativoCheckBox);
            this.panel3.Controls.Add(this.txtbx_ConfSnh);
            this.panel3.Controls.Add(this.txtbx_Snh);
            this.panel3.Controls.Add(this.txtbx_Lgn);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(0, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 267);
            this.panel3.TabIndex = 34;
            // 
            // rdbt_ConfSenha
            // 
            this.rdbt_ConfSenha.AutoSize = true;
            this.rdbt_ConfSenha.Location = new System.Drawing.Point(369, 141);
            this.rdbt_ConfSenha.Name = "rdbt_ConfSenha";
            this.rdbt_ConfSenha.Size = new System.Drawing.Size(17, 16);
            this.rdbt_ConfSenha.TabIndex = 51;
            this.rdbt_ConfSenha.TabStop = true;
            this.rdbt_ConfSenha.UseVisualStyleBackColor = true;
            // 
            // rdbt_Senha
            // 
            this.rdbt_Senha.AutoSize = true;
            this.rdbt_Senha.Location = new System.Drawing.Point(369, 93);
            this.rdbt_Senha.Name = "rdbt_Senha";
            this.rdbt_Senha.Size = new System.Drawing.Size(17, 16);
            this.rdbt_Senha.TabIndex = 50;
            this.rdbt_Senha.TabStop = true;
            this.rdbt_Senha.UseVisualStyleBackColor = true;
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.lgn_usersBindingSource, "ativo", true));
            this.ativoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ativoCheckBox.Location = new System.Drawing.Point(158, 190);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.ativoCheckBox.TabIndex = 49;
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // txtbx_ConfSnh
            // 
            this.txtbx_ConfSnh.Location = new System.Drawing.Point(158, 140);
            this.txtbx_ConfSnh.Name = "txtbx_ConfSnh";
            this.txtbx_ConfSnh.Size = new System.Drawing.Size(205, 22);
            this.txtbx_ConfSnh.TabIndex = 48;
            // 
            // txtbx_Snh
            // 
            this.txtbx_Snh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lgn_usersBindingSource, "snh", true));
            this.txtbx_Snh.Location = new System.Drawing.Point(158, 92);
            this.txtbx_Snh.Name = "txtbx_Snh";
            this.txtbx_Snh.Size = new System.Drawing.Size(205, 22);
            this.txtbx_Snh.TabIndex = 47;
            // 
            // txtbx_Lgn
            // 
            this.txtbx_Lgn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lgn_usersBindingSource, "lgn", true));
            this.txtbx_Lgn.Location = new System.Drawing.Point(158, 42);
            this.txtbx_Lgn.Name = "txtbx_Lgn";
            this.txtbx_Lgn.Size = new System.Drawing.Size(205, 22);
            this.txtbx_Lgn.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Ativo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Conf. Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Senha: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Login: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_cadLgn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 377);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_cadLgn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Login";
            this.Load += new System.EventHandler(this.frm_cadLgn_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gldturfreDeployDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgn_usersBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_consulta_cliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private gldturfreDeployDataSet gldturfreDeployDataSet;
        private System.Windows.Forms.BindingSource lgn_usersBindingSource;
        private gldturfreDeployDataSetTableAdapters.lgn_usersTableAdapter lgn_usersTableAdapter;
        private gldturfreDeployDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.TextBox txtbx_ConfSnh;
        private System.Windows.Forms.TextBox txtbx_Snh;
        private System.Windows.Forms.TextBox txtbx_Lgn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rdbt_ConfSenha;
        private System.Windows.Forms.RadioButton rdbt_Senha;
    }
}