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
            this.grBxTopLeft = new System.Windows.Forms.GroupBox();
            this.grBxTopRight = new System.Windows.Forms.GroupBox();
            this.grBxMiddleLeft = new System.Windows.Forms.GroupBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.dGViewWaypoints = new System.Windows.Forms.DataGridView();
            this.WaypointNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longditude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBarZoom)).BeginInit();
            this.grBxMiddleLeft.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewWaypoints)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 6;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlpMain.Controls.Add(this.gMapMain, 1, 0);
            this.tlpMain.Controls.Add(this.trBarZoom, 4, 0);
            this.tlpMain.Controls.Add(this.grBxTopLeft, 0, 0);
            this.tlpMain.Controls.Add(this.grBxTopRight, 5, 0);
            this.tlpMain.Controls.Add(this.grBxMiddleLeft, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 24);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(942, 610);
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
            this.gMapMain.Size = new System.Drawing.Size(396, 604);
            this.gMapMain.TabIndex = 0;
            this.gMapMain.Zoom = 0D;
            // 
            // trBarZoom
            // 
            this.trBarZoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trBarZoom.Location = new System.Drawing.Point(655, 3);
            this.trBarZoom.Name = "trBarZoom";
            this.trBarZoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tlpMain.SetRowSpan(this.trBarZoom, 3);
            this.trBarZoom.Size = new System.Drawing.Size(32, 604);
            this.trBarZoom.TabIndex = 1;
            this.trBarZoom.Scroll += new System.EventHandler(this.trBarZoom_Scroll);
            // 
            // grBxTopLeft
            // 
            this.grBxTopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBxTopLeft.Location = new System.Drawing.Point(3, 3);
            this.grBxTopLeft.Name = "grBxTopLeft";
            this.grBxTopLeft.Size = new System.Drawing.Size(244, 244);
            this.grBxTopLeft.TabIndex = 2;
            this.grBxTopLeft.TabStop = false;
            this.grBxTopLeft.Text = "Waypoint";
            // 
            // grBxTopRight
            // 
            this.grBxTopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBxTopRight.Location = new System.Drawing.Point(693, 3);
            this.grBxTopRight.Name = "grBxTopRight";
            this.grBxTopRight.Size = new System.Drawing.Size(246, 244);
            this.grBxTopRight.TabIndex = 3;
            this.grBxTopRight.TabStop = false;
            this.grBxTopRight.Text = "Map Controls";
            // 
            // grBxMiddleLeft
            // 
            this.grBxMiddleLeft.Controls.Add(this.dGViewWaypoints);
            this.grBxMiddleLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBxMiddleLeft.Location = new System.Drawing.Point(3, 253);
            this.grBxMiddleLeft.Name = "grBxMiddleLeft";
            this.grBxMiddleLeft.Size = new System.Drawing.Size(244, 174);
            this.grBxMiddleLeft.TabIndex = 4;
            this.grBxMiddleLeft.TabStop = false;
            this.grBxMiddleLeft.Text = "Wapoint";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(942, 24);
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
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
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
            this.dGViewWaypoints.Size = new System.Drawing.Size(238, 155);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 634);
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
            this.grBxMiddleLeft.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewWaypoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private GMap.NET.WindowsForms.GMapControl gMapMain;
        private System.Windows.Forms.TrackBar trBarZoom;
        private System.Windows.Forms.GroupBox grBxTopLeft;
        private System.Windows.Forms.GroupBox grBxTopRight;
        private System.Windows.Forms.GroupBox grBxMiddleLeft;
        private System.Windows.Forms.DataGridView dGViewWaypoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaypointNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longditude;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;



    }
}

