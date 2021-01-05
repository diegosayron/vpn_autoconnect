using System;
using System.Configuration;

namespace VPNTray
{
    public static class Configuracoes
    {
        private static string sEnderecoOuIP;
        private static int iIntervaloDeMonitoramento = 5; //em segundos
        private static int iQtdPingQuedaConexao = 2;
        private static int iQuantidadeDePingsParaDisparar = 3;
        public static string EnderecoOuIp
        {
            get
            {
                sEnderecoOuIP = Properties.Settings.Default.NomeOuEndereco;
                return sEnderecoOuIP;
            }
            set
            {
                sEnderecoOuIP = value;
                Properties.Settings.Default.NomeOuEndereco = sEnderecoOuIP;
                Properties.Settings.Default.Save();
            }
        }

        public static int IntervaloDeMonitoramento
        {
            get
            {
                iIntervaloDeMonitoramento = Properties.Settings.Default.IntervaloEntreMonitoramento;
                return iIntervaloDeMonitoramento;
            }
            set
            {
                iIntervaloDeMonitoramento = value < 1 ? 1 : value;
                Properties.Settings.Default.IntervaloEntreMonitoramento = iIntervaloDeMonitoramento;
                Properties.Settings.Default.Save();
            }
        }

        public static int QuantidadeDePingsQuedaConexao
        {
            get
            {
                iQtdPingQuedaConexao = Properties.Settings.Default.QtdPingQuedaConexao;
                return iQtdPingQuedaConexao;
            }
            set
            {
                iQtdPingQuedaConexao = value < 1 || value > 86400 ? 2 : value ;
                Properties.Settings.Default.QtdPingQuedaConexao = iQtdPingQuedaConexao;
                Properties.Settings.Default.Save();
            }
        }

        public static int QuantidadeDePingsParaDisparar
        {
            get
            {
                iQuantidadeDePingsParaDisparar = Properties.Settings.Default.QuantidadeDePingsParaDisparar;
                return iQuantidadeDePingsParaDisparar;
            }
            set
            {
                iQuantidadeDePingsParaDisparar = value < 3 || value > 100 ? 3 : value;
                Properties.Settings.Default.QuantidadeDePingsParaDisparar = iQuantidadeDePingsParaDisparar;
                Properties.Settings.Default.Save();
            }
        }

        public static bool RequerConfigurar()
        {
            if(string.IsNullOrEmpty(sEnderecoOuIP))
            {
                return true;
            }
            return false;
        }



    }
}
