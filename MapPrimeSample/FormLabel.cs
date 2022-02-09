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
    public partial class FormLabelRenderer : Form
    {
        private GLayerLib.IGeoFeatureLayer _geoFeatureLayer = null;

        public FormLabelRenderer(GLayerLib.IGeoFeatureLayer geoLayer)
        {
            InitializeComponent();


            _geoFeatureLayer = geoLayer;

            this.Text = _geoFeatureLayer.Name;
            this.chkLabel.Checked = _geoFeatureLayer.DisplayAnnotation;
            if (this.chkLabel.Checked == true)
                this.grpLabelRenderer.Enabled = true;
            else
                this.grpLabelRenderer.Enabled = false;

            this.txtFieldName.Text = _geoFeatureLayer.LabelRenderer.Field;
            this.chkAllowDuplicate.Checked = _geoFeatureLayer.LabelRenderer.AllowDuplicate;
            this.chkAvoidCollisions.Checked = _geoFeatureLayer.LabelRenderer.AvoidCollisions;

            GDisplayLib.ITextSymbol symbol = _geoFeatureLayer.LabelRenderer.Symbol as GDisplayLib.ITextSymbol;
            initFormTextSymbol(symbol);
        }

        private void initFormTextSymbol(GDisplayLib.ITextSymbol symbol)
        {
            this.txtFont.Text = symbol.Font.Name;
            this.txtFontSize.Text = symbol.Font.Size.ToString();
            this.chkBold.Checked = symbol.Font.Bold;
            this.chkItalic.Checked = symbol.Font.Italic;
            this.chkUndeline.Checked = symbol.Font.Underline;
            this.txtOffsetX.Text = symbol.XOffset.ToString();
            this.txtOffsetY.Text = symbol.YOffset.ToString();

            this.btnTextFontColor.BackColor = FormMain.ToColor(symbol.RGBColor);

            this.chkBackColor.Checked = symbol.ShowBackground;
            this.btnTextBackColor.BackColor = FormMain.ToColor(symbol.BackgroundSymbol.RGBColor);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnTextFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.Color = this.btnTextFontColor.BackColor;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                this.btnTextFontColor.BackColor = colorDlg.Color;
            }
        }

        private void btnTextBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.Color = this.btnTextBackColor.BackColor;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                this.btnTextBackColor.BackColor = colorDlg.Color;
            }
        }

        private void chkLabel_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkLabel.Checked == true)
            {
                this.grpLabelRenderer.Enabled = true;
                this.chkAllowDuplicate.Checked = true;
                this.chkAvoidCollisions.Checked = true;
            }
            else
                this.grpLabelRenderer.Enabled = false;
        }

        private void applyTextSymbol(GDisplayLib.ITextSymbol symbol)
        {
            symbol.Font.Name = this.txtFont.Text;
            symbol.Font.Size = (decimal)Convert.ToDouble(this.txtFontSize.Text);
            symbol.Font.Bold = this.chkBold.Checked;
            symbol.Font.Italic = this.chkItalic.Checked;
            symbol.Font.Underline = this.chkUndeline.Checked;
            symbol.XOffset = Convert.ToDouble(this.txtOffsetX.Text);
            symbol.YOffset = Convert.ToDouble(this.txtOffsetY.Text);
            symbol.RGBColor = FormMain.ToUintRgb(this.btnTextFontColor.BackColor);
            symbol.ShowBackground = this.chkBackColor.Checked;
            symbol.BackgroundSymbol.RGBColor = FormMain.ToUintRgb(this.btnTextBackColor.BackColor);
        }

        private void btnApplyLabel_Click(object sender, EventArgs e)
        {
            _geoFeatureLayer.DisplayAnnotation = this.chkLabel.Checked;

            _geoFeatureLayer.LabelRenderer.Field = this.txtFieldName.Text;
            _geoFeatureLayer.LabelRenderer.AllowDuplicate = this.chkAllowDuplicate.Checked;
            _geoFeatureLayer.LabelRenderer.AvoidCollisions = this.chkAvoidCollisions.Checked;

            GDisplayLib.ITextSymbol symbol = _geoFeatureLayer.LabelRenderer.Symbol as GDisplayLib.ITextSymbol;
            applyTextSymbol(symbol);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
