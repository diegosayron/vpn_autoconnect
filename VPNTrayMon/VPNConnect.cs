using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VPNTrayMon
{
    public class VPNConnect
    {
        public string NomeOuIP { get; set; }
        public string NomeDaConexao { get; set; }
        public int QtdPerdaPacotesDefineVPNDesconectada { get; set; }
        public int QtdDisparos { get; set; }
        public int IntervaloEntrePings { get; set; } //segundos
        public bool Reconectar { get; set; }
        public DateTime DataHoraStatus { get; set; }
        public bool PausarMonitoramento { get; set; }
        private StatusVPN eStatusVPN;

        Process p;

        public VPNConnect(string NomeConexao, int QuantasPerdasPacotesDefineVPNDesconectada, 
                          int QtdDeDisparos, int IntervaloEntreDoisPings, bool ReconectarAVPN,
                          string NomeOuEnderecoIP)
        {
            NomeDaConexao = NomeConexao;
            QtdPerdaPacotesDefineVPNDesconectada = QuantasPerdasPacotesDefineVPNDesconectada;
            QtdDisparos = QtdDeDisparos;
            IntervaloEntrePings = IntervaloEntreDoisPings;
            Reconectar = ReconectarAVPN;
            NomeOuIP = NomeOuEnderecoIP;
        }
        public enum StatusVPN
        {
            VPNDesconectada = 0,
            VPNConectada = 1,
            VPNStatusNaoReconhecido
        }
        public  StatusVPN StatusDaVPN
        {
            get
            {
                return eStatusVPN;
            }
            set
            {
                eStatusVPN = value;
                DataHoraStatus = DateTime.Now;
            }
        }
        public  bool Conectar()
        {
            try
            {
                p = new Process();
                p.StartInfo = new ProcessStartInfo("rasdial.exe", NomeDaConexao);
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.Start();

                this.StatusDaVPN = StatusVPN.VPNConectada;
                return true;
            }
            catch (System.Exception)
            {
                this.StatusDaVPN = StatusVPN.VPNStatusNaoReconhecido;
                return false;
            }
        }
        public  bool Desconectar()
        {
            try
            {
                p = new Process();
                p.StartInfo = new ProcessStartInfo("rasdial.exe", $"{NomeDaConexao} /DISCONNECT");
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.Start();

                this.StatusDaVPN = StatusVPN.VPNDesconectada;
                return true;
            }
            catch(System.Exception)
            {
                this.StatusDaVPN = StatusVPN.VPNStatusNaoReconhecido;
                return false;
            }
        }
        public async Task<bool> VPNDesconectouAsync()
        {
            bool pingable = false;
            Ping pinger = null;
            int qtdPacotesPerdidos = 0;

            try
            {
                pinger = new Ping();

                for (int i = 0; i < QtdDisparos; i++)
                {
                    PingReply reply = pinger.Send(NomeOuIP);
                    pingable = reply.Status == IPStatus.Success;

                    if (!pingable)
                    {
                        qtdPacotesPerdidos++;
                    }
                    await Task.Delay(IntervaloEntrePings);
                }
            }

            catch (PingException)
            {
                this.eStatusVPN = StatusVPN.VPNDesconectada;
                return true;
            }

            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            if (qtdPacotesPerdidos >= QtdPerdaPacotesDefineVPNDesconectada)
            {
                this.eStatusVPN = StatusVPN.VPNDesconectada;
                return true;
            }
            else
            {
                this.eStatusVPN = StatusVPN.VPNConectada;
                return false;
            }
        }
        public static List<string> GetListaDeVPN()
        {

            // VPN adapters are stored in the rasphone.pdk
            // "C:\Users\Me\AppData\Roaming\Microsoft\Network\Connections\Pbk\rasphone.pbk"
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData) +
                          @"\Microsoft\Network\Connections\Pbk\rasphone.pbk";

            const string pattern = @"\[(.*?)\]";
             
            List<string> listaVPNs = new List<string>();

            var matches = Regex.Matches(System.IO.File.ReadAllText(path), pattern);
            foreach (Match m in matches)
            {
                listaVPNs.Add(m.Groups[1].ToString());
            }

            return listaVPNs;
            /*
            foreach (Match m in matches)
            {
                listView1.Items.Add(m.Groups[1].ToString());
            }
            listView1.View = View.Details;
            //listView1.Columns[0].Width = listView1.Width;
            listView1.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.Columns[0].TextAlign = HorizontalAlignment.Center;
            */
        }

    }
}
