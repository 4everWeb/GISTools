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
    public partial class FormLayerShowSclae : Form
    {
        private GLayerLib.ILayer _layer;

        public FormLayerShowSclae(GLayerLib.ILayer layer)
        {
            InitializeComponent();

            _layer = layer;

            this.Text = _layer.Name;

            this.txtMinimumScale.Text = _layer.MinimumScale.ToString();
            this.txtMaximumScale.Text = _layer.MaximumScale.ToString();
        }

        private void btnApplyShowScale_Click(object sender, EventArgs e)
        {
            _layer.MinimumScale = Convert.ToDouble(this.txtMinimumScale.Text);
            _layer.MaximumScale = Convert.ToDouble(this.txtMaximumScale.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
