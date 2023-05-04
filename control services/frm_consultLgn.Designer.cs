namespace control_services
{
    partial class frm_consultLgn
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
            System.Windows.Forms.Label ativoLabel;
            System.Windows.Forms.Label snhLabel;
            System.Windows.Forms.Label lgnLabel;
            System.Windows.Forms.Label id_userLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_consultLgn));
            this.gldturfreDeployDataSet = new control_services.gldturfreDeployDataSet();
            this.lgn_usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lgn_usersTableAdapter = new control_services.gldturfreDeployDataSetTableAdapters.lgn_usersTableAdapter();
            this.tableAdapterManager = new control_services.gldturfreDeployDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbt_ConfSenha = new System.Windows.Forms.RadioButton();
            this.rdbt_Senha = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtbx_ConfSnh = new System.Windows.Forms.TextBox();
            this.id_userLabel2 = new System.Windows.Forms.Label();
            this.lgnTextBox = new System.Windows.Forms.TextBox();
            this.snhTextBox = new System.Windows.Forms.TextBox();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_consulta_cliente = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.lgn_usersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdbtLgn = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbx_procuarLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ativoLabel = new System.Windows.Forms.Label();
            snhLabel = new System.Windows.Forms.Label();
            lgnLabel = new System.Windows.Forms.Label();
            id_userLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gldturfreDeployDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgn_usersBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lgn_usersBindingNavigator)).BeginInit();
            this.lgn_usersBindingNavigator.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ativoLabel.Location = new System.Drawing.Point(14, 286);
            ativoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(62, 25);
            ativoLabel.TabIndex = 14;
            ativoLabel.Text = "Ativo:";
            // 
            // snhLabel
            // 
            snhLabel.AutoSize = true;
            snhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            snhLabel.Location = new System.Drawing.Point(15, 168);
            snhLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            snhLabel.Name = "snhLabel";
            snhLabel.Size = new System.Drawing.Size(76, 25);
            snhLabel.TabIndex = 12;
            snhLabel.Text = "Senha:";
            // 
            // lgnLabel
            // 
            lgnLabel.AutoSize = true;
            lgnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lgnLabel.Location = new System.Drawing.Point(15, 92);
            lgnLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lgnLabel.Name = "lgnLabel";
            lgnLabel.Size = new System.Drawing.Size(66, 25);
            lgnLabel.TabIndex = 10;
            lgnLabel.Text = "Login:";
            lgnLabel.Click += new System.EventHandler(this.lgnLabel_Click);
            // 
            // id_userLabel
            // 
            id_userLabel.AutoSize = true;
            id_userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_userLabel.Location = new System.Drawing.Point(15, 31);
            id_userLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_userLabel.Name = "id_userLabel";
            id_userLabel.Size = new System.Drawing.Size(109, 25);
            id_userLabel.TabIndex = 8;
            id_userLabel.Text = "ID Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(15, 228);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(166, 25);
            label1.TabIndex = 17;
            label1.Text = "Confirmar Senha:";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbt_ConfSenha);
            this.panel1.Controls.Add(this.rdbt_Senha);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.txtbx_ConfSnh);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.id_userLabel2);
            this.panel1.Controls.Add(id_userLabel);
            this.panel1.Controls.Add(lgnLabel);
            this.panel1.Controls.Add(this.lgnTextBox);
            this.panel1.Controls.Add(snhLabel);
            this.panel1.Controls.Add(this.snhTextBox);
            this.panel1.Controls.Add(ativoLabel);
            this.panel1.Controls.Add(this.ativoCheckBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 231);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 386);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rdbt_ConfSenha
            // 
            this.rdbt_ConfSenha.AutoSize = true;
            this.rdbt_ConfSenha.Location = new System.Drawing.Point(393, 234);
            this.rdbt_ConfSenha.Name = "rdbt_ConfSenha";
            this.rdbt_ConfSenha.Size = new System.Drawing.Size(17, 16);
            this.rdbt_ConfSenha.TabIndex = 36;
            this.rdbt_ConfSenha.TabStop = true;
            this.rdbt_ConfSenha.UseVisualStyleBackColor = true;
            // 
            // rdbt_Senha
            // 
            this.rdbt_Senha.AutoSize = true;
            this.rdbt_Senha.Location = new System.Drawing.Point(393, 168);
            this.rdbt_Senha.Name = "rdbt_Senha";
            this.rdbt_Senha.Size = new System.Drawing.Size(17, 16);
            this.rdbt_Senha.TabIndex = 35;
            this.rdbt_Senha.TabStop = true;
            this.rdbt_Senha.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 361);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip1.Size = new System.Drawing.Size(435, 25);
            this.statusStrip1.TabIndex = 34;
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
            // txtbx_ConfSnh
            // 
            this.txtbx_ConfSnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_ConfSnh.Location = new System.Drawing.Point(230, 224);
            this.txtbx_ConfSnh.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_ConfSnh.Name = "txtbx_ConfSnh";
            this.txtbx_ConfSnh.Size = new System.Drawing.Size(155, 30);
            this.txtbx_ConfSnh.TabIndex = 18;
            this.txtbx_ConfSnh.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // id_userLabel2
            // 
            this.id_userLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lgn_usersBindingSource, "id_user", true));
            this.id_userLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_userLabel2.Location = new System.Drawing.Point(159, 34);
            this.id_userLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id_userLabel2.Name = "id_userLabel2";
            this.id_userLabel2.Size = new System.Drawing.Size(125, 29);
            this.id_userLabel2.TabIndex = 16;
            this.id_userLabel2.Text = "label1";
            // 
            // lgnTextBox
            // 
            this.lgnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lgn_usersBindingSource, "lgn", true));
            this.lgnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgnTextBox.Location = new System.Drawing.Point(118, 89);
            this.lgnTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lgnTextBox.Name = "lgnTextBox";
            this.lgnTextBox.Size = new System.Drawing.Size(268, 30);
            this.lgnTextBox.TabIndex = 11;
            // 
            // snhTextBox
            // 
            this.snhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lgn_usersBindingSource, "snh", true));
            this.snhTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snhTextBox.Location = new System.Drawing.Point(118, 161);
            this.snhTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.snhTextBox.Name = "snhTextBox";
            this.snhTextBox.Size = new System.Drawing.Size(268, 30);
            this.snhTextBox.TabIndex = 13;
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.lgn_usersBindingSource, "ativo", true));
            this.ativoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ativoCheckBox.Location = new System.Drawing.Point(84, 284);
            this.ativoCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(130, 30);
            this.ativoCheckBox.TabIndex = 15;
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            this.ativoCheckBox.CheckedChanged += new System.EventHandler(this.ativoCheckBox_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_salvar);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.btn_consulta_cliente);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 112);
            this.panel2.TabIndex = 13;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_salvar.Image = global::control_services.Properties.Resources._003_ponto_de_verificacao;
            this.btn_salvar.Location = new System.Drawing.Point(224, 0);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(112, 112);
            this.btn_salvar.TabIndex = 3;
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_add
            // 
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_add.Image = global::control_services.Properties.Resources._005_crio;
            this.btn_add.Location = new System.Drawing.Point(112, 0);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 112);
            this.btn_add.TabIndex = 2;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_consulta_cliente
            // 
            this.btn_consulta_cliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_consulta_cliente.Enabled = false;
            this.btn_consulta_cliente.Image = global::control_services.Properties.Resources._001_analytic;
            this.btn_consulta_cliente.Location = new System.Drawing.Point(0, 0);
            this.btn_consulta_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_consulta_cliente.Name = "btn_consulta_cliente";
            this.btn_consulta_cliente.Size = new System.Drawing.Size(112, 112);
            this.btn_consulta_cliente.TabIndex = 1;
            this.btn_consulta_cliente.UseVisualStyleBackColor = true;
            this.btn_consulta_cliente.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_sair);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(323, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(112, 112);
            this.panel3.TabIndex = 0;
            // 
            // btn_sair
            // 
            this.btn_sair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_sair.Image = global::control_services.Properties.Resources._001_exit1;
            this.btn_sair.Location = new System.Drawing.Point(0, 0);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(112, 112);
            this.btn_sair.TabIndex = 0;
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(62, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // lgn_usersBindingNavigator
            // 
            this.lgn_usersBindingNavigator.AddNewItem = null;
            this.lgn_usersBindingNavigator.BindingSource = this.lgn_usersBindingSource;
            this.lgn_usersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lgn_usersBindingNavigator.DeleteItem = null;
            this.lgn_usersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lgn_usersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.lgn_usersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lgn_usersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lgn_usersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lgn_usersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lgn_usersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lgn_usersBindingNavigator.Name = "lgn_usersBindingNavigator";
            this.lgn_usersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lgn_usersBindingNavigator.Size = new System.Drawing.Size(435, 27);
            this.lgn_usersBindingNavigator.TabIndex = 0;
            this.lgn_usersBindingNavigator.Text = "bindingNavigator1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdbtLgn);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.txtbx_procuarLogin);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(435, 92);
            this.panel4.TabIndex = 14;
            // 
            // rdbtLgn
            // 
            this.rdbtLgn.AutoSize = true;
            this.rdbtLgn.Location = new System.Drawing.Point(320, 40);
            this.rdbtLgn.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtLgn.Name = "rdbtLgn";
            this.rdbtLgn.Size = new System.Drawing.Size(17, 16);
            this.rdbtLgn.TabIndex = 27;
            this.rdbtLgn.TabStop = true;
            this.rdbtLgn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 76);
            this.button1.TabIndex = 25;
            this.button1.Text = "Procurar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtbx_procuarLogin
            // 
            this.txtbx_procuarLogin.Location = new System.Drawing.Point(188, 33);
            this.txtbx_procuarLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_procuarLogin.Name = "txtbx_procuarLogin";
            this.txtbx_procuarLogin.Size = new System.Drawing.Size(124, 26);
            this.txtbx_procuarLogin.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Procurar pelo Login:";
            // 
            // frm_consultLgn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 617);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lgn_usersBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_consultLgn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Login";
            this.Load += new System.EventHandler(this.frm_consultLgn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gldturfreDeployDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgn_usersBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lgn_usersBindingNavigator)).EndInit();
            this.lgn_usersBindingNavigator.ResumeLayout(false);
            this.lgn_usersBindingNavigator.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private gldturfreDeployDataSet gldturfreDeployDataSet;
        private System.Windows.Forms.BindingSource lgn_usersBindingSource;
        private gldturfreDeployDataSetTableAdapters.lgn_usersTableAdapter lgn_usersTableAdapter;
        private gldturfreDeployDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_consulta_cliente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.TextBox txtbx_ConfSnh;
        private System.Windows.Forms.Label id_userLabel2;
        private System.Windows.Forms.TextBox lgnTextBox;
        private System.Windows.Forms.TextBox snhTextBox;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rdbt_ConfSenha;
        private System.Windows.Forms.RadioButton rdbt_Senha;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.BindingNavigator lgn_usersBindingNavigator;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdbtLgn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbx_procuarLogin;
        private System.Windows.Forms.Label label3;
    }
}