namespace control_services
{
    partial class frm_OrcForaTabela
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
            System.Windows.Forms.Button button3;
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button btnSalvar;
            System.Windows.Forms.Button btnAdd;
            System.Windows.Forms.Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_OrcForaTabela));
            System.Windows.Forms.Label id_orcamentoLabel;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label id_cliLabel;
            System.Windows.Forms.Label nome_razao_socialLabel;
            System.Windows.Forms.Label cpf_cnpjLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label num_enderecoLabel;
            System.Windows.Forms.Label complementoLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label estadoLabel;
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.chkbx_NotaFiscal = new System.Windows.Forms.CheckBox();
            this.txtbx_kmVolta = new System.Windows.Forms.TextBox();
            this.txtbx_kmIda = new System.Windows.Forms.TextBox();
            this.txtbx_CidadeDestino = new System.Windows.Forms.TextBox();
            this.orcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gldturfreDeployDataSet = new control_services.gldturfreDeployDataSet();
            this.txtbx_cidadePartida = new System.Windows.Forms.TextBox();
            this.chkbx_UsarValorCalculo = new System.Windows.Forms.CheckBox();
            this.lbl_ValorCalculo = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lbl_totalKm = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtbx_Fechamento = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbbx_CatVeiculo = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbbx_PeriodoViagem = new System.Windows.Forms.ComboBox();
            this.grpbx_InfCliente = new System.Windows.Forms.GroupBox();
            this.telefoneLabel2 = new System.Windows.Forms.Label();
            this.nome_razao_socialLabel2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_SelecionarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.msktxbx_CpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.cmbbx_mask_CpfCnpj = new System.Windows.Forms.ComboBox();
            this.cad_clieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_cliTextBox = new System.Windows.Forms.TextBox();
            this.cad_cliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nome_razao_socialTextBox = new System.Windows.Forms.TextBox();
            this.cpf_cnpjTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.num_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.complementoTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.txtbx_HoraRetorno = new System.Windows.Forms.MaskedTextBox();
            this.txtbx_DataRetorno = new System.Windows.Forms.MaskedTextBox();
            this.txtbx_HoraPartida = new System.Windows.Forms.MaskedTextBox();
            this.txtbx_DataPartida = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtbx_embarque5 = new System.Windows.Forms.TextBox();
            this.txtbx_embarque4 = new System.Windows.Forms.TextBox();
            this.txtbx_embarque3 = new System.Windows.Forms.TextBox();
            this.txtbx_embarque2 = new System.Windows.Forms.TextBox();
            this.txtbx_embarque1 = new System.Windows.Forms.TextBox();
            this.msktxbx_Embarque5 = new System.Windows.Forms.MaskedTextBox();
            this.msktxbx_Embarque4 = new System.Windows.Forms.MaskedTextBox();
            this.msktxbx_Embarque3 = new System.Windows.Forms.MaskedTextBox();
            this.msktxbx_Embarque2 = new System.Windows.Forms.MaskedTextBox();
            this.msktxbx_Embarque1 = new System.Windows.Forms.MaskedTextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.maskedTextBox10 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox9 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox8 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            //this.cad_clieTableAdapter = new control_services.gldturfreDeployDataSetTableAdapters.-cad_clieTableAdapter();
            this.tableAdapterManager = new control_services.gldturfreDeployDataSetTableAdapters.TableAdapterManager();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sfdSalvar = new System.Windows.Forms.SaveFileDialog();
            this.orcamentoTableAdapter = new control_services.gldturfreDeployDataSetTableAdapters.orcamentoTableAdapter();
            this.id_orcamentoTextBox = new System.Windows.Forms.TextBox();
            this.txtbx_idOrcString = new System.Windows.Forms.TextBox();
            this.cad_cliTableAdapter = new control_services.gldturfreDeployDataSetTableAdapters.cad_cliTableAdapter();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            btnSalvar = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            id_orcamentoLabel = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            id_cliLabel = new System.Windows.Forms.Label();
            nome_razao_socialLabel = new System.Windows.Forms.Label();
            cpf_cnpjLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            num_enderecoLabel = new System.Windows.Forms.Label();
            complementoLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gldturfreDeployDataSet)).BeginInit();
            this.grpbx_InfCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cad_clieBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cad_cliBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            button3.Dock = System.Windows.Forms.DockStyle.Left;
            button3.Image = global::control_services.Properties.Resources.whatsapp;
            button3.Location = new System.Drawing.Point(270, 0);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(90, 85);
            button3.TabIndex = 47;
            button3.Tag = "Salvar";
            button3.Text = "Orcamento WhatsApp";
            button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            button2.Dock = System.Windows.Forms.DockStyle.Right;
            button2.Image = global::control_services.Properties.Resources._001_exit1;
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
            // id_orcamentoLabel
            // 
            id_orcamentoLabel.AutoSize = true;
            id_orcamentoLabel.Location = new System.Drawing.Point(70, 843);
            id_orcamentoLabel.Name = "id_orcamentoLabel";
            id_orcamentoLabel.Size = new System.Drawing.Size(94, 17);
            id_orcamentoLabel.TabIndex = 58;
            id_orcamentoLabel.Text = "id orcamento:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(27, 871);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(137, 17);
            label14.TabIndex = 61;
            label14.Text = "id orcamento_string:";
            // 
            // id_cliLabel
            // 
            id_cliLabel.AutoSize = true;
            id_cliLabel.Location = new System.Drawing.Point(33, 52);
            id_cliLabel.Name = "id_cliLabel";
            id_cliLabel.Size = new System.Drawing.Size(40, 17);
            id_cliLabel.TabIndex = 0;
            id_cliLabel.Text = "id cli:";
            // 
            // nome_razao_socialLabel
            // 
            nome_razao_socialLabel.AutoSize = true;
            nome_razao_socialLabel.Location = new System.Drawing.Point(33, 80);
            nome_razao_socialLabel.Name = "nome_razao_socialLabel";
            nome_razao_socialLabel.Size = new System.Drawing.Size(127, 17);
            nome_razao_socialLabel.TabIndex = 2;
            nome_razao_socialLabel.Text = "nome razao social:";
            // 
            // cpf_cnpjLabel
            // 
            cpf_cnpjLabel.AutoSize = true;
            cpf_cnpjLabel.Location = new System.Drawing.Point(33, 108);
            cpf_cnpjLabel.Name = "cpf_cnpjLabel";
            cpf_cnpjLabel.Size = new System.Drawing.Size(61, 17);
            cpf_cnpjLabel.TabIndex = 4;
            cpf_cnpjLabel.Text = "cpf cnpj:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(33, 136);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(45, 17);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "email:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(33, 164);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(63, 17);
            telefoneLabel.TabIndex = 8;
            telefoneLabel.Text = "telefone:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(33, 192);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(72, 17);
            enderecoLabel.TabIndex = 10;
            enderecoLabel.Text = "endereco:";
            // 
            // num_enderecoLabel
            // 
            num_enderecoLabel.AutoSize = true;
            num_enderecoLabel.Location = new System.Drawing.Point(33, 220);
            num_enderecoLabel.Name = "num_enderecoLabel";
            num_enderecoLabel.Size = new System.Drawing.Size(103, 17);
            num_enderecoLabel.TabIndex = 12;
            num_enderecoLabel.Text = "num endereco:";
            // 
            // complementoLabel
            // 
            complementoLabel.AutoSize = true;
            complementoLabel.Location = new System.Drawing.Point(33, 248);
            complementoLabel.Name = "complementoLabel";
            complementoLabel.Size = new System.Drawing.Size(96, 17);
            complementoLabel.TabIndex = 14;
            complementoLabel.Text = "complemento:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(33, 276);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(49, 17);
            bairroLabel.TabIndex = 16;
            bairroLabel.Text = "bairro:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(33, 304);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(54, 17);
            cidadeLabel.TabIndex = 18;
            cidadeLabel.Text = "cidade:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(33, 332);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(55, 17);
            estadoLabel.TabIndex = 20;
            estadoLabel.Text = "estado:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(button3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(btnSalvar);
            this.panel2.Controls.Add(btnAdd);
            this.panel2.Controls.Add(button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 85);
            this.panel2.TabIndex = 46;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(963, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(89, 85);
            this.panel3.TabIndex = 46;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button7);
            this.groupBox6.Controls.Add(this.btn_calcular);
            this.groupBox6.Controls.Add(this.chkbx_NotaFiscal);
            this.groupBox6.Controls.Add(this.txtbx_kmVolta);
            this.groupBox6.Controls.Add(this.txtbx_kmIda);
            this.groupBox6.Controls.Add(this.txtbx_CidadeDestino);
            this.groupBox6.Controls.Add(this.txtbx_cidadePartida);
            this.groupBox6.Controls.Add(this.chkbx_UsarValorCalculo);
            this.groupBox6.Controls.Add(this.lbl_ValorCalculo);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.lbl_totalKm);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.txtbx_Fechamento);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.cmbbx_CatVeiculo);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.cmbbx_PeriodoViagem);
            this.groupBox6.Location = new System.Drawing.Point(0, 284);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(462, 543);
            this.groupBox6.TabIndex = 56;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Fora da tabela";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(339, 61);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 60);
            this.button7.TabIndex = 31;
            this.button7.Text = "Consultar Distancia";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(337, 324);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(94, 60);
            this.btn_calcular.TabIndex = 17;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // chkbx_NotaFiscal
            // 
            this.chkbx_NotaFiscal.AutoSize = true;
            this.chkbx_NotaFiscal.Location = new System.Drawing.Point(280, 429);
            this.chkbx_NotaFiscal.Name = "chkbx_NotaFiscal";
            this.chkbx_NotaFiscal.Size = new System.Drawing.Size(108, 21);
            this.chkbx_NotaFiscal.TabIndex = 17;
            this.chkbx_NotaFiscal.Text = "Nota Fiscal?";
            this.chkbx_NotaFiscal.UseVisualStyleBackColor = true;
            // 
            // txtbx_kmVolta
            // 
            this.txtbx_kmVolta.Location = new System.Drawing.Point(180, 212);
            this.txtbx_kmVolta.Name = "txtbx_kmVolta";
            this.txtbx_kmVolta.Size = new System.Drawing.Size(153, 22);
            this.txtbx_kmVolta.TabIndex = 30;
            // 
            // txtbx_kmIda
            // 
            this.txtbx_kmIda.Location = new System.Drawing.Point(180, 175);
            this.txtbx_kmIda.Name = "txtbx_kmIda";
            this.txtbx_kmIda.Size = new System.Drawing.Size(153, 22);
            this.txtbx_kmIda.TabIndex = 29;
            // 
            // txtbx_CidadeDestino
            // 
            this.txtbx_CidadeDestino.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "destino", true));
            this.txtbx_CidadeDestino.Location = new System.Drawing.Point(180, 102);
            this.txtbx_CidadeDestino.Name = "txtbx_CidadeDestino";
            this.txtbx_CidadeDestino.Size = new System.Drawing.Size(153, 22);
            this.txtbx_CidadeDestino.TabIndex = 0;
            // 
            // orcamentoBindingSource
            // 
            this.orcamentoBindingSource.DataMember = "orcamento";
            this.orcamentoBindingSource.DataSource = this.gldturfreDeployDataSet;
            // 
            // gldturfreDeployDataSet
            // 
            this.gldturfreDeployDataSet.DataSetName = "gldturfreDeployDataSet";
            this.gldturfreDeployDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtbx_cidadePartida
            // 
            this.txtbx_cidadePartida.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "partida", true));
            this.txtbx_cidadePartida.Location = new System.Drawing.Point(180, 66);
            this.txtbx_cidadePartida.Name = "txtbx_cidadePartida";
            this.txtbx_cidadePartida.Size = new System.Drawing.Size(153, 22);
            this.txtbx_cidadePartida.TabIndex = 28;
            // 
            // chkbx_UsarValorCalculo
            // 
            this.chkbx_UsarValorCalculo.AutoSize = true;
            this.chkbx_UsarValorCalculo.Location = new System.Drawing.Point(280, 403);
            this.chkbx_UsarValorCalculo.Name = "chkbx_UsarValorCalculo";
            this.chkbx_UsarValorCalculo.Size = new System.Drawing.Size(151, 21);
            this.chkbx_UsarValorCalculo.TabIndex = 27;
            this.chkbx_UsarValorCalculo.Text = "Usar valor calculo?";
            this.chkbx_UsarValorCalculo.UseVisualStyleBackColor = true;
            this.chkbx_UsarValorCalculo.CheckedChanged += new System.EventHandler(this.chkbx_UsarValorCalculo_CheckedChanged);
            // 
            // lbl_ValorCalculo
            // 
            this.lbl_ValorCalculo.AutoSize = true;
            this.lbl_ValorCalculo.Location = new System.Drawing.Point(157, 404);
            this.lbl_ValorCalculo.Name = "lbl_ValorCalculo";
            this.lbl_ValorCalculo.Size = new System.Drawing.Size(69, 17);
            this.lbl_ValorCalculo.TabIndex = 26;
            this.lbl_ValorCalculo.Text = "label total";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(125, 404);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(26, 17);
            this.label24.TabIndex = 25;
            this.label24.Text = "R$";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(20, 404);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(99, 17);
            this.label25.TabIndex = 24;
            this.label25.Text = "Valor Calculo :";
            // 
            // lbl_totalKm
            // 
            this.lbl_totalKm.AutoSize = true;
            this.lbl_totalKm.Location = new System.Drawing.Point(186, 273);
            this.lbl_totalKm.Name = "lbl_totalKm";
            this.lbl_totalKm.Size = new System.Drawing.Size(57, 17);
            this.lbl_totalKm.TabIndex = 5;
            this.lbl_totalKm.Text = "total km";
            this.lbl_totalKm.Click += new System.EventHandler(this.lbl_totalKm_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(102, 273);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 17);
            this.label19.TabIndex = 4;
            this.label19.Text = "Km total :";
            // 
            // txtbx_Fechamento
            // 
            this.txtbx_Fechamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "valor", true));
            this.txtbx_Fechamento.Location = new System.Drawing.Point(178, 477);
            this.txtbx_Fechamento.Name = "txtbx_Fechamento";
            this.txtbx_Fechamento.Size = new System.Drawing.Size(104, 22);
            this.txtbx_Fechamento.TabIndex = 23;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 215);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(163, 17);
            this.label18.TabIndex = 3;
            this.label18.Text = "Distancia em km (volta) :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(146, 480);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 17);
            this.label20.TabIndex = 22;
            this.label20.Text = "R$";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 178);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 17);
            this.label17.TabIndex = 2;
            this.label17.Text = "Distancia em km (ida) :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Cidade de Destino :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 480);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(131, 17);
            this.label21.TabIndex = 21;
            this.label21.Text = "Valor Fechamento :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Cidade de Partida :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(21, 360);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 17);
            this.label22.TabIndex = 18;
            this.label22.Text = "Categoria :";
            // 
            // cmbbx_CatVeiculo
            // 
            this.cmbbx_CatVeiculo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "categ_veiculo", true));
            this.cmbbx_CatVeiculo.FormattingEnabled = true;
            this.cmbbx_CatVeiculo.Items.AddRange(new object[] {
            "DD 64L",
            "DD 60L",
            "SEMI 46L",
            "EXEC 50L",
            "EXEC 46L",
            "CONV 47L",
            "MICRO 32L",
            "VAN 18L",
            "VAN 15L",
            "CARRO"});
            this.cmbbx_CatVeiculo.Location = new System.Drawing.Point(107, 357);
            this.cmbbx_CatVeiculo.Name = "cmbbx_CatVeiculo";
            this.cmbbx_CatVeiculo.Size = new System.Drawing.Size(172, 24);
            this.cmbbx_CatVeiculo.TabIndex = 20;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(21, 326);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 17);
            this.label23.TabIndex = 17;
            this.label23.Text = "Periodo :";
            // 
            // cmbbx_PeriodoViagem
            // 
            this.cmbbx_PeriodoViagem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "periodo", true));
            this.cmbbx_PeriodoViagem.FormattingEnabled = true;
            this.cmbbx_PeriodoViagem.Items.AddRange(new object[] {
            "FIM DE SEMANA",
            "FERIADO PROLONGADO",
            "BATE E VOLTA"});
            this.cmbbx_PeriodoViagem.Location = new System.Drawing.Point(107, 323);
            this.cmbbx_PeriodoViagem.Name = "cmbbx_PeriodoViagem";
            this.cmbbx_PeriodoViagem.Size = new System.Drawing.Size(172, 24);
            this.cmbbx_PeriodoViagem.TabIndex = 19;
            // 
            // grpbx_InfCliente
            // 
            this.grpbx_InfCliente.Controls.Add(this.telefoneLabel2);
            this.grpbx_InfCliente.Controls.Add(this.nome_razao_socialLabel2);
            this.grpbx_InfCliente.Controls.Add(this.button6);
            this.grpbx_InfCliente.Controls.Add(this.button5);
            this.grpbx_InfCliente.Controls.Add(this.label5);
            this.grpbx_InfCliente.Controls.Add(this.btn_SelecionarCliente);
            this.grpbx_InfCliente.Controls.Add(this.label1);
            this.grpbx_InfCliente.Controls.Add(this.msktxbx_CpfCnpj);
            this.grpbx_InfCliente.Controls.Add(this.cmbbx_mask_CpfCnpj);
            this.grpbx_InfCliente.Enabled = false;
            this.grpbx_InfCliente.Location = new System.Drawing.Point(0, 102);
            this.grpbx_InfCliente.Name = "grpbx_InfCliente";
            this.grpbx_InfCliente.Size = new System.Drawing.Size(462, 182);
            this.grpbx_InfCliente.TabIndex = 57;
            this.grpbx_InfCliente.TabStop = false;
            this.grpbx_InfCliente.Text = "Inf. do Cliente";
            this.grpbx_InfCliente.Enter += new System.EventHandler(this.grpbx_InfCliente_Enter);
            // 
            // telefoneLabel2
            // 
            this.telefoneLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "tel_cliente", true));
            this.telefoneLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneLabel2.Location = new System.Drawing.Point(101, 104);
            this.telefoneLabel2.Name = "telefoneLabel2";
            this.telefoneLabel2.Size = new System.Drawing.Size(100, 23);
            this.telefoneLabel2.TabIndex = 13;
            this.telefoneLabel2.Text = "label7";
            // 
            // nome_razao_socialLabel2
            // 
            this.nome_razao_socialLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "nome_cliente", true));
            this.nome_razao_socialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_razao_socialLabel2.Location = new System.Drawing.Point(103, 73);
            this.nome_razao_socialLabel2.Name = "nome_razao_socialLabel2";
            this.nome_razao_socialLabel2.Size = new System.Drawing.Size(100, 23);
            this.nome_razao_socialLabel2.TabIndex = 12;
            this.nome_razao_socialLabel2.Text = "label7";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(204, 132);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(195, 30);
            this.button6.TabIndex = 8;
            this.button6.Text = "Consultar Cliente";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 132);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 30);
            this.button5.TabIndex = 7;
            this.button5.Text = "Cadastrar Novo Cliente";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telefone :";
            // 
            // btn_SelecionarCliente
            // 
            this.btn_SelecionarCliente.Image = global::control_services.Properties.Resources.lupa__1_;
            this.btn_SelecionarCliente.Location = new System.Drawing.Point(367, 23);
            this.btn_SelecionarCliente.Name = "btn_SelecionarCliente";
            this.btn_SelecionarCliente.Size = new System.Drawing.Size(46, 42);
            this.btn_SelecionarCliente.TabIndex = 4;
            this.btn_SelecionarCliente.UseVisualStyleBackColor = true;
            this.btn_SelecionarCliente.Click += new System.EventHandler(this.btn_SelecionarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente :";
            // 
            // msktxbx_CpfCnpj
            // 
            this.msktxbx_CpfCnpj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "cpf_cnpj_cliente", true));
            this.msktxbx_CpfCnpj.Enabled = false;
            this.msktxbx_CpfCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxbx_CpfCnpj.Location = new System.Drawing.Point(103, 31);
            this.msktxbx_CpfCnpj.Name = "msktxbx_CpfCnpj";
            this.msktxbx_CpfCnpj.Size = new System.Drawing.Size(257, 28);
            this.msktxbx_CpfCnpj.TabIndex = 1;
            // 
            // cmbbx_mask_CpfCnpj
            // 
            this.cmbbx_mask_CpfCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbx_mask_CpfCnpj.FormattingEnabled = true;
            this.cmbbx_mask_CpfCnpj.Items.AddRange(new object[] {
            "CPF",
            "CNPJ"});
            this.cmbbx_mask_CpfCnpj.Location = new System.Drawing.Point(6, 31);
            this.cmbbx_mask_CpfCnpj.Name = "cmbbx_mask_CpfCnpj";
            this.cmbbx_mask_CpfCnpj.Size = new System.Drawing.Size(91, 26);
            this.cmbbx_mask_CpfCnpj.TabIndex = 0;
            // 
            // cad_clieBindingSource
            // 
            this.cad_clieBindingSource.DataMember = "cad_clie";
            this.cad_clieBindingSource.DataSource = this.gldturfreDeployDataSet;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(463, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 970);
            this.tabControl1.TabIndex = 58;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txtbx_HoraRetorno);
            this.tabPage1.Controls.Add(this.txtbx_DataRetorno);
            this.tabPage1.Controls.Add(this.txtbx_HoraPartida);
            this.tabPage1.Controls.Add(this.txtbx_DataPartida);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(581, 941);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data da Viagem";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(id_cliLabel);
            this.groupBox1.Controls.Add(this.id_cliTextBox);
            this.groupBox1.Controls.Add(nome_razao_socialLabel);
            this.groupBox1.Controls.Add(this.nome_razao_socialTextBox);
            this.groupBox1.Controls.Add(cpf_cnpjLabel);
            this.groupBox1.Controls.Add(this.cpf_cnpjTextBox);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(telefoneLabel);
            this.groupBox1.Controls.Add(this.telefoneTextBox);
            this.groupBox1.Controls.Add(enderecoLabel);
            this.groupBox1.Controls.Add(this.enderecoTextBox);
            this.groupBox1.Controls.Add(num_enderecoLabel);
            this.groupBox1.Controls.Add(this.num_enderecoTextBox);
            this.groupBox1.Controls.Add(complementoLabel);
            this.groupBox1.Controls.Add(this.complementoTextBox);
            this.groupBox1.Controls.Add(bairroLabel);
            this.groupBox1.Controls.Add(this.bairroTextBox);
            this.groupBox1.Controls.Add(cidadeLabel);
            this.groupBox1.Controls.Add(this.cidadeTextBox);
            this.groupBox1.Controls.Add(estadoLabel);
            this.groupBox1.Controls.Add(this.estadoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(97, 427);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 455);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // id_cliTextBox
            // 
            this.id_cliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_cliBindingSource, "id_cli", true));
            this.id_cliTextBox.Location = new System.Drawing.Point(166, 49);
            this.id_cliTextBox.Name = "id_cliTextBox";
            this.id_cliTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_cliTextBox.TabIndex = 1;
            // 
            // cad_cliBindingSource
            // 
            this.cad_cliBindingSource.DataMember = "cad_cli";
            this.cad_cliBindingSource.DataSource = this.gldturfreDeployDataSet;
            // 
            // nome_razao_socialTextBox
            // 
            this.nome_razao_socialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_cliBindingSource, "nome_razao_social", true));
            this.nome_razao_socialTextBox.Location = new System.Drawing.Point(166, 77);
            this.nome_razao_socialTextBox.Name = "nome_razao_socialTextBox";
            this.nome_razao_socialTextBox.Size = new System.Drawing.Size(100, 22);
            this.nome_razao_socialTextBox.TabIndex = 3;
            // 
            // cpf_cnpjTextBox
            // 
            this.cpf_cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_cliBindingSource, "cpf_cnpj", true));
            this.cpf_cnpjTextBox.Location = new System.Drawing.Point(166, 105);
            this.cpf_cnpjTextBox.Name = "cpf_cnpjTextBox";
            this.cpf_cnpjTextBox.Size = new System.Drawing.Size(100, 22);
            this.cpf_cnpjTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_cliBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(166, 133);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 22);
            this.emailTextBox.TabIndex = 7;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_cliBindingSource, "telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(166, 161);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(100, 22);
            this.telefoneTextBox.TabIndex = 9;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_cliBindingSource, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(166, 189);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(100, 22);
            this.enderecoTextBox.TabIndex = 11;
            // 
            // num_enderecoTextBox
            // 
            this.num_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_cliBindingSource, "num_endereco", true));
            this.num_enderecoTextBox.Location = new System.Drawing.Point(166, 217);
            this.num_enderecoTextBox.Name = "num_enderecoTextBox";
            this.num_enderecoTextBox.Size = new System.Drawing.Size(100, 22);
            this.num_enderecoTextBox.TabIndex = 13;
            // 
            // complementoTextBox
            // 
            this.complementoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_cliBindingSource, "complemento", true));
            this.complementoTextBox.Location = new System.Drawing.Point(166, 245);
            this.complementoTextBox.Name = "complementoTextBox";
            this.complementoTextBox.Size = new System.Drawing.Size(100, 22);
            this.complementoTextBox.TabIndex = 15;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_cliBindingSource, "bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(166, 273);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(100, 22);
            this.bairroTextBox.TabIndex = 17;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_cliBindingSource, "cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(166, 301);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(100, 22);
            this.cidadeTextBox.TabIndex = 19;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_cliBindingSource, "estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(166, 329);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(100, 22);
            this.estadoTextBox.TabIndex = 21;
            // 
            // txtbx_HoraRetorno
            // 
            this.txtbx_HoraRetorno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "horario_retorno", true));
            this.txtbx_HoraRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_HoraRetorno.Location = new System.Drawing.Point(174, 262);
            this.txtbx_HoraRetorno.Mask = "00:00";
            this.txtbx_HoraRetorno.Name = "txtbx_HoraRetorno";
            this.txtbx_HoraRetorno.Size = new System.Drawing.Size(100, 26);
            this.txtbx_HoraRetorno.TabIndex = 51;
            this.txtbx_HoraRetorno.ValidatingType = typeof(System.DateTime);
            // 
            // txtbx_DataRetorno
            // 
            this.txtbx_DataRetorno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "data_retorno", true));
            this.txtbx_DataRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_DataRetorno.Location = new System.Drawing.Point(154, 200);
            this.txtbx_DataRetorno.Mask = "00/00/0000";
            this.txtbx_DataRetorno.Name = "txtbx_DataRetorno";
            this.txtbx_DataRetorno.Size = new System.Drawing.Size(100, 26);
            this.txtbx_DataRetorno.TabIndex = 50;
            this.txtbx_DataRetorno.ValidatingType = typeof(System.DateTime);
            // 
            // txtbx_HoraPartida
            // 
            this.txtbx_HoraPartida.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "hora_partida", true));
            this.txtbx_HoraPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_HoraPartida.Location = new System.Drawing.Point(168, 99);
            this.txtbx_HoraPartida.Mask = "00:00";
            this.txtbx_HoraPartida.Name = "txtbx_HoraPartida";
            this.txtbx_HoraPartida.Size = new System.Drawing.Size(100, 26);
            this.txtbx_HoraPartida.TabIndex = 49;
            this.txtbx_HoraPartida.ValidatingType = typeof(System.DateTime);
            // 
            // txtbx_DataPartida
            // 
            this.txtbx_DataPartida.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "data_partida", true));
            this.txtbx_DataPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_DataPartida.Location = new System.Drawing.Point(148, 47);
            this.txtbx_DataPartida.Mask = "00/00/0000";
            this.txtbx_DataPartida.Name = "txtbx_DataPartida";
            this.txtbx_DataPartida.Size = new System.Drawing.Size(100, 26);
            this.txtbx_DataPartida.TabIndex = 48;
            this.txtbx_DataPartida.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Horario de Retorno :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Horario de Partida :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Data de Retorno: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Data de Partida :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.txtbx_embarque5);
            this.tabPage2.Controls.Add(this.txtbx_embarque4);
            this.tabPage2.Controls.Add(this.txtbx_embarque3);
            this.tabPage2.Controls.Add(this.txtbx_embarque2);
            this.tabPage2.Controls.Add(this.txtbx_embarque1);
            this.tabPage2.Controls.Add(this.msktxbx_Embarque5);
            this.tabPage2.Controls.Add(this.msktxbx_Embarque4);
            this.tabPage2.Controls.Add(this.msktxbx_Embarque3);
            this.tabPage2.Controls.Add(this.msktxbx_Embarque2);
            this.tabPage2.Controls.Add(this.msktxbx_Embarque1);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(581, 941);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Informacoes do Embarque";
            // 
            // txtbx_embarque5
            // 
            this.txtbx_embarque5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "embarque_cinco", true));
            this.txtbx_embarque5.Location = new System.Drawing.Point(220, 452);
            this.txtbx_embarque5.Name = "txtbx_embarque5";
            this.txtbx_embarque5.Size = new System.Drawing.Size(267, 22);
            this.txtbx_embarque5.TabIndex = 39;
            // 
            // txtbx_embarque4
            // 
            this.txtbx_embarque4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "embarque_quatro", true));
            this.txtbx_embarque4.Location = new System.Drawing.Point(220, 336);
            this.txtbx_embarque4.Name = "txtbx_embarque4";
            this.txtbx_embarque4.Size = new System.Drawing.Size(267, 22);
            this.txtbx_embarque4.TabIndex = 38;
            // 
            // txtbx_embarque3
            // 
            this.txtbx_embarque3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "embarque_tres", true));
            this.txtbx_embarque3.Location = new System.Drawing.Point(220, 223);
            this.txtbx_embarque3.Name = "txtbx_embarque3";
            this.txtbx_embarque3.Size = new System.Drawing.Size(267, 22);
            this.txtbx_embarque3.TabIndex = 37;
            // 
            // txtbx_embarque2
            // 
            this.txtbx_embarque2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "embarque_dois", true));
            this.txtbx_embarque2.Location = new System.Drawing.Point(220, 127);
            this.txtbx_embarque2.Name = "txtbx_embarque2";
            this.txtbx_embarque2.Size = new System.Drawing.Size(267, 22);
            this.txtbx_embarque2.TabIndex = 36;
            // 
            // txtbx_embarque1
            // 
            this.txtbx_embarque1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "embarque_um", true));
            this.txtbx_embarque1.Location = new System.Drawing.Point(220, 25);
            this.txtbx_embarque1.Name = "txtbx_embarque1";
            this.txtbx_embarque1.Size = new System.Drawing.Size(267, 22);
            this.txtbx_embarque1.TabIndex = 35;
            // 
            // msktxbx_Embarque5
            // 
            this.msktxbx_Embarque5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "horario_embarque_cinco", true));
            this.msktxbx_Embarque5.Location = new System.Drawing.Point(220, 487);
            this.msktxbx_Embarque5.Mask = "00:00";
            this.msktxbx_Embarque5.Name = "msktxbx_Embarque5";
            this.msktxbx_Embarque5.Size = new System.Drawing.Size(100, 22);
            this.msktxbx_Embarque5.TabIndex = 34;
            this.msktxbx_Embarque5.ValidatingType = typeof(System.DateTime);
            // 
            // msktxbx_Embarque4
            // 
            this.msktxbx_Embarque4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "horario_embarque_quatro", true));
            this.msktxbx_Embarque4.Location = new System.Drawing.Point(220, 371);
            this.msktxbx_Embarque4.Mask = "00:00";
            this.msktxbx_Embarque4.Name = "msktxbx_Embarque4";
            this.msktxbx_Embarque4.Size = new System.Drawing.Size(100, 22);
            this.msktxbx_Embarque4.TabIndex = 33;
            this.msktxbx_Embarque4.ValidatingType = typeof(System.DateTime);
            // 
            // msktxbx_Embarque3
            // 
            this.msktxbx_Embarque3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "horario_embarque_tres", true));
            this.msktxbx_Embarque3.Location = new System.Drawing.Point(220, 260);
            this.msktxbx_Embarque3.Mask = "00:00";
            this.msktxbx_Embarque3.Name = "msktxbx_Embarque3";
            this.msktxbx_Embarque3.Size = new System.Drawing.Size(100, 22);
            this.msktxbx_Embarque3.TabIndex = 32;
            this.msktxbx_Embarque3.ValidatingType = typeof(System.DateTime);
            // 
            // msktxbx_Embarque2
            // 
            this.msktxbx_Embarque2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "horario_embarque_dois", true));
            this.msktxbx_Embarque2.Location = new System.Drawing.Point(220, 162);
            this.msktxbx_Embarque2.Mask = "00:00";
            this.msktxbx_Embarque2.Name = "msktxbx_Embarque2";
            this.msktxbx_Embarque2.Size = new System.Drawing.Size(100, 22);
            this.msktxbx_Embarque2.TabIndex = 31;
            this.msktxbx_Embarque2.ValidatingType = typeof(System.DateTime);
            // 
            // msktxbx_Embarque1
            // 
            this.msktxbx_Embarque1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "horario_embarque_um", true));
            this.msktxbx_Embarque1.Location = new System.Drawing.Point(220, 60);
            this.msktxbx_Embarque1.Mask = "00:00";
            this.msktxbx_Embarque1.Name = "msktxbx_Embarque1";
            this.msktxbx_Embarque1.Size = new System.Drawing.Size(100, 22);
            this.msktxbx_Embarque1.TabIndex = 30;
            this.msktxbx_Embarque1.ValidatingType = typeof(System.DateTime);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 490);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(198, 17);
            this.label27.TabIndex = 29;
            this.label27.Text = "Horario do Quinto Embarque: ";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 455);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(185, 17);
            this.label28.TabIndex = 28;
            this.label28.Text = "Local do Quinto Embarque: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Horario do Quarto Embarque: ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 339);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(187, 17);
            this.label26.TabIndex = 26;
            this.label26.Text = "Local do Quarto Embarque: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Horario do Terceiro Embarque: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Local do Terceiro Embarque: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(213, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Horario do Segundo Embarque: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Local do Segundo Embarque: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(208, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Horario do Primeiro Embarque: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(195, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Local do Primeiro Embarque: ";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.label41);
            this.tabPage3.Controls.Add(this.label42);
            this.tabPage3.Controls.Add(this.label43);
            this.tabPage3.Controls.Add(this.label29);
            this.tabPage3.Controls.Add(this.label30);
            this.tabPage3.Controls.Add(this.label31);
            this.tabPage3.Controls.Add(this.label32);
            this.tabPage3.Controls.Add(this.label33);
            this.tabPage3.Controls.Add(this.label34);
            this.tabPage3.Controls.Add(this.maskedTextBox10);
            this.tabPage3.Controls.Add(this.maskedTextBox9);
            this.tabPage3.Controls.Add(this.maskedTextBox8);
            this.tabPage3.Controls.Add(this.maskedTextBox7);
            this.tabPage3.Controls.Add(this.label40);
            this.tabPage3.Controls.Add(this.maskedTextBox6);
            this.tabPage3.Controls.Add(this.label39);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.maskedTextBox1);
            this.tabPage3.Controls.Add(this.maskedTextBox2);
            this.tabPage3.Controls.Add(this.maskedTextBox3);
            this.tabPage3.Controls.Add(this.maskedTextBox4);
            this.tabPage3.Controls.Add(this.maskedTextBox5);
            this.tabPage3.Controls.Add(this.label35);
            this.tabPage3.Controls.Add(this.label36);
            this.tabPage3.Controls.Add(this.label37);
            this.tabPage3.Controls.Add(this.label38);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(581, 941);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "City Tour / Passeios";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(7, 601);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(175, 17);
            this.label41.TabIndex = 88;
            this.label41.Text = "Horario do Quinto Roteiro ";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(7, 573);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(162, 17);
            this.label42.TabIndex = 87;
            this.label42.Text = "Data do Quinto Roteiro: ";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(7, 538);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(166, 17);
            this.label43.TabIndex = 86;
            this.label43.Text = "Local do Quinto Roteiro: ";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(7, 472);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(177, 17);
            this.label29.TabIndex = 85;
            this.label29.Text = "Horario do Quarto Roteiro ";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(7, 349);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(186, 17);
            this.label30.TabIndex = 84;
            this.label30.Text = "Horario do Terceiro Roteiro:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(7, 444);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(164, 17);
            this.label31.TabIndex = 83;
            this.label31.Text = "Data do Quarto Roteiro: ";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(7, 409);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(168, 17);
            this.label32.TabIndex = 82;
            this.label32.Text = "Local do Quarto Roteiro: ";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(7, 321);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(177, 17);
            this.label33.TabIndex = 81;
            this.label33.Text = "Data do Terceiro Roteiro:  ";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(7, 286);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(177, 17);
            this.label34.TabIndex = 80;
            this.label34.Text = "Local do Terceiro Roteiro: ";
            // 
            // maskedTextBox10
            // 
            this.maskedTextBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "roteiro_dia_cinco_horario", true));
            this.maskedTextBox10.Location = new System.Drawing.Point(220, 598);
            this.maskedTextBox10.Mask = "00:00";
            this.maskedTextBox10.Name = "maskedTextBox10";
            this.maskedTextBox10.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox10.TabIndex = 79;
            this.maskedTextBox10.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox9
            // 
            this.maskedTextBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "roteiro_dia_quatro_horario", true));
            this.maskedTextBox9.Location = new System.Drawing.Point(220, 469);
            this.maskedTextBox9.Mask = "00:00";
            this.maskedTextBox9.Name = "maskedTextBox9";
            this.maskedTextBox9.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox9.TabIndex = 78;
            this.maskedTextBox9.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox8
            // 
            this.maskedTextBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "roteiro_dia_tres_horario", true));
            this.maskedTextBox8.Location = new System.Drawing.Point(220, 346);
            this.maskedTextBox8.Mask = "00:00";
            this.maskedTextBox8.Name = "maskedTextBox8";
            this.maskedTextBox8.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox8.TabIndex = 77;
            this.maskedTextBox8.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox7
            // 
            this.maskedTextBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "roteiro_dia_dois_horario", true));
            this.maskedTextBox7.Location = new System.Drawing.Point(220, 211);
            this.maskedTextBox7.Mask = "00:00";
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox7.TabIndex = 76;
            this.maskedTextBox7.ValidatingType = typeof(System.DateTime);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(6, 214);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(190, 17);
            this.label40.TabIndex = 75;
            this.label40.Text = "Horario do Segundo Roteiro ";
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "roteiro_dia_um_horario", true));
            this.maskedTextBox6.Location = new System.Drawing.Point(220, 88);
            this.maskedTextBox6.Mask = "00:00";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox6.TabIndex = 74;
            this.maskedTextBox6.ValidatingType = typeof(System.DateTime);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(6, 91);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(185, 17);
            this.label39.TabIndex = 73;
            this.label39.Text = "Horario do Primeiro Roteiro:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "roteiro_dia_cinco_roteiro", true));
            this.textBox1.Location = new System.Drawing.Point(220, 535);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 22);
            this.textBox1.TabIndex = 72;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "roteiro_dia_quatro_roteiro", true));
            this.textBox2.Location = new System.Drawing.Point(220, 406);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(267, 22);
            this.textBox2.TabIndex = 71;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "roteiro_dia_tres_roteiro", true));
            this.textBox3.Location = new System.Drawing.Point(220, 281);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(267, 22);
            this.textBox3.TabIndex = 70;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "roteiro_dia_dois_roteiro", true));
            this.textBox4.Location = new System.Drawing.Point(220, 148);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(267, 22);
            this.textBox4.TabIndex = 69;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "roteiro_dia_um_roteiro", true));
            this.textBox5.Location = new System.Drawing.Point(220, 25);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(267, 22);
            this.textBox5.TabIndex = 68;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "roteiro_dia_cinco_data", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(220, 570);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 67;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "roteiro_dia_quatro_data", true));
            this.maskedTextBox2.Location = new System.Drawing.Point(220, 441);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox2.TabIndex = 66;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "roteiro_dia_tres_data", true));
            this.maskedTextBox3.Location = new System.Drawing.Point(220, 318);
            this.maskedTextBox3.Mask = "00/00/0000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox3.TabIndex = 65;
            this.maskedTextBox3.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "roteiro_dia_dois_data", true));
            this.maskedTextBox4.Location = new System.Drawing.Point(220, 183);
            this.maskedTextBox4.Mask = "00/00/0000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox4.TabIndex = 64;
            this.maskedTextBox4.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "roteiro_dia_um_data", true));
            this.maskedTextBox5.Location = new System.Drawing.Point(220, 60);
            this.maskedTextBox5.Mask = "00/00/0000";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox5.TabIndex = 63;
            this.maskedTextBox5.ValidatingType = typeof(System.DateTime);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 186);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(177, 17);
            this.label35.TabIndex = 62;
            this.label35.Text = "Data do Segundo Roteiro: ";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 151);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(181, 17);
            this.label36.TabIndex = 61;
            this.label36.Text = "Local do Segundo Roteiro: ";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 63);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(176, 17);
            this.label37.TabIndex = 60;
            this.label37.Text = "Data do Primeiro Roteiro:  ";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(6, 28);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(176, 17);
            this.label38.TabIndex = 59;
            this.label38.Text = "Local do Primeiro Roteiro: ";
            // 
            // cad_clieTableAdapter
            // 
            //this.cad_clieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            //this.tableAdapterManager.cad_clieTableAdapter = this.cad_clieTableAdapter;
            this.tableAdapterManager.cad_cliTableAdapter = null;
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sfdSalvar
            // 
            this.sfdSalvar.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdSalvar_FileOk);
            // 
            // orcamentoTableAdapter
            // 
            this.orcamentoTableAdapter.ClearBeforeFill = true;
            // 
            // id_orcamentoTextBox
            // 
            this.id_orcamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "id_orcamento", true));
            this.id_orcamentoTextBox.Location = new System.Drawing.Point(170, 840);
            this.id_orcamentoTextBox.Name = "id_orcamentoTextBox";
            this.id_orcamentoTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_orcamentoTextBox.TabIndex = 59;
            // 
            // txtbx_idOrcString
            // 
            this.txtbx_idOrcString.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "id_str", true));
            this.txtbx_idOrcString.Location = new System.Drawing.Point(170, 868);
            this.txtbx_idOrcString.Name = "txtbx_idOrcString";
            this.txtbx_idOrcString.Size = new System.Drawing.Size(100, 22);
            this.txtbx_idOrcString.TabIndex = 60;
            // 
            // cad_cliTableAdapter
            // 
            this.cad_cliTableAdapter.ClearBeforeFill = true;
            // 
            // frm_OrcForaTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1052, 1055);
            this.ControlBox = false;
            this.Controls.Add(label14);
            this.Controls.Add(this.txtbx_idOrcString);
            this.Controls.Add(id_orcamentoLabel);
            this.Controls.Add(this.id_orcamentoTextBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grpbx_InfCliente);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.panel2);
            this.Name = "frm_OrcForaTabela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orcamento Fora da Tabela";
            this.Load += new System.EventHandler(this.frm_OrcForaTabela_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gldturfreDeployDataSet)).EndInit();
            this.grpbx_InfCliente.ResumeLayout(false);
            this.grpbx_InfCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cad_clieBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cad_cliBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.CheckBox chkbx_NotaFiscal;
        private System.Windows.Forms.TextBox txtbx_kmVolta;
        private System.Windows.Forms.TextBox txtbx_kmIda;
        private System.Windows.Forms.TextBox txtbx_CidadeDestino;
        private System.Windows.Forms.TextBox txtbx_cidadePartida;
        private System.Windows.Forms.CheckBox chkbx_UsarValorCalculo;
        private System.Windows.Forms.Label lbl_ValorCalculo;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbl_totalKm;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtbx_Fechamento;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbbx_CatVeiculo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbbx_PeriodoViagem;
        private System.Windows.Forms.GroupBox grpbx_InfCliente;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_SelecionarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msktxbx_CpfCnpj;
        private System.Windows.Forms.ComboBox cmbbx_mask_CpfCnpj;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private gldturfreDeployDataSet gldturfreDeployDataSet;
        private System.Windows.Forms.BindingSource cad_clieBindingSource;
        //private gldturfreDeployDataSetTableAdapters.cad_clieTableAdapter cad_clieTableAdapter;
        private gldturfreDeployDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SaveFileDialog sfdSalvar;
        private System.Windows.Forms.Label telefoneLabel2;
        private System.Windows.Forms.Label nome_razao_socialLabel2;
        private System.Windows.Forms.BindingSource orcamentoBindingSource;
        private gldturfreDeployDataSetTableAdapters.orcamentoTableAdapter orcamentoTableAdapter;
        private System.Windows.Forms.MaskedTextBox txtbx_HoraRetorno;
        private System.Windows.Forms.MaskedTextBox txtbx_DataRetorno;
        private System.Windows.Forms.MaskedTextBox txtbx_HoraPartida;
        private System.Windows.Forms.MaskedTextBox txtbx_DataPartida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_embarque5;
        private System.Windows.Forms.TextBox txtbx_embarque4;
        private System.Windows.Forms.TextBox txtbx_embarque3;
        private System.Windows.Forms.TextBox txtbx_embarque2;
        private System.Windows.Forms.TextBox txtbx_embarque1;
        private System.Windows.Forms.MaskedTextBox msktxbx_Embarque5;
        private System.Windows.Forms.MaskedTextBox msktxbx_Embarque4;
        private System.Windows.Forms.MaskedTextBox msktxbx_Embarque3;
        private System.Windows.Forms.MaskedTextBox msktxbx_Embarque2;
        private System.Windows.Forms.MaskedTextBox msktxbx_Embarque1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.MaskedTextBox maskedTextBox10;
        private System.Windows.Forms.MaskedTextBox maskedTextBox9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox7;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox id_orcamentoTextBox;
        private System.Windows.Forms.TextBox txtbx_idOrcString;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource cad_cliBindingSource;
        private gldturfreDeployDataSetTableAdapters.cad_cliTableAdapter cad_cliTableAdapter;
        private System.Windows.Forms.TextBox id_cliTextBox;
        private System.Windows.Forms.TextBox nome_razao_socialTextBox;
        private System.Windows.Forms.TextBox cpf_cnpjTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox num_enderecoTextBox;
        private System.Windows.Forms.TextBox complementoTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
    }
}