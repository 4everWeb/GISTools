
namespace MapPrimeSample
{
    partial class FormLayerShowSclae
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
            this.btnApplyShowScale = new System.Windows.Forms.Button();
            this.grpShowScale = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinimumScale = new System.Windows.Forms.TextBox();
            this.txtMaximumScale = new System.Windows.Forms.TextBox();
            this.grpShowScale.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApplyShowScale
            // 
            this.btnApplyShowScale.Location = new System.Drawing.Point(163, 127);
            this.btnApplyShowScale.Name = "btnApplyShowScale";
            this.btnApplyShowScale.Size = new System.Drawing.Size(134, 23);
            this.btnApplyShowScale.TabIndex = 0;
            this.btnApplyShowScale.Text = "Apply show scale";
            this.btnApplyShowScale.UseVisualStyleBackColor = true;
            this.btnApplyShowScale.Click += new System.EventHandler(this.btnApplyShowScale_Click);
            // 
            // grpShowScale
            // 
            this.grpShowScale.Controls.Add(this.txtMaximumScale);
            this.grpShowScale.Controls.Add(this.txtMinimumScale);
            this.grpShowScale.Controls.Add(this.label2);
            this.grpShowScale.Controls.Add(this.label1);
            this.grpShowScale.Location = new System.Drawing.Point(25, 31);
            this.grpShowScale.Name = "grpShowScale";
            this.grpShowScale.Size = new System.Drawing.Size(271, 82);
            this.grpShowScale.TabIndex = 1;
            this.grpShowScale.TabStop = false;
            this.grpShowScale.Text = "Show scale";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum scale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maximum scale";
            // 
            // txtMinimumScale
            // 
            this.txtMinimumScale.Location = new System.Drawing.Point(138, 20);
            this.txtMinimumScale.Name = "txtMinimumScale";
            this.txtMinimumScale.Size = new System.Drawing.Size(107, 21);
            this.txtMinimumScale.TabIndex = 2;
            // 
            // txtMaximumScale
            // 
            this.txtMaximumScale.Location = new System.Drawing.Point(138, 47);
            this.txtMaximumScale.Name = "txtMaximumScale";
            this.txtMaximumScale.Size = new System.Drawing.Size(107, 21);
            this.txtMaximumScale.TabIndex = 3;
            // 
            // FormLayerShowSclae
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 157);
            this.Controls.Add(this.grpShowScale);
            this.Controls.Add(this.btnApplyShowScale);
            this.Name = "FormLayerShowSclae";
            this.Text = "FormLayerShowSclae";
            this.grpShowScale.ResumeLayout(false);
            this.grpShowScale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApplyShowScale;
        private System.Windows.Forms.GroupBox grpShowScale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaximumScale;
        private System.Windows.Forms.TextBox txtMinimumScale;
    }
}