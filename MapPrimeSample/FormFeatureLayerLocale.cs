using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapPrimeSample
{
    public partial class FormFeatureClassLocale : Form
    {
        private GLayerLib.IFeatureLayer _featureLayer = null;

        public FormFeatureClassLocale(GLayerLib.IFeatureLayer featureLayer)
        {
            InitializeComponent();

            _featureLayer = featureLayer;

            this.Text = featureLayer.Name;

            if (_featureLayer.FeatureClass.Locale == GDataSourceLib.eLocale.eCP949)
            {
                this.rdoCP949.Checked = true;
            }
            else if (_featureLayer.FeatureClass.Locale == GDataSourceLib.eLocale.eEUCKR)
            {
                this.rdoEUCKR.Checked = true;
            }
            else if (_featureLayer.FeatureClass.Locale == GDataSourceLib.eLocale.eUTF8)
            {
                this.rdoUTF8.Checked = true;
            }
            else if (_featureLayer.FeatureClass.Locale == GDataSourceLib.eLocale.eSystem)
            {
                this.rdoSystem.Checked = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnApplyLocale_Click(object sender, EventArgs e)
        {

            if (this.rdoCP949.Checked == true)
            {
                _featureLayer.FeatureClass.Locale = GDataSourceLib.eLocale.eCP949;
            }
            else if (this.rdoEUCKR.Checked == true)
            {
                _featureLayer.FeatureClass.Locale = GDataSourceLib.eLocale.eEUCKR;
            }
            else if (this.rdoUTF8.Checked == true)
            {
                _featureLayer.FeatureClass.Locale = GDataSourceLib.eLocale.eUTF8;
            }
            else if (this.rdoSystem.Checked == true)
            {
                _featureLayer.FeatureClass.Locale = GDataSourceLib.eLocale.eSystem;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
