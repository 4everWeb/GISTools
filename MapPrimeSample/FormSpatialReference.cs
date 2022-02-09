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
    public partial class FormSpatialReference : Form
    {
        private GLayerLib.ILayer _layer = null;

        public FormSpatialReference(GLayerLib.ILayer layer)
        {
            InitializeComponent();

            _layer = layer;

            this.Text = _layer.Name;

            if (_layer.SpatialReference != null)
            {
                int code = _layer.SpatialReference.Code;
                this.txtCode.Text = code.ToString();
                this.txtSrtext.Text = _layer.SpatialReference.SrText;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnApplySpatialReference_Click(object sender, EventArgs e)
        {
            GSpatialReferenceLib.ISpatialReferenceFactory srf = new GSpatialReferenceLib.SpatialReferenceFactory();
            GSpatialReferenceLib.ISpatialReference sr = srf.CreateFromWKT(this.txtSrtext.Text);
            _layer.SpatialReference = sr;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
