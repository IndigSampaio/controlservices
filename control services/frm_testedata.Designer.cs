namespace control_services
{
    partial class frm_testedata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_testedata));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_quantosDias = new System.Windows.Forms.Label();
            this.data_partida = new System.Windows.Forms.DateTimePicker();
            this.data_volta = new System.Windows.Forms.DateTimePicker();
            this.contagemDias = new System.Windows.Forms.Timer(this.components);
            this.chkbx_BateVolta = new System.Windows.Forms.CheckBox();
            this.chkbx_FerPro = new System.Windows.Forms.CheckBox();
            this.chkbx_FimSem = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gldturfreDeployDataSet = new control_services.gldturfreDeployDataSet();
            this.orcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orcamentoTableAdapter = new control_services.gldturfreDeployDataSetTableAdapters.orcamentoTableAdapter();
            this.tableAdapterManager = new control_services.gldturfreDeployDataSetTableAdapters.TableAdapterManager();
            this.orcamentoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.orcamentoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.txtbx_kmVolta = new System.Windows.Forms.TextBox();
            this.txtbx_kmIda = new System.Windows.Forms.TextBox();
            this.txtbx_CidadeDestino = new System.Windows.Forms.TextBox();
            this.txtbx_cidadePartida = new System.Windows.Forms.TextBox();
            this.lbl_totalKm = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gldturfreDeployDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoBindingNavigator)).BeginInit();
            this.orcamentoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Partida: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Retorno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantos dias: ";
            // 
            // lbl_quantosDias
            // 
            this.lbl_quantosDias.AutoSize = true;
            this.lbl_quantosDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantosDias.Location = new System.Drawing.Point(140, 549);
            this.lbl_quantosDias.Name = "lbl_quantosDias";
            this.lbl_quantosDias.Size = new System.Drawing.Size(46, 17);
            this.lbl_quantosDias.TabIndex = 3;
            this.lbl_quantosDias.Text = "label4";
            // 
            // data_partida
            // 
            this.data_partida.Location = new System.Drawing.Point(90, 377);
            this.data_partida.Name = "data_partida";
            this.data_partida.Size = new System.Drawing.Size(295, 22);
            this.data_partida.TabIndex = 5;
            // 
            // data_volta
            // 
            this.data_volta.Location = new System.Drawing.Point(90, 467);
            this.data_volta.Name = "data_volta";
            this.data_volta.Size = new System.Drawing.Size(295, 22);
            this.data_volta.TabIndex = 6;
            this.data_volta.Value = new System.DateTime(2023, 4, 8, 0, 0, 0, 0);
            // 
            // contagemDias
            // 
            this.contagemDias.Enabled = true;
            this.contagemDias.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chkbx_BateVolta
            // 
            this.chkbx_BateVolta.AutoSize = true;
            this.chkbx_BateVolta.Location = new System.Drawing.Point(684, 161);
            this.chkbx_BateVolta.Name = "chkbx_BateVolta";
            this.chkbx_BateVolta.Size = new System.Drawing.Size(107, 21);
            this.chkbx_BateVolta.TabIndex = 7;
            this.chkbx_BateVolta.Text = "Bate e Volta";
            this.chkbx_BateVolta.UseVisualStyleBackColor = true;
            // 
            // chkbx_FerPro
            // 
            this.chkbx_FerPro.AutoSize = true;
            this.chkbx_FerPro.Location = new System.Drawing.Point(684, 188);
            this.chkbx_FerPro.Name = "chkbx_FerPro";
            this.chkbx_FerPro.Size = new System.Drawing.Size(155, 21);
            this.chkbx_FerPro.TabIndex = 8;
            this.chkbx_FerPro.Text = "Feriado Prolongado";
            this.chkbx_FerPro.UseVisualStyleBackColor = true;
            // 
            // chkbx_FimSem
            // 
            this.chkbx_FimSem.AutoSize = true;
            this.chkbx_FimSem.Location = new System.Drawing.Point(684, 134);
            this.chkbx_FimSem.Name = "chkbx_FimSem";
            this.chkbx_FimSem.Size = new System.Drawing.Size(128, 21);
            this.chkbx_FimSem.TabIndex = 9;
            this.chkbx_FimSem.Text = "Fim de Semana";
            this.chkbx_FimSem.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DD64",
            "DD60",
            "Semi 46",
            "Exec 50",
            "Exec 46",
            "Conv 47",
            "Micro 32",
            "Van 18",
            "Van 15",
            "Carro"});
            this.comboBox1.Location = new System.Drawing.Point(188, 325);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Categoria de veiculo:";
            // 
            // gldturfreDeployDataSet
            // 
            this.gldturfreDeployDataSet.DataSetName = "gldturfreDeployDataSet";
            this.gldturfreDeployDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orcamentoBindingSource
            // 
            this.orcamentoBindingSource.DataMember = "orcamento";
            this.orcamentoBindingSource.DataSource = this.gldturfreDeployDataSet;
            // 
            // orcamentoTableAdapter
            // 
            this.orcamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            //this.tableAdapterManager.cad_clieTableAdapter = null;
            this.tableAdapterManager.cad_cliTableAdapter = null;
            this.tableAdapterManager.cad_funTableAdapter = null;
            this.tableAdapterManager.categ_veiculoTableAdapter = null;
            this.tableAdapterManager.estadoTableAdapter = null;
            this.tableAdapterManager.lgn_usersTableAdapter = null;
            this.tableAdapterManager.orcamentoTableAdapter = this.orcamentoTableAdapter;
            this.tableAdapterManager.tabela_BateVoltaTableAdapter = null;
            this.tableAdapterManager.tabela_FerProTableAdapter = null;
            this.tableAdapterManager.tabela_FimSemTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = control_services.gldturfreDeployDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veiculoTableAdapter = null;
            this.tableAdapterManager.viagem_fechadaTableAdapter = null;
            // 
            // orcamentoBindingNavigator
            // 
            this.orcamentoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.orcamentoBindingNavigator.BindingSource = this.orcamentoBindingSource;
            this.orcamentoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orcamentoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orcamentoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.orcamentoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.orcamentoBindingNavigatorSaveItem});
            this.orcamentoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orcamentoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orcamentoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orcamentoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orcamentoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orcamentoBindingNavigator.Name = "orcamentoBindingNavigator";
            this.orcamentoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orcamentoBindingNavigator.Size = new System.Drawing.Size(874, 27);
            this.orcamentoBindingNavigator.TabIndex = 12;
            this.orcamentoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // orcamentoBindingNavigatorSaveItem
            // 
            this.orcamentoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orcamentoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orcamentoBindingNavigatorSaveItem.Image")));
            this.orcamentoBindingNavigatorSaveItem.Name = "orcamentoBindingNavigatorSaveItem";
            this.orcamentoBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.orcamentoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.orcamentoBindingNavigatorSaveItem.Click += new System.EventHandler(this.orcamentoBindingNavigatorSaveItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hora Partida: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Hora Retorno:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(133, 413);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 16;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(133, 507);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox2.TabIndex = 17;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // txtbx_kmVolta
            // 
            this.txtbx_kmVolta.Location = new System.Drawing.Point(180, 200);
            this.txtbx_kmVolta.Name = "txtbx_kmVolta";
            this.txtbx_kmVolta.Size = new System.Drawing.Size(153, 22);
            this.txtbx_kmVolta.TabIndex = 40;
            // 
            // txtbx_kmIda
            // 
            this.txtbx_kmIda.Location = new System.Drawing.Point(180, 163);
            this.txtbx_kmIda.Name = "txtbx_kmIda";
            this.txtbx_kmIda.Size = new System.Drawing.Size(153, 22);
            this.txtbx_kmIda.TabIndex = 39;
            // 
            // txtbx_CidadeDestino
            // 
            this.txtbx_CidadeDestino.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "destino", true));
            this.txtbx_CidadeDestino.Location = new System.Drawing.Point(180, 90);
            this.txtbx_CidadeDestino.Name = "txtbx_CidadeDestino";
            this.txtbx_CidadeDestino.Size = new System.Drawing.Size(153, 22);
            this.txtbx_CidadeDestino.TabIndex = 31;
            // 
            // txtbx_cidadePartida
            // 
            this.txtbx_cidadePartida.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orcamentoBindingSource, "partida", true));
            this.txtbx_cidadePartida.Location = new System.Drawing.Point(180, 54);
            this.txtbx_cidadePartida.Name = "txtbx_cidadePartida";
            this.txtbx_cidadePartida.Size = new System.Drawing.Size(153, 22);
            this.txtbx_cidadePartida.TabIndex = 38;
            // 
            // lbl_totalKm
            // 
            this.lbl_totalKm.AutoSize = true;
            this.lbl_totalKm.Location = new System.Drawing.Point(186, 261);
            this.lbl_totalKm.Name = "lbl_totalKm";
            this.lbl_totalKm.Size = new System.Drawing.Size(57, 17);
            this.lbl_totalKm.TabIndex = 37;
            this.lbl_totalKm.Text = "total km";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(102, 261);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 17);
            this.label19.TabIndex = 36;
            this.label19.Text = "Km total :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 203);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(163, 17);
            this.label18.TabIndex = 35;
            this.label18.Text = "Distancia em km (volta) :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 166);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 17);
            this.label17.TabIndex = 34;
            this.label17.Text = "Distancia em km (ida) :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 17);
            this.label16.TabIndex = 33;
            this.label16.Text = "Cidade de Destino :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 17);
            this.label15.TabIndex = 32;
            this.label15.Text = "Cidade de Partida :";
            // 
            // frm_testedata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 675);
            this.Controls.Add(this.txtbx_kmVolta);
            this.Controls.Add(this.txtbx_kmIda);
            this.Controls.Add(this.txtbx_CidadeDestino);
            this.Controls.Add(this.txtbx_cidadePartida);
            this.Controls.Add(this.lbl_totalKm);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.orcamentoBindingNavigator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chkbx_FimSem);
            this.Controls.Add(this.chkbx_FerPro);
            this.Controls.Add(this.chkbx_BateVolta);
            this.Controls.Add(this.data_volta);
            this.Controls.Add(this.data_partida);
            this.Controls.Add(this.lbl_quantosDias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_testedata";
            this.Text = "frm_testedata";
            ((System.ComponentModel.ISupportInitialize)(this.gldturfreDeployDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoBindingNavigator)).EndInit();
            this.orcamentoBindingNavigator.ResumeLayout(false);
            this.orcamentoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_quantosDias;
        private System.Windows.Forms.DateTimePicker data_partida;
        private System.Windows.Forms.DateTimePicker data_volta;
        private System.Windows.Forms.Timer contagemDias;
        private System.Windows.Forms.CheckBox chkbx_BateVolta;
        private System.Windows.Forms.CheckBox chkbx_FerPro;
        private System.Windows.Forms.CheckBox chkbx_FimSem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private gldturfreDeployDataSet gldturfreDeployDataSet;
        private System.Windows.Forms.BindingSource orcamentoBindingSource;
        private gldturfreDeployDataSetTableAdapters.orcamentoTableAdapter orcamentoTableAdapter;
        private gldturfreDeployDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator orcamentoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton orcamentoBindingNavigatorSaveItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.TextBox txtbx_kmVolta;
        private System.Windows.Forms.TextBox txtbx_kmIda;
        private System.Windows.Forms.TextBox txtbx_CidadeDestino;
        private System.Windows.Forms.TextBox txtbx_cidadePartida;
        private System.Windows.Forms.Label lbl_totalKm;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}