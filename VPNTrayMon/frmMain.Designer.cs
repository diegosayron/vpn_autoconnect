
namespace VPNTrayMon
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPg1 = new System.Windows.Forms.TabPage();
            this.btnVPNControl = new System.Windows.Forms.Button();
            this.lblStatusVPN = new System.Windows.Forms.Label();
            this.lblDataHoraUltimoStatus = new System.Windows.Forms.Label();
            this.picStatus = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbPg2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNomeOuIP = new System.Windows.Forms.TextBox();
            this.chkReconectarVPN = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtQtdPingsADisparar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstViewVPN = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtQtdPingsQuedaConexao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIntervaloMon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeConexaoVPN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.abrirInterfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pausarMonitoramentoDaVPNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encerrarAAplicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SobretoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.err1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.tmrMonitor = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tbPg1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tbPg2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPg1);
            this.tabControl1.Controls.Add(this.tbPg2);
            this.tabControl1.Location = new System.Drawing.Point(6, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 464);
            this.tabControl1.TabIndex = 23;
            // 
            // tbPg1
            // 
            this.tbPg1.Controls.Add(this.btnVPNControl);
            this.tbPg1.Controls.Add(this.lblStatusVPN);
            this.tbPg1.Controls.Add(this.lblDataHoraUltimoStatus);
            this.tbPg1.Controls.Add(this.picStatus);
            this.tbPg1.Controls.Add(this.label7);
            this.tbPg1.Controls.Add(this.pictureBox2);
            this.tbPg1.Location = new System.Drawing.Point(4, 22);
            this.tbPg1.Name = "tbPg1";
            this.tbPg1.Padding = new System.Windows.Forms.Padding(3);
            this.tbPg1.Size = new System.Drawing.Size(615, 438);
            this.tbPg1.TabIndex = 0;
            this.tbPg1.Text = "Geral";
            this.tbPg1.UseVisualStyleBackColor = true;
            // 
            // btnVPNControl
            // 
            this.btnVPNControl.Location = new System.Drawing.Point(192, 281);
            this.btnVPNControl.Name = "btnVPNControl";
            this.btnVPNControl.Size = new System.Drawing.Size(238, 44);
            this.btnVPNControl.TabIndex = 41;
            this.btnVPNControl.Text = "Forçar Desconexão";
            this.btnVPNControl.UseVisualStyleBackColor = true;
            this.btnVPNControl.Click += new System.EventHandler(this.btnVPNControl_Click);
            // 
            // lblStatusVPN
            // 
            this.lblStatusVPN.Location = new System.Drawing.Point(6, 375);
            this.lblStatusVPN.Name = "lblStatusVPN";
            this.lblStatusVPN.Size = new System.Drawing.Size(359, 22);
            this.lblStatusVPN.TabIndex = 39;
            // 
            // lblDataHoraUltimoStatus
            // 
            this.lblDataHoraUltimoStatus.Location = new System.Drawing.Point(6, 397);
            this.lblDataHoraUltimoStatus.Name = "lblDataHoraUltimoStatus";
            this.lblDataHoraUltimoStatus.Size = new System.Drawing.Size(356, 20);
            this.lblDataHoraUltimoStatus.TabIndex = 38;
            // 
            // picStatus
            // 
            this.picStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStatus.Image = global::VPNTrayMon.Properties.Resources.Desconhecido;
            this.picStatus.Location = new System.Drawing.Point(0, 65);
            this.picStatus.Name = "picStatus";
            this.picStatus.Size = new System.Drawing.Size(612, 198);
            this.picStatus.TabIndex = 40;
            this.picStatus.TabStop = false;
            this.picStatus.Tag = "Desconectado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "Status da Conexão";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(619, 59);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // tbPg2
            // 
            this.tbPg2.Controls.Add(this.label8);
            this.tbPg2.Controls.Add(this.txtNomeOuIP);
            this.tbPg2.Controls.Add(this.chkReconectarVPN);
            this.tbPg2.Controls.Add(this.btnRefresh);
            this.tbPg2.Controls.Add(this.btnSalvar);
            this.tbPg2.Controls.Add(this.txtQtdPingsADisparar);
            this.tbPg2.Controls.Add(this.label6);
            this.tbPg2.Controls.Add(this.lstViewVPN);
            this.tbPg2.Controls.Add(this.txtQtdPingsQuedaConexao);
            this.tbPg2.Controls.Add(this.label1);
            this.tbPg2.Controls.Add(this.label5);
            this.tbPg2.Controls.Add(this.label3);
            this.tbPg2.Controls.Add(this.txtIntervaloMon);
            this.tbPg2.Controls.Add(this.label4);
            this.tbPg2.Controls.Add(this.txtNomeConexaoVPN);
            this.tbPg2.Controls.Add(this.label2);
            this.tbPg2.Controls.Add(this.pictureBox1);
            this.tbPg2.Location = new System.Drawing.Point(4, 22);
            this.tbPg2.Name = "tbPg2";
            this.tbPg2.Padding = new System.Windows.Forms.Padding(3);
            this.tbPg2.Size = new System.Drawing.Size(615, 438);
            this.tbPg2.TabIndex = 1;
            this.tbPg2.Text = "Configurações";
            this.tbPg2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(235, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 17);
            this.label8.TabIndex = 67;
            this.label8.Text = "Nome ou Endereço IP do Servidor VPN";
            // 
            // txtNomeOuIP
            // 
            this.err1.SetError(this.txtNomeOuIP, "Digite o Nome ou o IP do Servidor da VPN armazenada");
            this.txtNomeOuIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNomeOuIP.Location = new System.Drawing.Point(238, 125);
            this.txtNomeOuIP.MaxLength = 25;
            this.txtNomeOuIP.Name = "txtNomeOuIP";
            this.txtNomeOuIP.Size = new System.Drawing.Size(344, 23);
            this.txtNomeOuIP.TabIndex = 66;
            // 
            // chkReconectarVPN
            // 
            this.chkReconectarVPN.AutoSize = true;
            this.chkReconectarVPN.Checked = true;
            this.chkReconectarVPN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReconectarVPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkReconectarVPN.Location = new System.Drawing.Point(238, 373);
            this.chkReconectarVPN.Name = "chkReconectarVPN";
            this.chkReconectarVPN.Size = new System.Drawing.Size(302, 21);
            this.chkReconectarVPN.TabIndex = 65;
            this.chkReconectarVPN.Text = "Reconectar se a VPN estiver desconectada";
            this.chkReconectarVPN.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::VPNTrayMon.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(188, 78);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(26, 24);
            this.btnRefresh.TabIndex = 64;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(494, 404);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 28);
            this.btnSalvar.TabIndex = 57;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtQtdPingsADisparar
            // 
            this.err1.SetError(this.txtQtdPingsADisparar, "Informe quantos pings serão disparados no teste. Entre 2 e 10");
            this.txtQtdPingsADisparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtQtdPingsADisparar.Location = new System.Drawing.Point(238, 345);
            this.txtQtdPingsADisparar.MaxLength = 2;
            this.txtQtdPingsADisparar.Name = "txtQtdPingsADisparar";
            this.txtQtdPingsADisparar.Size = new System.Drawing.Size(96, 23);
            this.txtQtdPingsADisparar.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(235, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 17);
            this.label6.TabIndex = 63;
            this.label6.Text = "Quantidade de pings a serem disparados:";
            // 
            // lstViewVPN
            // 
            this.lstViewVPN.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstViewVPN.HideSelection = false;
            this.lstViewVPN.Location = new System.Drawing.Point(12, 105);
            this.lstViewVPN.Name = "lstViewVPN";
            this.lstViewVPN.Size = new System.Drawing.Size(202, 289);
            this.lstViewVPN.TabIndex = 58;
            this.lstViewVPN.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // txtQtdPingsQuedaConexao
            // 
            this.err1.SetError(this.txtQtdPingsQuedaConexao, "Informe quantos pacotes perdidos definem queda de conexão. Entre 2 e 5.");
            this.txtQtdPingsQuedaConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtQtdPingsQuedaConexao.Location = new System.Drawing.Point(238, 289);
            this.txtQtdPingsQuedaConexao.MaxLength = 2;
            this.txtQtdPingsQuedaConexao.Name = "txtQtdPingsQuedaConexao";
            this.txtQtdPingsQuedaConexao.Size = new System.Drawing.Size(96, 23);
            this.txtQtdPingsQuedaConexao.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humnst777 Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 59;
            this.label1.Text = "Conexões Disponíveis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(235, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 17);
            this.label5.TabIndex = 62;
            this.label5.Text = "Quantidade de pings que definem queda de conexão:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(235, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Intervalo entre pings (segundos):";
            // 
            // txtIntervaloMon
            // 
            this.txtIntervaloMon.AcceptsReturn = true;
            this.txtIntervaloMon.AcceptsTab = true;
            this.err1.SetError(this.txtIntervaloMon, "Informe o intervalo em segundos. Entre 1 e 5 segundos");
            this.txtIntervaloMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIntervaloMon.Location = new System.Drawing.Point(238, 232);
            this.txtIntervaloMon.MaxLength = 3;
            this.txtIntervaloMon.Name = "txtIntervaloMon";
            this.txtIntervaloMon.Size = new System.Drawing.Size(96, 23);
            this.txtIntervaloMon.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(235, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "Nome da conexão VPN para monitoramentos:";
            // 
            // txtNomeConexaoVPN
            // 
            this.err1.SetError(this.txtNomeConexaoVPN, "Digite o nome da conexão VPN armazenada");
            this.txtNomeConexaoVPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNomeConexaoVPN.Location = new System.Drawing.Point(238, 178);
            this.txtNomeConexaoVPN.MaxLength = 100;
            this.txtNomeConexaoVPN.Name = "txtNomeConexaoVPN";
            this.txtNomeConexaoVPN.Size = new System.Drawing.Size(344, 23);
            this.txtNomeConexaoVPN.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Selecione uma conexão para monitorar e rediscar.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(613, 59);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // abrirInterfaceToolStripMenuItem
            // 
            this.abrirInterfaceToolStripMenuItem.Name = "abrirInterfaceToolStripMenuItem";
            this.abrirInterfaceToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.abrirInterfaceToolStripMenuItem.Text = "Abrir interface";
            this.abrirInterfaceToolStripMenuItem.Click += new System.EventHandler(this.abrirInterfaceToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Clique para ver opções";
            this.notifyIcon1.BalloonTipTitle = "Informações";
            this.notifyIcon1.ContextMenuStrip = this.MenuStrip;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "VPNTrayMon - Monitor de VPN";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirInterfaceToolStripMenuItem,
            this.pausarMonitoramentoDaVPNToolStripMenuItem,
            this.encerrarAAplicaçãoToolStripMenuItem,
            this.SobretoolStripMenuItem1});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(239, 92);
            this.MenuStrip.Text = "Menu";
            // 
            // pausarMonitoramentoDaVPNToolStripMenuItem
            // 
            this.pausarMonitoramentoDaVPNToolStripMenuItem.CheckOnClick = true;
            this.pausarMonitoramentoDaVPNToolStripMenuItem.Name = "pausarMonitoramentoDaVPNToolStripMenuItem";
            this.pausarMonitoramentoDaVPNToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.pausarMonitoramentoDaVPNToolStripMenuItem.Text = "Pausar monitoramento da VPN";
            this.pausarMonitoramentoDaVPNToolStripMenuItem.Click += new System.EventHandler(this.pausarMonitoramentoDaVPNToolStripMenuItem_Click);
            // 
            // encerrarAAplicaçãoToolStripMenuItem
            // 
            this.encerrarAAplicaçãoToolStripMenuItem.Name = "encerrarAAplicaçãoToolStripMenuItem";
            this.encerrarAAplicaçãoToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.encerrarAAplicaçãoToolStripMenuItem.Text = "Encerrar a aplicação";
            this.encerrarAAplicaçãoToolStripMenuItem.Click += new System.EventHandler(this.encerrarAAplicaçãoToolStripMenuItem_Click);
            // 
            // SobretoolStripMenuItem1
            // 
            this.SobretoolStripMenuItem1.Image = global::VPNTrayMon.Properties.Resources.questoes;
            this.SobretoolStripMenuItem1.Name = "SobretoolStripMenuItem1";
            this.SobretoolStripMenuItem1.Size = new System.Drawing.Size(238, 22);
            this.SobretoolStripMenuItem1.Text = "Sobre";
            this.SobretoolStripMenuItem1.Click += new System.EventHandler(this.SobretoolStripMenuItem1_Click);
            // 
            // err1
            // 
            this.err1.ContainerControl = this;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.Location = new System.Drawing.Point(513, 487);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(109, 34);
            this.btnMinimizar.TabIndex = 31;
            this.btnMinimizar.Text = "Minimizar";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // tmrMonitor
            // 
            this.tmrMonitor.Enabled = true;
            this.tmrMonitor.Interval = 15000;
            this.tmrMonitor.Tick += new System.EventHandler(this.tmrMonitor_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 530);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnMinimizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tbPg1.ResumeLayout(false);
            this.tbPg1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tbPg2.ResumeLayout(false);
            this.tbPg2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPg2;
        private System.Windows.Forms.ErrorProvider err1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tbPg1;
        private System.Windows.Forms.Label lblStatusVPN;
        private System.Windows.Forms.Label lblDataHoraUltimoStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem abrirInterfaceToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtQtdPingsADisparar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lstViewVPN;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txtQtdPingsQuedaConexao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIntervaloMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeConexaoVPN;
        private System.Windows.Forms.PictureBox picStatus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem pausarMonitoramentoDaVPNToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkReconectarVPN;
        private System.Windows.Forms.Timer tmrMonitor;
        private System.Windows.Forms.ToolStripMenuItem encerrarAAplicaçãoToolStripMenuItem;
        private System.Windows.Forms.Button btnVPNControl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNomeOuIP;
        private System.Windows.Forms.ToolStripMenuItem SobretoolStripMenuItem1;
    }
}