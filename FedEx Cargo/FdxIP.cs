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
    public partial class FdxIP : UserControl
    {
        public FdxIP()
        {
            InitializeComponent();
        }

        private void btnFuel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.fedex.com/en-th/shipping/surcharges.html");
        }

        private void IpCalc()
        {

            double WB;
            string sWB = txtWeight.Text;
            WB= double.Parse(sWB);

            double HS;
            string sHS = cbHandling.Text;
            HS= double.Parse(sHS);

            double FSI;
            string sFSI = txtFuel.Text;
            FSI= double.Parse(sFSI);

            int Residential;
            string sResidential = txtResidential.Text;
            Residential = int.Parse(sResidential);

            double Disc;
            double Gtotal;


            switch(cbDestination.SelectedIndex)
            {
                //U.S.A, Canada, Mexico
                case 0:
                    WB = WB * 782;
                    Disc = WB * 71.03 / 100;
                    //Disc = WB * 76.52174 / 100; Happy Hour!
                    txtDiscount.Text = Disc.ToString();
                    WB = WB - Disc;
                    
                    WB = WB + Residential + HS;
                    FSI = WB * (FSI / 100);
                    Gtotal = WB + FSI;


                    txtTotal.Text = Gtotal.ToString();

                    break;

            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            IpCalc();
        }

        private void txtWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter) { IpCalc(); }
        }

        private void txtFuel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { IpCalc(); }
        }
    }
}
