using System;
using System.Windows.Forms;

namespace VPNTrayMon
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Configuracoes.LerConfiguracoes();
            Application.Run(new frmMain());
        }
    }
}
