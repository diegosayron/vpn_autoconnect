using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Windows.Forms;
using System.Timers;
namespace VPNTray
{
    public partial class VPNTray : ServiceBase
    {
        private int eventId = 1;
        System.Timers.Timer timer = new System.Timers.Timer();
        VPNConnect vpnMonitorada;

        public VPNTray()
        {
            InitializeComponent();

            eventLog1 = new EventLog();
            if (!EventLog.SourceExists("VPNTray"))
            {
                EventLog.CreateEventSource(
                    "VPNTray", "VPNTrayLog");
            }
            eventLog1.Source = "VPNTray";
            eventLog1.Log = "VPNTrayLog";


        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("O VPNTray iniciou o serviço");

            timer.Interval = (Configuracoes.IntervaloDeMonitoramento > 0 && Configuracoes.IntervaloDeMonitoramento < 86400 ?
                                Configuracoes.IntervaloDeMonitoramento * 1000 : 300000); //milisec

            timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }

        private void OnTimer(object sender, ElapsedEventArgs e)
        {
            // TODO: Insert monitoring activities here.
            eventLog1.WriteEntry("Monitorando a VPN", EventLogEntryType.Information, eventId++);
            if (Configuracoes.RequerConfigurar())
            {
                if (Application.OpenForms.OfType<frmConfig>().Count() == 0)
                {
                    frmConfig f = new frmConfig();
                    f.Show();
                }
            }
            else
            {
                vpnMonitorada = new VPNConnect(Configuracoes.EnderecoOuIp);

                if (vpnMonitorada.VPNDesconectou(Configuracoes.EnderecoOuIp,
                    Configuracoes.QuantidadeDePingsQuedaConexao,
                    Configuracoes.QuantidadeDePingsParaDisparar))
                {
                    vpnMonitorada.Conectar();
                }
            }
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("VPNTray entrou em estado 'Parado'");
        }

        private void tmrStatus_Tick(object sender, System.EventArgs e)
        {
            switch (vpnMonitorada.StatusDaVPN)
            {
                case VPNConnect.StatusVPN.VPNConectada:
                    lblStatusVPN.Text = "VPN Conectada";
                    break;

                case VPNConnect.StatusVPN.VPNDesconectada:
                    lblStatusVPN.Text = "VPN Conectada";
                    break;

                default:
                    lblStatusVPN.Text = "ESTADO DESCONHECIDO DA VPN";
                    break;

            }
            lblDataHoraUltimoStatus.Text = $"Último status da VPN: {vpnMonitorada.DataHoraStatus.ToString()}";

        }
    }
}
