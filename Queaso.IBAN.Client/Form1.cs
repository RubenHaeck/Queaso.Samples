using Queaso.IBAN.Client.Proxies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Queaso.IBAN.Client
{
    public partial class MainForm : MetroForm
    {

        private IBANSoapProxy _clientProxy;

        public MainForm()
        {
            InitializeComponent();
            _clientProxy = new IBANSoapProxy("IBANBICSoap");
        }

        private void btnCountries_Click(object sender, EventArgs e)
        {
            
           

          
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedTab == tpCountries)
            {
                LoadCountries();
            }
        }

        private void LoadCountries()
        {
            gridCountries.DataSource = _clientProxy.GetCountryList();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var belgianBankNumber = txtBBAN.Text;
            if (_clientProxy.CheckBBAN(belgianBankNumber)) 
            { 
                txtBankName.Text = _clientProxy.GetBankName(txtBBAN.Text);
            }
        }
    }
}
