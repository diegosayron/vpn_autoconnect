
namespace VPNTray
{
    partial class frmConfig
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstViewVPN = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIntervaloMon = new System.Windows.Forms.TextBox();
            this.txtNomeOuIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.err1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtQtdPings = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Selecione uma conexão para monitorar e rediscar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(613, 59);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humnst777 Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Conexões Disponíveis";
            // 
            // lstViewVPN
            // 
            this.lstViewVPN.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstViewVPN.HideSelection = false;
            this.lstViewVPN.Location = new System.Drawing.Point(12, 96);
            this.lstViewVPN.Name = "lstViewVPN";
            this.lstViewVPN.Size = new System.Drawing.Size(202, 227);
            this.lstViewVPN.TabIndex = 7;
            this.lstViewVPN.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(376, 335);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 37);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(235, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Intervalo entre monitoramentos (minutos):";
            // 
            // txtIntervaloMon
            // 
            this.txtIntervaloMon.AcceptsReturn = true;
            this.txtIntervaloMon.AcceptsTab = true;
            this.err1.SetError(this.txtIntervaloMon, "Informe o intervalo em minutos. Mínimo 1 minuto");
            this.txtIntervaloMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIntervaloMon.Location = new System.Drawing.Point(238, 116);
            this.txtIntervaloMon.MaxLength = 3;
            this.txtIntervaloMon.Name = "txtIntervaloMon";
            this.txtIntervaloMon.Size = new System.Drawing.Size(96, 23);
            this.txtIntervaloMon.TabIndex = 12;
            // 
            // txtNomeOuIP
            // 
            this.err1.SetError(this.txtNomeOuIP, "Digite o nome ou o endereço IP do servidor VPN");
            this.txtNomeOuIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNomeOuIP.Location = new System.Drawing.Point(238, 184);
            this.txtNomeOuIP.MaxLength = 100;
            this.txtNomeOuIP.Name = "txtNomeOuIP";
            this.txtNomeOuIP.Size = new System.Drawing.Size(340, 23);
            this.txtNomeOuIP.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(235, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome/endereço para monitoramentos:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(491, 335);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 37);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // err1
            // 
            this.err1.ContainerControl = this;
            // 
            // txtQtdPings
            // 
            this.err1.SetError(this.txtQtdPings, "Informe quantos pacotes perdidos definem queda de conexão (Recomendado a partir d" +
        "e 2)");
            this.txtQtdPings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtQtdPings.Location = new System.Drawing.Point(238, 253);
            this.txtQtdPings.MaxLength = 1;
            this.txtQtdPings.Name = "txtQtdPings";
            this.txtQtdPings.Size = new System.Drawing.Size(96, 23);
            this.txtQtdPings.TabIndex = 18;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::VPNTray.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(188, 69);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(26, 24);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(235, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Quantidade de pings que definem queda de conexão";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 384);
            this.Controls.Add(this.txtQtdPings);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNomeOuIP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIntervaloMon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstViewVPN);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmConfig";
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstViewVPN;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIntervaloMon;
        private System.Windows.Forms.TextBox txtNomeOuIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider err1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtQtdPings;
        private System.Windows.Forms.Label label5;
    }
}