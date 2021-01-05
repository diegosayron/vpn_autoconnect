using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VPNTray
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            PreencherListView();
        }

        public void PreencherListView()
        {


            foreach (var vpns in VPNConnect.GetListaDeVPN())
            {
                lstViewVPN.Items.Add(vpns);
            }
            lstViewVPN.View = View.Details;
            lstViewVPN.Columns[0].Width = lstViewVPN.Width;
            lstViewVPN.Columns[0].TextAlign = HorizontalAlignment.Center;           
        }
    }
}
