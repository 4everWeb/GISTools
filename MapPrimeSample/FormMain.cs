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
    public partial class FormMain : Form
    {

        private void refreshLayerList()
        {
            this.listBoxTOC.Items.Clear();
            for (int i = 0; i < this.axMapControl1.LayerCount; i++)
            {
                GLayerLib.ILayer layer = this.axMapControl1.get_Layer(i);
                this.listBoxTOC.Items.Add(layer.Name);
            }
        }

        private GLayerLib.IFeatureLayer createFeatureLayer(GDataSourceLib.IFeatureClass featureClass, string layerName)
        {
            GLayerLib.IFeatureLayer newFeatureLayer = new GLayerLib.FeatureLayer();
            newFeatureLayer.FeatureClass = featureClass;
            newFeatureLayer.Name = layerName;
            newFeatureLayer.LayerID = Guid.NewGuid().ToString();
            newFeatureLayer.MinimumScale = 0.0;
            newFeatureLayer.MaximumScale = 1000000000000;
            return newFeatureLayer;
        }

        private GDataSourceLib.IFeatureClass openFeatureClass(GDataSourceLib.IDataSource dataSource, string className)
        {
            GDataSourceLib.IFeatureClass featureClass = dataSource.OpenFeatureClass(className);
            if (featureClass == null)
                throw new ArgumentException("featureClass == null");

            return featureClass;
        }

        private GDataSourceLib.IDataSource openShapeDirectory(string path)
        {
            GDataSourceLib.IDataSource dataSource = (GDataSourceLib.IDataSource)new GDataSourceLib.ShapeDataSource();
            GCommonLib.Properties pProp = new GCommonLib.Properties();
            pProp.SetProperty("PATH", path + "\\");

            bool isOpen = dataSource.Open(pProp);
            if (isOpen == false)
                return null;

            return dataSource;
        }



        public FormMain()
        {
            InitializeComponent();
        }

        private void listBoxFeatureClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxFeatureClass_DoubleClick(object sender, EventArgs e)
        {

        }

        private void listBoxTOC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxTOC_DoubleClick(object sender, EventArgs e)
        {

            string className = this.listBoxTOC.SelectedItem.ToString();
            int deleteIndex = this.listBoxTOC.Items.IndexOf(className);

            this.axMapControl1.DeleteLayer(deleteIndex);
            this.axMapControl1.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerAll);
            refreshLayerList();
        }

        private void toolRefershLayerList_Click(object sender, EventArgs e)
        {
            refreshLayerList();
        }

        private void toolRemoveAllLayer_Click(object sender, EventArgs e)
        {
            this.axMapControl1.ClearLayers();
            this.axMapControl1.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerAll);
            refreshLayerList();
        }

        private void toolZoomFit_Click(object sender, EventArgs e)
        {

        }

        private void toolZoomIn_Click(object sender, EventArgs e)
        {

        }

        private void toolZoomOut_Click(object sender, EventArgs e)
        {

        }

        private void toolMapPanning_Click(object sender, EventArgs e)
        {

        }

        private void toolSelectObjects_Click(object sender, EventArgs e)
        {

        }

        private void toolCancelSelectObjects_Click(object sender, EventArgs e)
        {

        }

        private void toolIdentify_Click(object sender, EventArgs e)
        {

        }

        private void toolCalculateDistance_Click(object sender, EventArgs e)
        {

        }

        private void toolCalculateArea_Click(object sender, EventArgs e)
        {

        }

        private void toolClearMap_Click(object sender, EventArgs e)
        {

        }

        private void btnConnectionGISServer_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenShapeDataSource_Click(object sender, EventArgs e)
        {
            this.listBoxShapeFileList.Items.Clear();

            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                GDataSourceLib.IDataSource dataSource = openShapeDirectory(dlg.SelectedPath);
                if (dataSource == null)
                    throw new ArgumentException("DataSource Open 실패");
                else
                {
                    this.txtShapeFileDirectory.Text = dataSource.PathName;
                    this.txtShapeFileDirectory.Tag = dataSource;

                    System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(dataSource.PathName);
                    System.IO.FileInfo[] fis = di.GetFiles();
                    for (int f = 0; f < fis.Length; f++)
                    {
                        if (fis[f].Extension.ToUpper() == ".SHP")
                        {
                            string className = fis[f].Name.Replace(fis[f].Extension, "");
                            this.listBoxShapeFileList.Items.Add(className);
                        }
                    }
                }
            }
        }

        private void listBoxShapeFileList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxShapeFileList_DoubleClick(object sender, EventArgs e)
        {
            string className = this.listBoxShapeFileList.SelectedItem.ToString();
            GDataSourceLib.IDataSource dataSource = this.txtShapeFileDirectory.Tag as GDataSourceLib.IDataSource;
            GDataSourceLib.IFeatureClass featureClass = openFeatureClass(dataSource, className);
            string layerName = className;
            GLayerLib.IFeatureLayer featureLayer = createFeatureLayer(featureClass, layerName);
            this.axMapControl1.AddLayer(featureLayer);
            this.axMapControl1.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerAll);
            refreshLayerList();
        }

    }
}
