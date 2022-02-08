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
        private GCommonLib.IGCommand _zoomInTool;
        private GCommonLib.IGCommand _zoomOutTool;
        private GCommonLib.IGCommand _panTool;
        private GCommonLib.IGCommand _selectFeaturesTool;
        private GCommonLib.IGCommand _identifyTool;
        private GCommonLib.IGCommand _measureDistance;
        private GCommonLib.IGCommand _measureArea;

        private List<string> _identifyLayerIDList = new List<string>();
        private List<int> _identifyOIDList = new List<int>();


        public FormMain()
        {
            InitializeComponent();

            //지도확대
            _zoomInTool = new GControlsLib.ZoomInTool() as GCommonLib.IGCommand;
            _zoomInTool.OnCreate(this.axMapControl1.GetOcx());

            //지도축소
            _zoomOutTool = new GControlsLib.ZoomOutTool() as GCommonLib.IGCommand;
            _zoomOutTool.OnCreate(this.axMapControl1.GetOcx());

            //지도이동
            _panTool = new GControlsLib.PanTool() as GCommonLib.IGCommand;
            _panTool.OnCreate(this.axMapControl1.GetOcx());

            //객체선택
            _selectFeaturesTool = new GControlsLib.SelectFeaturesTool() as GCommonLib.IGCommand;
            _selectFeaturesTool.OnCreate(this.axMapControl1.GetOcx());

            //객체확인
            _identifyTool = new GControlsLib.IdentifyTool() as GCommonLib.IGCommand;
            _identifyTool.OnCreate(this.axMapControl1.GetOcx());

            //거리계산
            _measureDistance = new GControlsLib.MeasureDistance() as GCommonLib.IGCommand;
            _measureDistance.OnCreate(this.axMapControl1.GetOcx());

            //면적계산
            _measureArea = new GControlsLib.MeasureArea() as GCommonLib.IGCommand;
            _measureArea.OnCreate(this.axMapControl1.GetOcx());

          
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

        /*        private void listBoxTOC_DoubleClick(object sender, EventArgs e)
                {

                    string className = this.listBoxTOC.SelectedItem.ToString();
                    int deleteIndex = this.listBoxTOC.Items.IndexOf(className);

                    this.axMapControl1.DeleteLayer(deleteIndex);
                    this.axMapControl1.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerAll);
                    refreshLayerList();
                }*/

        private void listBoxTOC_DoubleClick(object sender, EventArgs e)
        {
            //this.axMapControl.DeleteLayer(this.listBoxTOC.SelectedIndex);
            //this.axMapControl.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerAll);
            //refreshLayerList();

            if (this.listBoxTOC.SelectedItems.Count == 0) return;

            int cnt = 0;
            double minX = 0.0;
            double minY = 0.0;
            double maxX = 0.0;
            double maxY = 0.0;
            GSpatialReferenceLib.ISpatialReference spRef = this.axMapControl1.SpatialReference;

            GLayerLib.ILayer layer = this.axMapControl1.get_Layer(this.listBoxTOC.SelectedIndex);

            if (layer is GLayerLib.IGroupLayer)
            {
                cnt = zoomFitGroupLayer(layer as GLayerLib.IGroupLayer, spRef, cnt, ref minX, ref minY, ref maxX, ref maxY);
            }
            else
            {
                cnt = zoomFitLayer(layer, spRef, cnt, ref minX, ref minY, ref maxX, ref maxY);
            }

            if (cnt > 0)
            {
                GGeometryLib.Envelope env = new GGeometryLib.Envelope();
                env.MinX = minX;
                env.MinY = minY;
                env.MaxX = maxX;
                env.MaxY = maxY;
                env.Expand(1.2, 1.2, true);
                this.axMapControl1.Extent = env;
                this.axMapControl1.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerAll);
            }
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

        //전체보기
        private void toolZoomFit_Click(object sender, EventArgs e)
        {
            if (this.axMapControl1.LayerCount == 0) return;

            int cnt = 0;
            double minX = 0.0;
            double minY = 0.0;
            double maxX = 0.0;
            double maxY = 0.0;
            GSpatialReferenceLib.ISpatialReference spRef = this.axMapControl1.SpatialReference;

            for (int k = 0; k < this.axMapControl1.LayerCount; k++)
            {
                if (this.axMapControl1.get_Layer(k) is GLayerLib.IGroupLayer)
                {
                    cnt = zoomFitGroupLayer(this.axMapControl1.get_Layer(k) as GLayerLib.IGroupLayer, spRef, cnt, ref minX, ref minY, ref maxX, ref maxY);
                }
                else
                {
                    cnt = zoomFitLayer(this.axMapControl1.get_Layer(k) as GLayerLib.ILayer, spRef, cnt, ref minX, ref minY, ref maxX, ref maxY);
                }
            }

            if (cnt > 0)
            {
                GGeometryLib.Envelope env = new GGeometryLib.Envelope();
                env.MinX = minX;
                env.MinY = minY;
                env.MaxX = maxX;
                env.MaxY = maxY;
                env.Expand(1.2, 1.2, true);
                this.axMapControl1.Extent = env;
                this.axMapControl1.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerAll);
            }
        }

        private void toolZoomIn_Click(object sender, EventArgs e)
        {
            this.axMapControl1.CurrentTool = _zoomInTool as GCommonLib.Tool;
        }

        private void toolZoomOut_Click(object sender, EventArgs e)
        {
            this.axMapControl1.CurrentTool = _zoomOutTool as GCommonLib.Tool;
        }

        private void toolMapPanning_Click(object sender, EventArgs e)
        {
            this.axMapControl1.CurrentTool = _panTool as GCommonLib.Tool;
        }

        private void toolSelectObjects_Click(object sender, EventArgs e)
        {
            this.axMapControl1.CurrentTool = _selectFeaturesTool as GCommonLib.Tool;
        }

        private void toolCancelSelectObjects_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.axMapControl1.LayerCount; i++)
            {
                GLayerLib.ILayer layer = this.axMapControl1.get_Layer(i);

                if (layer is GLayerLib.IFeatureLayer)
                {
                    GLayerLib.IFeatureSelection fselection = layer as GLayerLib.IFeatureSelection;
                    if (fselection != null)
                    {
                        if (fselection.Selection != null)
                            fselection.Selection.Clear();
                    }
                }
            }

            this.axMapControl1.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerGeoSelection);
        }

        private void toolIdentify_Click(object sender, EventArgs e)
        {
            GControlsLib.IdentifyTool identify = _identifyTool as GControlsLib.IdentifyTool;
            identify.mode = GControlsLib.eIdentifyMode.eIdentifyModeAll;
            this.axMapControl1.CurrentTool = identify as GCommonLib.Tool;
        }

        private void toolCalculateDistance_Click(object sender, EventArgs e)
        {
            this.axMapControl1.CurrentTool = _measureDistance as GCommonLib.Tool;
        }

        private void toolCalculateArea_Click(object sender, EventArgs e)
        {
            this.axMapControl1.CurrentTool = _measureArea as GCommonLib.Tool;
        }

        private void toolClearMap_Click(object sender, EventArgs e)
        {
            GElementsLib.IGraphicsContainer gContainer = this.axMapControl1.BaseGraphicsLayer as GElementsLib.IGraphicsContainer;
            gContainer.DeleteAllElements();
            this.axMapControl1.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerGeoSelection);
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

        private void listBoxIdentifyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtProperty.Text = "";

            if (this.listBoxIdentifyList.SelectedItem == null)
                return;

            int idx = this.listBoxIdentifyList.SelectedIndex;
            string layerID = _identifyLayerIDList[idx];
            int oid = _identifyOIDList[idx];

            GLayerLib.IFeatureLayer featureLayer = GetLayer(layerID) as GLayerLib.IFeatureLayer;
            if (featureLayer == null)
                return;

            GDataSourceLib.Feature feature = featureLayer.FeatureClass.GetFeature(oid);
            if (feature == null)
                return;

            for (int c = 0; c < feature.Fields.FieldCount; c++)
            {
                if (feature.Fields.Field[c].Type == GDataSourceLib.eFieldType.eFieldTypeBlob
                    || feature.Fields.Field[c].Type == GDataSourceLib.eFieldType.eFieldTypeGeometry)
                    continue;

                if (feature.Value[c] == null)
                    continue;

                string str = "[" + feature.Fields.Field[c].Name + "] " + feature.Value[c].ToString();
                this.txtProperty.AppendText(str + "\r\n");
            }
        }

        private void axMapControl_OnMouseUp(object sender, AxGMapLib.IMapControlEvents_OnMouseUpEvent e)
        {
            if (e.button == 1)
            {
                if (this.axMapControl1.CurrentTool is GControlsLib.SelectFeaturesTool
                    || this.axMapControl1.CurrentTool is GControlsLib.EditSelectFeatureTool)
                {
                    GLayerLib.IFeatureLayer selectedFeatureLayer = GetSelectedLayer();
                    if (selectedFeatureLayer == null)
                    {
                        this.dataGridView1.Rows.Clear();
                        this.dataGridView1.Columns.Clear();
                    }
                    else
                    {
                        this.dataGridView1.Rows.Clear();
                        this.dataGridView1.Columns.Clear();
                        outputSelectedObjects(selectedFeatureLayer);
                    }
                }
                else if (this.axMapControl1.CurrentTool is GControlsLib.IdentifyTool)
                {
                    this.axMapControl1.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerGeoSelection);
                    outputIdentify();
                }
            }
        }

 



        private void outputIdentify()
        {
            this.listBoxIdentifyList.Items.Clear();
            _identifyLayerIDList.Clear();
            _identifyOIDList.Clear();

            for (int i = 0; i < this.axMapControl1.LayerCount; i++)
            {
                GLayerLib.ILayer layer = this.axMapControl1.get_Layer(i);
                if (layer is GLayerLib.IFeatureLayer)
                {
                    GLayerLib.IFeatureIdentify featureIdentify = layer as GLayerLib.IFeatureIdentify;
                    if (featureIdentify != null)
                    {
                        if (featureIdentify.Identify != null)
                        {
                            if (featureIdentify.Identify.Count > 0)
                            {
                                for (int n = 0; n < featureIdentify.Identify.Count; n++)
                                {
                                    int oid = featureIdentify.Identify.GetID(n);
                                    string str = "[Layer] " + layer.Name + " [OID] " + oid.ToString();
                                    this.listBoxIdentifyList.Items.Add(str);
                                    _identifyLayerIDList.Add(layer.LayerID);
                                    _identifyOIDList.Add(oid);
                                }
                            }
                        }
                    }
                }
            }
        }

        public GLayerLib.ILayer GetLayer(string layerID)
        {
            for (int i = 0; i < this.axMapControl1.LayerCount; i++)
            {
                GLayerLib.ILayer layer = this.axMapControl1.get_Layer(i);
                if (layer.LayerID == layerID)
                    return layer;
            }
            return null;
        }


        //선택된 레이어를 반환
        public GLayerLib.IFeatureLayer GetSelectedLayer()
        {
            for (int i = 0; i < this.axMapControl1.LayerCount; i++)
            {
                GLayerLib.ILayer layer = this.axMapControl1.get_Layer(i);

                if (layer is GLayerLib.IFeatureLayer)
                {
                    GLayerLib.IFeatureSelection fSelection = layer as GLayerLib.IFeatureSelection;
                    if (fSelection != null)
                    {
                        if (fSelection.Selection != null)
                        {
                            if (fSelection.Selection.Count > 0)
                            {
                                return layer as GLayerLib.IFeatureLayer;
                            }
                        }
                    }
                }
            }
            return null;
        }

        private void outputSelectedObjects(GLayerLib.IFeatureLayer selectedFeatureLayer)
        {
            GLayerLib.IFeatureSelection fSelection = selectedFeatureLayer as GLayerLib.IFeatureSelection;
            GDataSourceLib.IEnumFeature features = fSelection.SelectedFeatures;
            features.Reset();
            GDataSourceLib.Feature feature = features.Next();
            while (feature != null)
            {

                for (int c = 0; c < feature.Fields.FieldCount; c++)
                {
                    if (feature.Fields.Field[c].Type != GDataSourceLib.eFieldType.eFieldTypeBlob
                        && feature.Fields.Field[c].Type != GDataSourceLib.eFieldType.eFieldTypeGeometry)
                    {
                        this.dataGridView1.Columns.Add(feature.Fields.Field[c].Name, feature.Fields.Field[c].Name);
                    }
                }

                this.dataGridView1.Rows.Add(1);
                for (int c = 0; c < feature.Fields.FieldCount; c++)
                {
                    if (feature.Fields.Field[c].Type != GDataSourceLib.eFieldType.eFieldTypeBlob
                        && feature.Fields.Field[c].Type != GDataSourceLib.eFieldType.eFieldTypeGeometry)
                    {
                        if (feature.Value[c] != null)
                            this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[feature.Fields.Field[c].Name].Value = feature.Value[c].ToString();
                    }
                }

                feature = features.Next();
            }
        }


        private int zoomFitGroupLayer(GLayerLib.IGroupLayer grpLayer, GSpatialReferenceLib.ISpatialReference spRef, int cnt, ref double minX, ref double minY, ref double maxX, ref double maxY)
        {
            for (int g = 0; g < grpLayer.LayerCount; g++)
            {
                if (grpLayer.Layer[g] is GLayerLib.IGroupLayer)
                {
                    cnt = zoomFitGroupLayer(grpLayer.Layer[g] as GLayerLib.IGroupLayer, spRef, cnt, ref minX, ref minY, ref maxX, ref maxY);
                }
                else
                {
                    cnt = zoomFitLayer(grpLayer.Layer[g] as GLayerLib.ILayer, spRef, cnt, ref minX, ref minY, ref maxX, ref maxY);
                }
            }
            return cnt;
        }

        private int zoomFitLayer(GLayerLib.ILayer layer, GSpatialReferenceLib.ISpatialReference spRef, int cnt, ref double minX, ref double minY, ref double maxX, ref double maxY)
        {
            GGeometryLib.IEnvelope lyrExtent = layer.Extent.Project(spRef) as GGeometryLib.IEnvelope;
            if (cnt == 0)
            {
                minX = lyrExtent.MinX;
                minY = lyrExtent.MinY;
                maxX = lyrExtent.MaxX;
                maxY = lyrExtent.MaxY;
            }
            else
            {
                if (minX > lyrExtent.MinX)
                    minX = lyrExtent.MinX;
                if (minY > lyrExtent.MinY)
                    minY = lyrExtent.MinY;
                if (maxX < lyrExtent.MaxX)
                    maxX = lyrExtent.MaxX;
                if (maxY < lyrExtent.MaxY)
                    maxY = lyrExtent.MaxY;
            }
            cnt++;
            return cnt;
        }

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

        private void listBoxSelectedObjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
