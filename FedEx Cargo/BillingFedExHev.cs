using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FedEx_Cargo
{
    public partial class BillingFedExHev : Form
    {
        public BillingFedExHev()
        {
            InitializeComponent();
            Load += BillingFedExHev_Load;
        }

        private void BillingFedExHev_Load(object sender, EventArgs e)
        {
            SetActivePanel(ucRead1);
        }

        public void SetActivePanel(UserControl control)
        {
            ucRead1.Visible= false;
            ucWrite1.Visible= false;

            control.Visible = true;
        }

        private void BillingFedExHev_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }


        private void txtAWB_Click(object sender, EventArgs e)
        {
            txtAWB.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CbOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CbOption.SelectedIndex)
            {
                case 0: SetActivePanel(ucRead1);
                    break;
                case 1: SetActivePanel(ucWrite1);
                    break;
            }
        }
    }
}
