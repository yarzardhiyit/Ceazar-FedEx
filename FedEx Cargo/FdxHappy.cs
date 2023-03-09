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
    public partial class FdxHappy : UserControl
    {
        public FdxHappy()
        {
            InitializeComponent();
        }
        
        private void IpHappy()
        {

            double WB;
            string sWB = txtWeight.Text;

            try
            {
                WB = double.Parse(sWB);
            }
            catch (FormatException ex)
            {
                // Set a default value for WB or return from the method, depending on your requirements
                WB = 0;
            }

            double PS;

            double HS;
            string sHS = cbHandling.Text;
            HS = double.Parse(sHS);

            double FSI;
            string sFSI = txtFuel.Text;

            try
            {
                FSI = double.Parse(sFSI);
            }
            catch (FormatException ex)
            {
                // Set a default value for FSI or return from the method, depending on your requirements
                FSI = 0;
            }


            int Residential;
            string sResidential = txtResidential.Text;
            Residential = int.Parse(sResidential);

            double Disc;
            double Gtotal;


            switch (cbDestination.SelectedIndex)
            {
                //U.S.A, Canada, Mexico
                case 0:
                    PS = WB * 32;
                    txtPsurcharges.Text = PS.ToString();

                    WB = WB * 782;
                    //Disc = WB * 71.03 / 100;
                    Disc = WB * 76.52174 / 100; // Happy Hour!
                    txtDiscount.Text = Disc.ToString();
                    WB = WB - Disc;
                    
                    txtPsurcharges.Text = PS.ToString();

                    WB = WB + Residential + HS + PS;
                    FSI = WB * (FSI / 100);
                    Gtotal = WB + FSI;


                    txtTotal.Text = Gtotal.ToString();

                    break;

            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            IpHappy();
        }

        private void txtWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IpHappy();
            }
        }

        private void txtFuel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IpHappy();
            }
        }

        private void txtResidential_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IpHappy();
            }
        }
    }
}
