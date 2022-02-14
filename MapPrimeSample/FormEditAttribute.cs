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
    public partial class FormEditAttribute : Form
    {
        private GDataSourceLib.Feature _feature = null;
        public FormEditAttribute(GDataSourceLib.Feature feature)
        {
            InitializeComponent();
            _feature = feature;
            refreshAttribute();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int r = 0; r < this.dataGridView1.Rows.Count; r++)
            {
                string fieldName = this.dataGridView1.Rows[r].Cells["FieldName"].Value.ToString();
                int idx = _feature.Fields.FindField(fieldName);
                _feature.Value[idx] = this.dataGridView1.Rows[r].Cells["FieldValue"].Value;
            }

            string grpID;
            FormMain.EngineOperationStack.StartGroup("Store", out grpID);
            _feature.Store();
            FormMain.EngineOperationStack.StopGroup();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void refreshAttribute()
        {
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Columns.Clear();

            this.dataGridView1.Columns.Add("FieldName", "필드명");
            this.dataGridView1.Columns.Add("FieldValue", "값");
            this.dataGridView1.Columns["FieldValue"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            int r = -1;
            for (int c = 0; c < _feature.Fields.FieldCount; c++)
            {
                if (_feature.Fields.Field[c].Type != GDataSourceLib.eFieldType.eFieldTypeBlob &&
                    _feature.Fields.Field[c].Type != GDataSourceLib.eFieldType.eFieldTypeGeometry &&
                    _feature.Fields.Field[c].Type != GDataSourceLib.eFieldType.eFieldTypeDate &&
                    _feature.Fields.Field[c].Type != GDataSourceLib.eFieldType.eFieldTypeOID)
                {
                    r++;
                    this.dataGridView1.Rows.Add(1);
                    this.dataGridView1.Rows[r].Cells["FieldName"].Value = _feature.Fields.Field[c].Name;

                    if (_feature.Value[c] != null)
                        this.dataGridView1.Rows[r].Cells["FieldValue"].Value = _feature.Value[c];
                }
            }
        }



    }
}
