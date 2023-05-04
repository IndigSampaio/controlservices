namespace control_services
{
    partial class frm_escala2
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
            System.Windows.Forms.Label id_orcamentoLabel;
            System.Windows.Forms.Label nome_clienteLabel;
            System.Windows.Forms.Label cpf_cnpj_clienteLabel;
            System.Windows.Forms.Label tel_clienteLabel;
            System.Windows.Forms.Label motoristaLabel;
            System.Windows.Forms.Label partidaLabel;
            System.Windows.Forms.Label data_partidaLabel;
            System.Windows.Forms.Label hora_partidaLabel;
            System.Windows.Forms.Label destinoLabel;
            System.Windows.Forms.Label data_retornoLabel;
            System.Windows.Forms.Label hora_retornoLabel;
            System.Windows.Forms.Label categ_veiculoLabel;
            System.Windows.Forms.Label veiculoLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idorcamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motoristaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapartidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_retorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categ_veiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viagemfechadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gldturfreDeployDataSet = new control_services.gldturfreDeployDataSet();
            this.veiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.viagem_fechadaTableAdapter = new control_services.gldturfreDeployDataSetTableAdapters.viagem_fechadaTableAdapter();
            this.veiculoTableAdapter = new control_services.gldturfreDeployDataSetTableAdapters.veiculoTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.motoristaComboBox = new System.Windows.Forms.ComboBox();
            this.hora_retornoLabel2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.categ_veiculoLabel1 = new System.Windows.Forms.Label();
            this.data_retornoLabel1 = new System.Windows.Forms.Label();
            this.destinoLabel1 = new System.Windows.Forms.Label();
            this.hora_partidaLabel1 = new System.Windows.Forms.Label();
            this.data_partidaLabel1 = new System.Windows.Forms.Label();
            this.partidaLabel1 = new System.Windows.Forms.Label();
            this.tel_clienteLabel1 = new System.Windows.Forms.Label();
            this.cpf_cnpj_clienteLabel1 = new System.Windows.Forms.Label();
            this.nome_clienteLabel1 = new System.Windows.Forms.Label();
            this.id_orcamentoLabel1 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new control_services.gldturfreDeployDataSetTableAdapters.TableAdapterManager();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.categveiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.data_partidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtbx_IDViagem = new System.Windows.Forms.TextBox();
            this.categ_veiculoTableAdapter = new control_services.gldturfreDeployDataSetTableAdapters.categ_veiculoTableAdapter();
            this.motoristaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motoristaTableAdapter = new control_services.gldturfreDeployDataSetTableAdapters.motoristaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            id_orcamentoLabel = new System.Windows.Forms.Label();
            nome_clienteLabel = new System.Windows.Forms.Label();
            cpf_cnpj_clienteLabel = new System.Windows.Forms.Label();
            tel_clienteLabel = new System.Windows.Forms.Label();
            motoristaLabel = new System.Windows.Forms.Label();
            partidaLabel = new System.Windows.Forms.Label();
            data_partidaLabel = new System.Windows.Forms.Label();
            hora_partidaLabel = new System.Windows.Forms.Label();
            destinoLabel = new System.Windows.Forms.Label();
            data_retornoLabel = new System.Windows.Forms.Label();
            hora_retornoLabel = new System.Windows.Forms.Label();
            categ_veiculoLabel = new System.Windows.Forms.Label();
            veiculoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viagemfechadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gldturfreDeployDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categveiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoristaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_orcamentoLabel
            // 
            id_orcamentoLabel.AutoSize = true;
            id_orcamentoLabel.Location = new System.Drawing.Point(12, 34);
            id_orcamentoLabel.Name = "id_orcamentoLabel";
            id_orcamentoLabel.Size = new System.Drawing.Size(94, 17);
            id_orcamentoLabel.TabIndex = 0;
            id_orcamentoLabel.Text = "id orcamento:";
            // 
            // nome_clienteLabel
            // 
            nome_clienteLabel.AutoSize = true;
            nome_clienteLabel.Location = new System.Drawing.Point(12, 67);
            nome_clienteLabel.Name = "nome_clienteLabel";
            nome_clienteLabel.Size = new System.Drawing.Size(92, 17);
            nome_clienteLabel.TabIndex = 2;
            nome_clienteLabel.Text = "nome cliente:";
            // 
            // cpf_cnpj_clienteLabel
            // 
            cpf_cnpj_clienteLabel.AutoSize = true;
            cpf_cnpj_clienteLabel.Location = new System.Drawing.Point(12, 102);
            cpf_cnpj_clienteLabel.Name = "cpf_cnpj_clienteLabel";
            cpf_cnpj_clienteLabel.Size = new System.Drawing.Size(106, 17);
            cpf_cnpj_clienteLabel.TabIndex = 4;
            cpf_cnpj_clienteLabel.Text = "cpf cnpj cliente:";
            // 
            // tel_clienteLabel
            // 
            tel_clienteLabel.AutoSize = true;
            tel_clienteLabel.Location = new System.Drawing.Point(12, 141);
            tel_clienteLabel.Name = "tel_clienteLabel";
            tel_clienteLabel.Size = new System.Drawing.Size(72, 17);
            tel_clienteLabel.TabIndex = 6;
            tel_clienteLabel.Text = "tel cliente:";
            // 
            // motoristaLabel
            // 
            motoristaLabel.AutoSize = true;
            motoristaLabel.Location = new System.Drawing.Point(12, 173);
            motoristaLabel.Name = "motoristaLabel";
            motoristaLabel.Size = new System.Drawing.Size(70, 17);
            motoristaLabel.TabIndex = 8;
            motoristaLabel.Text = "motorista:";
            // 
            // partidaLabel
            // 
            partidaLabel.AutoSize = true;
            partidaLabel.Location = new System.Drawing.Point(598, 34);
            partidaLabel.Name = "partidaLabel";
            partidaLabel.Size = new System.Drawing.Size(56, 17);
            partidaLabel.TabIndex = 10;
            partidaLabel.Text = "partida:";
            // 
            // data_partidaLabel
            // 
            data_partidaLabel.AutoSize = true;
            data_partidaLabel.Location = new System.Drawing.Point(598, 67);
            data_partidaLabel.Name = "data_partidaLabel";
            data_partidaLabel.Size = new System.Drawing.Size(88, 17);
            data_partidaLabel.TabIndex = 12;
            data_partidaLabel.Text = "data partida:";
            // 
            // hora_partidaLabel
            // 
            hora_partidaLabel.AutoSize = true;
            hora_partidaLabel.Location = new System.Drawing.Point(598, 102);
            hora_partidaLabel.Name = "hora_partidaLabel";
            hora_partidaLabel.Size = new System.Drawing.Size(89, 17);
            hora_partidaLabel.TabIndex = 14;
            hora_partidaLabel.Text = "hora partida:";
            // 
            // destinoLabel
            // 
            destinoLabel.AutoSize = true;
            destinoLabel.Location = new System.Drawing.Point(598, 141);
            destinoLabel.Name = "destinoLabel";
            destinoLabel.Size = new System.Drawing.Size(58, 17);
            destinoLabel.TabIndex = 16;
            destinoLabel.Text = "destino:";
            // 
            // data_retornoLabel
            // 
            data_retornoLabel.AutoSize = true;
            data_retornoLabel.Location = new System.Drawing.Point(1212, 36);
            data_retornoLabel.Name = "data_retornoLabel";
            data_retornoLabel.Size = new System.Drawing.Size(90, 17);
            data_retornoLabel.TabIndex = 18;
            data_retornoLabel.Text = "data retorno:";
            // 
            // hora_retornoLabel
            // 
            hora_retornoLabel.AutoSize = true;
            hora_retornoLabel.Location = new System.Drawing.Point(1212, 68);
            hora_retornoLabel.Name = "hora_retornoLabel";
            hora_retornoLabel.Size = new System.Drawing.Size(91, 17);
            hora_retornoLabel.TabIndex = 20;
            hora_retornoLabel.Text = "hora retorno:";
            // 
            // categ_veiculoLabel
            // 
            categ_veiculoLabel.AutoSize = true;
            categ_veiculoLabel.Location = new System.Drawing.Point(1212, 104);
            categ_veiculoLabel.Name = "categ_veiculoLabel";
            categ_veiculoLabel.Size = new System.Drawing.Size(95, 17);
            categ_veiculoLabel.TabIndex = 22;
            categ_veiculoLabel.Text = "categ veiculo:";
            // 
            // veiculoLabel
            // 
            veiculoLabel.AutoSize = true;
            veiculoLabel.Location = new System.Drawing.Point(1212, 141);
            veiculoLabel.Name = "veiculoLabel";
            veiculoLabel.Size = new System.Drawing.Size(56, 17);
            veiculoLabel.TabIndex = 24;
            veiculoLabel.Text = "veiculo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 671);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1924, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idorcamentoDataGridViewTextBoxColumn,
            this.nomeclienteDataGridViewTextBoxColumn,
            this.motoristaDataGridViewTextBoxColumn,
            this.partidaDataGridViewTextBoxColumn,
            this.datapartidaDataGridViewTextBoxColumn,
            this.hora_partida,
            this.destinoDataGridViewTextBoxColumn,
            this.hora_retorno,
            this.categ_veiculo,
            this.veiculoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viagemfechadaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1918, 363);
            this.dataGridView1.TabIndex = 0;
            // 
            // idorcamentoDataGridViewTextBoxColumn
            // 
            this.idorcamentoDataGridViewTextBoxColumn.DataPropertyName = "id_orcamento";
            this.idorcamentoDataGridViewTextBoxColumn.HeaderText = "ID Viagem";
            this.idorcamentoDataGridViewTextBoxColumn.Name = "idorcamentoDataGridViewTextBoxColumn";
            this.idorcamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeclienteDataGridViewTextBoxColumn
            // 
            this.nomeclienteDataGridViewTextBoxColumn.DataPropertyName = "nome_cliente";
            this.nomeclienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.nomeclienteDataGridViewTextBoxColumn.Name = "nomeclienteDataGridViewTextBoxColumn";
            // 
            // motoristaDataGridViewTextBoxColumn
            // 
            this.motoristaDataGridViewTextBoxColumn.DataPropertyName = "motorista";
            this.motoristaDataGridViewTextBoxColumn.HeaderText = "motorista";
            this.motoristaDataGridViewTextBoxColumn.Name = "motoristaDataGridViewTextBoxColumn";
            this.motoristaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // partidaDataGridViewTextBoxColumn
            // 
            this.partidaDataGridViewTextBoxColumn.DataPropertyName = "partida";
            this.partidaDataGridViewTextBoxColumn.HeaderText = "partida";
            this.partidaDataGridViewTextBoxColumn.Name = "partidaDataGridViewTextBoxColumn";
            // 
            // datapartidaDataGridViewTextBoxColumn
            // 
            this.datapartidaDataGridViewTextBoxColumn.DataPropertyName = "data_partida";
            this.datapartidaDataGridViewTextBoxColumn.HeaderText = "Data";
            this.datapartidaDataGridViewTextBoxColumn.Name = "datapartidaDataGridViewTextBoxColumn";
            // 
            // hora_partida
            // 
            this.hora_partida.DataPropertyName = "hora_partida";
            this.hora_partida.HeaderText = "Hora de Partida";
            this.hora_partida.Name = "hora_partida";
            // 
            // destinoDataGridViewTextBoxColumn
            // 
            this.destinoDataGridViewTextBoxColumn.DataPropertyName = "destino";
            this.destinoDataGridViewTextBoxColumn.HeaderText = "Destino";
            this.destinoDataGridViewTextBoxColumn.Name = "destinoDataGridViewTextBoxColumn";
            // 
            // hora_retorno
            // 
            this.hora_retorno.DataPropertyName = "hora_retorno";
            this.hora_retorno.HeaderText = "Horario de Retorno";
            this.hora_retorno.Name = "hora_retorno";
            // 
            // categ_veiculo
            // 
            this.categ_veiculo.DataPropertyName = "Categoria";
            this.categ_veiculo.HeaderText = "Categoria";
            this.categ_veiculo.Name = "categ_veiculo";
            // 
            // veiculoDataGridViewTextBoxColumn
            // 
            this.veiculoDataGridViewTextBoxColumn.DataPropertyName = "veiculo";
            this.veiculoDataGridViewTextBoxColumn.HeaderText = "Veiculo";
            this.veiculoDataGridViewTextBoxColumn.Name = "veiculoDataGridViewTextBoxColumn";
            this.veiculoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // viagemfechadaBindingSource
            // 
            this.viagemfechadaBindingSource.DataMember = "viagem_fechada";
            this.viagemfechadaBindingSource.DataSource = this.gldturfreDeployDataSet;
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // viagem_fechadaTableAdapter
            // 
            this.viagem_fechadaTableAdapter.ClearBeforeFill = true;
            // 
            // veiculoTableAdapter
            // 
            this.veiculoTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.motoristaComboBox);
            this.groupBox3.Controls.Add(this.hora_retornoLabel2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(veiculoLabel);
            this.groupBox3.Controls.Add(categ_veiculoLabel);
            this.groupBox3.Controls.Add(this.categ_veiculoLabel1);
            this.groupBox3.Controls.Add(hora_retornoLabel);
            this.groupBox3.Controls.Add(data_retornoLabel);
            this.groupBox3.Controls.Add(this.data_retornoLabel1);
            this.groupBox3.Controls.Add(destinoLabel);
            this.groupBox3.Controls.Add(this.destinoLabel1);
            this.groupBox3.Controls.Add(hora_partidaLabel);
            this.groupBox3.Controls.Add(this.hora_partidaLabel1);
            this.groupBox3.Controls.Add(data_partidaLabel);
            this.groupBox3.Controls.Add(this.data_partidaLabel1);
            this.groupBox3.Controls.Add(partidaLabel);
            this.groupBox3.Controls.Add(this.partidaLabel1);
            this.groupBox3.Controls.Add(motoristaLabel);
            this.groupBox3.Controls.Add(tel_clienteLabel);
            this.groupBox3.Controls.Add(this.tel_clienteLabel1);
            this.groupBox3.Controls.Add(cpf_cnpj_clienteLabel);
            this.groupBox3.Controls.Add(this.cpf_cnpj_clienteLabel1);
            this.groupBox3.Controls.Add(nome_clienteLabel);
            this.groupBox3.Controls.Add(this.nome_clienteLabel1);
            this.groupBox3.Controls.Add(id_orcamentoLabel);
            this.groupBox3.Controls.Add(this.id_orcamentoLabel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 434);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1924, 237);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // motoristaComboBox
            // 
            this.motoristaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viagemfechadaBindingSource, "motorista", true));
            this.motoristaComboBox.DataSource = this.motoristaBindingSource;
            this.motoristaComboBox.DisplayMember = "nome";
            this.motoristaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motoristaComboBox.FormattingEnabled = true;
            this.motoristaComboBox.Location = new System.Drawing.Point(88, 170);
            this.motoristaComboBox.Name = "motoristaComboBox";
            this.motoristaComboBox.Size = new System.Drawing.Size(304, 28);
            this.motoristaComboBox.TabIndex = 27;
            this.motoristaComboBox.ValueMember = "chaveiro";
            // 
            // hora_retornoLabel2
            // 
            this.hora_retornoLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viagemfechadaBindingSource, "hora_retorno", true));
            this.hora_retornoLabel2.Location = new System.Drawing.Point(1307, 68);
            this.hora_retornoLabel2.Name = "hora_retornoLabel2";
            this.hora_retornoLabel2.Size = new System.Drawing.Size(100, 23);
            this.hora_retornoLabel2.TabIndex = 26;
            this.hora_retornoLabel2.Text = "label5";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viagemfechadaBindingSource, "veiculo", true));
            this.comboBox1.DataSource = this.veiculoBindingSource;
            this.comboBox1.DisplayMember = "veiculo";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1274, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 28);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.ValueMember = "id_veiculo";
            // 
            // categ_veiculoLabel1
            // 
            this.categ_veiculoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viagemfechadaBindingSource, "categ_veiculo", true));
            this.categ_veiculoLabel1.Location = new System.Drawing.Point(1313, 104);
            this.categ_veiculoLabel1.Name = "categ_veiculoLabel1";
            this.categ_veiculoLabel1.Size = new System.Drawing.Size(100, 23);
            this.categ_veiculoLabel1.TabIndex = 23;
            this.categ_veiculoLabel1.Text = "label5";
            // 
            // data_retornoLabel1
            // 
            this.data_retornoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viagemfechadaBindingSource, "data_retorno", true));
            this.data_retornoLabel1.Location = new System.Drawing.Point(1308, 36);
            this.data_retornoLabel1.Name = "data_retornoLabel1";
            this.data_retornoLabel1.Size = new System.Drawing.Size(100, 23);
            this.data_retornoLabel1.TabIndex = 19;
            this.data_retornoLabel1.Text = "label5";
            // 
            // destinoLabel1
            // 
            this.destinoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viagemfechadaBindingSource, "destino", true));
            this.destinoLabel1.Location = new System.Drawing.Point(662, 141);
            this.destinoLabel1.Name = "destinoLabel1";
            this.destinoLabel1.Size = new System.Drawing.Size(199, 23);
            this.destinoLabel1.TabIndex = 17;
            this.destinoLabel1.Text = "label5";
            // 
            // hora_partidaLabel1
            // 
            this.hora_partidaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viagemfechadaBindingSource, "hora_partida", true));
            this.hora_partidaLabel1.Location = new System.Drawing.Point(693, 102);
            this.hora_partidaLabel1.Name = "hora_partidaLabel1";
            this.hora_partidaLabel1.Size = new System.Drawing.Size(100, 23);
            this.hora_partidaLabel1.TabIndex = 15;
            this.hora_partidaLabel1.Text = "label5";
            // 
            // data_partidaLabel1
            // 
            this.data_partidaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viagemfechadaBindingSource, "data_partida", true));
            this.data_partidaLabel1.Location = new System.Drawing.Point(692, 67);
            this.data_partidaLabel1.Name = "data_partidaLabel1";
            this.data_partidaLabel1.Size = new System.Drawing.Size(100, 23);
            this.data_partidaLabel1.TabIndex = 13;
            this.data_partidaLabel1.Text = "label5";
            // 
            // partidaLabel1
            // 
            this.partidaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viagemfechadaBindingSource, "partida", true));
            this.partidaLabel1.Location = new System.Drawing.Point(660, 34);
            this.partidaLabel1.Name = "partidaLabel1";
            this.partidaLabel1.Size = new System.Drawing.Size(100, 23);
            this.partidaLabel1.TabIndex = 11;
            this.partidaLabel1.Text = "label5";
            // 
            // tel_clienteLabel1
            // 
            this.tel_clienteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viagemfechadaBindingSource, "motorista", true));
            this.tel_clienteLabel1.Location = new System.Drawing.Point(90, 141);
            this.tel_clienteLabel1.Name = "tel_clienteLabel1";
            this.tel_clienteLabel1.Size = new System.Drawing.Size(100, 23);
            this.tel_clienteLabel1.TabIndex = 7;
            this.tel_clienteLabel1.Text = "label5";
            // 
            // cpf_cnpj_clienteLabel1
            // 
            this.cpf_cnpj_clienteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viagemfechadaBindingSource, "cpf_cnpj_cliente", true));
            this.cpf_cnpj_clienteLabel1.Location = new System.Drawing.Point(124, 102);
            this.cpf_cnpj_clienteLabel1.Name = "cpf_cnpj_clienteLabel1";
            this.cpf_cnpj_clienteLabel1.Size = new System.Drawing.Size(100, 23);
            this.cpf_cnpj_clienteLabel1.TabIndex = 5;
            this.cpf_cnpj_clienteLabel1.Text = "label5";
            // 
            // nome_clienteLabel1
            // 
            this.nome_clienteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viagemfechadaBindingSource, "nome_cliente", true));
            this.nome_clienteLabel1.Location = new System.Drawing.Point(110, 67);
            this.nome_clienteLabel1.Name = "nome_clienteLabel1";
            this.nome_clienteLabel1.Size = new System.Drawing.Size(100, 23);
            this.nome_clienteLabel1.TabIndex = 3;
            this.nome_clienteLabel1.Text = "label5";
            // 
            // id_orcamentoLabel1
            // 
            this.id_orcamentoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viagemfechadaBindingSource, "id_orcamento", true));
            this.id_orcamentoLabel1.Location = new System.Drawing.Point(112, 34);
            this.id_orcamentoLabel1.Name = "id_orcamentoLabel1";
            this.id_orcamentoLabel1.Size = new System.Drawing.Size(100, 23);
            this.id_orcamentoLabel1.TabIndex = 1;
            this.id_orcamentoLabel1.Text = "label5";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cad_cliTableAdapter = null;
            this.tableAdapterManager.cad_funTableAdapter = null;
            this.tableAdapterManager.cad_motoristaTableAdapter = null;
            this.tableAdapterManager.categ_veiculoTableAdapter = null;
            this.tableAdapterManager.estadoTableAdapter = null;
            this.tableAdapterManager.lgn_usersTableAdapter = null;
            this.tableAdapterManager.motoristaTableAdapter = null;
            this.tableAdapterManager.orcamentoTableAdapter = null;
            this.tableAdapterManager.tabela_BateVoltaTableAdapter = null;
            this.tableAdapterManager.tabela_FerProTableAdapter = null;
            this.tableAdapterManager.tabela_FimSemTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = control_services.gldturfreDeployDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veiculoTableAdapter = this.veiculoTableAdapter;
            this.tableAdapterManager.viagem_fechadaTableAdapter = this.viagem_fechadaTableAdapter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.data_partidaDateTimePicker);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.txtbx_IDViagem);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1924, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.categveiculoBindingSource;
            this.comboBox2.DisplayMember = "categoria";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(999, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(190, 24);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.ValueMember = "id_categoria";
            // 
            // categveiculoBindingSource
            // 
            this.categveiculoBindingSource.DataMember = "categ_veiculo";
            this.categveiculoBindingSource.DataSource = this.gldturfreDeployDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(920, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Categoria:";
            // 
            // data_partidaDateTimePicker
            // 
            this.data_partidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.viagemfechadaBindingSource, "data_partida", true));
            this.data_partidaDateTimePicker.Location = new System.Drawing.Point(1366, 43);
            this.data_partidaDateTimePicker.Name = "data_partidaDateTimePicker";
            this.data_partidaDateTimePicker.Size = new System.Drawing.Size(322, 22);
            this.data_partidaDateTimePicker.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1303, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Partida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Veiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Motorista:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID Viagem:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(665, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(331, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 22);
            this.textBox2.TabIndex = 8;
            // 
            // txtbx_IDViagem
            // 
            this.txtbx_IDViagem.Location = new System.Drawing.Point(94, 45);
            this.txtbx_IDViagem.Name = "txtbx_IDViagem";
            this.txtbx_IDViagem.Size = new System.Drawing.Size(100, 22);
            this.txtbx_IDViagem.TabIndex = 7;
            // 
            // categ_veiculoTableAdapter
            // 
            this.categ_veiculoTableAdapter.ClearBeforeFill = true;
            // 
            // motoristaBindingSource
            // 
            this.motoristaBindingSource.DataMember = "motorista";
            this.motoristaBindingSource.DataSource = this.gldturfreDeployDataSet;
            // 
            // motoristaTableAdapter
            // 
            this.motoristaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1215, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 42);
            this.button1.TabIndex = 28;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_escala2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_escala2";
            this.Text = "frm_escala2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_escala2_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viagemfechadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gldturfreDeployDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categveiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoristaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private gldturfreDeployDataSet gldturfreDeployDataSet;
        private System.Windows.Forms.BindingSource viagemfechadaBindingSource;
        private gldturfreDeployDataSetTableAdapters.viagem_fechadaTableAdapter viagem_fechadaTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource veiculoBindingSource;
        private gldturfreDeployDataSetTableAdapters.veiculoTableAdapter veiculoTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label tel_clienteLabel1;
        private System.Windows.Forms.Label cpf_cnpj_clienteLabel1;
        private System.Windows.Forms.Label nome_clienteLabel1;
        private System.Windows.Forms.Label id_orcamentoLabel1;
        private gldturfreDeployDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorcamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motoristaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datapartidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_retorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn categ_veiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn veiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label data_retornoLabel1;
        private System.Windows.Forms.Label destinoLabel1;
        private System.Windows.Forms.Label hora_partidaLabel1;
        private System.Windows.Forms.Label data_partidaLabel1;
        private System.Windows.Forms.Label partidaLabel1;
        private System.Windows.Forms.Label categ_veiculoLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label hora_retornoLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtbx_IDViagem;
        private System.Windows.Forms.DateTimePicker data_partidaDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource categveiculoBindingSource;
        private gldturfreDeployDataSetTableAdapters.categ_veiculoTableAdapter categ_veiculoTableAdapter;
        private System.Windows.Forms.ComboBox motoristaComboBox;
        private System.Windows.Forms.BindingSource motoristaBindingSource;
        private gldturfreDeployDataSetTableAdapters.motoristaTableAdapter motoristaTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}