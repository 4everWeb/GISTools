
namespace MapPrimeSample
{
    partial class FormLabelRenderer
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
            this.chkLabel = new System.Windows.Forms.CheckBox();
            this.btnApplyLabel = new System.Windows.Forms.Button();
            this.grpLabelRenderer = new System.Windows.Forms.GroupBox();
            this.chkAvoidCollisions = new System.Windows.Forms.CheckBox();
            this.chkAllowDuplicate = new System.Windows.Forms.CheckBox();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTextSymbol = new System.Windows.Forms.GroupBox();
            this.txtOffsetY = new System.Windows.Forms.TextBox();
            this.txtOffsetX = new System.Windows.Forms.TextBox();
            this.txtFontSize = new System.Windows.Forms.TextBox();
            this.btnTextBackColor = new System.Windows.Forms.Button();
            this.btnTextFontColor = new System.Windows.Forms.Button();
            this.chkBackColor = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFont = new System.Windows.Forms.TextBox();
            this.chkUndeline = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpLabelRenderer.SuspendLayout();
            this.grpTextSymbol.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkLabel
            // 
            this.chkLabel.AutoSize = true;
            this.chkLabel.Location = new System.Drawing.Point(12, 12);
            this.chkLabel.Name = "chkLabel";
            this.chkLabel.Size = new System.Drawing.Size(91, 16);
            this.chkLabel.TabIndex = 0;
            this.chkLabel.Text = "Show Label";
            this.chkLabel.UseVisualStyleBackColor = true;
            this.chkLabel.CheckedChanged += new System.EventHandler(this.chkLabel_CheckedChanged);
            // 
            // btnApplyLabel
            // 
            this.btnApplyLabel.Location = new System.Drawing.Point(569, 304);
            this.btnApplyLabel.Name = "btnApplyLabel";
            this.btnApplyLabel.Size = new System.Drawing.Size(203, 37);
            this.btnApplyLabel.TabIndex = 1;
            this.btnApplyLabel.Text = "Apply label";
            this.btnApplyLabel.UseVisualStyleBackColor = true;
            this.btnApplyLabel.Click += new System.EventHandler(this.btnApplyLabel_Click);
            // 
            // grpLabelRenderer
            // 
            this.grpLabelRenderer.Controls.Add(this.chkAvoidCollisions);
            this.grpLabelRenderer.Controls.Add(this.chkAllowDuplicate);
            this.grpLabelRenderer.Controls.Add(this.txtFieldName);
            this.grpLabelRenderer.Controls.Add(this.label1);
            this.grpLabelRenderer.Controls.Add(this.grpTextSymbol);
            this.grpLabelRenderer.Location = new System.Drawing.Point(36, 55);
            this.grpLabelRenderer.Name = "grpLabelRenderer";
            this.grpLabelRenderer.Size = new System.Drawing.Size(735, 231);
            this.grpLabelRenderer.TabIndex = 2;
            this.grpLabelRenderer.TabStop = false;
            this.grpLabelRenderer.Text = "Label Renderer";
            // 
            // chkAvoidCollisions
            // 
            this.chkAvoidCollisions.AutoSize = true;
            this.chkAvoidCollisions.Location = new System.Drawing.Point(487, 48);
            this.chkAvoidCollisions.Name = "chkAvoidCollisions";
            this.chkAvoidCollisions.Size = new System.Drawing.Size(115, 16);
            this.chkAvoidCollisions.TabIndex = 4;
            this.chkAvoidCollisions.Text = "Avoid Collisions";
            this.chkAvoidCollisions.UseVisualStyleBackColor = true;
            // 
            // chkAllowDuplicate
            // 
            this.chkAllowDuplicate.AutoSize = true;
            this.chkAllowDuplicate.Location = new System.Drawing.Point(358, 48);
            this.chkAllowDuplicate.Name = "chkAllowDuplicate";
            this.chkAllowDuplicate.Size = new System.Drawing.Size(110, 16);
            this.chkAllowDuplicate.TabIndex = 3;
            this.chkAllowDuplicate.Text = "Allow duplicate";
            this.chkAllowDuplicate.UseVisualStyleBackColor = true;
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(142, 43);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(171, 21);
            this.txtFieldName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Field";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpTextSymbol
            // 
            this.grpTextSymbol.Controls.Add(this.txtOffsetY);
            this.grpTextSymbol.Controls.Add(this.txtOffsetX);
            this.grpTextSymbol.Controls.Add(this.txtFontSize);
            this.grpTextSymbol.Controls.Add(this.btnTextBackColor);
            this.grpTextSymbol.Controls.Add(this.btnTextFontColor);
            this.grpTextSymbol.Controls.Add(this.chkBackColor);
            this.grpTextSymbol.Controls.Add(this.label6);
            this.grpTextSymbol.Controls.Add(this.label5);
            this.grpTextSymbol.Controls.Add(this.label4);
            this.grpTextSymbol.Controls.Add(this.txtFont);
            this.grpTextSymbol.Controls.Add(this.chkUndeline);
            this.grpTextSymbol.Controls.Add(this.chkItalic);
            this.grpTextSymbol.Controls.Add(this.chkBold);
            this.grpTextSymbol.Controls.Add(this.label3);
            this.grpTextSymbol.Controls.Add(this.label2);
            this.grpTextSymbol.Location = new System.Drawing.Point(32, 85);
            this.grpTextSymbol.Name = "grpTextSymbol";
            this.grpTextSymbol.Size = new System.Drawing.Size(686, 127);
            this.grpTextSymbol.TabIndex = 0;
            this.grpTextSymbol.TabStop = false;
            this.grpTextSymbol.Text = "Text Symbol";
            // 
            // txtOffsetY
            // 
            this.txtOffsetY.Location = new System.Drawing.Point(310, 88);
            this.txtOffsetY.Name = "txtOffsetY";
            this.txtOffsetY.Size = new System.Drawing.Size(52, 21);
            this.txtOffsetY.TabIndex = 16;
            // 
            // txtOffsetX
            // 
            this.txtOffsetX.Location = new System.Drawing.Point(310, 61);
            this.txtOffsetX.Name = "txtOffsetX";
            this.txtOffsetX.Size = new System.Drawing.Size(52, 21);
            this.txtOffsetX.TabIndex = 15;
            // 
            // txtFontSize
            // 
            this.txtFontSize.Location = new System.Drawing.Point(310, 34);
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(52, 21);
            this.txtFontSize.TabIndex = 14;
            // 
            // btnTextBackColor
            // 
            this.btnTextBackColor.Location = new System.Drawing.Point(110, 90);
            this.btnTextBackColor.Name = "btnTextBackColor";
            this.btnTextBackColor.Size = new System.Drawing.Size(87, 23);
            this.btnTextBackColor.TabIndex = 13;
            this.btnTextBackColor.UseVisualStyleBackColor = true;
            this.btnTextBackColor.Click += new System.EventHandler(this.btnTextBackColor_Click);
            // 
            // btnTextFontColor
            // 
            this.btnTextFontColor.Location = new System.Drawing.Point(110, 62);
            this.btnTextFontColor.Name = "btnTextFontColor";
            this.btnTextFontColor.Size = new System.Drawing.Size(87, 23);
            this.btnTextFontColor.TabIndex = 12;
            this.btnTextFontColor.UseVisualStyleBackColor = true;
            this.btnTextFontColor.Click += new System.EventHandler(this.btnTextFontColor_Click);
            // 
            // chkBackColor
            // 
            this.chkBackColor.AutoSize = true;
            this.chkBackColor.Location = new System.Drawing.Point(11, 94);
            this.chkBackColor.Name = "chkBackColor";
            this.chkBackColor.Size = new System.Drawing.Size(86, 16);
            this.chkBackColor.TabIndex = 11;
            this.chkBackColor.Text = "Back Color";
            this.chkBackColor.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Offset Y";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Offset X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Size";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtFont
            // 
            this.txtFont.Location = new System.Drawing.Point(110, 34);
            this.txtFont.Name = "txtFont";
            this.txtFont.Size = new System.Drawing.Size(87, 21);
            this.txtFont.TabIndex = 7;
            // 
            // chkUndeline
            // 
            this.chkUndeline.AutoSize = true;
            this.chkUndeline.Location = new System.Drawing.Point(555, 39);
            this.chkUndeline.Name = "chkUndeline";
            this.chkUndeline.Size = new System.Drawing.Size(77, 16);
            this.chkUndeline.TabIndex = 6;
            this.chkUndeline.Text = "Underline";
            this.chkUndeline.UseVisualStyleBackColor = true;
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(474, 38);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(50, 16);
            this.chkItalic.TabIndex = 5;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(391, 38);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(49, 16);
            this.chkBold.TabIndex = 4;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Font Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Font Name";
            // 
            // FormLabelRenderer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 358);
            this.Controls.Add(this.grpLabelRenderer);
            this.Controls.Add(this.btnApplyLabel);
            this.Controls.Add(this.chkLabel);
            this.Name = "FormLabelRenderer";
            this.Text = "FormLabel";
            this.grpLabelRenderer.ResumeLayout(false);
            this.grpLabelRenderer.PerformLayout();
            this.grpTextSymbol.ResumeLayout(false);
            this.grpTextSymbol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkLabel;
        private System.Windows.Forms.Button btnApplyLabel;
        private System.Windows.Forms.GroupBox grpLabelRenderer;
        private System.Windows.Forms.GroupBox grpTextSymbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.CheckBox chkAvoidCollisions;
        private System.Windows.Forms.CheckBox chkAllowDuplicate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkUndeline;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFont;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkBackColor;
        private System.Windows.Forms.Button btnTextBackColor;
        private System.Windows.Forms.Button btnTextFontColor;
        private System.Windows.Forms.TextBox txtOffsetY;
        private System.Windows.Forms.TextBox txtOffsetX;
        private System.Windows.Forms.TextBox txtFontSize;
    }
}