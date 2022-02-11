using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapPrimeSample
{

    

   // [Guid("1CFD3E53-5194-48AB-8D44-426B2A79822F")]
    [Guid("e86aeb57-9a7b-48e1-9986-9d0b7645eabe")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("Controls.CreateTask")]

    public class EditorInsertObjectTask : GControlsLib.IEngineEditTask2
    {
        protected string m_sName = "EditorInsertObjectTask";
        protected string m_sUniqueName = "Custom.EditorInsertObjectTask";
        protected string m_sGroupName = "CustomTask";

        //Guid 생성
        //Guid new_guid = Guid.NewGuid();
        //new_guid.ToString()

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

        public void OnFinishSketch()
        {
            GControlsLib.IEngineEditSketch eEditSketch = (GControlsLib.IEngineEditSketch)_eEditor;
            GControlsLib.IEngineEditLayers editLayers = _eEditor as GControlsLib.IEngineEditLayers;

            var feature = editLayers.TargetLayer.FeatureClass.CreateFeature();
            feature.Geometry = eEditSketch.Geometry;

            string grpID;
            FormMain.EngineOperationStack.StartGroup("InsertFeature", out grpID);
            editLayers.TargetLayer.FeatureClass.InsertFeature(feature);
            FormMain.EngineOperationStack.StopGroup();

            _eEditor.Map.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerAll);
        }

    }

}
