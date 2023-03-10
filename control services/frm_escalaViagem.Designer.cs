namespace control_services
{
    partial class frm_escalaViagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_escalaViagem));
            this.glturfreDeployDataSet = new control_services.glturfreDeployDataSet();
            this.orcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orcamentoTableAdapter = new control_services.glturfreDeployDataSetTableAdapters.orcamentoTableAdapter();
            this.tableAdapterManager = new control_services.glturfreDeployDataSetTableAdapters.TableAdapterManager();
            this.orcamentoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.orcamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.orcamentoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.glturfreDeployDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoBindingNavigator)).BeginInit();
            this.orcamentoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // glturfreDeployDataSet
            // 
            this.glturfreDeployDataSet.DataSetName = "glturfreDeployDataSet";
            this.glturfreDeployDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orcamentoBindingSource
            // 
            this.orcamentoBindingSource.DataMember = "orcamento";
            this.orcamentoBindingSource.DataSource = this.glturfreDeployDataSet;
            // 
            // orcamentoTableAdapter
            // 
            this.orcamentoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.orcamentoTableAdapter = this.orcamentoTableAdapter;
            this.tableAdapterManager.UpdateOrder = control_services.glturfreDeployDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veiculoTableAdapter = null;
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
            this.orcamentoBindingNavigator.Size = new System.Drawing.Size(1374, 27);
            this.orcamentoBindingNavigator.TabIndex = 0;
            this.orcamentoBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // orcamentoDataGridView
            // 
            this.orcamentoDataGridView.AllowUserToDeleteRows = false;
            this.orcamentoDataGridView.AutoGenerateColumns = false;
            this.orcamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orcamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.orcamentoDataGridView.DataSource = this.orcamentoBindingSource;
            this.orcamentoDataGridView.Location = new System.Drawing.Point(0, 422);
            this.orcamentoDataGridView.Name = "orcamentoDataGridView";
            this.orcamentoDataGridView.RowTemplate.Height = 24;
            this.orcamentoDataGridView.Size = new System.Drawing.Size(1114, 220);
            this.orcamentoDataGridView.TabIndex = 1;
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
            // orcamentoBindingNavigatorSaveItem
            // 
            this.orcamentoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orcamentoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orcamentoBindingNavigatorSaveItem.Image")));
            this.orcamentoBindingNavigatorSaveItem.Name = "orcamentoBindingNavigatorSaveItem";
            this.orcamentoBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.orcamentoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.orcamentoBindingNavigatorSaveItem.Click += new System.EventHandler(this.orcamentoBindingNavigatorSaveItem_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_orcamento";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_orcamento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome_cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome_cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cpf_cnpj_cliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "cpf_cnpj_cliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tel_cliente";
            this.dataGridViewTextBoxColumn4.HeaderText = "tel_cliente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn5.HeaderText = "valor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "motorista";
            this.dataGridViewTextBoxColumn6.HeaderText = "motorista";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "partida";
            this.dataGridViewTextBoxColumn7.HeaderText = "partida";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "data_partida";
            this.dataGridViewTextBoxColumn8.HeaderText = "data_partida";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "destino";
            this.dataGridViewTextBoxColumn10.HeaderText = "destino";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "data_retorno";
            this.dataGridViewTextBoxColumn11.HeaderText = "data_retorno";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // frm_escalaViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 695);
            this.Controls.Add(this.orcamentoDataGridView);
            this.Controls.Add(this.orcamentoBindingNavigator);
            this.Name = "frm_escalaViagem";
            this.Text = "Escala de Viagem";
            this.Load += new System.EventHandler(this.frm_escalaViagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glturfreDeployDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoBindingNavigator)).EndInit();
            this.orcamentoBindingNavigator.ResumeLayout(false);
            this.orcamentoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private glturfreDeployDataSet glturfreDeployDataSet;
        private System.Windows.Forms.BindingSource orcamentoBindingSource;
        private glturfreDeployDataSetTableAdapters.orcamentoTableAdapter orcamentoTableAdapter;
        private glturfreDeployDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.DataGridView orcamentoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}