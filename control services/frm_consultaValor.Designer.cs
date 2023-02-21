namespace control_services
{
    partial class frm_consultaValor
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
            this.glturfreDeployDataSet = new control_services.glturfreDeployDataSet();
            this.batevolta_dd64LBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.batevolta_dd64LTableAdapter = new control_services.glturfreDeployDataSetTableAdapters.batevolta_dd64LTableAdapter();
            this.tableAdapterManager = new control_services.glturfreDeployDataSetTableAdapters.TableAdapterManager();
            this.batevolta_dd60LTableAdapter = new control_services.glturfreDeployDataSetTableAdapters.batevolta_dd60LTableAdapter();
            this.batevolta_dd60LBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtbx_valorBateVolta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_BateVolta = new System.Windows.Forms.TabPage();
            this.tabPage_FimSemana = new System.Windows.Forms.TabPage();
            this.tabPage_FeriadoProlongado = new System.Windows.Forms.TabPage();
            this.chkBx_BateVolta_DD64L = new System.Windows.Forms.CheckBox();
            this.chkBx_BateVolta_DD60L = new System.Windows.Forms.CheckBox();
            this.chkBx_BateVolta_Semi46L = new System.Windows.Forms.CheckBox();
            this.chkBx_BateVolta_Exec50L = new System.Windows.Forms.CheckBox();
            this.chkBx_BateVolta_Exec46L = new System.Windows.Forms.CheckBox();
            this.chkBx_BateVolta_Conv47L = new System.Windows.Forms.CheckBox();
            this.chkBx_BateVolta_Micro32L = new System.Windows.Forms.CheckBox();
            this.chkBx_BateVolta_Van18L = new System.Windows.Forms.CheckBox();
            this.chkBx_BateVolta_Van15L = new System.Windows.Forms.CheckBox();
            this.chkBx_BateVolta_Carro = new System.Windows.Forms.CheckBox();
            this.chkBx_FimSem_Carro = new System.Windows.Forms.CheckBox();
            this.chkBx_FimSem_Van15L = new System.Windows.Forms.CheckBox();
            this.chkBx_FimSem_Van18L = new System.Windows.Forms.CheckBox();
            this.chkBx_FimSem_Micro32L = new System.Windows.Forms.CheckBox();
            this.chkBx_FimSem_Conv47L = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkBx_FimSem_Exec46L = new System.Windows.Forms.CheckBox();
            this.txtbx_valorFimSem = new System.Windows.Forms.TextBox();
            this.chkBx_FimSem_Exec50L = new System.Windows.Forms.CheckBox();
            this.chkBx_FimSem_Semi46L = new System.Windows.Forms.CheckBox();
            this.chkBx_FimSem_DD60L = new System.Windows.Forms.CheckBox();
            this.chkBx_FimSem_DD64L = new System.Windows.Forms.CheckBox();
            this.chkBx_FerPro_Carro = new System.Windows.Forms.CheckBox();
            this.chkBx_FerPro_Van15L = new System.Windows.Forms.CheckBox();
            this.chkBx_FerPro_Van18L = new System.Windows.Forms.CheckBox();
            this.chkBx_FerPro_Micro32L = new System.Windows.Forms.CheckBox();
            this.chkBx_FerPro_Conv47L = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkBx_FerPro_Exec46L = new System.Windows.Forms.CheckBox();
            this.txtbx_valorFerPro = new System.Windows.Forms.TextBox();
            this.chkBx_FerPro_Exec50L = new System.Windows.Forms.CheckBox();
            this.chkBx_FerPro_Semi46L = new System.Windows.Forms.CheckBox();
            this.chkBx_FerPro_DD60L = new System.Windows.Forms.CheckBox();
            this.chkBx_FerPro_DD64L = new System.Windows.Forms.CheckBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.glturfreDeployDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batevolta_dd64LBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batevolta_dd60LBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage_BateVolta.SuspendLayout();
            this.tabPage_FimSemana.SuspendLayout();
            this.tabPage_FeriadoProlongado.SuspendLayout();
            this.SuspendLayout();
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
            this.tableAdapterManager.UpdateOrder = control_services.glturfreDeployDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cidade :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtbx_valorBateVolta
            // 
            this.txtbx_valorBateVolta.Location = new System.Drawing.Point(92, 267);
            this.txtbx_valorBateVolta.Name = "txtbx_valorBateVolta";
            this.txtbx_valorBateVolta.Size = new System.Drawing.Size(187, 22);
            this.txtbx_valorBateVolta.TabIndex = 2;
            this.txtbx_valorBateVolta.TextChanged += new System.EventHandler(this.txtbx_valorBateVolta_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "R$";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_BateVolta);
            this.tabControl1.Controls.Add(this.tabPage_FimSemana);
            this.tabControl1.Controls.Add(this.tabPage_FeriadoProlongado);
            this.tabControl1.Location = new System.Drawing.Point(6, 112);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(396, 352);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage_BateVolta
            // 
            this.tabPage_BateVolta.Controls.Add(this.chkBx_BateVolta_Carro);
            this.tabPage_BateVolta.Controls.Add(this.chkBx_BateVolta_Van15L);
            this.tabPage_BateVolta.Controls.Add(this.chkBx_BateVolta_Van18L);
            this.tabPage_BateVolta.Controls.Add(this.chkBx_BateVolta_Micro32L);
            this.tabPage_BateVolta.Controls.Add(this.chkBx_BateVolta_Conv47L);
            this.tabPage_BateVolta.Controls.Add(this.label2);
            this.tabPage_BateVolta.Controls.Add(this.chkBx_BateVolta_Exec46L);
            this.tabPage_BateVolta.Controls.Add(this.txtbx_valorBateVolta);
            this.tabPage_BateVolta.Controls.Add(this.chkBx_BateVolta_Exec50L);
            this.tabPage_BateVolta.Controls.Add(this.chkBx_BateVolta_Semi46L);
            this.tabPage_BateVolta.Controls.Add(this.chkBx_BateVolta_DD60L);
            this.tabPage_BateVolta.Controls.Add(this.chkBx_BateVolta_DD64L);
            this.tabPage_BateVolta.Location = new System.Drawing.Point(4, 25);
            this.tabPage_BateVolta.Name = "tabPage_BateVolta";
            this.tabPage_BateVolta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_BateVolta.Size = new System.Drawing.Size(388, 323);
            this.tabPage_BateVolta.TabIndex = 0;
            this.tabPage_BateVolta.Text = "Bate / Volta";
            this.tabPage_BateVolta.UseVisualStyleBackColor = true;
            // 
            // tabPage_FimSemana
            // 
            this.tabPage_FimSemana.Controls.Add(this.chkBx_FimSem_Carro);
            this.tabPage_FimSemana.Controls.Add(this.chkBx_FimSem_Van15L);
            this.tabPage_FimSemana.Controls.Add(this.chkBx_FimSem_Van18L);
            this.tabPage_FimSemana.Controls.Add(this.chkBx_FimSem_Micro32L);
            this.tabPage_FimSemana.Controls.Add(this.chkBx_FimSem_Conv47L);
            this.tabPage_FimSemana.Controls.Add(this.label3);
            this.tabPage_FimSemana.Controls.Add(this.chkBx_FimSem_Exec46L);
            this.tabPage_FimSemana.Controls.Add(this.txtbx_valorFimSem);
            this.tabPage_FimSemana.Controls.Add(this.chkBx_FimSem_Exec50L);
            this.tabPage_FimSemana.Controls.Add(this.chkBx_FimSem_Semi46L);
            this.tabPage_FimSemana.Controls.Add(this.chkBx_FimSem_DD60L);
            this.tabPage_FimSemana.Controls.Add(this.chkBx_FimSem_DD64L);
            this.tabPage_FimSemana.Location = new System.Drawing.Point(4, 25);
            this.tabPage_FimSemana.Name = "tabPage_FimSemana";
            this.tabPage_FimSemana.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_FimSemana.Size = new System.Drawing.Size(388, 323);
            this.tabPage_FimSemana.TabIndex = 1;
            this.tabPage_FimSemana.Text = "Fim de Semana";
            this.tabPage_FimSemana.UseVisualStyleBackColor = true;
            // 
            // tabPage_FeriadoProlongado
            // 
            this.tabPage_FeriadoProlongado.Controls.Add(this.chkBx_FerPro_Carro);
            this.tabPage_FeriadoProlongado.Controls.Add(this.chkBx_FerPro_Van15L);
            this.tabPage_FeriadoProlongado.Controls.Add(this.chkBx_FerPro_Van18L);
            this.tabPage_FeriadoProlongado.Controls.Add(this.chkBx_FerPro_Micro32L);
            this.tabPage_FeriadoProlongado.Controls.Add(this.chkBx_FerPro_Conv47L);
            this.tabPage_FeriadoProlongado.Controls.Add(this.label4);
            this.tabPage_FeriadoProlongado.Controls.Add(this.chkBx_FerPro_Exec46L);
            this.tabPage_FeriadoProlongado.Controls.Add(this.txtbx_valorFerPro);
            this.tabPage_FeriadoProlongado.Controls.Add(this.chkBx_FerPro_Exec50L);
            this.tabPage_FeriadoProlongado.Controls.Add(this.chkBx_FerPro_Semi46L);
            this.tabPage_FeriadoProlongado.Controls.Add(this.chkBx_FerPro_DD60L);
            this.tabPage_FeriadoProlongado.Controls.Add(this.chkBx_FerPro_DD64L);
            this.tabPage_FeriadoProlongado.Location = new System.Drawing.Point(4, 25);
            this.tabPage_FeriadoProlongado.Name = "tabPage_FeriadoProlongado";
            this.tabPage_FeriadoProlongado.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_FeriadoProlongado.Size = new System.Drawing.Size(388, 323);
            this.tabPage_FeriadoProlongado.TabIndex = 2;
            this.tabPage_FeriadoProlongado.Text = "Feriado Prolongado";
            this.tabPage_FeriadoProlongado.UseVisualStyleBackColor = true;
            // 
            // chkBx_BateVolta_DD64L
            // 
            this.chkBx_BateVolta_DD64L.AutoSize = true;
            this.chkBx_BateVolta_DD64L.Location = new System.Drawing.Point(45, 30);
            this.chkBx_BateVolta_DD64L.Name = "chkBx_BateVolta_DD64L";
            this.chkBx_BateVolta_DD64L.Size = new System.Drawing.Size(78, 21);
            this.chkBx_BateVolta_DD64L.TabIndex = 0;
            this.chkBx_BateVolta_DD64L.Text = "DD 64L";
            this.chkBx_BateVolta_DD64L.UseVisualStyleBackColor = true;
            this.chkBx_BateVolta_DD64L.CheckedChanged += new System.EventHandler(this.chkBx_BateVolta_DD64L_CheckedChanged);
            // 
            // chkBx_BateVolta_DD60L
            // 
            this.chkBx_BateVolta_DD60L.AutoSize = true;
            this.chkBx_BateVolta_DD60L.Location = new System.Drawing.Point(45, 70);
            this.chkBx_BateVolta_DD60L.Name = "chkBx_BateVolta_DD60L";
            this.chkBx_BateVolta_DD60L.Size = new System.Drawing.Size(78, 21);
            this.chkBx_BateVolta_DD60L.TabIndex = 1;
            this.chkBx_BateVolta_DD60L.Text = "DD 60L";
            this.chkBx_BateVolta_DD60L.UseVisualStyleBackColor = true;
            // 
            // chkBx_BateVolta_Semi46L
            // 
            this.chkBx_BateVolta_Semi46L.AutoSize = true;
            this.chkBx_BateVolta_Semi46L.Location = new System.Drawing.Point(45, 110);
            this.chkBx_BateVolta_Semi46L.Name = "chkBx_BateVolta_Semi46L";
            this.chkBx_BateVolta_Semi46L.Size = new System.Drawing.Size(89, 21);
            this.chkBx_BateVolta_Semi46L.TabIndex = 2;
            this.chkBx_BateVolta_Semi46L.Text = "Semi 46L";
            this.chkBx_BateVolta_Semi46L.UseVisualStyleBackColor = true;
            // 
            // chkBx_BateVolta_Exec50L
            // 
            this.chkBx_BateVolta_Exec50L.AutoSize = true;
            this.chkBx_BateVolta_Exec50L.Location = new System.Drawing.Point(45, 150);
            this.chkBx_BateVolta_Exec50L.Name = "chkBx_BateVolta_Exec50L";
            this.chkBx_BateVolta_Exec50L.Size = new System.Drawing.Size(92, 21);
            this.chkBx_BateVolta_Exec50L.TabIndex = 3;
            this.chkBx_BateVolta_Exec50L.Text = "Exec. 50L";
            this.chkBx_BateVolta_Exec50L.UseVisualStyleBackColor = true;
            // 
            // chkBx_BateVolta_Exec46L
            // 
            this.chkBx_BateVolta_Exec46L.AutoSize = true;
            this.chkBx_BateVolta_Exec46L.Location = new System.Drawing.Point(45, 190);
            this.chkBx_BateVolta_Exec46L.Name = "chkBx_BateVolta_Exec46L";
            this.chkBx_BateVolta_Exec46L.Size = new System.Drawing.Size(92, 21);
            this.chkBx_BateVolta_Exec46L.TabIndex = 4;
            this.chkBx_BateVolta_Exec46L.Text = "Exec. 46L";
            this.chkBx_BateVolta_Exec46L.UseVisualStyleBackColor = true;
            // 
            // chkBx_BateVolta_Conv47L
            // 
            this.chkBx_BateVolta_Conv47L.AutoSize = true;
            this.chkBx_BateVolta_Conv47L.Location = new System.Drawing.Point(220, 30);
            this.chkBx_BateVolta_Conv47L.Name = "chkBx_BateVolta_Conv47L";
            this.chkBx_BateVolta_Conv47L.Size = new System.Drawing.Size(94, 21);
            this.chkBx_BateVolta_Conv47L.TabIndex = 5;
            this.chkBx_BateVolta_Conv47L.Text = "Conv. 47L";
            this.chkBx_BateVolta_Conv47L.UseVisualStyleBackColor = true;
            // 
            // chkBx_BateVolta_Micro32L
            // 
            this.chkBx_BateVolta_Micro32L.AutoSize = true;
            this.chkBx_BateVolta_Micro32L.Location = new System.Drawing.Point(220, 70);
            this.chkBx_BateVolta_Micro32L.Name = "chkBx_BateVolta_Micro32L";
            this.chkBx_BateVolta_Micro32L.Size = new System.Drawing.Size(92, 21);
            this.chkBx_BateVolta_Micro32L.TabIndex = 6;
            this.chkBx_BateVolta_Micro32L.Text = "Micro 32L";
            this.chkBx_BateVolta_Micro32L.UseVisualStyleBackColor = true;
            // 
            // chkBx_BateVolta_Van18L
            // 
            this.chkBx_BateVolta_Van18L.AutoSize = true;
            this.chkBx_BateVolta_Van18L.Location = new System.Drawing.Point(220, 110);
            this.chkBx_BateVolta_Van18L.Name = "chkBx_BateVolta_Van18L";
            this.chkBx_BateVolta_Van18L.Size = new System.Drawing.Size(83, 21);
            this.chkBx_BateVolta_Van18L.TabIndex = 7;
            this.chkBx_BateVolta_Van18L.Text = "Van 18L";
            this.chkBx_BateVolta_Van18L.UseVisualStyleBackColor = true;
            // 
            // chkBx_BateVolta_Van15L
            // 
            this.chkBx_BateVolta_Van15L.AutoSize = true;
            this.chkBx_BateVolta_Van15L.Location = new System.Drawing.Point(220, 150);
            this.chkBx_BateVolta_Van15L.Name = "chkBx_BateVolta_Van15L";
            this.chkBx_BateVolta_Van15L.Size = new System.Drawing.Size(83, 21);
            this.chkBx_BateVolta_Van15L.TabIndex = 8;
            this.chkBx_BateVolta_Van15L.Text = "Van 15L";
            this.chkBx_BateVolta_Van15L.UseVisualStyleBackColor = true;
            // 
            // chkBx_BateVolta_Carro
            // 
            this.chkBx_BateVolta_Carro.AutoSize = true;
            this.chkBx_BateVolta_Carro.Location = new System.Drawing.Point(220, 190);
            this.chkBx_BateVolta_Carro.Name = "chkBx_BateVolta_Carro";
            this.chkBx_BateVolta_Carro.Size = new System.Drawing.Size(65, 21);
            this.chkBx_BateVolta_Carro.TabIndex = 9;
            this.chkBx_BateVolta_Carro.Text = "Carro";
            this.chkBx_BateVolta_Carro.UseVisualStyleBackColor = true;
            // 
            // chkBx_FimSem_Carro
            // 
            this.chkBx_FimSem_Carro.AutoSize = true;
            this.chkBx_FimSem_Carro.Location = new System.Drawing.Point(220, 190);
            this.chkBx_FimSem_Carro.Name = "chkBx_FimSem_Carro";
            this.chkBx_FimSem_Carro.Size = new System.Drawing.Size(65, 21);
            this.chkBx_FimSem_Carro.TabIndex = 21;
            this.chkBx_FimSem_Carro.Text = "Carro";
            this.chkBx_FimSem_Carro.UseVisualStyleBackColor = true;
            // 
            // chkBx_FimSem_Van15L
            // 
            this.chkBx_FimSem_Van15L.AutoSize = true;
            this.chkBx_FimSem_Van15L.Location = new System.Drawing.Point(220, 150);
            this.chkBx_FimSem_Van15L.Name = "chkBx_FimSem_Van15L";
            this.chkBx_FimSem_Van15L.Size = new System.Drawing.Size(83, 21);
            this.chkBx_FimSem_Van15L.TabIndex = 20;
            this.chkBx_FimSem_Van15L.Text = "Van 15L";
            this.chkBx_FimSem_Van15L.UseVisualStyleBackColor = true;
            // 
            // chkBx_FimSem_Van18L
            // 
            this.chkBx_FimSem_Van18L.AutoSize = true;
            this.chkBx_FimSem_Van18L.Location = new System.Drawing.Point(220, 110);
            this.chkBx_FimSem_Van18L.Name = "chkBx_FimSem_Van18L";
            this.chkBx_FimSem_Van18L.Size = new System.Drawing.Size(83, 21);
            this.chkBx_FimSem_Van18L.TabIndex = 19;
            this.chkBx_FimSem_Van18L.Text = "Van 18L";
            this.chkBx_FimSem_Van18L.UseVisualStyleBackColor = true;
            // 
            // chkBx_FimSem_Micro32L
            // 
            this.chkBx_FimSem_Micro32L.AutoSize = true;
            this.chkBx_FimSem_Micro32L.Location = new System.Drawing.Point(220, 70);
            this.chkBx_FimSem_Micro32L.Name = "chkBx_FimSem_Micro32L";
            this.chkBx_FimSem_Micro32L.Size = new System.Drawing.Size(92, 21);
            this.chkBx_FimSem_Micro32L.TabIndex = 18;
            this.chkBx_FimSem_Micro32L.Text = "Micro 32L";
            this.chkBx_FimSem_Micro32L.UseVisualStyleBackColor = true;
            // 
            // chkBx_FimSem_Conv47L
            // 
            this.chkBx_FimSem_Conv47L.AutoSize = true;
            this.chkBx_FimSem_Conv47L.Location = new System.Drawing.Point(220, 30);
            this.chkBx_FimSem_Conv47L.Name = "chkBx_FimSem_Conv47L";
            this.chkBx_FimSem_Conv47L.Size = new System.Drawing.Size(94, 21);
            this.chkBx_FimSem_Conv47L.TabIndex = 17;
            this.chkBx_FimSem_Conv47L.Text = "Conv. 47L";
            this.chkBx_FimSem_Conv47L.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "R$";
            // 
            // chkBx_FimSem_Exec46L
            // 
            this.chkBx_FimSem_Exec46L.AutoSize = true;
            this.chkBx_FimSem_Exec46L.Location = new System.Drawing.Point(45, 190);
            this.chkBx_FimSem_Exec46L.Name = "chkBx_FimSem_Exec46L";
            this.chkBx_FimSem_Exec46L.Size = new System.Drawing.Size(92, 21);
            this.chkBx_FimSem_Exec46L.TabIndex = 16;
            this.chkBx_FimSem_Exec46L.Text = "Exec. 46L";
            this.chkBx_FimSem_Exec46L.UseVisualStyleBackColor = true;
            // 
            // txtbx_valorFimSem
            // 
            this.txtbx_valorFimSem.Location = new System.Drawing.Point(92, 267);
            this.txtbx_valorFimSem.Name = "txtbx_valorFimSem";
            this.txtbx_valorFimSem.Size = new System.Drawing.Size(187, 22);
            this.txtbx_valorFimSem.TabIndex = 12;
            // 
            // chkBx_FimSem_Exec50L
            // 
            this.chkBx_FimSem_Exec50L.AutoSize = true;
            this.chkBx_FimSem_Exec50L.Location = new System.Drawing.Point(45, 150);
            this.chkBx_FimSem_Exec50L.Name = "chkBx_FimSem_Exec50L";
            this.chkBx_FimSem_Exec50L.Size = new System.Drawing.Size(92, 21);
            this.chkBx_FimSem_Exec50L.TabIndex = 15;
            this.chkBx_FimSem_Exec50L.Text = "Exec. 50L";
            this.chkBx_FimSem_Exec50L.UseVisualStyleBackColor = true;
            // 
            // chkBx_FimSem_Semi46L
            // 
            this.chkBx_FimSem_Semi46L.AutoSize = true;
            this.chkBx_FimSem_Semi46L.Location = new System.Drawing.Point(45, 110);
            this.chkBx_FimSem_Semi46L.Name = "chkBx_FimSem_Semi46L";
            this.chkBx_FimSem_Semi46L.Size = new System.Drawing.Size(89, 21);
            this.chkBx_FimSem_Semi46L.TabIndex = 13;
            this.chkBx_FimSem_Semi46L.Text = "Semi 46L";
            this.chkBx_FimSem_Semi46L.UseVisualStyleBackColor = true;
            // 
            // chkBx_FimSem_DD60L
            // 
            this.chkBx_FimSem_DD60L.AutoSize = true;
            this.chkBx_FimSem_DD60L.Location = new System.Drawing.Point(45, 70);
            this.chkBx_FimSem_DD60L.Name = "chkBx_FimSem_DD60L";
            this.chkBx_FimSem_DD60L.Size = new System.Drawing.Size(78, 21);
            this.chkBx_FimSem_DD60L.TabIndex = 11;
            this.chkBx_FimSem_DD60L.Text = "DD 60L";
            this.chkBx_FimSem_DD60L.UseVisualStyleBackColor = true;
            // 
            // chkBx_FimSem_DD64L
            // 
            this.chkBx_FimSem_DD64L.AutoSize = true;
            this.chkBx_FimSem_DD64L.Location = new System.Drawing.Point(45, 30);
            this.chkBx_FimSem_DD64L.Name = "chkBx_FimSem_DD64L";
            this.chkBx_FimSem_DD64L.Size = new System.Drawing.Size(78, 21);
            this.chkBx_FimSem_DD64L.TabIndex = 10;
            this.chkBx_FimSem_DD64L.Text = "DD 64L";
            this.chkBx_FimSem_DD64L.UseVisualStyleBackColor = true;
            // 
            // chkBx_FerPro_Carro
            // 
            this.chkBx_FerPro_Carro.AutoSize = true;
            this.chkBx_FerPro_Carro.Location = new System.Drawing.Point(220, 190);
            this.chkBx_FerPro_Carro.Name = "chkBx_FerPro_Carro";
            this.chkBx_FerPro_Carro.Size = new System.Drawing.Size(65, 21);
            this.chkBx_FerPro_Carro.TabIndex = 21;
            this.chkBx_FerPro_Carro.Text = "Carro";
            this.chkBx_FerPro_Carro.UseVisualStyleBackColor = true;
            // 
            // chkBx_FerPro_Van15L
            // 
            this.chkBx_FerPro_Van15L.AutoSize = true;
            this.chkBx_FerPro_Van15L.Location = new System.Drawing.Point(220, 150);
            this.chkBx_FerPro_Van15L.Name = "chkBx_FerPro_Van15L";
            this.chkBx_FerPro_Van15L.Size = new System.Drawing.Size(83, 21);
            this.chkBx_FerPro_Van15L.TabIndex = 20;
            this.chkBx_FerPro_Van15L.Text = "Van 15L";
            this.chkBx_FerPro_Van15L.UseVisualStyleBackColor = true;
            // 
            // chkBx_FerPro_Van18L
            // 
            this.chkBx_FerPro_Van18L.AutoSize = true;
            this.chkBx_FerPro_Van18L.Location = new System.Drawing.Point(220, 110);
            this.chkBx_FerPro_Van18L.Name = "chkBx_FerPro_Van18L";
            this.chkBx_FerPro_Van18L.Size = new System.Drawing.Size(83, 21);
            this.chkBx_FerPro_Van18L.TabIndex = 19;
            this.chkBx_FerPro_Van18L.Text = "Van 18L";
            this.chkBx_FerPro_Van18L.UseVisualStyleBackColor = true;
            // 
            // chkBx_FerPro_Micro32L
            // 
            this.chkBx_FerPro_Micro32L.AutoSize = true;
            this.chkBx_FerPro_Micro32L.Location = new System.Drawing.Point(220, 70);
            this.chkBx_FerPro_Micro32L.Name = "chkBx_FerPro_Micro32L";
            this.chkBx_FerPro_Micro32L.Size = new System.Drawing.Size(92, 21);
            this.chkBx_FerPro_Micro32L.TabIndex = 18;
            this.chkBx_FerPro_Micro32L.Text = "Micro 32L";
            this.chkBx_FerPro_Micro32L.UseVisualStyleBackColor = true;
            // 
            // chkBx_FerPro_Conv47L
            // 
            this.chkBx_FerPro_Conv47L.AutoSize = true;
            this.chkBx_FerPro_Conv47L.Location = new System.Drawing.Point(220, 30);
            this.chkBx_FerPro_Conv47L.Name = "chkBx_FerPro_Conv47L";
            this.chkBx_FerPro_Conv47L.Size = new System.Drawing.Size(94, 21);
            this.chkBx_FerPro_Conv47L.TabIndex = 17;
            this.chkBx_FerPro_Conv47L.Text = "Conv. 47L";
            this.chkBx_FerPro_Conv47L.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "R$";
            // 
            // chkBx_FerPro_Exec46L
            // 
            this.chkBx_FerPro_Exec46L.AutoSize = true;
            this.chkBx_FerPro_Exec46L.Location = new System.Drawing.Point(45, 190);
            this.chkBx_FerPro_Exec46L.Name = "chkBx_FerPro_Exec46L";
            this.chkBx_FerPro_Exec46L.Size = new System.Drawing.Size(92, 21);
            this.chkBx_FerPro_Exec46L.TabIndex = 16;
            this.chkBx_FerPro_Exec46L.Text = "Exec. 46L";
            this.chkBx_FerPro_Exec46L.UseVisualStyleBackColor = true;
            // 
            // txtbx_valorFerPro
            // 
            this.txtbx_valorFerPro.Location = new System.Drawing.Point(92, 267);
            this.txtbx_valorFerPro.Name = "txtbx_valorFerPro";
            this.txtbx_valorFerPro.Size = new System.Drawing.Size(187, 22);
            this.txtbx_valorFerPro.TabIndex = 12;
            // 
            // chkBx_FerPro_Exec50L
            // 
            this.chkBx_FerPro_Exec50L.AutoSize = true;
            this.chkBx_FerPro_Exec50L.Location = new System.Drawing.Point(45, 150);
            this.chkBx_FerPro_Exec50L.Name = "chkBx_FerPro_Exec50L";
            this.chkBx_FerPro_Exec50L.Size = new System.Drawing.Size(92, 21);
            this.chkBx_FerPro_Exec50L.TabIndex = 15;
            this.chkBx_FerPro_Exec50L.Text = "Exec. 50L";
            this.chkBx_FerPro_Exec50L.UseVisualStyleBackColor = true;
            // 
            // chkBx_FerPro_Semi46L
            // 
            this.chkBx_FerPro_Semi46L.AutoSize = true;
            this.chkBx_FerPro_Semi46L.Location = new System.Drawing.Point(45, 110);
            this.chkBx_FerPro_Semi46L.Name = "chkBx_FerPro_Semi46L";
            this.chkBx_FerPro_Semi46L.Size = new System.Drawing.Size(89, 21);
            this.chkBx_FerPro_Semi46L.TabIndex = 13;
            this.chkBx_FerPro_Semi46L.Text = "Semi 46L";
            this.chkBx_FerPro_Semi46L.UseVisualStyleBackColor = true;
            // 
            // chkBx_FerPro_DD60L
            // 
            this.chkBx_FerPro_DD60L.AutoSize = true;
            this.chkBx_FerPro_DD60L.Location = new System.Drawing.Point(45, 70);
            this.chkBx_FerPro_DD60L.Name = "chkBx_FerPro_DD60L";
            this.chkBx_FerPro_DD60L.Size = new System.Drawing.Size(78, 21);
            this.chkBx_FerPro_DD60L.TabIndex = 11;
            this.chkBx_FerPro_DD60L.Text = "DD 60L";
            this.chkBx_FerPro_DD60L.UseVisualStyleBackColor = true;
            // 
            // chkBx_FerPro_DD64L
            // 
            this.chkBx_FerPro_DD64L.AutoSize = true;
            this.chkBx_FerPro_DD64L.Location = new System.Drawing.Point(45, 30);
            this.chkBx_FerPro_DD64L.Name = "chkBx_FerPro_DD64L";
            this.chkBx_FerPro_DD64L.Size = new System.Drawing.Size(78, 21);
            this.chkBx_FerPro_DD64L.TabIndex = 10;
            this.chkBx_FerPro_DD64L.Text = "DD 64L";
            this.chkBx_FerPro_DD64L.UseVisualStyleBackColor = true;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batevolta_dd64LBindingSource, "valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(577, 149);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(154, 22);
            this.valorTextBox.TabIndex = 5;
            this.valorTextBox.TextChanged += new System.EventHandler(this.valorTextBox_TextChanged);
            // 
            // frm_consultaValor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 555);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_consultaValor";
            this.Text = "frm_consultaValor";
            this.Load += new System.EventHandler(this.frm_consultaValor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glturfreDeployDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batevolta_dd64LBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batevolta_dd60LBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_BateVolta.ResumeLayout(false);
            this.tabPage_BateVolta.PerformLayout();
            this.tabPage_FimSemana.ResumeLayout(false);
            this.tabPage_FimSemana.PerformLayout();
            this.tabPage_FeriadoProlongado.ResumeLayout(false);
            this.tabPage_FeriadoProlongado.PerformLayout();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtbx_valorBateVolta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_BateVolta;
        private System.Windows.Forms.CheckBox chkBx_BateVolta_Carro;
        private System.Windows.Forms.CheckBox chkBx_BateVolta_Van15L;
        private System.Windows.Forms.CheckBox chkBx_BateVolta_Van18L;
        private System.Windows.Forms.CheckBox chkBx_BateVolta_Micro32L;
        private System.Windows.Forms.CheckBox chkBx_BateVolta_Conv47L;
        private System.Windows.Forms.CheckBox chkBx_BateVolta_Exec46L;
        private System.Windows.Forms.CheckBox chkBx_BateVolta_Exec50L;
        private System.Windows.Forms.CheckBox chkBx_BateVolta_Semi46L;
        private System.Windows.Forms.CheckBox chkBx_BateVolta_DD60L;
        private System.Windows.Forms.CheckBox chkBx_BateVolta_DD64L;
        private System.Windows.Forms.TabPage tabPage_FimSemana;
        private System.Windows.Forms.TabPage tabPage_FeriadoProlongado;
        private System.Windows.Forms.CheckBox chkBx_FimSem_Carro;
        private System.Windows.Forms.CheckBox chkBx_FimSem_Van15L;
        private System.Windows.Forms.CheckBox chkBx_FimSem_Van18L;
        private System.Windows.Forms.CheckBox chkBx_FimSem_Micro32L;
        private System.Windows.Forms.CheckBox chkBx_FimSem_Conv47L;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkBx_FimSem_Exec46L;
        private System.Windows.Forms.TextBox txtbx_valorFimSem;
        private System.Windows.Forms.CheckBox chkBx_FimSem_Exec50L;
        private System.Windows.Forms.CheckBox chkBx_FimSem_Semi46L;
        private System.Windows.Forms.CheckBox chkBx_FimSem_DD60L;
        private System.Windows.Forms.CheckBox chkBx_FimSem_DD64L;
        private System.Windows.Forms.CheckBox chkBx_FerPro_Carro;
        private System.Windows.Forms.CheckBox chkBx_FerPro_Van15L;
        private System.Windows.Forms.CheckBox chkBx_FerPro_Van18L;
        private System.Windows.Forms.CheckBox chkBx_FerPro_Micro32L;
        private System.Windows.Forms.CheckBox chkBx_FerPro_Conv47L;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkBx_FerPro_Exec46L;
        private System.Windows.Forms.TextBox txtbx_valorFerPro;
        private System.Windows.Forms.CheckBox chkBx_FerPro_Exec50L;
        private System.Windows.Forms.CheckBox chkBx_FerPro_Semi46L;
        private System.Windows.Forms.CheckBox chkBx_FerPro_DD60L;
        private System.Windows.Forms.CheckBox chkBx_FerPro_DD64L;
        private System.Windows.Forms.TextBox valorTextBox;
    }
}