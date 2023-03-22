namespace control_services
{
    partial class frm_lgn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbx_lgn = new System.Windows.Forms.TextBox();
            this.txtbx_snh = new System.Windows.Forms.TextBox();
            this.ver_senha = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableAdapterManager = new control_services.glturfreDeployDataSetTableAdapters.TableAdapterManager();
            this.gldturfreDeployDataSet = new control_services.gldturfreDeployDataSet();
            this.cad_funBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cad_funTableAdapter = new control_services.gldturfreDeployDataSetTableAdapters.cad_funTableAdapter();
            this.tableAdapterManager1 = new control_services.gldturfreDeployDataSetTableAdapters.TableAdapterManager();
            this.lgn_usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lgn_usersTableAdapter = new control_services.gldturfreDeployDataSetTableAdapters.lgn_usersTableAdapter();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gldturfreDeployDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cad_funBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgn_usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(374, 25);
            this.statusStrip1.TabIndex = 2;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::control_services.Properties.Resources.logo_gold;
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtbx_lgn
            // 
            this.txtbx_lgn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_lgn.Location = new System.Drawing.Point(99, 256);
            this.txtbx_lgn.Name = "txtbx_lgn";
            this.txtbx_lgn.Size = new System.Drawing.Size(234, 30);
            this.txtbx_lgn.TabIndex = 1;
            // 
            // txtbx_snh
            // 
            this.txtbx_snh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_snh.Location = new System.Drawing.Point(99, 310);
            this.txtbx_snh.Name = "txtbx_snh";
            this.txtbx_snh.PasswordChar = '*';
            this.txtbx_snh.Size = new System.Drawing.Size(234, 30);
            this.txtbx_snh.TabIndex = 2;
            // 
            // ver_senha
            // 
            this.ver_senha.AutoSize = true;
            this.ver_senha.Location = new System.Drawing.Point(341, 319);
            this.ver_senha.Name = "ver_senha";
            this.ver_senha.Size = new System.Drawing.Size(18, 17);
            this.ver_senha.TabIndex = 6;
            this.ver_senha.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "&Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.tableAdapterManager.cad_loginTableAdapter = null;
            this.tableAdapterManager.categ_veiculoTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            // gldturfreDeployDataSet
            // 
            this.gldturfreDeployDataSet.DataSetName = "gldturfreDeployDataSet";
            this.gldturfreDeployDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cad_funBindingSource
            // 
            this.cad_funBindingSource.DataMember = "cad_fun";
            this.cad_funBindingSource.DataSource = this.gldturfreDeployDataSet;
            // 
            // cad_funTableAdapter
            // 
            this.cad_funTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.cad_clieTableAdapter = null;
            this.tableAdapterManager1.cad_funTableAdapter = this.cad_funTableAdapter;
            this.tableAdapterManager1.categ_veiculoTableAdapter = null;
            this.tableAdapterManager1.estadoTableAdapter = null;
            this.tableAdapterManager1.lgn_usersTableAdapter = null;
            this.tableAdapterManager1.orcamentoTableAdapter = null;
            this.tableAdapterManager1.tabela_BateVoltaTableAdapter = null;
            this.tableAdapterManager1.tabela_FerProTableAdapter = null;
            this.tableAdapterManager1.tabela_FimSemTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = control_services.gldturfreDeployDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.veiculoTableAdapter = null;
            this.tableAdapterManager1.viagem_fechadaTableAdapter = null;
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
            // frm_lgn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 544);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ver_senha);
            this.Controls.Add(this.txtbx_snh);
            this.Controls.Add(this.txtbx_lgn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_lgn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_lgn";
            this.Load += new System.EventHandler(this.frm_lgn_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gldturfreDeployDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cad_funBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgn_usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.TextBox txtbx_lgn;
        private System.Windows.Forms.TextBox txtbx_snh;
        private System.Windows.Forms.CheckBox ver_senha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private glturfreDeployDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private gldturfreDeployDataSet gldturfreDeployDataSet;
        private System.Windows.Forms.BindingSource cad_funBindingSource;
        private gldturfreDeployDataSetTableAdapters.cad_funTableAdapter cad_funTableAdapter;
        private gldturfreDeployDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource lgn_usersBindingSource;
        private gldturfreDeployDataSetTableAdapters.lgn_usersTableAdapter lgn_usersTableAdapter;
    }
}