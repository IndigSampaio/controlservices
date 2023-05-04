namespace control_services
{
    partial class frm_cadVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadVeiculo));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gldturfreDeployDataSet = new control_services.gldturfreDeployDataSet();
            this.veiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veiculoTableAdapter = new control_services.gldturfreDeployDataSetTableAdapters.veiculoTableAdapter();
            this.tableAdapterManager = new control_services.gldturfreDeployDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_CatVeiculo = new System.Windows.Forms.ComboBox();
            this.txtbx_PrefixoVeiculo = new System.Windows.Forms.TextBox();
            this.txtbx_Placa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkbx_Ativo = new System.Windows.Forms.CheckBox();
            this.categveiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categ_veiculoTableAdapter = new control_services.gldturfreDeployDataSetTableAdapters.categ_veiculoTableAdapter();
            button2 = new System.Windows.Forms.Button();
            btnSalvar = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gldturfreDeployDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categveiculoBindingSource)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(558, 86);
            this.panel2.TabIndex = 124;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(469, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(89, 86);
            this.panel3.TabIndex = 46;
            // 
            // button2
            // 
            button2.Dock = System.Windows.Forms.DockStyle.Right;
            button2.Image = global::control_services.Properties.Resources._001_exit1;
            button2.Location = new System.Drawing.Point(-1, 0);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(90, 86);
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
            btnSalvar.Size = new System.Drawing.Size(90, 86);
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
            btnAdd.Size = new System.Drawing.Size(90, 86);
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
            button1.Size = new System.Drawing.Size(90, 86);
            button1.TabIndex = 43;
            button1.Tag = "Consultar";
            button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            // 
            // gldturfreDeployDataSet
            // 
            this.gldturfreDeployDataSet.DataSetName = "gldturfreDeployDataSet";
            this.gldturfreDeployDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veiculoBindingSource
            // 
            this.veiculoBindingSource.DataMember = "veiculo";
            this.veiculoBindingSource.DataSource = this.gldturfreDeployDataSet;
            // 
            // veiculoTableAdapter
            // 
            this.veiculoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cad_cliTableAdapter = null;
            this.tableAdapterManager.cad_funTableAdapter = null;
            this.tableAdapterManager.categ_veiculoTableAdapter = this.categ_veiculoTableAdapter;
            this.tableAdapterManager.estadoTableAdapter = null;
            this.tableAdapterManager.lgn_usersTableAdapter = null;
            this.tableAdapterManager.orcamentoTableAdapter = null;
            this.tableAdapterManager.tabela_BateVoltaTableAdapter = null;
            this.tableAdapterManager.tabela_FerProTableAdapter = null;
            this.tableAdapterManager.tabela_FimSemTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = control_services.gldturfreDeployDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veiculoTableAdapter = this.veiculoTableAdapter;
            this.tableAdapterManager.viagem_fechadaTableAdapter = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 126;
            this.label1.Text = "Veiculo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 127;
            this.label2.Text = "Cat. do Veiculo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 128;
            this.label3.Text = "Placa:";
            // 
            // cmb_CatVeiculo
            // 
            this.cmb_CatVeiculo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.veiculoBindingSource, "categ_veiculo", true));
            this.cmb_CatVeiculo.DataSource = this.categveiculoBindingSource;
            this.cmb_CatVeiculo.DisplayMember = "categoria";
            this.cmb_CatVeiculo.Enabled = false;
            this.cmb_CatVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CatVeiculo.FormattingEnabled = true;
            this.cmb_CatVeiculo.Location = new System.Drawing.Point(165, 120);
            this.cmb_CatVeiculo.Name = "cmb_CatVeiculo";
            this.cmb_CatVeiculo.Size = new System.Drawing.Size(309, 28);
            this.cmb_CatVeiculo.TabIndex = 129;
            this.cmb_CatVeiculo.ValueMember = "id_categoria";
            // 
            // txtbx_PrefixoVeiculo
            // 
            this.txtbx_PrefixoVeiculo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.veiculoBindingSource, "veiculo", true));
            this.txtbx_PrefixoVeiculo.Enabled = false;
            this.txtbx_PrefixoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_PrefixoVeiculo.Location = new System.Drawing.Point(165, 205);
            this.txtbx_PrefixoVeiculo.Name = "txtbx_PrefixoVeiculo";
            this.txtbx_PrefixoVeiculo.Size = new System.Drawing.Size(309, 26);
            this.txtbx_PrefixoVeiculo.TabIndex = 130;
            // 
            // txtbx_Placa
            // 
            this.txtbx_Placa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbx_Placa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.veiculoBindingSource, "placa", true));
            this.txtbx_Placa.Enabled = false;
            this.txtbx_Placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Placa.Location = new System.Drawing.Point(165, 293);
            this.txtbx_Placa.Name = "txtbx_Placa";
            this.txtbx_Placa.Size = new System.Drawing.Size(309, 26);
            this.txtbx_Placa.TabIndex = 131;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 132;
            this.label4.Text = "Ativo:";
            // 
            // chkbx_Ativo
            // 
            this.chkbx_Ativo.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.veiculoBindingSource, "ativo", true));
            this.chkbx_Ativo.Enabled = false;
            this.chkbx_Ativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbx_Ativo.Location = new System.Drawing.Point(165, 387);
            this.chkbx_Ativo.Name = "chkbx_Ativo";
            this.chkbx_Ativo.Size = new System.Drawing.Size(104, 24);
            this.chkbx_Ativo.TabIndex = 133;
            this.chkbx_Ativo.UseVisualStyleBackColor = true;
            // 
            // categveiculoBindingSource
            // 
            this.categveiculoBindingSource.DataMember = "categ_veiculo";
            this.categveiculoBindingSource.DataSource = this.gldturfreDeployDataSet;
            // 
            // categ_veiculoTableAdapter
            // 
            this.categ_veiculoTableAdapter.ClearBeforeFill = true;
            // 
            // frm_cadVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 523);
            this.ControlBox = false;
            this.Controls.Add(this.chkbx_Ativo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbx_Placa);
            this.Controls.Add(this.txtbx_PrefixoVeiculo);
            this.Controls.Add(this.cmb_CatVeiculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_cadVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Veiculo";
            this.Load += new System.EventHandler(this.frm_cadVeiculo_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gldturfreDeployDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categveiculoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private gldturfreDeployDataSet gldturfreDeployDataSet;
        private System.Windows.Forms.BindingSource veiculoBindingSource;
        private gldturfreDeployDataSetTableAdapters.veiculoTableAdapter veiculoTableAdapter;
        private gldturfreDeployDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_CatVeiculo;
        private System.Windows.Forms.TextBox txtbx_PrefixoVeiculo;
        private System.Windows.Forms.TextBox txtbx_Placa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkbx_Ativo;
        private gldturfreDeployDataSetTableAdapters.categ_veiculoTableAdapter categ_veiculoTableAdapter;
        private System.Windows.Forms.BindingSource categveiculoBindingSource;
    }
}