namespace control_services
{
    partial class frm_escala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_escala));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viagem_fechadaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.viagem_fechadaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.viagem_fechadaDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.viagem_fechadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gldturfreDeployDataSet = new control_services.gldturfreDeployDataSet();
            this.viagem_fechadaTableAdapter = new control_services.gldturfreDeployDataSetTableAdapters.viagem_fechadaTableAdapter();
            this.tableAdapterManager = new control_services.gldturfreDeployDataSetTableAdapters.TableAdapterManager();
            this.veiculoTableAdapter = new control_services.gldturfreDeployDataSetTableAdapters.veiculoTableAdapter();
            this.fillByCategVeiculo_DisponivelToolStrip = new System.Windows.Forms.ToolStrip();
            this.param1ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.param1ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByCategVeiculo_DisponivelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.id_orcamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.viagem_fechadaBindingNavigator)).BeginInit();
            this.viagem_fechadaBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viagem_fechadaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viagem_fechadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gldturfreDeployDataSet)).BeginInit();
            this.fillByCategVeiculo_DisponivelToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // viagem_fechadaBindingNavigator
            // 
            this.viagem_fechadaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.viagem_fechadaBindingNavigator.BindingSource = this.viagem_fechadaBindingSource;
            this.viagem_fechadaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.viagem_fechadaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.viagem_fechadaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.viagem_fechadaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.viagem_fechadaBindingNavigatorSaveItem});
            this.viagem_fechadaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.viagem_fechadaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.viagem_fechadaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.viagem_fechadaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.viagem_fechadaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.viagem_fechadaBindingNavigator.Name = "viagem_fechadaBindingNavigator";
            this.viagem_fechadaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.viagem_fechadaBindingNavigator.Size = new System.Drawing.Size(1219, 27);
            this.viagem_fechadaBindingNavigator.TabIndex = 0;
            this.viagem_fechadaBindingNavigator.Text = "bindingNavigator1";
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
            // viagem_fechadaBindingNavigatorSaveItem
            // 
            this.viagem_fechadaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.viagem_fechadaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("viagem_fechadaBindingNavigatorSaveItem.Image")));
            this.viagem_fechadaBindingNavigatorSaveItem.Name = "viagem_fechadaBindingNavigatorSaveItem";
            this.viagem_fechadaBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.viagem_fechadaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.viagem_fechadaBindingNavigatorSaveItem.Click += new System.EventHandler(this.viagem_fechadaBindingNavigatorSaveItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.viagem_fechadaDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 457);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 598);
            this.panel1.TabIndex = 1;
            // 
            // viagem_fechadaDataGridView
            // 
            this.viagem_fechadaDataGridView.AllowUserToAddRows = false;
            this.viagem_fechadaDataGridView.AllowUserToDeleteRows = false;
            this.viagem_fechadaDataGridView.AutoGenerateColumns = false;
            this.viagem_fechadaDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.viagem_fechadaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viagem_fechadaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_orcamento,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn7});
            this.viagem_fechadaDataGridView.DataSource = this.viagem_fechadaBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viagem_fechadaDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.viagem_fechadaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viagem_fechadaDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.viagem_fechadaDataGridView.Location = new System.Drawing.Point(0, 0);
            this.viagem_fechadaDataGridView.Name = "viagem_fechadaDataGridView";
            this.viagem_fechadaDataGridView.RowTemplate.Height = 24;
            this.viagem_fechadaDataGridView.Size = new System.Drawing.Size(1219, 598);
            this.viagem_fechadaDataGridView.TabIndex = 2;
            this.viagem_fechadaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viagem_fechadaDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veiculo:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // viagem_fechadaBindingSource
            // 
            this.viagem_fechadaBindingSource.DataMember = "viagem_fechada";
            this.viagem_fechadaBindingSource.DataSource = this.gldturfreDeployDataSet;
            // 
            // gldturfreDeployDataSet
            // 
            this.gldturfreDeployDataSet.DataSetName = "gldturfreDeployDataSet";
            this.gldturfreDeployDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viagem_fechadaTableAdapter
            // 
            this.viagem_fechadaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cad_clieTableAdapter = null;
            this.tableAdapterManager.cad_funTableAdapter = null;
            this.tableAdapterManager.categ_veiculoTableAdapter = null;
            this.tableAdapterManager.estadoTableAdapter = null;
            this.tableAdapterManager.orcamentoTableAdapter = null;
            this.tableAdapterManager.tabela_BateVoltaTableAdapter = null;
            this.tableAdapterManager.tabela_FerProTableAdapter = null;
            this.tableAdapterManager.tabela_FimSemTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = control_services.gldturfreDeployDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veiculoTableAdapter = null;
            this.tableAdapterManager.viagem_fechadaTableAdapter = this.viagem_fechadaTableAdapter;
            // 
            // veiculoTableAdapter
            // 
            this.veiculoTableAdapter.ClearBeforeFill = true;
            // 
            // fillByCategVeiculo_DisponivelToolStrip
            // 
            this.fillByCategVeiculo_DisponivelToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByCategVeiculo_DisponivelToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.param1ToolStripLabel,
            this.param1ToolStripTextBox,
            this.fillByCategVeiculo_DisponivelToolStripButton});
            this.fillByCategVeiculo_DisponivelToolStrip.Location = new System.Drawing.Point(0, 27);
            this.fillByCategVeiculo_DisponivelToolStrip.Name = "fillByCategVeiculo_DisponivelToolStrip";
            this.fillByCategVeiculo_DisponivelToolStrip.Size = new System.Drawing.Size(1219, 27);
            this.fillByCategVeiculo_DisponivelToolStrip.TabIndex = 4;
            this.fillByCategVeiculo_DisponivelToolStrip.Text = "fillByCategVeiculo_DisponivelToolStrip";
            // 
            // param1ToolStripLabel
            // 
            this.param1ToolStripLabel.Name = "param1ToolStripLabel";
            this.param1ToolStripLabel.Size = new System.Drawing.Size(61, 24);
            this.param1ToolStripLabel.Text = "Param1:";
            // 
            // param1ToolStripTextBox
            // 
            this.param1ToolStripTextBox.Name = "param1ToolStripTextBox";
            this.param1ToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillByCategVeiculo_DisponivelToolStripButton
            // 
            this.fillByCategVeiculo_DisponivelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByCategVeiculo_DisponivelToolStripButton.Name = "fillByCategVeiculo_DisponivelToolStripButton";
            this.fillByCategVeiculo_DisponivelToolStripButton.Size = new System.Drawing.Size(211, 24);
            this.fillByCategVeiculo_DisponivelToolStripButton.Text = "FillByCategVeiculo_Disponivel";
            this.fillByCategVeiculo_DisponivelToolStripButton.Click += new System.EventHandler(this.fillByCategVeiculo_DisponivelToolStripButton_Click);
            // 
            // id_orcamento
            // 
            this.id_orcamento.DataPropertyName = "id_orcamento";
            this.id_orcamento.HeaderText = "Cod. Contrato";
            this.id_orcamento.Name = "id_orcamento";
            this.id_orcamento.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cpf_cnpj_cliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "CPF/CNPJ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "partida";
            this.dataGridViewTextBoxColumn8.HeaderText = "Partida";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "destino";
            this.dataGridViewTextBoxColumn11.HeaderText = "Destino";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "categ_veiculo";
            this.dataGridViewTextBoxColumn13.HeaderText = "Categoria do Veiculo";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "veiculo";
            this.dataGridViewTextBoxColumn14.HeaderText = "Veiculo";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn14.Width = 83;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "motorista";
            this.dataGridViewTextBoxColumn7.HeaderText = "Motorista";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_escala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1219, 1055);
            this.Controls.Add(this.fillByCategVeiculo_DisponivelToolStrip);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.viagem_fechadaBindingNavigator);
            this.Name = "frm_escala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escala de Viagem";
            this.Load += new System.EventHandler(this.frm_escala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viagem_fechadaBindingNavigator)).EndInit();
            this.viagem_fechadaBindingNavigator.ResumeLayout(false);
            this.viagem_fechadaBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viagem_fechadaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viagem_fechadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gldturfreDeployDataSet)).EndInit();
            this.fillByCategVeiculo_DisponivelToolStrip.ResumeLayout(false);
            this.fillByCategVeiculo_DisponivelToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private gldturfreDeployDataSet gldturfreDeployDataSet;
        private System.Windows.Forms.BindingSource viagem_fechadaBindingSource;
        private gldturfreDeployDataSetTableAdapters.viagem_fechadaTableAdapter viagem_fechadaTableAdapter;
        private gldturfreDeployDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator viagem_fechadaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton viagem_fechadaBindingNavigatorSaveItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView viagem_fechadaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private gldturfreDeployDataSetTableAdapters.veiculoTableAdapter veiculoTableAdapter;
        private System.Windows.Forms.ToolStrip fillByCategVeiculo_DisponivelToolStrip;
        private System.Windows.Forms.ToolStripLabel param1ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox param1ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByCategVeiculo_DisponivelToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_orcamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Timer timer1;
    }
}