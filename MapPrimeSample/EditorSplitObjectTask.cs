using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MapPrimeSample
{
    [Guid("52055a7d-dd5a-4974-afc2-c8f4beafb2ce")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("Controls.CreateTask")]
    public class EditorSplitObjectTask : GControlsLib.IEngineEditTask2
    {
        protected string m_sName = "EditorInsertObjectTask";
        protected string m_sUniqueName = "Custom.EditorInsertObjectTask";
        protected string m_sGroupName = "CustomTask";

        GControlsLib.IEngineEditor _eEditor = null;
        GControlsLib.IEngineEditTask _eEditOldTask = null;

        public string Name
        {
            get { return m_sName; }
            set { m_sName = value; }
        }

        public string UniqueName
        {
            get { return m_sUniqueName; }
            set { m_sUniqueName = value; }
        }

        public string GroupName
        {
            get { return m_sGroupName; }
            set { m_sGroupName = value; }
        }

        public void Activate(GControlsLib.EngineEditor editor, GControlsLib.IEngineEditTask oldTask)
        {
            if (editor == null)
                return;

            _eEditor = (GControlsLib.IEngineEditor)editor;

            if (oldTask != null)
                _eEditOldTask = (GControlsLib.IEngineEditTask)oldTask;
        }

        public void Deactivate()
        {
            _eEditor = null;
            _eEditOldTask = null;
        }
        private List<GDataSourceLib.Feature> GetSelectedFeatureList(GLayerLib.IFeatureLayer selectedFeatureLayer)
        {
            GLayerLib.IFeatureSelection featureSelection = selectedFeatureLayer as GLayerLib.IFeatureSelection;

            GDataSourceLib.IEnumFeature features = featureSelection.SelectedFeatures;
            features.Reset();
            GDataSourceLib.Feature feature = features.Next();

            List<GDataSourceLib.Feature> featureList = new List<GDataSourceLib.Feature>();
            while (feature != null)
            {
                featureList.Add(feature);
                feature = features.Next();
            }

            featureSelection.Selection.Clear();
            return featureList;
        }

        public void OnFinishSketch()
        {
            GLayerLib.IFeatureLayer selectedFeatureLayer = getSelectedFeatureLayer();
            if (selectedFeatureLayer == null)
                return;

            List<GDataSourceLib.Feature> selectedFeature = GetSelectedFeatureList(selectedFeatureLayer);
            if (selectedFeature == null)
                return;

            GControlsLib.IEngineEditSketch eEditSketch = (GControlsLib.IEngineEditSketch)_eEditor;
            GGeometryLib.ILineString line = eEditSketch.Geometry as GGeometryLib.ILineString;


            for(int i=0; i< selectedFeature.Count; i++) { 

            GGeometryLib.IGeometryCollection splitGeomCollection = AppGeometry.MakeSplitMultiGoemetry(selectedFeature[i].Geometry, line);
            if (splitGeomCollection.NumGeometries < 2)
            {
                _eEditor.Map.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerAll);
                MessageBox.Show("분할실패");
                return;
            }

            string grpID;
            FormMain.EngineOperationStack.StartGroup("Split", out grpID);

            for (int j = 0; j < splitGeomCollection.NumGeometries; j++)
            {
                GDataSourceLib.Feature newFeature = selectedFeatureLayer.FeatureClass.CreateFeature();
                newFeature.Geometry = splitGeomCollection.Geometry[j];
                selectedFeatureLayer.FeatureClass.InsertFeature(newFeature);
            }

            selectedFeature[i].Delete();

            FormMain.EngineOperationStack.StopGroup();
            }

            _eEditor.Map.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerAll);
        }

        public void OnDeleteSketch()
        {
        }

        public void OnPasteSketch()
        {
        }

        public void OnPasteFeatures(GDataSourceLib.IEnumFeature feature)
        {
        }

        public void OnFinishSelect()
        {
        }

        public void OnCommand(string Command)
        {
        }

        public void OnKeyDown(int keyCode, int Shift)
        {
        }

        public void OnUpdateFeatures(GDataSourceLib.IEnumFeature features)
        {
        }
        private GLayerLib.IFeatureLayer getSelectedFeatureLayer()
        {
            GLayerLib.IFeatureLayer selectedFeatureLayer = null;
            for (int i = 0; i < _eEditor.Map.LayerCount; i++)
            {
                GLayerLib.ILayer layer = _eEditor.Map.get_Layer(i);

                if (layer is GLayerLib.IFeatureLayer)
                {
                    GLayerLib.IFeatureSelection fSelection = layer as GLayerLib.IFeatureSelection;
                    if (fSelection != null)
                    {
                        if (fSelection.Selection != null)
                        {
                            if (fSelection.Selection.Count > 0)
                            {
                                selectedFeatureLayer = layer as GLayerLib.IFeatureLayer;
                            }
                        }
                    }
                }
            }
            if (selectedFeatureLayer == null)
            {
                _eEditor.Map.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerAll);
                MessageBox.Show("선택된 객체가 없습니다.");
                return null;
            }
            return selectedFeatureLayer;
        }

        
    }
}