
namespace VPNTray
{
    partial class VPNTray
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Diagnostics.EventLog eventLog1;



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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.tmrStatus = new System.Windows.Forms.Timer(this.components);
            this.lblStatusVPN = new System.Windows.Forms.Label();
            this.lblDataHoraUltimoStatus = new System.Windows.Forms.Label();
            this.btnDeveReconectar = new System.Windows.Forms.Button();
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            // 
            // tmrStatus
            // 
            this.tmrStatus.Interval = 5000;
            this.tmrStatus.Tick += new System.EventHandler(this.tmrStatus_Tick);
            // 
            // lblStatusVPN
            // 
            this.lblStatusVPN.AutoSize = true;
            this.lblStatusVPN.Location = new System.Drawing.Point(0, 0);
            this.lblStatusVPN.Name = "lblStatusVPN";
            this.lblStatusVPN.Size = new System.Drawing.Size(100, 23);
            this.lblStatusVPN.TabIndex = 0;
            this.lblStatusVPN.Text = "lblStatusVPN";
            // 
            // lblDataHoraUltimoStatus
            // 
            this.lblDataHoraUltimoStatus.AutoSize = true;
            this.lblDataHoraUltimoStatus.Location = new System.Drawing.Point(0, 0);
            this.lblDataHoraUltimoStatus.Name = "lblDataHoraUltimoStatus";
            this.lblDataHoraUltimoStatus.Size = new System.Drawing.Size(100, 23);
            this.lblDataHoraUltimoStatus.TabIndex = 0;
            // 
            // btnDeveReconectar
            // 
            this.btnDeveReconectar.Location = new System.Drawing.Point(0, 0);
            this.btnDeveReconectar.Name = "btnDeveReconectar";
            this.btnDeveReconectar.Size = new System.Drawing.Size(75, 23);
            this.btnDeveReconectar.TabIndex = 0;
            this.btnDeveReconectar.Text = "Interromper Reconexão";
            this.btnDeveReconectar.UseVisualStyleBackColor = true;
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.Size = new System.Drawing.Size(200, 24);
            this.mnPrincipal.TabIndex = 0;
            this.mnPrincipal.Text = "Menu Principal";
            // 
            // VPNTray
            // 
            this.ServiceName = "VPNTrayMonitor";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();

        }

        #endregion

        private System.Windows.Forms.Timer tmrStatus;
        private System.Windows.Forms.Label lblStatusVPN;
        private System.Windows.Forms.Label lblDataHoraUltimoStatus;
        private System.Windows.Forms.Button btnDeveReconectar;
        private System.Windows.Forms.MenuStrip mnPrincipal;
    }
}
