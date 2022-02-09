
namespace MapPrimeSample
{
    partial class FormFeatureClassLocale
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
            this.grpLocale = new System.Windows.Forms.GroupBox();
            this.btnApplyLocale = new System.Windows.Forms.Button();
            this.rdoCP949 = new System.Windows.Forms.RadioButton();
            this.rdoEUCKR = new System.Windows.Forms.RadioButton();
            this.rdoUTF8 = new System.Windows.Forms.RadioButton();
            this.rdoSystem = new System.Windows.Forms.RadioButton();
            this.grpLocale.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLocale
            // 
            this.grpLocale.Controls.Add(this.rdoSystem);
            this.grpLocale.Controls.Add(this.rdoUTF8);
            this.grpLocale.Controls.Add(this.rdoEUCKR);
            this.grpLocale.Controls.Add(this.rdoCP949);
            this.grpLocale.Location = new System.Drawing.Point(22, 29);
            this.grpLocale.Name = "grpLocale";
            this.grpLocale.Size = new System.Drawing.Size(543, 100);
            this.grpLocale.TabIndex = 0;
            this.grpLocale.TabStop = false;
            this.grpLocale.Text = "Locale";
            // 
            // btnApplyLocale
            // 
            this.btnApplyLocale.Location = new System.Drawing.Point(406, 143);
            this.btnApplyLocale.Name = "btnApplyLocale";
            this.btnApplyLocale.Size = new System.Drawing.Size(158, 28);
            this.btnApplyLocale.TabIndex = 1;
            this.btnApplyLocale.Text = "Apply locale";
            this.btnApplyLocale.UseVisualStyleBackColor = true;
            this.btnApplyLocale.Click += new System.EventHandler(this.btnApplyLocale_Click);
            // 
            // rdoCP949
            // 
            this.rdoCP949.AutoSize = true;
            this.rdoCP949.Location = new System.Drawing.Point(37, 41);
            this.rdoCP949.Name = "rdoCP949";
            this.rdoCP949.Size = new System.Drawing.Size(58, 16);
            this.rdoCP949.TabIndex = 0;
            this.rdoCP949.TabStop = true;
            this.rdoCP949.Text = "CP949";
            this.rdoCP949.UseVisualStyleBackColor = true;
            // 
            // rdoEUCKR
            // 
            this.rdoEUCKR.AutoSize = true;
            this.rdoEUCKR.Location = new System.Drawing.Point(126, 41);
            this.rdoEUCKR.Name = "rdoEUCKR";
            this.rdoEUCKR.Size = new System.Drawing.Size(64, 16);
            this.rdoEUCKR.TabIndex = 1;
            this.rdoEUCKR.TabStop = true;
            this.rdoEUCKR.Text = "EUCKR";
            this.rdoEUCKR.UseVisualStyleBackColor = true;
            // 
            // rdoUTF8
            // 
            this.rdoUTF8.AutoSize = true;
            this.rdoUTF8.Location = new System.Drawing.Point(217, 41);
            this.rdoUTF8.Name = "rdoUTF8";
            this.rdoUTF8.Size = new System.Drawing.Size(52, 16);
            this.rdoUTF8.TabIndex = 2;
            this.rdoUTF8.TabStop = true;
            this.rdoUTF8.Text = "UTF8";
            this.rdoUTF8.UseVisualStyleBackColor = true;
            this.rdoUTF8.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdoSystem
            // 
            this.rdoSystem.AutoSize = true;
            this.rdoSystem.Location = new System.Drawing.Point(297, 41);
            this.rdoSystem.Name = "rdoSystem";
            this.rdoSystem.Size = new System.Drawing.Size(62, 16);
            this.rdoSystem.TabIndex = 3;
            this.rdoSystem.TabStop = true;
            this.rdoSystem.Text = "Ststem";
            this.rdoSystem.UseVisualStyleBackColor = true;
            // 
            // FormFeatureClassLocale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 183);
            this.Controls.Add(this.btnApplyLocale);
            this.Controls.Add(this.grpLocale);
            this.Name = "FormFeatureClassLocale";
            this.Text = "FormFeatureLayerLocale";
            this.grpLocale.ResumeLayout(false);
            this.grpLocale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLocale;
        private System.Windows.Forms.Button btnApplyLocale;
        private System.Windows.Forms.RadioButton rdoSystem;
        private System.Windows.Forms.RadioButton rdoUTF8;
        private System.Windows.Forms.RadioButton rdoEUCKR;
        private System.Windows.Forms.RadioButton rdoCP949;
    }
}