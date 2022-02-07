﻿namespace MapPrimeSample
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.axMapControl1 = new AxGMapLib.AxMapControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolZoomFit = new System.Windows.Forms.ToolStripButton();
            this.toolZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolZoomOut = new System.Windows.Forms.ToolStripButton();
            this.listBoxTOC = new System.Windows.Forms.ListBox();
            this.listBoxFeatureClass = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolRefershLayerList = new System.Windows.Forms.ToolStripButton();
            this.toolRemoveAllLayer = new System.Windows.Forms.ToolStripButton();
            this.toolClearMap = new System.Windows.Forms.ToolStripButton();
            this.toolSelectObjects = new System.Windows.Forms.ToolStripButton();
            this.toolMapPanning = new System.Windows.Forms.ToolStripButton();
            this.toolIdentify = new System.Windows.Forms.ToolStripButton();
            this.toolCancelSelectObjects = new System.Windows.Forms.ToolStripButton();
            this.toolCalculateDistance = new System.Windows.Forms.ToolStripButton();
            this.toolCalculateArea = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnectionGISServer = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxShapeFileList = new System.Windows.Forms.ListBox();
            this.btnOpenShapeDataSource = new System.Windows.Forms.Button();
            this.txtShapeFileDirectory = new System.Windows.Forms.TextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPageMapView = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.tabControl6 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBoxSelectedObjects = new System.Windows.Forms.ListBox();
            this.listBoxIdentifyList = new System.Windows.Forms.ListBox();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.txtProperty = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPageMapView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabControl5.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.tabControl6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.SuspendLayout();
            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl1.Location = new System.Drawing.Point(3, 3);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(445, 376);
            this.axMapControl1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 593);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1159, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1159, 566);
            this.splitContainer1.SplitterDistance = 338;
            this.splitContainer1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolZoomFit,
            this.toolZoomIn,
            this.toolZoomOut,
            this.toolMapPanning,
            this.toolSelectObjects,
            this.toolCancelSelectObjects,
            this.toolIdentify,
            this.toolCalculateDistance,
            this.toolCalculateArea,
            this.toolClearMap});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1159, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolZoomFit
            // 
            this.toolZoomFit.Image = ((System.Drawing.Image)(resources.GetObject("toolZoomFit.Image")));
            this.toolZoomFit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomFit.Name = "toolZoomFit";
            this.toolZoomFit.Size = new System.Drawing.Size(93, 24);
            this.toolZoomFit.Text = "전체보기";
            this.toolZoomFit.Click += new System.EventHandler(this.toolZoomFit_Click);
            // 
            // toolZoomIn
            // 
            this.toolZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("toolZoomIn.Image")));
            this.toolZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomIn.Name = "toolZoomIn";
            this.toolZoomIn.Size = new System.Drawing.Size(93, 24);
            this.toolZoomIn.Text = "지도확대";
            this.toolZoomIn.Click += new System.EventHandler(this.toolZoomIn_Click);
            // 
            // toolZoomOut
            // 
            this.toolZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("toolZoomOut.Image")));
            this.toolZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomOut.Name = "toolZoomOut";
            this.toolZoomOut.Size = new System.Drawing.Size(93, 24);
            this.toolZoomOut.Text = "지도축소";
            this.toolZoomOut.Click += new System.EventHandler(this.toolZoomOut_Click);
            // 
            // listBoxTOC
            // 
            this.listBoxTOC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTOC.FormattingEnabled = true;
            this.listBoxTOC.ItemHeight = 15;
            this.listBoxTOC.Location = new System.Drawing.Point(3, 30);
            this.listBoxTOC.Name = "listBoxTOC";
            this.listBoxTOC.Size = new System.Drawing.Size(322, 234);
            this.listBoxTOC.TabIndex = 0;
            this.listBoxTOC.SelectedIndexChanged += new System.EventHandler(this.listBoxTOC_SelectedIndexChanged);
            this.listBoxTOC.DoubleClick += new System.EventHandler(this.listBoxTOC_DoubleClick);
            // 
            // listBoxFeatureClass
            // 
            this.listBoxFeatureClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFeatureClass.FormattingEnabled = true;
            this.listBoxFeatureClass.ItemHeight = 15;
            this.listBoxFeatureClass.Location = new System.Drawing.Point(3, 105);
            this.listBoxFeatureClass.Name = "listBoxFeatureClass";
            this.listBoxFeatureClass.Size = new System.Drawing.Size(336, 112);
            this.listBoxFeatureClass.TabIndex = 1;
            this.listBoxFeatureClass.SelectedIndexChanged += new System.EventHandler(this.listBoxFeatureClass_SelectedIndexChanged);
            this.listBoxFeatureClass.DoubleClick += new System.EventHandler(this.listBoxFeatureClass_DoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(336, 262);
            this.tabControl1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnConnectionGISServer);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUserID);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.txtHost);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 102);
            this.panel1.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(336, 296);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxTOC);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(328, 267);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "레이어목록";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer2.Size = new System.Drawing.Size(338, 566);
            this.splitContainer2.SplitterDistance = 264;
            this.splitContainer2.TabIndex = 4;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolRefershLayerList,
            this.toolRemoveAllLayer});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(322, 27);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolRefershLayerList
            // 
            this.toolRefershLayerList.Image = ((System.Drawing.Image)(resources.GetObject("toolRefershLayerList.Image")));
            this.toolRefershLayerList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRefershLayerList.Name = "toolRefershLayerList";
            this.toolRefershLayerList.Size = new System.Drawing.Size(83, 24);
            this.toolRefershLayerList.Text = "Refresh";
            this.toolRefershLayerList.Click += new System.EventHandler(this.toolRefershLayerList_Click);
            // 
            // toolRemoveAllLayer
            // 
            this.toolRemoveAllLayer.Image = ((System.Drawing.Image)(resources.GetObject("toolRemoveAllLayer.Image")));
            this.toolRemoveAllLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRemoveAllLayer.Name = "toolRemoveAllLayer";
            this.toolRemoveAllLayer.Size = new System.Drawing.Size(105, 24);
            this.toolRemoveAllLayer.Text = "RemoveAll";
            this.toolRemoveAllLayer.Click += new System.EventHandler(this.toolRemoveAllLayer_Click);
            // 
            // toolClearMap
            // 
            this.toolClearMap.Image = ((System.Drawing.Image)(resources.GetObject("toolClearMap.Image")));
            this.toolClearMap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolClearMap.Name = "toolClearMap";
            this.toolClearMap.Size = new System.Drawing.Size(108, 24);
            this.toolClearMap.Text = "화면지우기";
            this.toolClearMap.Click += new System.EventHandler(this.toolClearMap_Click);
            // 
            // toolSelectObjects
            // 
            this.toolSelectObjects.Image = ((System.Drawing.Image)(resources.GetObject("toolSelectObjects.Image")));
            this.toolSelectObjects.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSelectObjects.Name = "toolSelectObjects";
            this.toolSelectObjects.Size = new System.Drawing.Size(93, 24);
            this.toolSelectObjects.Text = "객체선택";
            this.toolSelectObjects.Click += new System.EventHandler(this.toolSelectObjects_Click);
            // 
            // toolMapPanning
            // 
            this.toolMapPanning.Image = ((System.Drawing.Image)(resources.GetObject("toolMapPanning.Image")));
            this.toolMapPanning.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMapPanning.Name = "toolMapPanning";
            this.toolMapPanning.Size = new System.Drawing.Size(93, 24);
            this.toolMapPanning.Text = "지도이동";
            this.toolMapPanning.Click += new System.EventHandler(this.toolMapPanning_Click);
            // 
            // toolIdentify
            // 
            this.toolIdentify.Image = ((System.Drawing.Image)(resources.GetObject("toolIdentify.Image")));
            this.toolIdentify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolIdentify.Name = "toolIdentify";
            this.toolIdentify.Size = new System.Drawing.Size(123, 24);
            this.toolIdentify.Text = "객체정보확인";
            this.toolIdentify.Click += new System.EventHandler(this.toolIdentify_Click);
            // 
            // toolCancelSelectObjects
            // 
            this.toolCancelSelectObjects.Image = ((System.Drawing.Image)(resources.GetObject("toolCancelSelectObjects.Image")));
            this.toolCancelSelectObjects.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCancelSelectObjects.Name = "toolCancelSelectObjects";
            this.toolCancelSelectObjects.Size = new System.Drawing.Size(93, 24);
            this.toolCancelSelectObjects.Text = "선택해제";
            this.toolCancelSelectObjects.Click += new System.EventHandler(this.toolCancelSelectObjects_Click);
            // 
            // toolCalculateDistance
            // 
            this.toolCalculateDistance.Image = ((System.Drawing.Image)(resources.GetObject("toolCalculateDistance.Image")));
            this.toolCalculateDistance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCalculateDistance.Name = "toolCalculateDistance";
            this.toolCalculateDistance.Size = new System.Drawing.Size(93, 24);
            this.toolCalculateDistance.Text = "거리계산";
            this.toolCalculateDistance.Click += new System.EventHandler(this.toolCalculateDistance_Click);
            // 
            // toolCalculateArea
            // 
            this.toolCalculateArea.Image = ((System.Drawing.Image)(resources.GetObject("toolCalculateArea.Image")));
            this.toolCalculateArea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCalculateArea.Name = "toolCalculateArea";
            this.toolCalculateArea.Size = new System.Drawing.Size(93, 24);
            this.toolCalculateArea.Text = "면적계산";
            this.toolCalculateArea.Click += new System.EventHandler(this.toolCalculateArea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(87, 5);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(109, 25);
            this.txtHost.TabIndex = 4;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(255, 8);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(58, 25);
            this.txtPort.TabIndex = 5;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(87, 36);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(135, 25);
            this.txtUserID.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(87, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(135, 25);
            this.txtPassword.TabIndex = 7;
            // 
            // btnConnectionGISServer
            // 
            this.btnConnectionGISServer.Location = new System.Drawing.Point(228, 55);
            this.btnConnectionGISServer.Name = "btnConnectionGISServer";
            this.btnConnectionGISServer.Size = new System.Drawing.Size(85, 37);
            this.btnConnectionGISServer.TabIndex = 8;
            this.btnConnectionGISServer.Text = "연결";
            this.btnConnectionGISServer.UseVisualStyleBackColor = true;
            this.btnConnectionGISServer.Click += new System.EventHandler(this.btnConnectionGISServer_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBoxShapeFileList);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(328, 233);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Shape파일";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtShapeFileDirectory);
            this.panel2.Controls.Add(this.btnOpenShapeDataSource);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 91);
            this.panel2.TabIndex = 1;
            // 
            // listBoxShapeFileList
            // 
            this.listBoxShapeFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxShapeFileList.FormattingEnabled = true;
            this.listBoxShapeFileList.ItemHeight = 15;
            this.listBoxShapeFileList.Location = new System.Drawing.Point(3, 94);
            this.listBoxShapeFileList.Name = "listBoxShapeFileList";
            this.listBoxShapeFileList.Size = new System.Drawing.Size(322, 136);
            this.listBoxShapeFileList.TabIndex = 2;
            this.listBoxShapeFileList.SelectedIndexChanged += new System.EventHandler(this.listBoxShapeFileList_SelectedIndexChanged);
            this.listBoxShapeFileList.DoubleClick += new System.EventHandler(this.listBoxShapeFileList_DoubleClick);
            // 
            // btnOpenShapeDataSource
            // 
            this.btnOpenShapeDataSource.Location = new System.Drawing.Point(6, 5);
            this.btnOpenShapeDataSource.Name = "btnOpenShapeDataSource";
            this.btnOpenShapeDataSource.Size = new System.Drawing.Size(213, 27);
            this.btnOpenShapeDataSource.TabIndex = 9;
            this.btnOpenShapeDataSource.Text = "Shape 파일 디렉토리 선택";
            this.btnOpenShapeDataSource.UseVisualStyleBackColor = true;
            this.btnOpenShapeDataSource.Click += new System.EventHandler(this.btnOpenShapeDataSource_Click);
            // 
            // txtShapeFileDirectory
            // 
            this.txtShapeFileDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShapeFileDirectory.Location = new System.Drawing.Point(4, 38);
            this.txtShapeFileDirectory.Multiline = true;
            this.txtShapeFileDirectory.Name = "txtShapeFileDirectory";
            this.txtShapeFileDirectory.ReadOnly = true;
            this.txtShapeFileDirectory.Size = new System.Drawing.Size(311, 46);
            this.txtShapeFileDirectory.TabIndex = 10;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(817, 566);
            this.splitContainer3.SplitterDistance = 461;
            this.splitContainer3.TabIndex = 1;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPageMapView);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(459, 411);
            this.tabControl3.TabIndex = 1;
            // 
            // tabPageMapView
            // 
            this.tabPageMapView.Controls.Add(this.axMapControl1);
            this.tabPageMapView.Location = new System.Drawing.Point(4, 25);
            this.tabPageMapView.Name = "tabPageMapView";
            this.tabPageMapView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMapView.Size = new System.Drawing.Size(451, 382);
            this.tabPageMapView.TabIndex = 1;
            this.tabPageMapView.Text = "지도화면";
            this.tabPageMapView.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.tabControl4);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.tabControl5);
            this.splitContainer4.Size = new System.Drawing.Size(352, 566);
            this.splitContainer4.SplitterDistance = 251;
            this.splitContainer4.TabIndex = 0;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage6);
            this.tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl4.Location = new System.Drawing.Point(0, 0);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(350, 249);
            this.tabControl4.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.listBoxFeatureClass);
            this.tabPage6.Controls.Add(this.panel1);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(342, 220);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "GIS서버연결";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.tabPage7);
            this.tabControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl5.Location = new System.Drawing.Point(0, 0);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(350, 309);
            this.tabControl5.TabIndex = 1;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.splitContainer6);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(342, 280);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "객체정보";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.tabControl3);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.tabControl6);
            this.splitContainer5.Size = new System.Drawing.Size(461, 566);
            this.splitContainer5.SplitterDistance = 413;
            this.splitContainer5.TabIndex = 2;
            // 
            // tabControl6
            // 
            this.tabControl6.Controls.Add(this.tabPage4);
            this.tabControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl6.Location = new System.Drawing.Point(0, 0);
            this.tabControl6.Name = "tabControl6";
            this.tabControl6.SelectedIndex = 0;
            this.tabControl6.Size = new System.Drawing.Size(459, 147);
            this.tabControl6.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listBoxSelectedObjects);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(451, 118);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "선택 객체";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBoxSelectedObjects
            // 
            this.listBoxSelectedObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSelectedObjects.FormattingEnabled = true;
            this.listBoxSelectedObjects.ItemHeight = 15;
            this.listBoxSelectedObjects.Location = new System.Drawing.Point(3, 3);
            this.listBoxSelectedObjects.Name = "listBoxSelectedObjects";
            this.listBoxSelectedObjects.Size = new System.Drawing.Size(445, 112);
            this.listBoxSelectedObjects.TabIndex = 0;
            // 
            // listBoxIdentifyList
            // 
            this.listBoxIdentifyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxIdentifyList.FormattingEnabled = true;
            this.listBoxIdentifyList.ItemHeight = 15;
            this.listBoxIdentifyList.Location = new System.Drawing.Point(0, 0);
            this.listBoxIdentifyList.Name = "listBoxIdentifyList";
            this.listBoxIdentifyList.Size = new System.Drawing.Size(152, 272);
            this.listBoxIdentifyList.TabIndex = 0;
            // 
            // splitContainer6
            // 
            this.splitContainer6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(3, 3);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.listBoxIdentifyList);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.txtProperty);
            this.splitContainer6.Size = new System.Drawing.Size(336, 274);
            this.splitContainer6.SplitterDistance = 154;
            this.splitContainer6.TabIndex = 1;
            // 
            // txtProperty
            // 
            this.txtProperty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProperty.Location = new System.Drawing.Point(0, 0);
            this.txtProperty.Multiline = true;
            this.txtProperty.Name = "txtProperty";
            this.txtProperty.ReadOnly = true;
            this.txtProperty.Size = new System.Drawing.Size(176, 272);
            this.txtProperty.TabIndex = 11;
            // 
            // Form12_SetupLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 615);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form12_SetupLayout";
            this.Text = "Form12_SetupLayout";
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPageMapView.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabControl5.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.tabControl6.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxGMapLib.AxMapControl axMapControl1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBoxTOC;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolZoomFit;
        private System.Windows.Forms.ToolStripButton toolZoomIn;
        private System.Windows.Forms.ToolStripButton toolZoomOut;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListBox listBoxFeatureClass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolRefershLayerList;
        private System.Windows.Forms.ToolStripButton toolRemoveAllLayer;
        private System.Windows.Forms.ToolStripButton toolMapPanning;
        private System.Windows.Forms.ToolStripButton toolSelectObjects;
        private System.Windows.Forms.ToolStripButton toolCancelSelectObjects;
        private System.Windows.Forms.ToolStripButton toolIdentify;
        private System.Windows.Forms.ToolStripButton toolCalculateDistance;
        private System.Windows.Forms.ToolStripButton toolCalculateArea;
        private System.Windows.Forms.ToolStripButton toolClearMap;
        private System.Windows.Forms.Button btnConnectionGISServer;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoxShapeFileList;
        private System.Windows.Forms.Button btnOpenShapeDataSource;
        private System.Windows.Forms.TextBox txtShapeFileDirectory;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPageMapView;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabControl tabControl5;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabControl tabControl6;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox listBoxSelectedObjects;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.ListBox listBoxIdentifyList;
        private System.Windows.Forms.TextBox txtProperty;
    }
}