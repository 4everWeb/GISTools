using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MapPrimeSample
{
    [Guid("7f5f3115-4259-48c2-9bea-6591e759e982")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("Controls.CreateTask")]
    public class EditorUpdateObjectTask : GControlsLib.IEngineEditTask2
    {
        protected string m_sName = "EditorUpdateObjectTask";
        protected string m_sUniqueName = "Custom.EditorUpdateObjectTask";
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

        public void OnFinishSketch()
        {
            GDataSourceLib.IEnumFeature features = _eEditor.EditSelection;
            features.Reset();
            GDataSourceLib.Feature feature = features.Next();

            string grpID;
            FormMain.EngineOperationStack.StartGroup("Store", out grpID);
            feature.Store();
            FormMain.EngineOperationStack.StopGroup();

            _eEditor.Map.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerAll);
        }
        public void OnDeleteSketch()
        {
        }


        public void OnPasteFeatures(GDataSourceLib.IEnumFeature feature)
        {
        }

        public void OnFinishSelect()
        {
            _eEditor.Map.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerGeoSelection);
        }

        public void OnCommand(string Command)
        {
        }

        public void OnKeyDown(int keyCode, int Shift)
        {
        }

        public void OnUpdateFeatures(GDataSourceLib.IEnumFeature features)
        {
            features.Reset();
            GDataSourceLib.Feature feature = features.Next();

            string grpID;
            FormMain.EngineOperationStack.StartGroup("Store", out grpID);

            while (feature != null)
            {
                feature.Store();
                feature = features.Next();
            }
            FormMain.EngineOperationStack.StopGroup();

            _eEditor.Map.Refresh(GCommonLib.eViewDrawLayer.eViewDrawLayerAll);
        }

    }
}

