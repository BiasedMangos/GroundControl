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
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBarZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 6;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpMain.Controls.Add(this.gMapMain, 1, 0);
            this.tlpMain.Controls.Add(this.trBarZoom, 4, 0);
            this.tlpMain.Controls.Add(this.grBxTopLeft, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.Size = new System.Drawing.Size(942, 634);
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
            this.gMapMain.Location = new System.Drawing.Point(203, 3);
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
            this.gMapMain.Size = new System.Drawing.Size(495, 628);
            this.gMapMain.TabIndex = 0;
            this.gMapMain.Zoom = 0D;
            // 
            // trBarZoom
            // 
            this.trBarZoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trBarZoom.Location = new System.Drawing.Point(704, 3);
            this.trBarZoom.Name = "trBarZoom";
            this.trBarZoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tlpMain.SetRowSpan(this.trBarZoom, 3);
            this.trBarZoom.Size = new System.Drawing.Size(32, 628);
            this.trBarZoom.TabIndex = 1;
            // 
            // grBxTopLeft
            // 
            this.grBxTopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBxTopLeft.Location = new System.Drawing.Point(3, 3);
            this.grBxTopLeft.Name = "grBxTopLeft";
            this.grBxTopLeft.Size = new System.Drawing.Size(194, 205);
            this.grBxTopLeft.TabIndex = 2;
            this.grBxTopLeft.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 634);
            this.Controls.Add(this.tlpMain);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmMain";
            this.Text = "GroundControl";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBarZoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private GMap.NET.WindowsForms.GMapControl gMapMain;
        private System.Windows.Forms.TrackBar trBarZoom;
        private System.Windows.Forms.GroupBox grBxTopLeft;



    }
}

