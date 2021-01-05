using System;
using System.Windows.Forms;

namespace VPNTrayMon
{
    public partial class frmMain : Form
    {

        VPNConnect vpnMonitorada;
        private bool allowVisible;

        public frmMain()
        {
            InitializeComponent();

            this.notifyIcon1.Icon = Properties.Resources.icone;
            StartInicialDoServico();

            Monitorar();
        }

        private void StartInicialDoServico()
        {
            if (Configuracoes.RequerConfigurar())
            {

                frmMain f = new frmMain();
                f.ShowDialog(this);
            }

            vpnMonitorada = new VPNConnect(Configuracoes.NomeConexaoVPN,
                                           Configuracoes.QuantidadeDePingsQuedaConexao,
                                           Configuracoes.QuantidadeDePingsParaDisparar,
                                           Configuracoes.IntervaloEntrePings,
                                           Configuracoes.ReconectarVPN,
                                           Configuracoes.NomeOuEnderecoIP);
        }

        private async void Monitorar()
        {
            await vpnMonitorada.VPNDesconectouAsync();

            if (vpnMonitorada.Reconectar &&
                (vpnMonitorada.StatusDaVPN == VPNConnect.StatusVPN.VPNDesconectada ||
                vpnMonitorada.StatusDaVPN == VPNConnect.StatusVPN.VPNStatusNaoReconhecido))
            {
                vpnMonitorada.Conectar();
            }

            AtulizarItensVisuaisDoStatusDaConexao();

        }

        private void PreencherCampos()
        {
            txtNomeOuIP.Text = Configuracoes.NomeOuEnderecoIP;
            txtNomeConexaoVPN.Text = Configuracoes.NomeConexaoVPN;
            txtIntervaloMon.Text = Configuracoes.IntervaloEntrePings.ToString();
            txtQtdPingsQuedaConexao.Text = Configuracoes.QuantidadeDePingsQuedaConexao.ToString();
            txtQtdPingsADisparar.Text = Configuracoes.QuantidadeDePingsParaDisparar.ToString();
            chkReconectarVPN.Checked = Configuracoes.ReconectarVPN;
            PreencherListView();
            AtulizarItensVisuaisDoStatusDaConexao();
        }

        public void PreencherListView()
        {
            lstViewVPN.Items.Clear();
            foreach (var vpns in VPNConnect.GetListaDeVPN())
            {
                lstViewVPN.Items.Add(vpns);
            }
            lstViewVPN.View = View.Details;
            lstViewVPN.Columns[0].Width = lstViewVPN.Width;
            lstViewVPN.Columns[0].TextAlign = HorizontalAlignment.Center;
        }

        private void lstViewVPN_DoubleClick(object sender, EventArgs e)
        {
            txtNomeConexaoVPN.Text = lstViewVPN.SelectedItems[0].Text;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PreencherListView();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                Configuracoes.NomeOuEnderecoIP = txtNomeOuIP.Text;
                Configuracoes.NomeConexaoVPN = txtNomeConexaoVPN.Text;
                Configuracoes.IntervaloEntrePings = Convert.ToInt16(txtIntervaloMon.Text);
                Configuracoes.QuantidadeDePingsQuedaConexao = Convert.ToInt16(txtQtdPingsQuedaConexao.Text);
                Configuracoes.QuantidadeDePingsParaDisparar = Convert.ToInt16(txtQtdPingsADisparar.Text);
                Configuracoes.ReconectarVPN = chkReconectarVPN.Checked;
                AtualizarCamposDaConexao();

                MessageBox.Show("As alterações foram salvas");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao salvar campos no arquivo de configuração.\n\n" +
                    "Certifique-se de que o arquivo existe e o usuário tem permissões de escrita.",
                    "Erro de gravação",MessageBoxButtons.OK);
            }

        }

        private void AtualizarCamposDaConexao()
        {
            vpnMonitorada.NomeOuIP = Configuracoes.NomeOuEnderecoIP;
            vpnMonitorada.NomeDaConexao = Configuracoes.NomeConexaoVPN;
            vpnMonitorada.IntervaloEntrePings  = Configuracoes.IntervaloEntrePings;
            vpnMonitorada.QtdPerdaPacotesDefineVPNDesconectada = Configuracoes.QuantidadeDePingsQuedaConexao;
            vpnMonitorada.QtdDisparos = Configuracoes.QuantidadeDePingsParaDisparar;
            vpnMonitorada.Reconectar = Configuracoes.ReconectarVPN;
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            HideInterface();
        }
        private void AtulizarItensVisuaisDoStatusDaConexao()
        {
            switch (vpnMonitorada.StatusDaVPN)
            {
                case VPNConnect.StatusVPN.VPNDesconectada:
                    if (picStatus.Tag.ToString() != "Desconectado")
                    {
                        lblStatusVPN.Text = "VPN Desconectada";
                        picStatus.Image = Properties.Resources.Desconectado;
                        picStatus.Tag = "Desconectado";
                        btnVPNControl.Text = "Forçar Conexão";
                        notifyIcon1.ShowBalloonTip(3000,$"Status da VPN {Configuracoes.NomeConexaoVPN}",
                                                   "A VPN foi desconectada",ToolTipIcon.Warning); 
                    }
                    break;
                case VPNConnect.StatusVPN.VPNConectada:
                    if (picStatus.Tag.ToString() != "Conectado")
                    {
                        lblStatusVPN.Text = "VPN Conectada";
                        picStatus.Image = Properties.Resources.Conectado;
                        picStatus.Tag = "Conectado";
                        btnVPNControl.Text = "Forçar Desconexão";
                    }
                    break;
                case VPNConnect.StatusVPN.VPNStatusNaoReconhecido:
                    if (picStatus.Tag.ToString() != "Desconhecido")
                    {
                        lblStatusVPN.Text = "ESTADO DESCONHECIDO DA VPN";
                        picStatus.Image = Properties.Resources.Desconhecido;
                        picStatus.Tag = "Desconhecido";
                        btnVPNControl.Text = "Forçar Conexão";
                    }
                    break;
                default:
                    lblStatusVPN.Text = "ESTADO DESCONHECIDO DA VPN";
                    picStatus.Image = Properties.Resources.Desconectado;
                    picStatus.Tag = "Desconectado";
                    btnVPNControl.Text = "Forçar Conexão";
                    break;
            }
            
            lblDataHoraUltimoStatus.Text = $"Último status salvo em {vpnMonitorada.DataHoraStatus.ToString()}";
        }
        private void pausarMonitoramentoDaVPNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pausarMonitoramentoDaVPNToolStripMenuItem.Checked)
            {
                vpnMonitorada.PausarMonitoramento = pausarMonitoramentoDaVPNToolStripMenuItem.Checked;
            }
            else
            {
                vpnMonitorada.PausarMonitoramento = false;
                Monitorar();
            }
        }
        private void abrirInterfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInterface();
        }

        private void tmrMonitor_Tick(object sender, EventArgs e)
        {
            if (!vpnMonitorada.PausarMonitoramento)
                Monitorar();
        }

        private void encerrarAAplicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVPNControl_Click(object sender, EventArgs e)
        {
            if (vpnMonitorada.StatusDaVPN == VPNConnect.StatusVPN.VPNConectada)
            {
                vpnMonitorada.Desconectar();
            }
            else
            {
                vpnMonitorada.Conectar();
            }

            AtulizarItensVisuaisDoStatusDaConexao();
        }

        protected override void SetVisibleCore(bool value)
        {
            if (!allowVisible)
            {
                value = false;
                if (!this.IsHandleCreated) CreateHandle();
            }
            base.SetVisibleCore(value);

            PreencherCampos();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            notifyIcon1.Visible = false;
            this.Dispose();
        }
        private void ShowInterface()
        {
            allowVisible = true;
            Show();
        }

        private void HideInterface()
        {
            allowVisible = true;
            Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInterface();
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Dispose();
        }

        private void SobretoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new frmAjuda();
            f.Show(this);
        }
    }
}
