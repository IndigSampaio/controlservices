namespace control_services
{
    partial class frm_cadfun_teste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadfun_teste));
            System.Windows.Forms.Label id_cadLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ver_senha = new System.Windows.Forms.CheckBox();
            this.txtbx_snh = new System.Windows.Forms.TextBox();
            this.txtbx_lgn = new System.Windows.Forms.TextBox();
            this.txtbx_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ckdbx_ativo = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtbx_info_tst = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.testeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmbbx_cargo = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.testeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gldturDataSet = new control_services.gldturDataSet();
            this.testeTableAdapter = new control_services.gldturDataSetTableAdapters.testeTableAdapter();
            this.tableAdapterManager = new control_services.gldturDataSetTableAdapters.TableAdapterManager();
            this.gldturDataSet1 = new control_services.gldturDataSet();
            this.testeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            id_cadLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testeBindingNavigator)).BeginInit();
            this.testeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gldturDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gldturDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(12, 210);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 602);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.maskedTextBox1);
            this.tabPage1.Controls.Add(id_cadLabel);
            this.tabPage1.Controls.Add(this.ver_senha);
            this.tabPage1.Controls.Add(this.txtbx_snh);
            this.tabPage1.Controls.Add(this.txtbx_lgn);
            this.tabPage1.Controls.Add(this.txtbx_nome);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 573);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ver_senha
            // 
            this.ver_senha.AutoSize = true;
            this.ver_senha.Location = new System.Drawing.Point(293, 199);
            this.ver_senha.Name = "ver_senha";
            this.ver_senha.Size = new System.Drawing.Size(107, 21);
            this.ver_senha.TabIndex = 6;
            this.ver_senha.Text = "Ver a senha";
            this.ver_senha.UseVisualStyleBackColor = true;
            // 
            // txtbx_snh
            // 
            this.txtbx_snh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbx_snh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testeBindingSource, "snh", true));
            this.txtbx_snh.Location = new System.Drawing.Point(105, 199);
            this.txtbx_snh.Name = "txtbx_snh";
            this.txtbx_snh.PasswordChar = '*';
            this.txtbx_snh.Size = new System.Drawing.Size(178, 22);
            this.txtbx_snh.TabIndex = 5;
            // 
            // txtbx_lgn
            // 
            this.txtbx_lgn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbx_lgn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testeBindingSource, "lgn", true));
            this.txtbx_lgn.Location = new System.Drawing.Point(105, 131);
            this.txtbx_lgn.Name = "txtbx_lgn";
            this.txtbx_lgn.Size = new System.Drawing.Size(182, 22);
            this.txtbx_lgn.TabIndex = 4;
            // 
            // txtbx_nome
            // 
            this.txtbx_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbx_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testeBindingSource, "nome", true));
            this.txtbx_nome.Location = new System.Drawing.Point(105, 86);
            this.txtbx_nome.Name = "txtbx_nome";
            this.txtbx_nome.Size = new System.Drawing.Size(182, 22);
            this.txtbx_nome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbbx_cargo);
            this.tabPage2.Controls.Add(this.ckdbx_ativo);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 573);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ckdbx_ativo
            // 
            this.ckdbx_ativo.AutoSize = true;
            this.ckdbx_ativo.Checked = true;
            this.ckdbx_ativo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckdbx_ativo.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.testeBindingSource, "ativo", true));
            this.ckdbx_ativo.Location = new System.Drawing.Point(136, 213);
            this.ckdbx_ativo.Name = "ckdbx_ativo";
            this.ckdbx_ativo.Size = new System.Drawing.Size(18, 17);
            this.ckdbx_ativo.TabIndex = 5;
            this.ckdbx_ativo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ativo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cargo :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtbx_info_tst);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 573);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtbx_info_tst
            // 
            this.txtbx_info_tst.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testeBindingSource, "inf_tst", true));
            this.txtbx_info_tst.Location = new System.Drawing.Point(199, 111);
            this.txtbx_info_tst.Name = "txtbx_info_tst";
            this.txtbx_info_tst.Size = new System.Drawing.Size(462, 22);
            this.txtbx_info_tst.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Informacao do teste :";
            // 
            // testeBindingNavigator
            // 
            this.testeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.testeBindingNavigator.BindingSource = this.testeBindingSource;
            this.testeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.testeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.testeBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.testeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.testeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.testeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.testeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.testeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.testeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.testeBindingNavigator.Name = "testeBindingNavigator";
            this.testeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.testeBindingNavigator.Size = new System.Drawing.Size(799, 27);
            this.testeBindingNavigator.TabIndex = 1;
            this.testeBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmbbx_cargo
            // 
            this.cmbbx_cargo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testeBindingSource, "cargo", true));
            this.cmbbx_cargo.FormattingEnabled = true;
            this.cmbbx_cargo.Items.AddRange(new object[] {
            "Financeiro",
            "T.I.",
            "R.H.",
            "Contabilidade"});
            this.cmbbx_cargo.Location = new System.Drawing.Point(143, 107);
            this.cmbbx_cargo.Name = "cmbbx_cargo";
            this.cmbbx_cargo.Size = new System.Drawing.Size(199, 24);
            this.cmbbx_cargo.TabIndex = 6;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(16, 64);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(172, 68);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(194, 64);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(172, 68);
            this.btn_salvar.TabIndex = 3;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(372, 64);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(172, 68);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // testeBindingSource
            // 
            this.testeBindingSource.DataMember = "teste";
            this.testeBindingSource.DataSource = this.gldturDataSet;
            // 
            // gldturDataSet
            // 
            this.gldturDataSet.DataSetName = "gldturDataSet";
            this.gldturDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testeTableAdapter
            // 
            this.testeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cad_funTableAdapter = null;
            this.tableAdapterManager.testeTableAdapter = this.testeTableAdapter;
            this.tableAdapterManager.UpdateOrder = control_services.gldturDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // id_cadLabel
            // 
            id_cadLabel.AutoSize = true;
            id_cadLabel.Location = new System.Drawing.Point(46, 38);
            id_cadLabel.Name = "id_cadLabel";
            id_cadLabel.Size = new System.Drawing.Size(42, 17);
            id_cadLabel.TabIndex = 9;
            id_cadLabel.Text = "CPF :";
            // 
            // gldturDataSet1
            // 
            this.gldturDataSet1.DataSetName = "gldturDataSet";
            this.gldturDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testeBindingSource1
            // 
            this.testeBindingSource1.DataMember = "teste";
            this.testeBindingSource1.DataSource = this.gldturDataSet1;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testeBindingSource1, "cpf", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(105, 38);
            this.maskedTextBox1.Mask = "999.999.999-99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(104, 22);
            this.maskedTextBox1.TabIndex = 10;
            // 
            // frm_cadfun_teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 832);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.testeBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_cadfun_teste";
            this.Text = "frm_cadfun_teste";
            this.Load += new System.EventHandler(this.frm_cadfun_teste_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testeBindingNavigator)).EndInit();
            this.testeBindingNavigator.ResumeLayout(false);
            this.testeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gldturDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gldturDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private gldturDataSet gldturDataSet;
        private System.Windows.Forms.BindingSource testeBindingSource;
        private gldturDataSetTableAdapters.testeTableAdapter testeTableAdapter;
        private gldturDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator testeBindingNavigator;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtbx_snh;
        private System.Windows.Forms.TextBox txtbx_lgn;
        private System.Windows.Forms.TextBox txtbx_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox ver_senha;
        private System.Windows.Forms.CheckBox ckdbx_ativo;
        private System.Windows.Forms.TextBox txtbx_info_tst;
        private System.Windows.Forms.ComboBox cmbbx_cargo;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private gldturDataSet gldturDataSet1;
        private System.Windows.Forms.BindingSource testeBindingSource1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}