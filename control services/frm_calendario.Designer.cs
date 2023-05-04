namespace control_services
{
    partial class frm_calendario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idorcamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfcnpjclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valortotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorpagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motoristaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapartidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horapartidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataretornoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.embarque_um = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.embarque_dois = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.embarquetresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.embarquequatroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.embarquecincoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viagemfechadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gldturfreDeployDataSet = new control_services.gldturfreDeployDataSet();
            this.viagem_fechadaTableAdapter = new control_services.gldturfreDeployDataSetTableAdapters.viagem_fechadaTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viagemfechadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gldturfreDeployDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(290, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 590);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idorcamentoDataGridViewTextBoxColumn,
            this.nomeclienteDataGridViewTextBoxColumn,
            this.cpfcnpjclienteDataGridViewTextBoxColumn,
            this.telclienteDataGridViewTextBoxColumn,
            this.valortotalDataGridViewTextBoxColumn,
            this.valorpagoDataGridViewTextBoxColumn,
            this.motoristaDataGridViewTextBoxColumn,
            this.partidaDataGridViewTextBoxColumn,
            this.datapartidaDataGridViewTextBoxColumn,
            this.horapartidaDataGridViewTextBoxColumn,
            this.destinoDataGridViewTextBoxColumn,
            this.dataretornoDataGridViewTextBoxColumn,
            this.veiculoDataGridViewTextBoxColumn,
            this.embarque_um,
            this.embarque_dois,
            this.embarquetresDataGridViewTextBoxColumn,
            this.embarquequatroDataGridViewTextBoxColumn,
            this.embarquecincoDataGridViewTextBoxColumn,
            this.obsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viagemfechadaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 590);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idorcamentoDataGridViewTextBoxColumn
            // 
            this.idorcamentoDataGridViewTextBoxColumn.DataPropertyName = "id_orcamento";
            this.idorcamentoDataGridViewTextBoxColumn.HeaderText = "id_orcamento";
            this.idorcamentoDataGridViewTextBoxColumn.Name = "idorcamentoDataGridViewTextBoxColumn";
            this.idorcamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeclienteDataGridViewTextBoxColumn
            // 
            this.nomeclienteDataGridViewTextBoxColumn.DataPropertyName = "nome_cliente";
            this.nomeclienteDataGridViewTextBoxColumn.HeaderText = "nome_cliente";
            this.nomeclienteDataGridViewTextBoxColumn.Name = "nomeclienteDataGridViewTextBoxColumn";
            this.nomeclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfcnpjclienteDataGridViewTextBoxColumn
            // 
            this.cpfcnpjclienteDataGridViewTextBoxColumn.DataPropertyName = "cpf_cnpj_cliente";
            this.cpfcnpjclienteDataGridViewTextBoxColumn.HeaderText = "cpf_cnpj_cliente";
            this.cpfcnpjclienteDataGridViewTextBoxColumn.Name = "cpfcnpjclienteDataGridViewTextBoxColumn";
            this.cpfcnpjclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telclienteDataGridViewTextBoxColumn
            // 
            this.telclienteDataGridViewTextBoxColumn.DataPropertyName = "tel_cliente";
            this.telclienteDataGridViewTextBoxColumn.HeaderText = "tel_cliente";
            this.telclienteDataGridViewTextBoxColumn.Name = "telclienteDataGridViewTextBoxColumn";
            this.telclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valortotalDataGridViewTextBoxColumn
            // 
            this.valortotalDataGridViewTextBoxColumn.DataPropertyName = "valor_total";
            this.valortotalDataGridViewTextBoxColumn.HeaderText = "valor_total";
            this.valortotalDataGridViewTextBoxColumn.Name = "valortotalDataGridViewTextBoxColumn";
            this.valortotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorpagoDataGridViewTextBoxColumn
            // 
            this.valorpagoDataGridViewTextBoxColumn.DataPropertyName = "valor_pago";
            this.valorpagoDataGridViewTextBoxColumn.HeaderText = "valor_pago";
            this.valorpagoDataGridViewTextBoxColumn.Name = "valorpagoDataGridViewTextBoxColumn";
            this.valorpagoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // motoristaDataGridViewTextBoxColumn
            // 
            this.motoristaDataGridViewTextBoxColumn.DataPropertyName = "motorista";
            this.motoristaDataGridViewTextBoxColumn.HeaderText = "motorista";
            this.motoristaDataGridViewTextBoxColumn.Name = "motoristaDataGridViewTextBoxColumn";
            this.motoristaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partidaDataGridViewTextBoxColumn
            // 
            this.partidaDataGridViewTextBoxColumn.DataPropertyName = "partida";
            this.partidaDataGridViewTextBoxColumn.HeaderText = "partida";
            this.partidaDataGridViewTextBoxColumn.Name = "partidaDataGridViewTextBoxColumn";
            this.partidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datapartidaDataGridViewTextBoxColumn
            // 
            this.datapartidaDataGridViewTextBoxColumn.DataPropertyName = "data_partida";
            this.datapartidaDataGridViewTextBoxColumn.HeaderText = "data_partida";
            this.datapartidaDataGridViewTextBoxColumn.Name = "datapartidaDataGridViewTextBoxColumn";
            this.datapartidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horapartidaDataGridViewTextBoxColumn
            // 
            this.horapartidaDataGridViewTextBoxColumn.DataPropertyName = "hora_partida";
            this.horapartidaDataGridViewTextBoxColumn.HeaderText = "hora_partida";
            this.horapartidaDataGridViewTextBoxColumn.Name = "horapartidaDataGridViewTextBoxColumn";
            this.horapartidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinoDataGridViewTextBoxColumn
            // 
            this.destinoDataGridViewTextBoxColumn.DataPropertyName = "destino";
            this.destinoDataGridViewTextBoxColumn.HeaderText = "destino";
            this.destinoDataGridViewTextBoxColumn.Name = "destinoDataGridViewTextBoxColumn";
            this.destinoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataretornoDataGridViewTextBoxColumn
            // 
            this.dataretornoDataGridViewTextBoxColumn.DataPropertyName = "data_retorno";
            this.dataretornoDataGridViewTextBoxColumn.HeaderText = "data_retorno";
            this.dataretornoDataGridViewTextBoxColumn.Name = "dataretornoDataGridViewTextBoxColumn";
            this.dataretornoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // veiculoDataGridViewTextBoxColumn
            // 
            this.veiculoDataGridViewTextBoxColumn.DataPropertyName = "veiculo";
            this.veiculoDataGridViewTextBoxColumn.HeaderText = "veiculo";
            this.veiculoDataGridViewTextBoxColumn.Name = "veiculoDataGridViewTextBoxColumn";
            this.veiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // embarque_um
            // 
            this.embarque_um.DataPropertyName = "embarque_um";
            this.embarque_um.HeaderText = "embarque_um";
            this.embarque_um.Name = "embarque_um";
            this.embarque_um.ReadOnly = true;
            // 
            // embarque_dois
            // 
            this.embarque_dois.DataPropertyName = "embarque_dois";
            this.embarque_dois.HeaderText = "embarque_dois";
            this.embarque_dois.Name = "embarque_dois";
            this.embarque_dois.ReadOnly = true;
            // 
            // embarquetresDataGridViewTextBoxColumn
            // 
            this.embarquetresDataGridViewTextBoxColumn.DataPropertyName = "embarque_tres";
            this.embarquetresDataGridViewTextBoxColumn.HeaderText = "embarque_tres";
            this.embarquetresDataGridViewTextBoxColumn.Name = "embarquetresDataGridViewTextBoxColumn";
            this.embarquetresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // embarquequatroDataGridViewTextBoxColumn
            // 
            this.embarquequatroDataGridViewTextBoxColumn.DataPropertyName = "embarque_quatro";
            this.embarquequatroDataGridViewTextBoxColumn.HeaderText = "embarque_quatro";
            this.embarquequatroDataGridViewTextBoxColumn.Name = "embarquequatroDataGridViewTextBoxColumn";
            this.embarquequatroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // embarquecincoDataGridViewTextBoxColumn
            // 
            this.embarquecincoDataGridViewTextBoxColumn.DataPropertyName = "embarque_cinco";
            this.embarquecincoDataGridViewTextBoxColumn.HeaderText = "embarque_cinco";
            this.embarquecincoDataGridViewTextBoxColumn.Name = "embarquecincoDataGridViewTextBoxColumn";
            this.embarquecincoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obsDataGridViewTextBoxColumn
            // 
            this.obsDataGridViewTextBoxColumn.DataPropertyName = "obs";
            this.obsDataGridViewTextBoxColumn.HeaderText = "obs";
            this.obsDataGridViewTextBoxColumn.Name = "obsDataGridViewTextBoxColumn";
            this.obsDataGridViewTextBoxColumn.ReadOnly = true;
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
            // viagem_fechadaTableAdapter
            // 
            this.viagem_fechadaTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 590);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoria:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 332);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // frm_calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 590);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_calendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendario";
            this.Load += new System.EventHandler(this.frm_calendario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viagemfechadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gldturfreDeployDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private gldturfreDeployDataSet gldturfreDeployDataSet;
        private System.Windows.Forms.BindingSource viagemfechadaBindingSource;
        private gldturfreDeployDataSetTableAdapters.viagem_fechadaTableAdapter viagem_fechadaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorcamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfcnpjclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valortotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorpagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motoristaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datapartidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horapartidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataretornoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn embarque_um;
        private System.Windows.Forms.DataGridViewTextBoxColumn embarque_dois;
        private System.Windows.Forms.DataGridViewTextBoxColumn embarquetresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn embarquequatroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn embarquecincoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}