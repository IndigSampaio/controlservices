namespace control_services
{
    partial class Form1
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
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label valorLabel1;
            this.glturfreDeployDataSet = new control_services.glturfreDeployDataSet();
            this.batevolta_dd64LBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.batevolta_dd64LTableAdapter = new control_services.glturfreDeployDataSetTableAdapters.batevolta_dd64LTableAdapter();
            this.tableAdapterManager = new control_services.glturfreDeployDataSetTableAdapters.TableAdapterManager();
            this.batevolta_dd60LTableAdapter = new control_services.glturfreDeployDataSetTableAdapters.batevolta_dd60LTableAdapter();
            this.batevolta_dd60LBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox1 = new System.Windows.Forms.TextBox();
            this.grpbxDD60L = new System.Windows.Forms.GroupBox();
            this.grpbxDD64L = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkbxDD60 = new System.Windows.Forms.CheckBox();
            this.chkbxDD64 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtbox_valor = new System.Windows.Forms.TextBox();
            valorLabel = new System.Windows.Forms.Label();
            valorLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.glturfreDeployDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batevolta_dd64LBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batevolta_dd60LBindingSource)).BeginInit();
            this.grpbxDD60L.SuspendLayout();
            this.grpbxDD64L.SuspendLayout();
            this.SuspendLayout();
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(12, 55);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(91, 17);
            valorLabel.TabIndex = 1;
            valorLabel.Text = "DD60L valor:";
            // 
            // valorLabel1
            // 
            valorLabel1.AutoSize = true;
            valorLabel1.Location = new System.Drawing.Point(12, 48);
            valorLabel1.Name = "valorLabel1";
            valorLabel1.Size = new System.Drawing.Size(91, 17);
            valorLabel1.TabIndex = 3;
            valorLabel1.Text = "DD64L valor:";
            // 
            // glturfreDeployDataSet
            // 
            this.glturfreDeployDataSet.DataSetName = "glturfreDeployDataSet";
            this.glturfreDeployDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // batevolta_dd64LBindingSource
            // 
            this.batevolta_dd64LBindingSource.DataMember = "batevolta_dd64L";
            this.batevolta_dd64LBindingSource.DataSource = this.glturfreDeployDataSet;
            // 
            // batevolta_dd64LTableAdapter
            // 
            this.batevolta_dd64LTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.batevolta_carroTableAdapter = null;
            this.tableAdapterManager.batevolta_conv47LTableAdapter = null;
            this.tableAdapterManager.batevolta_dd60LTableAdapter = this.batevolta_dd60LTableAdapter;
            this.tableAdapterManager.batevolta_dd64LTableAdapter = this.batevolta_dd64LTableAdapter;
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
            this.tableAdapterManager.orcamentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = control_services.glturfreDeployDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veiculoTableAdapter = null;
            // 
            // batevolta_dd60LTableAdapter
            // 
            this.batevolta_dd60LTableAdapter.ClearBeforeFill = true;
            // 
            // batevolta_dd60LBindingSource
            // 
            this.batevolta_dd60LBindingSource.DataMember = "batevolta_dd60L";
            this.batevolta_dd60LBindingSource.DataSource = this.glturfreDeployDataSet;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batevolta_dd60LBindingSource, "valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(109, 55);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 22);
            this.valorTextBox.TabIndex = 2;
            // 
            // valorTextBox1
            // 
            this.valorTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batevolta_dd64LBindingSource, "valor", true));
            this.valorTextBox1.Location = new System.Drawing.Point(109, 45);
            this.valorTextBox1.Name = "valorTextBox1";
            this.valorTextBox1.Size = new System.Drawing.Size(100, 22);
            this.valorTextBox1.TabIndex = 4;
            this.valorTextBox1.TextChanged += new System.EventHandler(this.valorTextBox1_TextChanged);
            // 
            // grpbxDD60L
            // 
            this.grpbxDD60L.Controls.Add(this.valorTextBox);
            this.grpbxDD60L.Controls.Add(valorLabel);
            this.grpbxDD60L.Location = new System.Drawing.Point(96, 196);
            this.grpbxDD60L.Name = "grpbxDD60L";
            this.grpbxDD60L.Size = new System.Drawing.Size(231, 100);
            this.grpbxDD60L.TabIndex = 5;
            this.grpbxDD60L.TabStop = false;
            this.grpbxDD60L.Text = "groupBox1";
            // 
            // grpbxDD64L
            // 
            this.grpbxDD64L.Controls.Add(valorLabel1);
            this.grpbxDD64L.Controls.Add(this.valorTextBox1);
            this.grpbxDD64L.Location = new System.Drawing.Point(96, 302);
            this.grpbxDD64L.Name = "grpbxDD64L";
            this.grpbxDD64L.Size = new System.Drawing.Size(231, 100);
            this.grpbxDD64L.TabIndex = 6;
            this.grpbxDD64L.TabStop = false;
            this.grpbxDD64L.Text = "groupBox2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chkbxDD60
            // 
            this.chkbxDD60.AutoSize = true;
            this.chkbxDD60.Location = new System.Drawing.Point(393, 111);
            this.chkbxDD60.Name = "chkbxDD60";
            this.chkbxDD60.Size = new System.Drawing.Size(74, 21);
            this.chkbxDD60.TabIndex = 8;
            this.chkbxDD60.Text = "DD60L";
            this.chkbxDD60.UseVisualStyleBackColor = true;
            // 
            // chkbxDD64
            // 
            this.chkbxDD64.AutoSize = true;
            this.chkbxDD64.Location = new System.Drawing.Point(393, 158);
            this.chkbxDD64.Name = "chkbxDD64";
            this.chkbxDD64.Size = new System.Drawing.Size(74, 21);
            this.chkbxDD64.TabIndex = 9;
            this.chkbxDD64.Text = "DD64L";
            this.chkbxDD64.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtbox_valor
            // 
            this.txtbox_valor.Location = new System.Drawing.Point(96, 424);
            this.txtbox_valor.Name = "txtbox_valor";
            this.txtbox_valor.Size = new System.Drawing.Size(231, 22);
            this.txtbox_valor.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 654);
            this.Controls.Add(this.txtbox_valor);
            this.Controls.Add(this.chkbxDD64);
            this.Controls.Add(this.chkbxDD60);
            this.Controls.Add(this.grpbxDD64L);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grpbxDD60L);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glturfreDeployDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batevolta_dd64LBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batevolta_dd60LBindingSource)).EndInit();
            this.grpbxDD60L.ResumeLayout(false);
            this.grpbxDD60L.PerformLayout();
            this.grpbxDD64L.ResumeLayout(false);
            this.grpbxDD64L.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private glturfreDeployDataSet glturfreDeployDataSet;
        private System.Windows.Forms.BindingSource batevolta_dd64LBindingSource;
        private glturfreDeployDataSetTableAdapters.batevolta_dd64LTableAdapter batevolta_dd64LTableAdapter;
        private glturfreDeployDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private glturfreDeployDataSetTableAdapters.batevolta_dd60LTableAdapter batevolta_dd60LTableAdapter;
        private System.Windows.Forms.BindingSource batevolta_dd60LBindingSource;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox valorTextBox1;
        private System.Windows.Forms.GroupBox grpbxDD60L;
        private System.Windows.Forms.GroupBox grpbxDD64L;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkbxDD60;
        private System.Windows.Forms.CheckBox chkbxDD64;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtbox_valor;
    }
}