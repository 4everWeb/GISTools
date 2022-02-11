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
    public partial class FormSimpleRenderer : Form
    {
        private GLayerLib.IGeoFeatureLayer _geoFeatureLayer = null;

        public FormSimpleRenderer(GLayerLib.IGeoFeatureLayer geoFeatureLayer)
        {
            InitializeComponent();

            _geoFeatureLayer = geoFeatureLayer;

            this.Text = _geoFeatureLayer.Name;
            this.grpFillSymbol.Enabled = false;
            this.grpFillSymbol.Enabled = false;
            this.grpPointSymbol.Enabled = false;

            GLayerLib.ISimpleRenderer simpleRender = _geoFeatureLayer.Renderer as GLayerLib.ISimpleRenderer;
            if (simpleRender == null)
            {
                simpleRender = new GLayerLib.SimpleRenderer();
                GDisplayLib.ISymbol crtSymbol = FormMain.CreateSymbol(_geoFeatureLayer);
                simpleRender.Symbol["ISymbol"] = crtSymbol;
            }

            if (_geoFeatureLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypeMultiPolygon
                || _geoFeatureLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypePolygon)
            {
                GDisplayLib.IFillSymbol symbol = simpleRender.Symbol["IFillSymbol"] as GDisplayLib.IFillSymbol;
                initFormFillSymbol(symbol);
            }
            else if (_geoFeatureLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypeMultiLineString
                || _geoFeatureLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypeLineString)
            {
                GDisplayLib.ILineSymbol symbol = simpleRender.Symbol["ILineSymbol"] as GDisplayLib.ILineSymbol;
                initFormLineSymbol(symbol);
            }
            else if (_geoFeatureLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypeMultiPoint
                || _geoFeatureLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypePoint)
            {
                GDisplayLib.IPointSymbol symbol = simpleRender.Symbol["IPointSymbol"] as GDisplayLib.IPointSymbol;
                initFormPointSymbol(symbol);
            }
        }

        private void initFormFillSymbol(GDisplayLib.IFillSymbol symbol)
        {
            this.grpFillSymbol.Enabled = true;
            this.grpFillSymbol.Enabled = true;

            this.btnLineColor.BackColor = FormMain.ToColor(symbol.RGBColor);
            this.txtFillSymbolTransparency.Text = symbol.Transparency.ToString();
            this.txtFillSymbolStyle.Text = symbol.Style.ToString();

            this.btnPointColor.BackColor = FormMain.ToColor(symbol.LineSymbol.RGBColor);
            this.txtLineWidth.Text = symbol.LineSymbol.Width.ToString();
            this.txtLineSymbolStyle.Text = symbol.LineSymbol.Style.ToString();
        }

        private void initFormLineSymbol(GDisplayLib.ILineSymbol symbol)
        {
            this.grpFillSymbol.Enabled = true;
            this.btnPointColor.BackColor = FormMain.ToColor(symbol.RGBColor);
            this.txtLineWidth.Text = symbol.Width.ToString();
            this.txtLineSymbolStyle.Text = symbol.Style.ToString();
        }

        private void initFormPointSymbol(GDisplayLib.IPointSymbol symbol)
        {
            this.grpPointSymbol.Enabled = true;
            this.btnFillColor.BackColor = FormMain.ToColor(symbol.RGBColor);
            this.txtPointSize.Text = symbol.Size.ToString();
            this.txtPointSymbolStyle.Text = symbol.Style.ToString();
        }


        private void applyFillSymbol(GDisplayLib.IFillSymbol symbol)
        {
            symbol.RGBColor = FormMain.ToUintRgb(this.btnFillColor.BackColor);
            symbol.Transparency = Convert.ToInt32(this.txtFillSymbolTransparency.Text);

            symbol.LineSymbol.RGBColor = FormMain.ToUintRgb(this.btnLineColor.BackColor);
            symbol.LineSymbol.Width = Convert.ToDouble(this.txtLineWidth.Text);
        }

        private void applyLineSymbol(GDisplayLib.ILineSymbol symbol)
        {
            symbol.RGBColor = FormMain.ToUintRgb(this.btnLineColor.BackColor);
            symbol.Width = Convert.ToDouble(this.txtLineWidth.Text);
        }

        private void applyPointSymbol(GDisplayLib.IPointSymbol symbol)
        {
            symbol.RGBColor = FormMain.ToUintRgb(this.btnPointColor.BackColor);
            symbol.Size = Convert.ToDouble(this.txtPointSize.Text);
        }

        private void FormSimpleRenderer_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.Color = this.btnFillColor.BackColor;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                this.btnFillColor.BackColor = colorDlg.Color;
            }
        }

        private void btnApplySimpleRenderer_Click(object sender, EventArgs e)
        {
            GLayerLib.ISimpleRenderer simpleRender = _geoFeatureLayer.Renderer as GLayerLib.ISimpleRenderer;
            if (simpleRender == null)
            {
                simpleRender = new GLayerLib.SimpleRenderer();
            }

            if (_geoFeatureLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypeMultiPolygon
                || _geoFeatureLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypePolygon)
            {
                GDisplayLib.IFillSymbol symbol = simpleRender.Symbol["IFillSymbol"] as GDisplayLib.IFillSymbol;
                applyFillSymbol(symbol);
            }
            else if (_geoFeatureLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypeMultiLineString
                || _geoFeatureLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypeLineString)
            {
                GDisplayLib.ILineSymbol symbol = simpleRender.Symbol["ILineSymbol"] as GDisplayLib.ILineSymbol;
                applyLineSymbol(symbol);
            }
            else if (_geoFeatureLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypeMultiPoint
                || _geoFeatureLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypePoint)
            {
                GDisplayLib.IPointSymbol symbol = simpleRender.Symbol["IPointSymbol"] as GDisplayLib.IPointSymbol;
                applyPointSymbol(symbol);
            }

            _geoFeatureLayer.Renderer = simpleRender as GLayerLib.IFeatureRenderer;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnLineColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.Color = this.btnLineColor.BackColor;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                this.btnLineColor.BackColor = colorDlg.Color;
            }
        }

        private void btnPointColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.Color = this.btnPointColor.BackColor;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                this.btnPointColor.BackColor = colorDlg.Color;
            }
        }
    }
}
