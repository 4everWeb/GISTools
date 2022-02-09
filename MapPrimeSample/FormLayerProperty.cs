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

    public partial class FormLayerProperty : Form
    {
        private GLayerLib.ILayer _layer = null;
        private AxGMapLib.AxMapControl _mapControl = null;

        public FormLayerProperty(GLayerLib.ILayer layer, AxGMapLib.AxMapControl mapContrl)
        {
            InitializeComponent();

            _mapControl = mapContrl;
            _layer = layer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GLayerLib.IFeatureLayer featureLayer = _layer as GLayerLib.IFeatureLayer;
            FormFeatureLayerDefinition definitionForm = new FormFeatureLayerDefinition(featureLayer);
            if (definitionForm.ShowDialog(this) == DialogResult.OK)
            {
                _mapControl.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerAll);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GLayerLib.IGeoFeatureLayer geoLayer = _layer as GLayerLib.IGeoFeatureLayer;
            FormSimpleRenderer simpleForm = new FormSimpleRenderer(geoLayer);
            if (simpleForm.ShowDialog(this) == DialogResult.OK)
            {
                _mapControl.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerAll);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormLayerShowSclae showScaleForm = new FormLayerShowSclae(_layer);
            if (showScaleForm.ShowDialog(this) == DialogResult.OK)
            {
                _mapControl.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerAll);
            }
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            GLayerLib.IGeoFeatureLayer geoLayer = _layer as GLayerLib.IGeoFeatureLayer;
            FormLabelRenderer labelFrom = new FormLabelRenderer(geoLayer);
            if (labelFrom.ShowDialog(this) == DialogResult.OK)
            {
                _mapControl.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerAll);
            }
        }

       
        private void button5_Click(object sender, EventArgs e)
        {
            GLayerLib.IFeatureLayer featureLayer = _layer as GLayerLib.IFeatureLayer;
            FormFeatureClassLocale localeForm = new FormFeatureClassLocale(featureLayer);
            if (localeForm.ShowDialog(this) == DialogResult.OK)
            {
                _mapControl.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerAll);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormSpatialReference srForm = new FormSpatialReference(_layer);
            if (srForm.ShowDialog(this) == DialogResult.OK)
            {
                _mapControl.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerAll);
            }
        }
    }
}

