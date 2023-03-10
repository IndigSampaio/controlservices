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
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button btnSalvar;
            System.Windows.Forms.Button btnAdd;
            System.Windows.Forms.Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadLgn));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_cadLgn = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_lgn = new System.Windows.Forms.TextBox();
            this.txtbx_snh = new System.Windows.Forms.TextBox();
            this.txtbx_ConfSnh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkbx_VerSnh = new System.Windows.Forms.CheckBox();
            this.chkbx_VerConfSnh = new System.Windows.Forms.CheckBox();
            this.chkbx_ativo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer_ConfSenhaErrado = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.glturfreDeployDataSet = new control_services.glturfreDeployDataSet();
            this.cad_loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cad_loginTableAdapter = new control_services.glturfreDeployDataSetTableAdapters.cad_loginTableAdapter();
            this.tableAdapterManager = new control_services.glturfreDeployDataSetTableAdapters.TableAdapterManager();
            this.timer_ConfVerSnh = new System.Windows.Forms.Timer(this.components);
            this.timer_VerSnh = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            button2 = new System.Windows.Forms.Button();
            btnSalvar = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_cadLgn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glturfreDeployDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cad_loginBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(btnSalvar);
            this.panel2.Controls.Add(btnAdd);
            this.panel2.Controls.Add(button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 85);
            this.panel2.TabIndex = 44;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(563, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(89, 85);
            this.panel3.TabIndex = 46;
            // 
            // button2
            // 
            button2.BackgroundImage = global::control_services.Properties.Resources._001_exit1;
            button2.Dock = System.Windows.Forms.DockStyle.Right;
            button2.Location = new System.Drawing.Point(-1, 0);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(90, 85);
            button2.TabIndex = 46;
            button2.Tag = "Salvar";
            button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalvar
            // 
            btnSalvar.Dock = System.Windows.Forms.DockStyle.Left;
            btnSalvar.Image = global::control_services.Properties.Resources._003_ponto_de_verificacao;
            btnSalvar.Location = new System.Drawing.Point(180, 0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new System.Drawing.Size(90, 85);
            btnSalvar.TabIndex = 45;
            btnSalvar.Tag = "Salvar";
            btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAdd
            // 
            btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            btnAdd.Image = global::control_services.Properties.Resources._002_inserir;
            btnAdd.Location = new System.Drawing.Point(90, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(90, 85);
            btnAdd.TabIndex = 44;
            btnAdd.Tag = "Inserir";
            btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            button1.Dock = System.Windows.Forms.DockStyle.Left;
            button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            button1.Location = new System.Drawing.Point(0, 0);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(90, 85);
            button1.TabIndex = 43;
            button1.Tag = "Consultar";
            button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel_cadLgn
            // 
            this.panel_cadLgn.Controls.Add(this.label4);
            this.panel_cadLgn.Controls.Add(this.chkbx_ativo);
            this.panel_cadLgn.Controls.Add(this.chkbx_VerConfSnh);
            this.panel_cadLgn.Controls.Add(this.chkbx_VerSnh);
            this.panel_cadLgn.Controls.Add(this.txtbx_ConfSnh);
            this.panel_cadLgn.Controls.Add(this.label1);
            this.panel_cadLgn.Controls.Add(this.txtbx_snh);
            this.panel_cadLgn.Controls.Add(this.txtbx_lgn);
            this.panel_cadLgn.Controls.Add(this.label3);
            this.panel_cadLgn.Controls.Add(this.label2);
            this.panel_cadLgn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cadLgn.Location = new System.Drawing.Point(0, 85);
            this.panel_cadLgn.Name = "panel_cadLgn";
            this.panel_cadLgn.Size = new System.Drawing.Size(652, 321);
            this.panel_cadLgn.TabIndex = 45;
            this.panel_cadLgn.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_cadLgn_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login do Usuario :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha do Usuario :";
            // 
            // txtbx_lgn
            // 
            this.txtbx_lgn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_loginBindingSource, "lgn", true));
            this.txtbx_lgn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_lgn.Location = new System.Drawing.Point(189, 38);
            this.txtbx_lgn.Name = "txtbx_lgn";
            this.txtbx_lgn.Size = new System.Drawing.Size(234, 28);
            this.txtbx_lgn.TabIndex = 4;
            // 
            // txtbx_snh
            // 
            this.txtbx_snh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_loginBindingSource, "snh", true));
            this.txtbx_snh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_snh.Location = new System.Drawing.Point(189, 102);
            this.txtbx_snh.Name = "txtbx_snh";
            this.txtbx_snh.Size = new System.Drawing.Size(234, 28);
            this.txtbx_snh.TabIndex = 5;
            // 
            // txtbx_ConfSnh
            // 
            this.txtbx_ConfSnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_ConfSnh.Location = new System.Drawing.Point(189, 142);
            this.txtbx_ConfSnh.Name = "txtbx_ConfSnh";
            this.txtbx_ConfSnh.Size = new System.Drawing.Size(234, 28);
            this.txtbx_ConfSnh.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Confirmar Senha :";
            // 
            // chkbx_VerSnh
            // 
            this.chkbx_VerSnh.AutoSize = true;
            this.chkbx_VerSnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbx_VerSnh.Location = new System.Drawing.Point(429, 104);
            this.chkbx_VerSnh.Name = "chkbx_VerSnh";
            this.chkbx_VerSnh.Size = new System.Drawing.Size(96, 22);
            this.chkbx_VerSnh.TabIndex = 8;
            this.chkbx_VerSnh.Text = "Ver senha";
            this.chkbx_VerSnh.UseVisualStyleBackColor = true;
            // 
            // chkbx_VerConfSnh
            // 
            this.chkbx_VerConfSnh.AutoSize = true;
            this.chkbx_VerConfSnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbx_VerConfSnh.Location = new System.Drawing.Point(429, 144);
            this.chkbx_VerConfSnh.Name = "chkbx_VerConfSnh";
            this.chkbx_VerConfSnh.Size = new System.Drawing.Size(203, 22);
            this.chkbx_VerConfSnh.TabIndex = 9;
            this.chkbx_VerConfSnh.Text = "Ver confirmacao de senha";
            this.chkbx_VerConfSnh.UseVisualStyleBackColor = true;
            // 
            // chkbx_ativo
            // 
            this.chkbx_ativo.AutoSize = true;
            this.chkbx_ativo.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.cad_loginBindingSource, "ativo", true));
            this.chkbx_ativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbx_ativo.Location = new System.Drawing.Point(79, 215);
            this.chkbx_ativo.Name = "chkbx_ativo";
            this.chkbx_ativo.Size = new System.Drawing.Size(18, 17);
            this.chkbx_ativo.TabIndex = 10;
            this.chkbx_ativo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ativo :";
            // 
            // timer_ConfSenhaErrado
            // 
            this.timer_ConfSenhaErrado.Enabled = true;
            this.timer_ConfSenhaErrado.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // glturfreDeployDataSet
            // 
            this.glturfreDeployDataSet.DataSetName = "glturfreDeployDataSet";
            this.glturfreDeployDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cad_loginBindingSource
            // 
            this.cad_loginBindingSource.DataMember = "cad_login";
            this.cad_loginBindingSource.DataSource = this.glturfreDeployDataSet;
            // 
            // cad_loginTableAdapter
            // 
            this.cad_loginTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.cad_cliTableAdapter = null;
            this.tableAdapterManager.cad_funTableAdapter = null;
            this.tableAdapterManager.cad_loginTableAdapter = this.cad_loginTableAdapter;
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
            // timer_ConfVerSnh
            // 
            this.timer_ConfVerSnh.Enabled = true;
            this.timer_ConfVerSnh.Tick += new System.EventHandler(this.timer_ConfVerSnh_Tick);
            // 
            // timer_VerSnh
            // 
            this.timer_VerSnh.Enabled = true;
            this.timer_VerSnh.Tick += new System.EventHandler(this.timer_VerSnh_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 381);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(652, 25);
            this.statusStrip1.TabIndex = 46;
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
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(344, 20);
            this.toolStripStatusLabel2.Text = "Precisa de ajuda? Clique aqui e fale com o suporte";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // frm_cadLgn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 406);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel_cadLgn);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_cadLgn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Login";
            this.Load += new System.EventHandler(this.frm_cadLgn_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_cadLgn.ResumeLayout(false);
            this.panel_cadLgn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glturfreDeployDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cad_loginBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_cadLgn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkbx_ativo;
        private System.Windows.Forms.CheckBox chkbx_VerConfSnh;
        private System.Windows.Forms.CheckBox chkbx_VerSnh;
        private System.Windows.Forms.TextBox txtbx_ConfSnh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_snh;
        private System.Windows.Forms.TextBox txtbx_lgn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer_ConfSenhaErrado;
        private System.Windows.Forms.Timer timer2;
        private glturfreDeployDataSet glturfreDeployDataSet;
        private System.Windows.Forms.BindingSource cad_loginBindingSource;
        private glturfreDeployDataSetTableAdapters.cad_loginTableAdapter cad_loginTableAdapter;
        private glturfreDeployDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Timer timer_ConfVerSnh;
        private System.Windows.Forms.Timer timer_VerSnh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}