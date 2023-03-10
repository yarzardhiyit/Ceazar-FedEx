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
    public partial class Light_weight : UserControl
    {
        public Light_weight()
        {
            InitializeComponent();
        }

        private void IpLightWeight()
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

            int cbDsr;
            string sDsr = cbBoxDsr.Text;
            cbDsr = int.Parse(sDsr);    

            /*
            int Residential;
            string sResidential = txtResidential.Text;
            Residential = int.Parse(sResidential); */

            double Disc;
            double Gtotal;


            switch (cbDestination.SelectedIndex)
            {
                //U.S.A, Canada, Mexico
                case 0:
                    PS = WB;
                    double roundedNumber = Math.Round(PS);

                    if (PS - roundedNumber >= 0.5) // to get output 3.5
                    {
                        roundedNumber += 0.5;
                    }
                    else if (PS - roundedNumber >= 0 && PS - roundedNumber < 0.5) // to get output 4 if user input is 3.6
                    {
                        roundedNumber += 1;
                    }

                    PS = roundedNumber * 32;


                    txtPsurcharges.Text = PS.ToString();

                    WB = WB * 782;
                    /*  
                     *  Disc = WB * 71.03 / 100; // Regular Rate
                     *  Disc = WB * 76.52174 / 100; // Happy Hour
                    */
                    Disc = WB * 69.03 / 100; // light_weight
                    txtDiscount.Text = Disc.ToString();
                    WB = WB - Disc;

                    txtPsurcharges.Text = PS.ToString();

                    WB = WB + cbDsr + HS + PS;
                    FSI = WB * (FSI / 100);
                    Gtotal = WB + FSI;


                    txtTotal.Text = Gtotal.ToString();

                    break;

            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            IpLightWeight();
        }

        private void txtWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IpLightWeight();
            }
        }

        private void txtFuel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IpLightWeight();
            }
        }
    }
}
