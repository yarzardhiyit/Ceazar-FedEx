using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Util.Store;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

namespace FedEx_Cargo
{
    public partial class UcWrite : UserControl
    {
        public UcWrite()
        {
            InitializeComponent();
        }

        private void UcWrite_Load(object sender, EventArgs e)
        {

        }

        private void txtwSellPrice_Click(object sender, EventArgs e)
        {
            txtwSellPrice.Clear();
        }

        private void txtwBuyingPrice_Click(object sender, EventArgs e)
        {
            txtwBuyingPrice.Clear();
        }

        private void gBoxPrice_Enter(object sender, EventArgs e)
        {

        }
    }
}
