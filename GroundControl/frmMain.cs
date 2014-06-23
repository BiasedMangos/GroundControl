using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.Projections;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace GroundControl
{
    public partial class frmMain : Form
    {
        int iMaxZoom = 22;
        int iMinZoom = 3;
        int iStartZoom = 17;

        FlightPath FlightPath;
        Geometry Geometry;

        GMapOverlay MarkerOverlay;
        GMapOverlay PathOverlay;
        GMapOverlay PolyOverlay;

        List<PointLatLng> lPointsPath;
        List<PointLatLng> lPointsPoly;
        List<PointLatLng> lPointsConvexHull;


        enum mode { idle, path, poly }
        mode drawingMode;

        DataTable dtWaypoint;

        public frmMain()
        {
            InitializeComponent();

            drawingMode = mode.idle;

            FlightPath = new FlightPath();
            Geometry = new Geometry();

            //sets which server the Control will get its map from and what mode it will be in
            gMapMain.MapProvider = GMapProviders.GoogleSatelliteMap;
            gMapMain.Manager.Mode = AccessMode.ServerAndCache;

            //details for access to map servers through school proxy
            /*GMapProvider.WebProxy = WebRequest.GetSystemWebProxy();
            GMapProvider.WebProxy.Credentials = new NetworkCredential("daniel.mann2", "5t3v3n");   */

            gMapMain.SetPositionByKeywords("Gosford, Australia");

            //sets limits and initial value for zoom of map
            trBarZoom.Maximum = gMapMain.MaxZoom = iMaxZoom;
            trBarZoom.Minimum = gMapMain.MinZoom = iMinZoom;
            trBarZoom.Value = iStartZoom;
            gMapMain.Zoom = iStartZoom;

            //adds overlays to the map which markers paths and polygons can then be placed on
            MarkerOverlay = new GMapOverlay("Markers");
            PathOverlay = new GMapOverlay("Path");
            PolyOverlay = new GMapOverlay("Poly");
            gMapMain.Overlays.Add(MarkerOverlay);
            gMapMain.Overlays.Add(PathOverlay);
            gMapMain.Overlays.Add(PolyOverlay);

            //initializes lists of points used for paths and polygons
            lPointsPath = new List<PointLatLng>();
            lPointsPoly = new List<PointLatLng>();
            lPointsConvexHull = new List<PointLatLng>();

            //dtWaypoint = new DataTable();
            //dtWaypoint.Columns.Add("No.", typeof(int));
            //dtWaypoint.Columns.Add("Lat", typeof(double));
            //dtWaypoint.Columns.Add("Lng", typeof(double));
            //dGViewWaypoints.DataSource = dtWaypoint;
            //dGViewWaypoints.EditMode = DataGridViewEditMode.EditOnEnter;
        }


        private void gMapMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //places a makrer on map when mouse is clicked
                //GMarkerGoogle newMarker = new GMarkerGoogle(gMapMain.FromLocalToLatLng(e.X, e.Y), GMarkerGoogleType.green);
                //markerOverlay.Markers.Add(newMarker);

                PointLatLng newPoint = gMapMain.FromLocalToLatLng(e.X, e.Y);

                //decides what a mouseclick on the map will do depending on what drawing mode the user is in
                switch (drawingMode)
                {
                    case mode.idle:
                        break;
                    case mode.path:
                        addPointToPath(newPoint);
                        break;
                    case mode.poly:
                        addPointToPoly(newPoint);
                        break;
                }
            }
        }
        private void gMapMain_MouseMove(object sender, MouseEventArgs e)
        {
            //updates status bar with current lat long coordinates of mouse position
            statLat.Text = string.Format("Lat: {000}", gMapMain.FromLocalToLatLng(e.X, e.Y).Lat);
            statLng.Text = string.Format("Long: {000}", gMapMain.FromLocalToLatLng(e.X, e.Y).Lng);
        }

        private void updateTable()
        {
            //displays waypoint coordinates for flight path in table
            dGViewWaypoints.Rows.Clear();
            if (lPointsPath.Count > 0)
                 dGViewWaypoints.Rows.Add(lPointsPath.Count);
            for (int i = 0; i < lPointsPath.Count; i++)
            {
                dGViewWaypoints.Rows[i].Cells[0].Value = (i + 1).ToString();
                dGViewWaypoints.Rows[i].Cells[1].Value = lPointsPath[i].Lat.ToString();
                dGViewWaypoints.Rows[i].Cells[2].Value = lPointsPath[i].Lng.ToString();
            }
            /*dtWaypoint.Rows.Clear();
            if (lPointsPath.Count > 0)
                dtWaypoint.Rows.Add(lPointsPath.Count);
            for (int i = 0; i < lPointsPath.Count; i++)
            {
                dtWaypoint.Rows.Add(10, 20, 6);
            }*/
        }

        private void addPointToPath(PointLatLng point)
        {
            lPointsPath.Add(point);
            addPathMarker(point);
            RenderPath();
        }
        public void addPathMarker(PointLatLng point)
        {
            if (lPointsPath.Count == 1)
            {
                //adds a marker to the begginging of the path
                GMarkerGoogle newMarker = new GMarkerGoogle(point, GMarkerGoogleType.green);
                MarkerOverlay.Markers.Add(newMarker);
            }
            else if (lPointsPath.Count > 2)
            {
                //adds markers to each point on the path except the first
                //leaves most recent point empty in case the path is ended there and the ending marker needs to be placed
                GMarkerGoogle newMarker = new GMarkerGoogle(lPointsPath[lPointsPath.Count - 2], GMarkerGoogleType.gray_small);
                MarkerOverlay.Markers.Add(newMarker);
            }
        }
        public void addPathMarkers()
        {
            GMarkerGoogle newMarker = new GMarkerGoogle(lPointsPath[0], GMarkerGoogleType.green);
            MarkerOverlay.Markers.Add(newMarker);
            for (int i = 1; i < lPointsPath.Count - 1; i++)
            {
                newMarker = new GMarkerGoogle(lPointsPath[i], GMarkerGoogleType.gray_small);
                MarkerOverlay.Markers.Add(newMarker);
            }
            newMarker = new GMarkerGoogle(lPointsPath[lPointsPath.Count - 1], GMarkerGoogleType.red);
            MarkerOverlay.Markers.Add(newMarker);
        }
        private void RenderPath()
        {
            GMapRoute path = new GMapRoute(lPointsPath, "Path");
            PathOverlay.Clear();
            PathOverlay.Routes.Add(path);
            updateTable();
        }

        private void GenerateSurvey()
        {
            MarkerOverlay.Clear();

            FlightPath.GenerateSurvey(lPointsPoly, lPointsConvexHull, lPointsPath, (double)nudPathSpacing.Value, (double)nudPointSpacing.Value, (90 - (double)nudPathAngle.Value) * (Math.PI/180));
            foreach (PointLatLng point in lPointsPath)
                addPathMarkers();
            RenderPath();
        }

        private void beginPath()
        {
            //enables all buttons and textboxes necessary for creating a path 
            //sets the correct drawing mode
            drawingMode = mode.path;
            btnPathBegin.Enabled = false;
            btnPathEnd.Enabled = true;
            txbxLatPath.Enabled = true;
            txbxLngPath.Enabled = true;
            btnAddPathPoint.Enabled = true;
        }
        private void endPath()
        {
            //disables all buttons and textboxes necessary for creating a path 
            //sets the correct drawing mode
            drawingMode = mode.idle;
            btnPathBegin.Enabled = true;
            btnPathEnd.Enabled = false;
            txbxLatPath.Enabled = false;
            txbxLngPath.Enabled = false;
            btnAddPathPoint.Enabled = false;
        }
        private void clearPath()
        {
            endPath();
            PathOverlay.Clear();
            lPointsPath.Clear();
            MarkerOverlay.Clear();
            dGViewWaypoints.Rows.Clear();
        }
        private void btnPathBegin_Click(object sender, EventArgs e)
        {
            clearPath();
            beginPath();
        }
        private void btnPathEnd_Click(object sender, EventArgs e)
        {
            endPath();
            //adds marker to end of path
            if (lPointsPath.Count > 0)
            {
                GMarkerGoogle newMarker = new GMarkerGoogle(lPointsPath.Last<PointLatLng>(), GMarkerGoogleType.red);
                MarkerOverlay.Markers.Add(newMarker);
            }
        }
        private void btnPathClear_Click(object sender, EventArgs e)
        {
            clearPath();
        }
        private void btnAddPathPoint_Click(object sender, EventArgs e)
        {
            try
            {
            addPointToPath(new PointLatLng(Convert.ToDouble(txbxLatPath.Text), Convert.ToDouble(txbxLngPath.Text)));
            }
            catch
            {
                MessageBox.Show("Enter Valid Coordinates"); 
            }
        }

        private void addPointToPoly(PointLatLng point)
        {
            lPointsPoly.Add(point);

            GMapPolygon poly = new GMapPolygon(lPointsPoly, "Poly");
            PolyOverlay.Clear();
            PolyOverlay.Polygons.Add(poly);
        }
        private void beginPoly()
        {
            //enables all buttons and textboxes necessary for creating a path 
            //sets the correct drawing mode
            drawingMode = mode.poly;
            btnPolyBegin.Enabled = false;
            btnPolyEnd.Enabled = true;
            txbxLatPoly.Enabled = true;
            txbxLngPoly.Enabled = true;
            btnAddPolyPoint.Enabled = true;
        }
        private void endPoly()
        {
            //disables all buttons and textboxes necessary for creating a polygon 
            //sets the correct drawing mode
            drawingMode = mode.idle;
            btnPolyBegin.Enabled = true;
            btnPolyEnd.Enabled = false;
            txbxLatPoly.Enabled = false;
            txbxLngPoly.Enabled = false;
            btnAddPolyPoint.Enabled = false;
            lPointsConvexHull = new List<PointLatLng>(lPointsPoly);
            Geometry.ConvexHull(lPointsConvexHull);
        }
        private void clearPoly()
        {
            endPoly();
            PolyOverlay.Clear();
            lPointsPoly.Clear();
            lPointsConvexHull.Clear();
        }
        private void btnPolyBegin_Click(object sender, EventArgs e)
        {
            clearPath();
            clearPoly();
            beginPoly();
        }
        private void btnPolyEnd_Click(object sender, EventArgs e)
        {
            endPoly();
            //Geometry.ConvexHull(lPointsPoly);
            GMapPolygon poly = new GMapPolygon(lPointsPoly, "Poly");
            PolyOverlay.Clear();
            PolyOverlay.Polygons.Add(poly);

            GenerateSurvey();
        }
        private void btnPolyClear_Click(object sender, EventArgs e)
        {
            clearPoly();
        }
        private void btnAddPolyPoint_Click(object sender, EventArgs e)
        {
            try
            {
                addPointToPoly(new PointLatLng(Convert.ToDouble(txbxLatPoly.Text), Convert.ToDouble(txbxLngPoly.Text)));
            }
            catch
            {
                MessageBox.Show("Enter Valid Coordinates");
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Save Text File";
            dialog.Filter = "TXT files|*.txt";
            dialog.InitialDirectory = @"C:\";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FlightPath.ExportToText(lPointsPath, dialog.FileName.ToString());
            }
        }

        //handles pan, zoom, and all other options related to displaying map
        #region Map Controls

        //binds scroll zoom and track bar zooming so they work together
        private void trBarZoom_Scroll(object sender, EventArgs e)
        {
            gMapMain.Zoom = trBarZoom.Value;
        }
        private void gMapMain_OnMapZoomChanged()
        {
            trBarZoom.Value = (int)gMapMain.Zoom;
        }

        #endregion

        private void nudPathSpacing_ValueChanged(object sender, EventArgs e)
        {
            GenerateSurvey();
        }

        private void nudPointSpacing_ValueChanged(object sender, EventArgs e)
        {
            GenerateSurvey();
        }

        private void nudPathAngle_ValueChanged(object sender, EventArgs e)
        {
            GenerateSurvey();
        }
    }
}
