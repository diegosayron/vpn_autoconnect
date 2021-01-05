using System;
using System.Configuration;

namespace VPNTrayMon
{
    public static class Configuracoes
    {
        private static string sNomeOuIP;
        private static string sNomeConexaoVPN;
        private static int iIntervaloDeTempoEntrePings = 2; //em segundos
        private static int iQtdPingQuedaConexao = 2;
        private static int iQuantidadeDePingsParaDisparar = 3;
        private static bool bReconectarVPN = true;

        public static string NomeOuEnderecoIP
        {
            get
            {
                sNomeOuIP = VPNTrayMon.Properties.Settings.Default.NomeOuIP;
                return sNomeOuIP;
            }
            set
            {
                sNomeOuIP = value;
                Properties.Settings.Default.NomeOuIP = sNomeOuIP;
                SalvarProperties();
            }
        }
        public static string NomeConexaoVPN
        {
            get
            {
                sNomeConexaoVPN = VPNTrayMon.Properties.Settings.Default.NomeDaConexaoVPN;
                return sNomeConexaoVPN;
            }
            set
            {
                sNomeConexaoVPN = value;
                Properties.Settings.Default.NomeDaConexaoVPN = sNomeConexaoVPN;
                SalvarProperties();
            }
        }

        public static int IntervaloEntrePings
        {
            get
            {
                iIntervaloDeTempoEntrePings = Properties.Settings.Default.IntervaloEntrePings;
                return iIntervaloDeTempoEntrePings;
            }
            set
            {
                iIntervaloDeTempoEntrePings = value < 1 || value > 5 ? 1 : value;
                Properties.Settings.Default.IntervaloEntrePings = iIntervaloDeTempoEntrePings;
                SalvarProperties();
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
                iQtdPingQuedaConexao = value < 1 || value > 5 ? 2 : value ;
                Properties.Settings.Default.QtdPingQuedaConexao = iQtdPingQuedaConexao;
                SalvarProperties();
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
                iQuantidadeDePingsParaDisparar = value < 2 || value > 10 ? 2 : value;
                Properties.Settings.Default.QuantidadeDePingsParaDisparar = iQuantidadeDePingsParaDisparar;
                SalvarProperties();
            }
        }


        public static bool ReconectarVPN
        {
            get
            {
                bReconectarVPN = Properties.Settings.Default.ReconectarSeDesconectada;
                return bReconectarVPN;
            }
            set
            {
                bReconectarVPN = value;
                Properties.Settings.Default.ReconectarSeDesconectada = bReconectarVPN;
                SalvarProperties();
            }
        }

        public static bool RequerConfigurar()
        {
            if(string.IsNullOrEmpty(sNomeConexaoVPN))
            {
                return true;
            }
            return false;
        }

        public static void LerConfiguracoes()
        {
            NomeConexaoVPN = VPNTrayMon.Properties.Settings.Default.NomeDaConexaoVPN;
            IntervaloEntrePings = Properties.Settings.Default.IntervaloEntrePings;
            QuantidadeDePingsQuedaConexao = Properties.Settings.Default.QtdPingQuedaConexao;
            QuantidadeDePingsParaDisparar = Properties.Settings.Default.QuantidadeDePingsParaDisparar;
            ReconectarVPN = Properties.Settings.Default.ReconectarSeDesconectada;
            NomeOuEnderecoIP = Properties.Settings.Default.NomeOuIP;
        }

        private static void SalvarProperties()
        {
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
        }
    }
}
