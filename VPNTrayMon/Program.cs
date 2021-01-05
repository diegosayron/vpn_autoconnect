using System.Windows.Forms;

namespace VPNTrayMon
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            //frmMain f = new frmMain();
            //f.Show();

            //MessageBox.Show(System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath);
            Configuracoes.LerConfiguracoes();
            Application.Run(new frmMain());
        }
    }
}
