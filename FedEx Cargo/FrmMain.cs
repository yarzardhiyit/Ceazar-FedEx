using System;
using System.Windows.Forms;

namespace FedEx_Cargo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            Load += FrmMain_Load;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SetActivePanel(ucIntro3);
        }

        public void SetActivePanel(UserControl control)
        {
            ucIntro3.Visible = false;
            ucDiam2.Visible = false;
            ucSpotRate2.Visible = false;
            fdxGround3.Visible = false;
            fdxIP2.Visible = false;
            fdxHappy2.Visible = false;
            light_weight1.Visible = false;

            control.Visible = true;
        }

        private void aboutUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App: CeazarPay \nVersion: 1.0.0.34 \nDeveloped By: yarzardhiyit");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucIntro3);
        }

        private void diamensionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucDiam2);
        }

        private void spotRatePricingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucSpotRate2);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void disputeInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActivePanel(fdxGround3);
        }

        private void fedExHeavyWeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillingFedExHev frmFdxHev = new BillingFedExHev();
            frmFdxHev.Show();
        }

        private void regularRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActivePanel(fdxIP2);
            FdxIP frmFdxIP = new FdxIP();
            frmFdxIP.Show();
        }

        private void lastMinuteRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActivePanel(fdxHappy2);
            FdxHappy fdxHappy = new FdxHappy();
            fdxHappy.Show();
        }

        private void fedExLightweightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActivePanel(light_weight1);
            Light_weight fdxLightweight = new Light_weight();
            fdxLightweight.Show();  
        }
    }
}
