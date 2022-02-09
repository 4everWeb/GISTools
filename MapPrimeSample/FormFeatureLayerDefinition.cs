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
    public partial class FormFeatureLayerDefinition : Form
    {
        private GLayerLib.IFeatureLayer _featureLayer = null;

        public FormFeatureLayerDefinition(GLayerLib.IFeatureLayer featureLayer)
        {
            InitializeComponent();

            _featureLayer = featureLayer;

            this.Text = featureLayer.Name;

            GLayerLib.IFeatureLayerDefinition layerDef = featureLayer as GLayerLib.IFeatureLayerDefinition;
            this.textBox1.Text = layerDef.DefinitionExpression;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GLayerLib.IFeatureLayerDefinition layerDef = _featureLayer as GLayerLib.IFeatureLayerDefinition;
            layerDef.DefinitionExpression = this.textBox1.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
