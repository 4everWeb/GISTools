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

        private GCommonLib.IGCommand _editNewPointTool;     //포인트 그리기
        private GCommonLib.IGCommand _editNewLineTool;      //라인 그리기
        private GCommonLib.IGCommand _editNewPolygonTool;   //폴리곤 그리기
        private GCommonLib.IGCommand _editSelectFeatureTool; //편집객체선택

        private List<string> _identifyLayerIDList = new List<string>();
        private List<int> _identifyOIDList = new List<int>();

        public static GControlsLib.IEngineEditor EngineEditor;
        public static GDataSourceLib.IEngineOperationStack EngineOperationStack;

    

        public static Color ToColor(uint ucol)
        {
            Color fillColpre = Color.FromArgb((int)ucol);
            return Color.FromArgb(255, fillColpre.B, fillColpre.G, fillColpre.R);
        }

        public static uint ToUintRgb(Color col)
        {
            Color colTmp = Color.FromArgb(0, col.B, col.G, col.R);
            return (uint)colTmp.ToArgb();
        }
        public static Color GetRandomColor()
        {
            byte[] colorByte = new byte[3];
            Random rand = new Random();
            rand.NextBytes(colorByte);
            Color randomColor = Color.FromArgb(255, colorByte[0], colorByte[1], colorByte[2]);
            return randomColor;
        }

        public static uint GetRandomUintRgb()
        {
            Color colTmp = GetRandomColor();
            return (uint)colTmp.ToArgb();
        }

        public static GDisplayLib.IFillSymbol CreateFillSymbol()
        {
            GDisplayLib.IFillSymbol sym = new GDisplayLib.FillSymbol();
            sym.RGBColor = GetRandomUintRgb();
            sym.Transparency = 255;
            sym.Style = GDisplayLib.eFillStyle.eFillStyleBS_SOLID;
            sym.LineSymbol.Style = GDisplayLib.eLineStyle.eLineStylePS_SOLID;
            sym.LineSymbol.Transparency = 255;
            sym.LineSymbol.RGBColor = GetRandomUintRgb();
            sym.LineSymbol.Width = 1;
            sym.LineSymbol.StartCapSize = 0;
            sym.LineSymbol.EndCapSize = 0;
            sym.LineSymbol.DashCapStyle = 0;
            return sym;
        }

        public static GDisplayLib.ILineSymbol CreateLineSymbol()
        {
            GDisplayLib.ILineSymbol sym = new GDisplayLib.LineSymbol();
            sym.RGBColor = GetRandomUintRgb();
            sym.Transparency = 255;
            sym.Style = GDisplayLib.eLineStyle.eLineStylePS_SOLID;
            sym.Width = 1;
            sym.StartCapSize = 0;
            sym.EndCapSize = 0;
            sym.DashCapStyle = 0;
            return sym;
        }

        public static GDisplayLib.IPointSymbol CreatePointSymbol()
        {
            GDisplayLib.IPointSymbol sym = new GDisplayLib.PointSymbol();
            sym.RGBColor = GetRandomUintRgb();
            sym.Transparency = 255;
            sym.Style = GDisplayLib.ePointStyle.ePointStyleCircle;
            sym.Size = 10;
            return sym;
        }

        public static GDisplayLib.ISymbol CreateSymbol(GLayerLib.IGeoFeatureLayer geoFeatureLayer)
        {
            if (geoFeatureLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypeMultiPolygon
                    || geoFeatureLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypePolygon)
            {
                return CreateFillSymbol() as GDisplayLib.ISymbol;
            }
            else if (geoFeatureLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypeMultiLineString
                    || geoFeatureLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypeLineString)
            {
                return CreateLineSymbol() as GDisplayLib.ISymbol;
            }
            else if (geoFeatureLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypeMultiPoint
                    || geoFeatureLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypePoint)
            {
                return CreatePointSymbol() as GDisplayLib.ISymbol;
            }
            else
                return null;
        }

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

            //포인트 그리기
            _editNewPointTool = new GControlsLib.EditNewPointTool() as GCommonLib.IGCommand;
            _editNewPointTool.OnCreate(this.axMapControl1.GetOcx());

            //라인 그리기
            _editNewLineTool = new GControlsLib.EditNewLineTool() as GCommonLib.IGCommand;
            _editNewLineTool.OnCreate(this.axMapControl1.GetOcx());

            //폴리곤 그리기
            _editNewPolygonTool = new GControlsLib.EditNewPolygonTool() as GCommonLib.IGCommand;
            _editNewPolygonTool.OnCreate(this.axMapControl1.GetOcx());

            //편집객체 선택
            _editSelectFeatureTool = new GControlsLib.EditSelectFeatureTool() as GCommonLib.IGCommand;
            _editSelectFeatureTool.OnCreate(this.axMapControl1.GetOcx());

            //엔진에디터
            FormMain.EngineEditor = new GControlsLib.EngineEditor();
            GCommonLib.IExtension ipExtension = (GCommonLib.IExtension)FormMain.EngineEditor;
            ipExtension.Startup(this.axMapControl1.GetOcx());
            GCommonLib.ExtensionManager ipExtensionManager = new GCommonLib.ExtensionManager();
            ipExtensionManager.AddExtension("GControls.EngineEditor", (GCommonLib.Extension)ipExtension);
            this.axMapControl1.ExtensionManager = ipExtensionManager;

        }

        private void listBoxFeatureClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxFeatureClass_DoubleClick(object sender, EventArgs e)
        {

        }

        private GLayerLib.IGeoFeatureLayer gfLayer = null;
        //레이어목록 배경색 변경
        private void listBoxTOC_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBoxTOC.BackColor = Color.White;

            if (this.listBoxTOC.SelectedItems.Count == 1)
            {
                GLayerLib.ILayer layer = this.axMapControl1.get_Layer(this.listBoxTOC.SelectedIndex);
                GLayerLib.IGeoFeatureLayer geoLayer = layer as GLayerLib.IGeoFeatureLayer;

                gfLayer = geoLayer;

                GLayerLib.ISimpleRenderer simpleRender = gfLayer.Renderer as GLayerLib.ISimpleRenderer;
                if (simpleRender == null)
                {
                    simpleRender = new GLayerLib.SimpleRenderer();
                    GDisplayLib.ISymbol crtSymbol = FormMain.CreateSymbol(gfLayer);
                    simpleRender.Symbol["ISymbol"] = crtSymbol;
                }

                if (gfLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypeMultiPolygon
                    || gfLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypePolygon)
                {
                    GDisplayLib.IFillSymbol symbol = simpleRender.Symbol["IFillSymbol"] as GDisplayLib.IFillSymbol;
                    this.listBoxTOC.BackColor = FormMain.ToColor(symbol.LineSymbol.RGBColor);
                }
                else if (gfLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypeMultiLineString
                    || gfLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypeLineString)
                {
                    GDisplayLib.ILineSymbol symbol = simpleRender.Symbol["ILineSymbol"] as GDisplayLib.ILineSymbol;
                    this.listBoxTOC.BackColor = FormMain.ToColor(symbol.RGBColor);
                }
                else if (gfLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypeMultiPoint
                        || gfLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypePoint)
                {
                    GDisplayLib.IPointSymbol symbol = simpleRender.Symbol["IPointSymbol"] as GDisplayLib.IPointSymbol;
                    this.listBoxTOC.BackColor = FormMain.ToColor(symbol.RGBColor);
                }
            }
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

            for (int c = 0; c < feature.Fields.FieldCount; c++)
            {
                if (feature.Fields.Field[c].Type != GDataSourceLib.eFieldType.eFieldTypeBlob
                    && feature.Fields.Field[c].Type != GDataSourceLib.eFieldType.eFieldTypeGeometry)
                {
                    this.dataGridView1.Columns.Add(feature.Fields.Field[c].Name, feature.Fields.Field[c].Name);
                }
            }

            while (feature != null)
            {
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

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

      
        private void Property_Click(object sender, EventArgs e)
        {
            if (this.listBoxTOC.SelectedItems.Count != 1)
            {
                MessageBox.Show("먼저, 레이어목록에서 한개의 레이어를 선택하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GLayerLib.ILayer layer = this.axMapControl1.get_Layer(this.listBoxTOC.SelectedIndex);
            FormLayerProperty frmLayerProp = new FormLayerProperty(layer, this.axMapControl1);

            frmLayerProp.ShowDialog(this);
        }

     
        private void listBoxIdentifyList_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void toolEditAttribute_Click(object sender, EventArgs e)
        {

        }

        private void toolEditStart_Click(object sender, EventArgs e)
        {
            if (FormMain.EngineEditor.EditState == GControlsLib.EngineEditState.eEngineStateEditing)
            {
                string errmsg = "기존 편집을 먼저 종료해주세요.";
                MessageBox.Show(errmsg, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.txtShapeFileDirectory.Tag == null)
            {
                string errmsg = "Shape 파일 디렉토리를 선택을 해주세요.";
                MessageBox.Show(errmsg, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GDataSourceLib.IDataSource dataSource = this.txtShapeFileDirectory.Tag as GDataSourceLib.IDataSource;
            FormMain.EngineEditor.StartEditing(dataSource, this.axMapControl1.GetOcx() as GMapLib.MapControl);
            FormMain.EngineEditor.StartOperation();
            FormMain.EngineOperationStack = dataSource as GDataSourceLib.IEngineOperationStack;
        }

        private void toolEditStopSave_Click(object sender, EventArgs e)
        {
            if (FormMain.EngineEditor.EditState != GControlsLib.EngineEditState.eEngineStateEditing)
            {
                string errmsg = "편집 상태가 아닙니다. ";
                MessageBox.Show(errmsg, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormMain.EngineEditor.StopOperation("");
            FormMain.EngineEditor.StopEditing(true);
            FormMain.EngineOperationStack.Reset();
            this.axMapControl1.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerAll);
        }

        private void toolEditStopCancel_Click(object sender, EventArgs e)
        {
            if (FormMain.EngineEditor.EditState != GControlsLib.EngineEditState.eEngineStateEditing)
            {
                string errmsg = "편집 상태가 아닙니다. ";
                MessageBox.Show(errmsg, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormMain.EngineEditor.StopOperation("");
            FormMain.EngineEditor.StopEditing(false);
            FormMain.EngineOperationStack.Reset();
            System.Threading.Thread.Sleep(1000);
            this.axMapControl1.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerAll);
        }

        private void toolAddObject_Click_1(object sender, EventArgs e)
        {
            if (FormMain.EngineEditor.EditState != GControlsLib.EngineEditState.eEngineStateEditing)
            {
                string errmsg = "편집 상태가 아닙니다. ";
                MessageBox.Show(errmsg, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.listBoxTOC.SelectedItems.Count != 1)
            {
                MessageBox.Show("먼저, 레이어목록에서 한개의 레이어를 선택하세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GLayerLib.ILayer layer = this.axMapControl1.get_Layer(this.listBoxTOC.SelectedIndex);

            GControlsLib.IEngineEditLayers editLayers = FormMain.EngineEditor as GControlsLib.IEngineEditLayers;
            editLayers.TargetLayer = layer as GLayerLib.FeatureLayer;

            GControlsLib.IEngineEditTask task = FormMain.EngineEditor.GetTaskByUniqueName("Custom.EditorInsertObjectTask");
            if (task == null)
            {
                task = new EditorInsertObjectTask() as GControlsLib.IEngineEditTask;
                FormMain.EngineEditor.AddTask(task);
            }
            FormMain.EngineEditor.CurrentTask = task;

            if (editLayers.TargetLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypePoint
                        || editLayers.TargetLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypeMultiPoint)
            {
                this.axMapControl1.CurrentTool = _editNewPointTool as GCommonLib.Tool;
            }
            else if (editLayers.TargetLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypeLineString
                || editLayers.TargetLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypeMultiLineString)
            {
                this.axMapControl1.CurrentTool = _editNewLineTool as GCommonLib.Tool;
            }
            else if (editLayers.TargetLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypePolygon
                || editLayers.TargetLayer.FeatureClass.GeometryType == GGeometryLib.eGeometryType.eGeometryTypeMultiPolygon)
            {
                this.axMapControl1.CurrentTool = _editNewPolygonTool as GCommonLib.Tool;
            }
        }

        private void toolDeleteObjects_Click(object sender, EventArgs e)
        {
            if (FormMain.EngineEditor.EditState != GControlsLib.EngineEditState.eEngineStateEditing)
            {
                string errmsg = "편집 상태가 아닙니다. ";
                MessageBox.Show(errmsg, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GLayerLib.IFeatureLayer selectedFeatureLayer = GetSelectedLayer() as GLayerLib.IFeatureLayer;
            if (selectedFeatureLayer == null)
            {
                string errmsg = "선택된 객체가 없습니다. ";
                MessageBox.Show(errmsg, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GLayerLib.IFeatureSelection featureSelection = selectedFeatureLayer as GLayerLib.IFeatureSelection;
            

            GDataSourceLib.IEnumFeature features = featureSelection.SelectedFeatures;

            features.Reset();
            GDataSourceLib.Feature feature = features.Next();

            string grpID;
            FormMain.EngineOperationStack.StartGroup("Delete", out grpID);

            while (feature != null)
            {
                feature.Delete();
                feature = features.Next();
            }

            FormMain.EngineOperationStack.StopGroup();

            featureSelection.Selection.Clear();
            this.axMapControl1.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerAll);

        }

    }
}


