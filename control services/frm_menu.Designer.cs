namespace control_services
{
    partial class frm_menu
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
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarValorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bateVoltaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.feriadoProlongadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fimDeSemanaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarValorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bateVoltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feriadoProlongadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fimDeSemanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orcamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valorForaDaTabelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EscalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.whatsAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.orcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glturfreDeployDataSet = new control_services.gldturfreDeployDataSet();
            this.orcamentoTableAdapter = new control_services.gldturfreDeployDataSetTableAdapters.orcamentoTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glturfreDeployDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1528, 741);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1528, 162);
            this.panel2.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 115);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cadastrar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 115);
            this.button2.TabIndex = 8;
            this.button2.Text = "Orcamento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(504, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 115);
            this.button3.TabIndex = 9;
            this.button3.Text = "Contrato";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1242, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 115);
            this.button4.TabIndex = 12;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(750, 23);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(240, 115);
            this.button6.TabIndex = 10;
            this.button6.Text = "Calendario";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(996, 23);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(240, 115);
            this.button5.TabIndex = 11;
            this.button5.Text = "Agendamento";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.valorToolStripMenuItem,
            this.orcamentoToolStripMenuItem,
            this.EscalarToolStripMenuItem,
            this.agendaToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.toolStripMenuItem1,
            this.whatsAppToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1528, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionarioToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.veiculoToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.cadastroToolStripMenuItem.Text = "Cadastrar";
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Enabled = false;
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.funcionarioToolStripMenuItem.Text = "Funcionario";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click_1);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // veiculoToolStripMenuItem
            // 
            this.veiculoToolStripMenuItem.Name = "veiculoToolStripMenuItem";
            this.veiculoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.veiculoToolStripMenuItem.Text = "Veiculo";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionarioToolStripMenuItem1,
            this.clienteToolStripMenuItem1,
            this.veiculoToolStripMenuItem1,
            this.loginToolStripMenuItem1});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // funcionarioToolStripMenuItem1
            // 
            this.funcionarioToolStripMenuItem1.Name = "funcionarioToolStripMenuItem1";
            this.funcionarioToolStripMenuItem1.Size = new System.Drawing.Size(161, 26);
            this.funcionarioToolStripMenuItem1.Text = "Funcionario";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(161, 26);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // veiculoToolStripMenuItem1
            // 
            this.veiculoToolStripMenuItem1.Name = "veiculoToolStripMenuItem1";
            this.veiculoToolStripMenuItem1.Size = new System.Drawing.Size(161, 26);
            this.veiculoToolStripMenuItem1.Text = "Veiculo";
            // 
            // loginToolStripMenuItem1
            // 
            this.loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            this.loginToolStripMenuItem1.Size = new System.Drawing.Size(161, 26);
            this.loginToolStripMenuItem1.Text = "Login";
            this.loginToolStripMenuItem1.Click += new System.EventHandler(this.loginToolStripMenuItem1_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharVendasToolStripMenuItem,
            this.consultarVendasToolStripMenuItem});
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.vendaToolStripMenuItem.Text = "Venda";
            // 
            // fecharVendasToolStripMenuItem
            // 
            this.fecharVendasToolStripMenuItem.Name = "fecharVendasToolStripMenuItem";
            this.fecharVendasToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.fecharVendasToolStripMenuItem.Text = "Fechar Vendas";
            this.fecharVendasToolStripMenuItem.Click += new System.EventHandler(this.fecharVendasToolStripMenuItem_Click);
            // 
            // consultarVendasToolStripMenuItem
            // 
            this.consultarVendasToolStripMenuItem.Name = "consultarVendasToolStripMenuItem";
            this.consultarVendasToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.consultarVendasToolStripMenuItem.Text = "Consultar Vendas";
            // 
            // valorToolStripMenuItem
            // 
            this.valorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizarValorToolStripMenuItem,
            this.consultarValorToolStripMenuItem});
            this.valorToolStripMenuItem.Name = "valorToolStripMenuItem";
            this.valorToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.valorToolStripMenuItem.Text = "Valor";
            // 
            // atualizarValorToolStripMenuItem
            // 
            this.atualizarValorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bateVoltaToolStripMenuItem1,
            this.feriadoProlongadoToolStripMenuItem1,
            this.fimDeSemanaToolStripMenuItem1});
            this.atualizarValorToolStripMenuItem.Name = "atualizarValorToolStripMenuItem";
            this.atualizarValorToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.atualizarValorToolStripMenuItem.Text = "Atualizar Valor";
            // 
            // bateVoltaToolStripMenuItem1
            // 
            this.bateVoltaToolStripMenuItem1.Name = "bateVoltaToolStripMenuItem1";
            this.bateVoltaToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.bateVoltaToolStripMenuItem1.Text = "Bate / Volta";
            // 
            // feriadoProlongadoToolStripMenuItem1
            // 
            this.feriadoProlongadoToolStripMenuItem1.Name = "feriadoProlongadoToolStripMenuItem1";
            this.feriadoProlongadoToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.feriadoProlongadoToolStripMenuItem1.Text = "Feriado Prolongado";
            // 
            // fimDeSemanaToolStripMenuItem1
            // 
            this.fimDeSemanaToolStripMenuItem1.Name = "fimDeSemanaToolStripMenuItem1";
            this.fimDeSemanaToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.fimDeSemanaToolStripMenuItem1.Text = "Fim de Semana";
            // 
            // consultarValorToolStripMenuItem
            // 
            this.consultarValorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bateVoltaToolStripMenuItem,
            this.feriadoProlongadoToolStripMenuItem,
            this.fimDeSemanaToolStripMenuItem});
            this.consultarValorToolStripMenuItem.Name = "consultarValorToolStripMenuItem";
            this.consultarValorToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.consultarValorToolStripMenuItem.Text = "Consultar Valor";
            // 
            // bateVoltaToolStripMenuItem
            // 
            this.bateVoltaToolStripMenuItem.Name = "bateVoltaToolStripMenuItem";
            this.bateVoltaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.bateVoltaToolStripMenuItem.Text = "Bate / Volta";
            this.bateVoltaToolStripMenuItem.Click += new System.EventHandler(this.bateVoltaToolStripMenuItem_Click);
            // 
            // feriadoProlongadoToolStripMenuItem
            // 
            this.feriadoProlongadoToolStripMenuItem.Name = "feriadoProlongadoToolStripMenuItem";
            this.feriadoProlongadoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.feriadoProlongadoToolStripMenuItem.Text = "Feriado Prolongado";
            this.feriadoProlongadoToolStripMenuItem.Click += new System.EventHandler(this.feriadoProlongadoToolStripMenuItem_Click);
            // 
            // fimDeSemanaToolStripMenuItem
            // 
            this.fimDeSemanaToolStripMenuItem.Name = "fimDeSemanaToolStripMenuItem";
            this.fimDeSemanaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.fimDeSemanaToolStripMenuItem.Text = "Fim de Semana";
            this.fimDeSemanaToolStripMenuItem.Click += new System.EventHandler(this.fimDeSemanaToolStripMenuItem_Click);
            // 
            // orcamentoToolStripMenuItem
            // 
            this.orcamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.valorForaDaTabelaToolStripMenuItem});
            this.orcamentoToolStripMenuItem.Name = "orcamentoToolStripMenuItem";
            this.orcamentoToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.orcamentoToolStripMenuItem.Text = "Orcamento";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.novoToolStripMenuItem.Text = "Valor Tabela";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // valorForaDaTabelaToolStripMenuItem
            // 
            this.valorForaDaTabelaToolStripMenuItem.Name = "valorForaDaTabelaToolStripMenuItem";
            this.valorForaDaTabelaToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.valorForaDaTabelaToolStripMenuItem.Text = "Valor Fora da Tabela";
            this.valorForaDaTabelaToolStripMenuItem.Click += new System.EventHandler(this.valorForaDaTabelaToolStripMenuItem_Click);
            // 
            // EscalarToolStripMenuItem
            // 
            this.EscalarToolStripMenuItem.Name = "EscalarToolStripMenuItem";
            this.EscalarToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.EscalarToolStripMenuItem.Text = "Escalar";
            this.EscalarToolStripMenuItem.Click += new System.EventHandler(this.agendamentoToolStripMenuItem_Click);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.agendaToolStripMenuItem.Text = "Calendario";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.agendaToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatoriosToolStripMenuItem,
            this.pagamentosToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // pagamentosToolStripMenuItem
            // 
            this.pagamentosToolStripMenuItem.Name = "pagamentosToolStripMenuItem";
            this.pagamentosToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.pagamentosToolStripMenuItem.Text = "Pagamentos";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Image = global::control_services.Properties.Resources.menu_hamburguer;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 24);
            this.toolStripMenuItem1.Text = ".";
            // 
            // whatsAppToolStripMenuItem
            // 
            this.whatsAppToolStripMenuItem.Name = "whatsAppToolStripMenuItem";
            this.whatsAppToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.whatsAppToolStripMenuItem.Text = "WhatsApp";
            this.whatsAppToolStripMenuItem.Click += new System.EventHandler(this.whatsAppToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 716);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1528, 25);
            this.statusStrip1.TabIndex = 47;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(344, 20);
            this.toolStripStatusLabel2.Text = "Precisa de ajuda? Clique aqui e fale com o suporte";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // orcamentoBindingSource
            // 
            this.orcamentoBindingSource.DataMember = "orcamento";
            this.orcamentoBindingSource.DataSource = this.glturfreDeployDataSet;
            // 
            // glturfreDeployDataSet
            // 
            this.glturfreDeployDataSet.DataSetName = "glturfreDeployDataSet";
            this.glturfreDeployDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orcamentoTableAdapter
            // 
            this.orcamentoTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 741);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Service";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glturfreDeployDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orcamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EscalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem valorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarValorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarValorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private gldturfreDeployDataSet glturfreDeployDataSet;
        private System.Windows.Forms.BindingSource orcamentoBindingSource;
        private gldturfreDeployDataSetTableAdapters.orcamentoTableAdapter orcamentoTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem valorForaDaTabelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bateVoltaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem feriadoProlongadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fimDeSemanaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bateVoltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feriadoProlongadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fimDeSemanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem veiculoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarVendasToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem whatsAppToolStripMenuItem;
    }
}