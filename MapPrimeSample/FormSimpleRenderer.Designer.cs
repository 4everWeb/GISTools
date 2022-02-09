
namespace MapPrimeSample
{
    partial class FormSimpleRenderer
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
            this.grpSimpleRenderer = new System.Windows.Forms.GroupBox();
            this.grpFillSymbol = new System.Windows.Forms.GroupBox();
            this.grpLineSymbol = new System.Windows.Forms.GroupBox();
            this.grpPointSymbol = new System.Windows.Forms.GroupBox();
            this.btnApplySimpleRenderer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.btnLineColor = new System.Windows.Forms.Button();
            this.btnPointColor = new System.Windows.Forms.Button();
            this.txtFillSymbolTransparency = new System.Windows.Forms.TextBox();
            this.txtLineWidth = new System.Windows.Forms.TextBox();
            this.txtPointSize = new System.Windows.Forms.TextBox();
            this.txtPointSymbolStyle = new System.Windows.Forms.TextBox();
            this.txtLineSymbolStyle = new System.Windows.Forms.TextBox();
            this.txtFillSymbolStyle = new System.Windows.Forms.TextBox();
            this.grpSimpleRenderer.SuspendLayout();
            this.grpFillSymbol.SuspendLayout();
            this.grpLineSymbol.SuspendLayout();
            this.grpPointSymbol.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSimpleRenderer
            // 
            this.grpSimpleRenderer.Controls.Add(this.grpPointSymbol);
            this.grpSimpleRenderer.Controls.Add(this.grpLineSymbol);
            this.grpSimpleRenderer.Controls.Add(this.grpFillSymbol);
            this.grpSimpleRenderer.Location = new System.Drawing.Point(23, 12);
            this.grpSimpleRenderer.Name = "grpSimpleRenderer";
            this.grpSimpleRenderer.Size = new System.Drawing.Size(619, 250);
            this.grpSimpleRenderer.TabIndex = 0;
            this.grpSimpleRenderer.TabStop = false;
            this.grpSimpleRenderer.Text = "Simple Renderer";
            // 
            // grpFillSymbol
            // 
            this.grpFillSymbol.Controls.Add(this.txtFillSymbolStyle);
            this.grpFillSymbol.Controls.Add(this.txtFillSymbolTransparency);
            this.grpFillSymbol.Controls.Add(this.btnFillColor);
            this.grpFillSymbol.Controls.Add(this.label3);
            this.grpFillSymbol.Controls.Add(this.label2);
            this.grpFillSymbol.Controls.Add(this.label1);
            this.grpFillSymbol.Location = new System.Drawing.Point(34, 34);
            this.grpFillSymbol.Name = "grpFillSymbol";
            this.grpFillSymbol.Size = new System.Drawing.Size(559, 53);
            this.grpFillSymbol.TabIndex = 0;
            this.grpFillSymbol.TabStop = false;
            this.grpFillSymbol.Text = "Fill Symbol";
            // 
            // grpLineSymbol
            // 
            this.grpLineSymbol.Controls.Add(this.txtLineSymbolStyle);
            this.grpLineSymbol.Controls.Add(this.txtLineWidth);
            this.grpLineSymbol.Controls.Add(this.btnLineColor);
            this.grpLineSymbol.Controls.Add(this.label4);
            this.grpLineSymbol.Controls.Add(this.label5);
            this.grpLineSymbol.Controls.Add(this.label6);
            this.grpLineSymbol.Location = new System.Drawing.Point(34, 105);
            this.grpLineSymbol.Name = "grpLineSymbol";
            this.grpLineSymbol.Size = new System.Drawing.Size(559, 53);
            this.grpLineSymbol.TabIndex = 1;
            this.grpLineSymbol.TabStop = false;
            this.grpLineSymbol.Text = "Line Symbol";
            this.grpLineSymbol.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // grpPointSymbol
            // 
            this.grpPointSymbol.Controls.Add(this.txtPointSymbolStyle);
            this.grpPointSymbol.Controls.Add(this.txtPointSize);
            this.grpPointSymbol.Controls.Add(this.btnPointColor);
            this.grpPointSymbol.Controls.Add(this.label7);
            this.grpPointSymbol.Controls.Add(this.label8);
            this.grpPointSymbol.Controls.Add(this.label9);
            this.grpPointSymbol.Location = new System.Drawing.Point(34, 175);
            this.grpPointSymbol.Name = "grpPointSymbol";
            this.grpPointSymbol.Size = new System.Drawing.Size(559, 53);
            this.grpPointSymbol.TabIndex = 2;
            this.grpPointSymbol.TabStop = false;
            this.grpPointSymbol.Text = "Point Symbol";
            // 
            // btnApplySimpleRenderer
            // 
            this.btnApplySimpleRenderer.Location = new System.Drawing.Point(462, 268);
            this.btnApplySimpleRenderer.Name = "btnApplySimpleRenderer";
            this.btnApplySimpleRenderer.Size = new System.Drawing.Size(180, 34);
            this.btnApplySimpleRenderer.TabIndex = 3;
            this.btnApplySimpleRenderer.Text = "Apply Simple Renderer";
            this.btnApplySimpleRenderer.UseVisualStyleBackColor = true;
            this.btnApplySimpleRenderer.Click += new System.EventHandler(this.btnApplySimpleRenderer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transparency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Style";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Style";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "Style";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "Size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "Color";
            // 
            // btnFillColor
            // 
            this.btnFillColor.Location = new System.Drawing.Point(84, 22);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(52, 20);
            this.btnFillColor.TabIndex = 3;
            this.btnFillColor.UseVisualStyleBackColor = true;
            this.btnFillColor.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLineColor
            // 
            this.btnLineColor.Location = new System.Drawing.Point(84, 23);
            this.btnLineColor.Name = "btnLineColor";
            this.btnLineColor.Size = new System.Drawing.Size(52, 20);
            this.btnLineColor.TabIndex = 6;
            this.btnLineColor.UseVisualStyleBackColor = true;
            // 
            // btnPointColor
            // 
            this.btnPointColor.Location = new System.Drawing.Point(84, 22);
            this.btnPointColor.Name = "btnPointColor";
            this.btnPointColor.Size = new System.Drawing.Size(52, 20);
            this.btnPointColor.TabIndex = 6;
            this.btnPointColor.UseVisualStyleBackColor = true;
            // 
            // txtFillSymbolTransparency
            // 
            this.txtFillSymbolTransparency.Location = new System.Drawing.Point(259, 22);
            this.txtFillSymbolTransparency.Name = "txtFillSymbolTransparency";
            this.txtFillSymbolTransparency.Size = new System.Drawing.Size(49, 21);
            this.txtFillSymbolTransparency.TabIndex = 4;
            // 
            // txtLineWidth
            // 
            this.txtLineWidth.Location = new System.Drawing.Point(259, 24);
            this.txtLineWidth.Name = "txtLineWidth";
            this.txtLineWidth.Size = new System.Drawing.Size(49, 21);
            this.txtLineWidth.TabIndex = 7;
            // 
            // txtPointSize
            // 
            this.txtPointSize.Location = new System.Drawing.Point(259, 21);
            this.txtPointSize.Name = "txtPointSize";
            this.txtPointSize.Size = new System.Drawing.Size(49, 21);
            this.txtPointSize.TabIndex = 7;
            // 
            // txtPointSymbolStyle
            // 
            this.txtPointSymbolStyle.Location = new System.Drawing.Point(376, 22);
            this.txtPointSymbolStyle.Name = "txtPointSymbolStyle";
            this.txtPointSymbolStyle.Size = new System.Drawing.Size(177, 21);
            this.txtPointSymbolStyle.TabIndex = 8;
            // 
            // txtLineSymbolStyle
            // 
            this.txtLineSymbolStyle.Location = new System.Drawing.Point(376, 24);
            this.txtLineSymbolStyle.Name = "txtLineSymbolStyle";
            this.txtLineSymbolStyle.Size = new System.Drawing.Size(177, 21);
            this.txtLineSymbolStyle.TabIndex = 9;
            // 
            // txtFillSymbolStyle
            // 
            this.txtFillSymbolStyle.Location = new System.Drawing.Point(376, 22);
            this.txtFillSymbolStyle.Name = "txtFillSymbolStyle";
            this.txtFillSymbolStyle.Size = new System.Drawing.Size(177, 21);
            this.txtFillSymbolStyle.TabIndex = 10;
            // 
            // FormSimpleRenderer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 315);
            this.Controls.Add(this.btnApplySimpleRenderer);
            this.Controls.Add(this.grpSimpleRenderer);
            this.Name = "FormSimpleRenderer";
            this.Text = "FormSimpleRenderer";
            this.Load += new System.EventHandler(this.FormSimpleRenderer_Load);
            this.grpSimpleRenderer.ResumeLayout(false);
            this.grpFillSymbol.ResumeLayout(false);
            this.grpFillSymbol.PerformLayout();
            this.grpLineSymbol.ResumeLayout(false);
            this.grpLineSymbol.PerformLayout();
            this.grpPointSymbol.ResumeLayout(false);
            this.grpPointSymbol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSimpleRenderer;
        private System.Windows.Forms.GroupBox grpPointSymbol;
        private System.Windows.Forms.GroupBox grpLineSymbol;
        private System.Windows.Forms.GroupBox grpFillSymbol;
        private System.Windows.Forms.Button btnApplySimpleRenderer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPointColor;
        private System.Windows.Forms.Button btnLineColor;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.TextBox txtPointSymbolStyle;
        private System.Windows.Forms.TextBox txtPointSize;
        private System.Windows.Forms.TextBox txtLineSymbolStyle;
        private System.Windows.Forms.TextBox txtLineWidth;
        private System.Windows.Forms.TextBox txtFillSymbolStyle;
        private System.Windows.Forms.TextBox txtFillSymbolTransparency;
    }
}