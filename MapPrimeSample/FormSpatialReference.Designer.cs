
namespace MapPrimeSample
{
    partial class FormSpatialReference
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpSpatialReference = new System.Windows.Forms.GroupBox();
            this.btnApplySpatialReference = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSrtext = new System.Windows.Forms.TextBox();
            this.grpSpatialReference.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSpatialReference
            // 
            this.grpSpatialReference.Controls.Add(this.txtSrtext);
            this.grpSpatialReference.Controls.Add(this.label2);
            this.grpSpatialReference.Controls.Add(this.txtCode);
            this.grpSpatialReference.Controls.Add(this.label1);
            this.grpSpatialReference.Location = new System.Drawing.Point(34, 24);
            this.grpSpatialReference.Name = "grpSpatialReference";
            this.grpSpatialReference.Size = new System.Drawing.Size(552, 215);
            this.grpSpatialReference.TabIndex = 0;
            this.grpSpatialReference.TabStop = false;
            this.grpSpatialReference.Text = "Spatial reference";
            // 
            // btnApplySpatialReference
            // 
            this.btnApplySpatialReference.Location = new System.Drawing.Point(439, 245);
            this.btnApplySpatialReference.Name = "btnApplySpatialReference";
            this.btnApplySpatialReference.Size = new System.Drawing.Size(147, 32);
            this.btnApplySpatialReference.TabIndex = 0;
            this.btnApplySpatialReference.Text = "Apply spatial reference";
            this.btnApplySpatialReference.UseVisualStyleBackColor = true;
            this.btnApplySpatialReference.Click += new System.EventHandler(this.btnApplySpatialReference_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "EPSG code";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(117, 25);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(134, 21);
            this.txtCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Spatial reference text";
            // 
            // txtSrtext
            // 
            this.txtSrtext.Location = new System.Drawing.Point(32, 89);
            this.txtSrtext.Multiline = true;
            this.txtSrtext.Name = "txtSrtext";
            this.txtSrtext.Size = new System.Drawing.Size(498, 100);
            this.txtSrtext.TabIndex = 3;
            this.txtSrtext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormSpatialReference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 289);
            this.Controls.Add(this.btnApplySpatialReference);
            this.Controls.Add(this.grpSpatialReference);
            this.Name = "FormSpatialReference";
            this.Text = "FormSpatialReference";
            this.grpSpatialReference.ResumeLayout(false);
            this.grpSpatialReference.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSpatialReference;
        private System.Windows.Forms.Button btnApplySpatialReference;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSrtext;
    }
}