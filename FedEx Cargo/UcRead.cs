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

namespace FedEx_Cargo
{
    public partial class UcRead : UserControl
    {
        public UcRead()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {

        }
    }
}
