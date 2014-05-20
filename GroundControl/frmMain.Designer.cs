namespace GroundControl
{
    partial class frmMain
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.gMapMain = new GMap.NET.WindowsForms.GMapControl();
            this.trBarZoom = new System.Windows.Forms.TrackBar();
            this.grBxPoints = new System.Windows.Forms.GroupBox();
            this.dGViewWaypoints = new System.Windows.Forms.DataGridView();
            this.WaypointNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPathControls = new System.Windows.Forms.TabControl();
            this.tbPgFlighPath = new System.Windows.Forms.TabPage();
            this.lblLatPath = new System.Windows.Forms.Label();
            this.btnAddPathPoint = new System.Windows.Forms.Button();
            this.btnPathBegin = new System.Windows.Forms.Button();
            this.lblLLngPath = new System.Windows.Forms.Label();
            this.btnPathEnd = new System.Windows.Forms.Button();
            this.btnPathClear = new System.Windows.Forms.Button();
            this.txbxLngPath = new System.Windows.Forms.TextBox();
            this.txbxLatPath = new System.Windows.Forms.TextBox();
            this.tbPgSurvey = new System.Windows.Forms.TabPage();
            this.nudPointSpacing = new System.Windows.Forms.NumericUpDown();
            this.nudPathSpacing = new System.Windows.Forms.NumericUpDown();
            this.btnAddPolyPoint = new System.Windows.Forms.Button();
            this.btnPolyBegin = new System.Windows.Forms.Button();
            this.txbxLatPoly = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxLngPoly = new System.Windows.Forms.TextBox();
            this.btnPolyEnd = new System.Windows.Forms.Button();
            this.btnPolyClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statLat = new System.Windows.Forms.ToolStripStatusLabel();
            this.statLng = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBarZoom)).BeginInit();
            this.grBxPoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewWaypoints)).BeginInit();
            this.tbPathControls.SuspendLayout();
            this.tbPgFlighPath.SuspendLayout();
            this.tbPgSurvey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPathSpacing)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.ColumnCount = 6;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tlpMain.Controls.Add(this.gMapMain, 1, 0);
            this.tlpMain.Controls.Add(this.trBarZoom, 4, 0);
            this.tlpMain.Controls.Add(this.grBxPoints, 5, 0);
            this.tlpMain.Controls.Add(this.tbPathControls, 0, 0);
            this.tlpMain.Location = new System.Drawing.Point(0, 24);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1087, 690);
            this.tlpMain.TabIndex = 0;
            // 
            // gMapMain
            // 
            this.gMapMain.Bearing = 0F;
            this.gMapMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gMapMain.CanDragMap = true;
            this.tlpMain.SetColumnSpan(this.gMapMain, 3);
            this.gMapMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapMain.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapMain.GrayScaleMode = false;
            this.gMapMain.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapMain.LevelsKeepInMemmory = 5;
            this.gMapMain.Location = new System.Drawing.Point(266, 3);
            this.gMapMain.MarkersEnabled = true;
            this.gMapMain.MaxZoom = 2;
            this.gMapMain.MinZoom = 2;
            this.gMapMain.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapMain.Name = "gMapMain";
            this.gMapMain.NegativeMode = false;
            this.gMapMain.PolygonsEnabled = true;
            this.gMapMain.RetryLoadTile = 0;
            this.gMapMain.RoutesEnabled = true;
            this.tlpMain.SetRowSpan(this.gMapMain, 4);
            this.gMapMain.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapMain.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapMain.ShowTileGridLines = false;
            this.gMapMain.Size = new System.Drawing.Size(513, 684);
            this.gMapMain.TabIndex = 0;
            this.gMapMain.Zoom = 0D;
            this.gMapMain.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gMapMain_OnMapZoomChanged);
            this.gMapMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapMain_MouseClick);
            this.gMapMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMapMain_MouseMove);
            // 
            // trBarZoom
            // 
            this.trBarZoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trBarZoom.Location = new System.Drawing.Point(785, 3);
            this.trBarZoom.Name = "trBarZoom";
            this.trBarZoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tlpMain.SetRowSpan(this.trBarZoom, 4);
            this.trBarZoom.Size = new System.Drawing.Size(32, 684);
            this.trBarZoom.TabIndex = 1;
            this.trBarZoom.Scroll += new System.EventHandler(this.trBarZoom_Scroll);
            // 
            // grBxPoints
            // 
            this.grBxPoints.Controls.Add(this.dGViewWaypoints);
            this.grBxPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBxPoints.Location = new System.Drawing.Point(823, 3);
            this.grBxPoints.Name = "grBxPoints";
            this.tlpMain.SetRowSpan(this.grBxPoints, 4);
            this.grBxPoints.Size = new System.Drawing.Size(261, 684);
            this.grBxPoints.TabIndex = 4;
            this.grBxPoints.TabStop = false;
            this.grBxPoints.Text = "Points";
            // 
            // dGViewWaypoints
            // 
            this.dGViewWaypoints.AllowUserToAddRows = false;
            this.dGViewWaypoints.AllowUserToDeleteRows = false;
            this.dGViewWaypoints.AllowUserToResizeColumns = false;
            this.dGViewWaypoints.AllowUserToResizeRows = false;
            this.dGViewWaypoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewWaypoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WaypointNumber,
            this.Lat,
            this.Lng});
            this.dGViewWaypoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGViewWaypoints.Location = new System.Drawing.Point(3, 16);
            this.dGViewWaypoints.Name = "dGViewWaypoints";
            this.dGViewWaypoints.ReadOnly = true;
            this.dGViewWaypoints.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dGViewWaypoints.RowHeadersVisible = false;
            this.dGViewWaypoints.Size = new System.Drawing.Size(255, 665);
            this.dGViewWaypoints.TabIndex = 0;
            // 
            // WaypointNumber
            // 
            this.WaypointNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WaypointNumber.HeaderText = "No.";
            this.WaypointNumber.Name = "WaypointNumber";
            this.WaypointNumber.ReadOnly = true;
            this.WaypointNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.WaypointNumber.Width = 49;
            // 
            // Lat
            // 
            this.Lat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Lat.HeaderText = "Lat";
            this.Lat.Name = "Lat";
            this.Lat.ReadOnly = true;
            // 
            // Lng
            // 
            this.Lng.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Lng.HeaderText = "Long";
            this.Lng.Name = "Lng";
            this.Lng.ReadOnly = true;
            // 
            // tbPathControls
            // 
            this.tbPathControls.Controls.Add(this.tbPgFlighPath);
            this.tbPathControls.Controls.Add(this.tbPgSurvey);
            this.tbPathControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPathControls.Location = new System.Drawing.Point(3, 3);
            this.tbPathControls.Name = "tbPathControls";
            this.tlpMain.SetRowSpan(this.tbPathControls, 3);
            this.tbPathControls.SelectedIndex = 0;
            this.tbPathControls.Size = new System.Drawing.Size(257, 494);
            this.tbPathControls.TabIndex = 6;
            // 
            // tbPgFlighPath
            // 
            this.tbPgFlighPath.Controls.Add(this.lblLatPath);
            this.tbPgFlighPath.Controls.Add(this.btnAddPathPoint);
            this.tbPgFlighPath.Controls.Add(this.btnPathBegin);
            this.tbPgFlighPath.Controls.Add(this.lblLLngPath);
            this.tbPgFlighPath.Controls.Add(this.btnPathEnd);
            this.tbPgFlighPath.Controls.Add(this.btnPathClear);
            this.tbPgFlighPath.Controls.Add(this.txbxLngPath);
            this.tbPgFlighPath.Controls.Add(this.txbxLatPath);
            this.tbPgFlighPath.Location = new System.Drawing.Point(4, 22);
            this.tbPgFlighPath.Name = "tbPgFlighPath";
            this.tbPgFlighPath.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgFlighPath.Size = new System.Drawing.Size(249, 468);
            this.tbPgFlighPath.TabIndex = 0;
            this.tbPgFlighPath.Text = "Flight Path";
            this.tbPgFlighPath.UseVisualStyleBackColor = true;
            // 
            // lblLatPath
            // 
            this.lblLatPath.AutoSize = true;
            this.lblLatPath.Location = new System.Drawing.Point(6, 32);
            this.lblLatPath.Name = "lblLatPath";
            this.lblLatPath.Size = new System.Drawing.Size(25, 13);
            this.lblLatPath.TabIndex = 5;
            this.lblLatPath.Text = "Lat:";
            // 
            // btnAddPathPoint
            // 
            this.btnAddPathPoint.Enabled = false;
            this.btnAddPathPoint.Location = new System.Drawing.Point(6, 74);
            this.btnAddPathPoint.Name = "btnAddPathPoint";
            this.btnAddPathPoint.Size = new System.Drawing.Size(75, 23);
            this.btnAddPathPoint.TabIndex = 7;
            this.btnAddPathPoint.Text = "Add Point";
            this.btnAddPathPoint.UseVisualStyleBackColor = true;
            this.btnAddPathPoint.Click += new System.EventHandler(this.btnAddPathPoint_Click);
            // 
            // btnPathBegin
            // 
            this.btnPathBegin.Location = new System.Drawing.Point(6, 6);
            this.btnPathBegin.Name = "btnPathBegin";
            this.btnPathBegin.Size = new System.Drawing.Size(75, 23);
            this.btnPathBegin.TabIndex = 0;
            this.btnPathBegin.Text = "Begin Path";
            this.btnPathBegin.UseVisualStyleBackColor = true;
            this.btnPathBegin.Click += new System.EventHandler(this.btnPathBegin_Click);
            // 
            // lblLLngPath
            // 
            this.lblLLngPath.AutoSize = true;
            this.lblLLngPath.Location = new System.Drawing.Point(109, 32);
            this.lblLLngPath.Name = "lblLLngPath";
            this.lblLLngPath.Size = new System.Drawing.Size(34, 13);
            this.lblLLngPath.TabIndex = 6;
            this.lblLLngPath.Text = "Long:";
            // 
            // btnPathEnd
            // 
            this.btnPathEnd.Enabled = false;
            this.btnPathEnd.Location = new System.Drawing.Point(87, 6);
            this.btnPathEnd.Name = "btnPathEnd";
            this.btnPathEnd.Size = new System.Drawing.Size(75, 23);
            this.btnPathEnd.TabIndex = 1;
            this.btnPathEnd.Text = "End Path";
            this.btnPathEnd.UseVisualStyleBackColor = true;
            this.btnPathEnd.Click += new System.EventHandler(this.btnPathEnd_Click);
            // 
            // btnPathClear
            // 
            this.btnPathClear.Location = new System.Drawing.Point(168, 6);
            this.btnPathClear.Name = "btnPathClear";
            this.btnPathClear.Size = new System.Drawing.Size(75, 23);
            this.btnPathClear.TabIndex = 2;
            this.btnPathClear.Text = "Clear Path";
            this.btnPathClear.UseVisualStyleBackColor = true;
            this.btnPathClear.Click += new System.EventHandler(this.btnPathClear_Click);
            // 
            // txbxLngPath
            // 
            this.txbxLngPath.Enabled = false;
            this.txbxLngPath.Location = new System.Drawing.Point(112, 48);
            this.txbxLngPath.Name = "txbxLngPath";
            this.txbxLngPath.Size = new System.Drawing.Size(100, 20);
            this.txbxLngPath.TabIndex = 4;
            // 
            // txbxLatPath
            // 
            this.txbxLatPath.Enabled = false;
            this.txbxLatPath.Location = new System.Drawing.Point(6, 48);
            this.txbxLatPath.Name = "txbxLatPath";
            this.txbxLatPath.Size = new System.Drawing.Size(100, 20);
            this.txbxLatPath.TabIndex = 3;
            // 
            // tbPgSurvey
            // 
            this.tbPgSurvey.Controls.Add(this.label4);
            this.tbPgSurvey.Controls.Add(this.label3);
            this.tbPgSurvey.Controls.Add(this.nudPointSpacing);
            this.tbPgSurvey.Controls.Add(this.nudPathSpacing);
            this.tbPgSurvey.Controls.Add(this.btnAddPolyPoint);
            this.tbPgSurvey.Controls.Add(this.btnPolyBegin);
            this.tbPgSurvey.Controls.Add(this.txbxLatPoly);
            this.tbPgSurvey.Controls.Add(this.label1);
            this.tbPgSurvey.Controls.Add(this.txbxLngPoly);
            this.tbPgSurvey.Controls.Add(this.btnPolyEnd);
            this.tbPgSurvey.Controls.Add(this.btnPolyClear);
            this.tbPgSurvey.Controls.Add(this.label2);
            this.tbPgSurvey.Location = new System.Drawing.Point(4, 22);
            this.tbPgSurvey.Name = "tbPgSurvey";
            this.tbPgSurvey.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgSurvey.Size = new System.Drawing.Size(249, 468);
            this.tbPgSurvey.TabIndex = 1;
            this.tbPgSurvey.Text = "Survey Polygon";
            this.tbPgSurvey.UseVisualStyleBackColor = true;
            // 
            // nudPointSpacing
            // 
            this.nudPointSpacing.Location = new System.Drawing.Point(128, 142);
            this.nudPointSpacing.Name = "nudPointSpacing";
            this.nudPointSpacing.Size = new System.Drawing.Size(115, 20);
            this.nudPointSpacing.TabIndex = 17;
            // 
            // nudPathSpacing
            // 
            this.nudPathSpacing.Location = new System.Drawing.Point(6, 142);
            this.nudPathSpacing.Name = "nudPathSpacing";
            this.nudPathSpacing.Size = new System.Drawing.Size(115, 20);
            this.nudPathSpacing.TabIndex = 16;
            // 
            // btnAddPolyPoint
            // 
            this.btnAddPolyPoint.Enabled = false;
            this.btnAddPolyPoint.Location = new System.Drawing.Point(6, 74);
            this.btnAddPolyPoint.Name = "btnAddPolyPoint";
            this.btnAddPolyPoint.Size = new System.Drawing.Size(75, 23);
            this.btnAddPolyPoint.TabIndex = 15;
            this.btnAddPolyPoint.Text = "Add Point";
            this.btnAddPolyPoint.UseVisualStyleBackColor = true;
            this.btnAddPolyPoint.Click += new System.EventHandler(this.btnAddPolyPoint_Click);
            // 
            // btnPolyBegin
            // 
            this.btnPolyBegin.Location = new System.Drawing.Point(6, 6);
            this.btnPolyBegin.Name = "btnPolyBegin";
            this.btnPolyBegin.Size = new System.Drawing.Size(75, 23);
            this.btnPolyBegin.TabIndex = 8;
            this.btnPolyBegin.Text = "Begin Poly";
            this.btnPolyBegin.UseVisualStyleBackColor = true;
            this.btnPolyBegin.Click += new System.EventHandler(this.btnPolyBegin_Click);
            // 
            // txbxLatPoly
            // 
            this.txbxLatPoly.Enabled = false;
            this.txbxLatPoly.Location = new System.Drawing.Point(6, 48);
            this.txbxLatPoly.Name = "txbxLatPoly";
            this.txbxLatPoly.Size = new System.Drawing.Size(100, 20);
            this.txbxLatPoly.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Long:";
            // 
            // txbxLngPoly
            // 
            this.txbxLngPoly.Enabled = false;
            this.txbxLngPoly.Location = new System.Drawing.Point(112, 48);
            this.txbxLngPoly.Name = "txbxLngPoly";
            this.txbxLngPoly.Size = new System.Drawing.Size(100, 20);
            this.txbxLngPoly.TabIndex = 12;
            // 
            // btnPolyEnd
            // 
            this.btnPolyEnd.Enabled = false;
            this.btnPolyEnd.Location = new System.Drawing.Point(87, 6);
            this.btnPolyEnd.Name = "btnPolyEnd";
            this.btnPolyEnd.Size = new System.Drawing.Size(75, 23);
            this.btnPolyEnd.TabIndex = 9;
            this.btnPolyEnd.Text = "End Poly";
            this.btnPolyEnd.UseVisualStyleBackColor = true;
            this.btnPolyEnd.Click += new System.EventHandler(this.btnPolyEnd_Click);
            // 
            // btnPolyClear
            // 
            this.btnPolyClear.Location = new System.Drawing.Point(168, 6);
            this.btnPolyClear.Name = "btnPolyClear";
            this.btnPolyClear.Size = new System.Drawing.Size(75, 23);
            this.btnPolyClear.TabIndex = 10;
            this.btnPolyClear.Text = "Clear Poly";
            this.btnPolyClear.UseVisualStyleBackColor = true;
            this.btnPolyClear.Click += new System.EventHandler(this.btnPolyClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lat:";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1087, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.saveToolStripMenuItem.Text = "Save..";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exportToolStripMenuItem.Text = "Export Flight Path...";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statLat,
            this.statLng});
            this.statusStrip.Location = new System.Drawing.Point(0, 717);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1087, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statLat
            // 
            this.statLat.Name = "statLat";
            this.statLat.Size = new System.Drawing.Size(26, 17);
            this.statLat.Text = "Lat:";
            // 
            // statLng
            // 
            this.statLng.Name = "statLng";
            this.statLng.Size = new System.Drawing.Size(37, 17);
            this.statLng.Text = "Long:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Path Spacing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Point Spacing";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 739);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "GroundControl";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBarZoom)).EndInit();
            this.grBxPoints.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGViewWaypoints)).EndInit();
            this.tbPathControls.ResumeLayout(false);
            this.tbPgFlighPath.ResumeLayout(false);
            this.tbPgFlighPath.PerformLayout();
            this.tbPgSurvey.ResumeLayout(false);
            this.tbPgSurvey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPathSpacing)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private GMap.NET.WindowsForms.GMapControl gMapMain;
        private System.Windows.Forms.TrackBar trBarZoom;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statLat;
        private System.Windows.Forms.ToolStripStatusLabel statLng;
        private System.Windows.Forms.GroupBox grBxPoints;
        private System.Windows.Forms.DataGridView dGViewWaypoints;
        private System.Windows.Forms.Button btnPathEnd;
        private System.Windows.Forms.Button btnPathBegin;
        private System.Windows.Forms.Button btnPathClear;
        private System.Windows.Forms.Button btnAddPathPoint;
        private System.Windows.Forms.Label lblLLngPath;
        private System.Windows.Forms.Label lblLatPath;
        private System.Windows.Forms.TextBox txbxLngPath;
        private System.Windows.Forms.TextBox txbxLatPath;
        private System.Windows.Forms.Button btnAddPolyPoint;
        private System.Windows.Forms.Button btnPolyBegin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPolyEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPolyClear;
        private System.Windows.Forms.TextBox txbxLngPoly;
        private System.Windows.Forms.TextBox txbxLatPoly;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaypointNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lng;
        private System.Windows.Forms.TabControl tbPathControls;
        private System.Windows.Forms.TabPage tbPgFlighPath;
        private System.Windows.Forms.TabPage tbPgSurvey;
        private System.Windows.Forms.NumericUpDown nudPointSpacing;
        private System.Windows.Forms.NumericUpDown nudPathSpacing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;



    }
}

