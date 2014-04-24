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
            this.grBxPath = new System.Windows.Forms.GroupBox();
            this.btnPathEnd = new System.Windows.Forms.Button();
            this.btnPathBegin = new System.Windows.Forms.Button();
            this.grBxTopRight = new System.Windows.Forms.GroupBox();
            this.grBxPoints = new System.Windows.Forms.GroupBox();
            this.dGViewWaypoints = new System.Windows.Forms.DataGridView();
            this.WaypointNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longditude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grBxPolygon = new System.Windows.Forms.GroupBox();
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
            this.btnPathClear = new System.Windows.Forms.Button();
            this.txbxLatPath = new System.Windows.Forms.TextBox();
            this.txbxLngPath = new System.Windows.Forms.TextBox();
            this.lblLatPath = new System.Windows.Forms.Label();
            this.lblLLngPath = new System.Windows.Forms.Label();
            this.btnAddPathPoint = new System.Windows.Forms.Button();
            this.btnAddPolyPoint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbxLngPoly = new System.Windows.Forms.TextBox();
            this.txbxLatPoly = new System.Windows.Forms.TextBox();
            this.btnPolyClear = new System.Windows.Forms.Button();
            this.btnPolyEnd = new System.Windows.Forms.Button();
            this.btnPolyBegin = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBarZoom)).BeginInit();
            this.grBxPath.SuspendLayout();
            this.grBxPoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewWaypoints)).BeginInit();
            this.grBxPolygon.SuspendLayout();
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
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 253F));
            this.tlpMain.Controls.Add(this.gMapMain, 1, 0);
            this.tlpMain.Controls.Add(this.trBarZoom, 4, 0);
            this.tlpMain.Controls.Add(this.grBxPath, 0, 0);
            this.tlpMain.Controls.Add(this.grBxTopRight, 5, 0);
            this.tlpMain.Controls.Add(this.grBxPoints, 0, 2);
            this.tlpMain.Controls.Add(this.grBxPolygon, 0, 1);
            this.tlpMain.Location = new System.Drawing.Point(0, 24);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
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
            this.gMapMain.Location = new System.Drawing.Point(253, 3);
            this.gMapMain.MarkersEnabled = true;
            this.gMapMain.MaxZoom = 2;
            this.gMapMain.MinZoom = 2;
            this.gMapMain.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapMain.Name = "gMapMain";
            this.gMapMain.NegativeMode = false;
            this.gMapMain.PolygonsEnabled = true;
            this.gMapMain.RetryLoadTile = 0;
            this.gMapMain.RoutesEnabled = true;
            this.tlpMain.SetRowSpan(this.gMapMain, 3);
            this.gMapMain.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapMain.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapMain.ShowTileGridLines = false;
            this.gMapMain.Size = new System.Drawing.Size(540, 684);
            this.gMapMain.TabIndex = 0;
            this.gMapMain.Zoom = 0D;
            this.gMapMain.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gMapMain_OnMapZoomChanged);
            this.gMapMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapMain_MouseClick);
            this.gMapMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMapMain_MouseMove);
            // 
            // trBarZoom
            // 
            this.trBarZoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trBarZoom.Location = new System.Drawing.Point(799, 3);
            this.trBarZoom.Name = "trBarZoom";
            this.trBarZoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tlpMain.SetRowSpan(this.trBarZoom, 3);
            this.trBarZoom.Size = new System.Drawing.Size(32, 684);
            this.trBarZoom.TabIndex = 1;
            this.trBarZoom.Scroll += new System.EventHandler(this.trBarZoom_Scroll);
            // 
            // grBxPath
            // 
            this.grBxPath.Controls.Add(this.btnAddPathPoint);
            this.grBxPath.Controls.Add(this.lblLLngPath);
            this.grBxPath.Controls.Add(this.lblLatPath);
            this.grBxPath.Controls.Add(this.txbxLngPath);
            this.grBxPath.Controls.Add(this.txbxLatPath);
            this.grBxPath.Controls.Add(this.btnPathClear);
            this.grBxPath.Controls.Add(this.btnPathEnd);
            this.grBxPath.Controls.Add(this.btnPathBegin);
            this.grBxPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBxPath.Location = new System.Drawing.Point(3, 3);
            this.grBxPath.Name = "grBxPath";
            this.grBxPath.Size = new System.Drawing.Size(244, 244);
            this.grBxPath.TabIndex = 2;
            this.grBxPath.TabStop = false;
            this.grBxPath.Text = "Flight Path";
            // 
            // btnPathEnd
            // 
            this.btnPathEnd.Enabled = false;
            this.btnPathEnd.Location = new System.Drawing.Point(86, 19);
            this.btnPathEnd.Name = "btnPathEnd";
            this.btnPathEnd.Size = new System.Drawing.Size(75, 23);
            this.btnPathEnd.TabIndex = 1;
            this.btnPathEnd.Text = "End Path";
            this.btnPathEnd.UseVisualStyleBackColor = true;
            this.btnPathEnd.Click += new System.EventHandler(this.btnPathEnd_Click);
            // 
            // btnPathBegin
            // 
            this.btnPathBegin.Location = new System.Drawing.Point(6, 19);
            this.btnPathBegin.Name = "btnPathBegin";
            this.btnPathBegin.Size = new System.Drawing.Size(75, 23);
            this.btnPathBegin.TabIndex = 0;
            this.btnPathBegin.Text = "Begin Path";
            this.btnPathBegin.UseVisualStyleBackColor = true;
            this.btnPathBegin.Click += new System.EventHandler(this.btnPathBegin_Click);
            // 
            // grBxTopRight
            // 
            this.grBxTopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBxTopRight.Location = new System.Drawing.Point(837, 3);
            this.grBxTopRight.Name = "grBxTopRight";
            this.grBxTopRight.Size = new System.Drawing.Size(247, 244);
            this.grBxTopRight.TabIndex = 3;
            this.grBxTopRight.TabStop = false;
            this.grBxTopRight.Text = "Map Controls";
            // 
            // grBxPoints
            // 
            this.grBxPoints.Controls.Add(this.dGViewWaypoints);
            this.grBxPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBxPoints.Location = new System.Drawing.Point(3, 503);
            this.grBxPoints.Name = "grBxPoints";
            this.grBxPoints.Size = new System.Drawing.Size(244, 184);
            this.grBxPoints.TabIndex = 4;
            this.grBxPoints.TabStop = false;
            this.grBxPoints.Text = "Points";
            // 
            // dGViewWaypoints
            // 
            this.dGViewWaypoints.AllowUserToAddRows = false;
            this.dGViewWaypoints.AllowUserToDeleteRows = false;
            this.dGViewWaypoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewWaypoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WaypointNumber,
            this.Latitude,
            this.Longditude});
            this.dGViewWaypoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGViewWaypoints.Location = new System.Drawing.Point(3, 16);
            this.dGViewWaypoints.Name = "dGViewWaypoints";
            this.dGViewWaypoints.ReadOnly = true;
            this.dGViewWaypoints.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dGViewWaypoints.RowHeadersVisible = false;
            this.dGViewWaypoints.Size = new System.Drawing.Size(238, 165);
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
            // Latitude
            // 
            this.Latitude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Latitude.HeaderText = "Lat";
            this.Latitude.Name = "Latitude";
            this.Latitude.ReadOnly = true;
            this.Latitude.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Latitude.Width = 47;
            // 
            // Longditude
            // 
            this.Longditude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Longditude.HeaderText = "long";
            this.Longditude.Name = "Longditude";
            this.Longditude.ReadOnly = true;
            this.Longditude.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Longditude.Width = 52;
            // 
            // grBxPolygon
            // 
            this.grBxPolygon.Controls.Add(this.btnAddPolyPoint);
            this.grBxPolygon.Controls.Add(this.btnPolyBegin);
            this.grBxPolygon.Controls.Add(this.label1);
            this.grBxPolygon.Controls.Add(this.btnPolyEnd);
            this.grBxPolygon.Controls.Add(this.label2);
            this.grBxPolygon.Controls.Add(this.btnPolyClear);
            this.grBxPolygon.Controls.Add(this.txbxLngPoly);
            this.grBxPolygon.Controls.Add(this.txbxLatPoly);
            this.grBxPolygon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBxPolygon.Location = new System.Drawing.Point(3, 253);
            this.grBxPolygon.Name = "grBxPolygon";
            this.grBxPolygon.Size = new System.Drawing.Size(244, 244);
            this.grBxPolygon.TabIndex = 5;
            this.grBxPolygon.TabStop = false;
            this.grBxPolygon.Text = "Survey Polygon";
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
            this.newToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(104, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
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
            // btnPathClear
            // 
            this.btnPathClear.Location = new System.Drawing.Point(166, 19);
            this.btnPathClear.Name = "btnPathClear";
            this.btnPathClear.Size = new System.Drawing.Size(75, 23);
            this.btnPathClear.TabIndex = 2;
            this.btnPathClear.Text = "Clear Path";
            this.btnPathClear.UseVisualStyleBackColor = true;
            this.btnPathClear.Click += new System.EventHandler(this.btnPathClear_Click);
            // 
            // txbxLatPath
            // 
            this.txbxLatPath.Enabled = false;
            this.txbxLatPath.Location = new System.Drawing.Point(6, 61);
            this.txbxLatPath.Name = "txbxLatPath";
            this.txbxLatPath.Size = new System.Drawing.Size(100, 20);
            this.txbxLatPath.TabIndex = 3;
            // 
            // txbxLngPath
            // 
            this.txbxLngPath.Enabled = false;
            this.txbxLngPath.Location = new System.Drawing.Point(112, 61);
            this.txbxLngPath.Name = "txbxLngPath";
            this.txbxLngPath.Size = new System.Drawing.Size(100, 20);
            this.txbxLngPath.TabIndex = 4;
            // 
            // lblLatPath
            // 
            this.lblLatPath.AutoSize = true;
            this.lblLatPath.Location = new System.Drawing.Point(6, 45);
            this.lblLatPath.Name = "lblLatPath";
            this.lblLatPath.Size = new System.Drawing.Size(25, 13);
            this.lblLatPath.TabIndex = 5;
            this.lblLatPath.Text = "Lat:";
            // 
            // lblLLngPath
            // 
            this.lblLLngPath.AutoSize = true;
            this.lblLLngPath.Location = new System.Drawing.Point(109, 45);
            this.lblLLngPath.Name = "lblLLngPath";
            this.lblLLngPath.Size = new System.Drawing.Size(34, 13);
            this.lblLLngPath.TabIndex = 6;
            this.lblLLngPath.Text = "Long:";
            // 
            // btnAddPathPoint
            // 
            this.btnAddPathPoint.Enabled = false;
            this.btnAddPathPoint.Location = new System.Drawing.Point(6, 87);
            this.btnAddPathPoint.Name = "btnAddPathPoint";
            this.btnAddPathPoint.Size = new System.Drawing.Size(75, 23);
            this.btnAddPathPoint.TabIndex = 7;
            this.btnAddPathPoint.Text = "Add Point";
            this.btnAddPathPoint.UseVisualStyleBackColor = true;
            this.btnAddPathPoint.Click += new System.EventHandler(this.btnAddPathPoint_Click);
            // 
            // btnAddPolyPoint
            // 
            this.btnAddPolyPoint.Enabled = false;
            this.btnAddPolyPoint.Location = new System.Drawing.Point(6, 87);
            this.btnAddPolyPoint.Name = "btnAddPolyPoint";
            this.btnAddPolyPoint.Size = new System.Drawing.Size(75, 23);
            this.btnAddPolyPoint.TabIndex = 15;
            this.btnAddPolyPoint.Text = "Add Point";
            this.btnAddPolyPoint.UseVisualStyleBackColor = true;
            this.btnAddPolyPoint.Click += new System.EventHandler(this.btnAddPolyPoint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Long:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lat:";
            // 
            // txbxLngPoly
            // 
            this.txbxLngPoly.Enabled = false;
            this.txbxLngPoly.Location = new System.Drawing.Point(112, 61);
            this.txbxLngPoly.Name = "txbxLngPoly";
            this.txbxLngPoly.Size = new System.Drawing.Size(100, 20);
            this.txbxLngPoly.TabIndex = 12;
            // 
            // txbxLatPoly
            // 
            this.txbxLatPoly.Enabled = false;
            this.txbxLatPoly.Location = new System.Drawing.Point(6, 61);
            this.txbxLatPoly.Name = "txbxLatPoly";
            this.txbxLatPoly.Size = new System.Drawing.Size(100, 20);
            this.txbxLatPoly.TabIndex = 11;
            // 
            // btnPolyClear
            // 
            this.btnPolyClear.Location = new System.Drawing.Point(166, 19);
            this.btnPolyClear.Name = "btnPolyClear";
            this.btnPolyClear.Size = new System.Drawing.Size(75, 23);
            this.btnPolyClear.TabIndex = 10;
            this.btnPolyClear.Text = "Clear Poly";
            this.btnPolyClear.UseVisualStyleBackColor = true;
            this.btnPolyClear.Click += new System.EventHandler(this.btnPolyClear_Click);
            // 
            // btnPolyEnd
            // 
            this.btnPolyEnd.Enabled = false;
            this.btnPolyEnd.Location = new System.Drawing.Point(86, 19);
            this.btnPolyEnd.Name = "btnPolyEnd";
            this.btnPolyEnd.Size = new System.Drawing.Size(75, 23);
            this.btnPolyEnd.TabIndex = 9;
            this.btnPolyEnd.Text = "End Poly";
            this.btnPolyEnd.UseVisualStyleBackColor = true;
            this.btnPolyEnd.Click += new System.EventHandler(this.btnPolyEnd_Click);
            // 
            // btnPolyBegin
            // 
            this.btnPolyBegin.Location = new System.Drawing.Point(6, 19);
            this.btnPolyBegin.Name = "btnPolyBegin";
            this.btnPolyBegin.Size = new System.Drawing.Size(75, 23);
            this.btnPolyBegin.TabIndex = 8;
            this.btnPolyBegin.Text = "Begin Poly";
            this.btnPolyBegin.UseVisualStyleBackColor = true;
            this.btnPolyBegin.Click += new System.EventHandler(this.btnPolyBegin_Click);
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
            this.grBxPath.ResumeLayout(false);
            this.grBxPath.PerformLayout();
            this.grBxPoints.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGViewWaypoints)).EndInit();
            this.grBxPolygon.ResumeLayout(false);
            this.grBxPolygon.PerformLayout();
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
        private System.Windows.Forms.GroupBox grBxPath;
        private System.Windows.Forms.GroupBox grBxTopRight;
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
        private System.Windows.Forms.GroupBox grBxPolygon;
        private System.Windows.Forms.GroupBox grBxPoints;
        private System.Windows.Forms.DataGridView dGViewWaypoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaypointNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longditude;
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



    }
}

