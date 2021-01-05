using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace VPNTray
{
    public class VPNConnect
    {
        public VPNConnect(string NomeDaConexaoVPN)
        {
            p.StartInfo = new ProcessStartInfo("rasdial.exe", NomeDaConexaoVPN);
        }
        public enum StatusVPN
        {
            VPNDesconectada = 0,
            VPNConectada = 1,
            VPNStatusNaoReconhecido
        }
        private StatusVPN eStatusVPN; 
        readonly Process p = new Process();
        public DateTime DataHoraStatus { get; set; }
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
                p.Kill();
            }
            catch(System.Exception)
            {
                this.StatusDaVPN = StatusVPN.VPNStatusNaoReconhecido;
                return false;
            }

            this.StatusDaVPN = StatusVPN.VPNDesconectada;
            return true;
        }
        public  bool VPNDesconectou(string NomeOuIP, int qtdPerdaPacotesDefineVPNDesconectada, int qtdDisparos)
        {
            bool pingable = false;
            Ping pinger = null;
            int qtdPacotesPerdidos = 0;

            try
            {
                pinger = new Ping();

                for (int i = 0; i < qtdDisparos; i++)
                {
                    PingReply reply = pinger.Send(NomeOuIP);
                    pingable = reply.Status == IPStatus.Success;

                    if (!pingable)
                    {
                        qtdPacotesPerdidos++;
                    }
                }

            }

            catch (PingException)
            {
                return true;
            }

            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            if (qtdPacotesPerdidos >= qtdPerdaPacotesDefineVPNDesconectada)
            {
                return true;
            }
            else
            {
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
