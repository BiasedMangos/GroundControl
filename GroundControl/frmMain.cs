﻿using System;
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
        int iStartZoom = 13;

        GMapOverlay MarkerOverlay;
        GMapOverlay PathOverlay;
        GMapOverlay PolyOverlay;

        BindingList<PointLatLng> pointsPath;
        List<PointLatLng> pointsPoly;

        enum mode { idle, path, poly }
        mode drawingMode;

        public frmMain()
        {
            InitializeComponent();

            drawingMode = mode.idle;

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
            pointsPath = new BindingList<PointLatLng>();
            pointsPoly = new List<PointLatLng>();

            //dGViewWaypoints.DataSource = pointsPath;
            //dGViewWaypoints.Columns[0] = 
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
            dGViewWaypoints.Rows.Add(1);
            for (int i = 0; i < pointsPath.Count; i++)
            {
                
                dGViewWaypoints.Rows[i].Cells[0].Value = (i + 1).ToString();
                dGViewWaypoints.Rows[i].Cells[1].Value = pointsPath[i].Lat.ToString();
                dGViewWaypoints.Rows[i].Cells[2].Value = pointsPath[i].Lng.ToString();
            }
        }

        private void addPointToPath(PointLatLng point)
        {
            pointsPath.Add(point);

            GMapRoute path = new GMapRoute(pointsPath, "Path");
            PathOverlay.Clear();
            PathOverlay.Routes.Add(path);

            if (pointsPath.Count == 1)
            {
                //adds a marker to the begginging of the path
                GMarkerGoogle newMarker = new GMarkerGoogle(point, GMarkerGoogleType.green);
                MarkerOverlay.Markers.Add(newMarker);
            }
            else if (pointsPath.Count > 2)
            {
                //adds markers to each point on the path except the first
                //leaves most recent point empty in case the path is ended there and the ending marker needs to be placed
                GMarkerGoogle newMarker = new GMarkerGoogle(pointsPath[pointsPath.Count - 2],GMarkerGoogleType.gray_small);
                MarkerOverlay.Markers.Add(newMarker);
            }
            updateTable();
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
        private void btnPathBegin_Click(object sender, EventArgs e)
        {
            beginPath();
        }
        private void btnPathEnd_Click(object sender, EventArgs e)
        {
            endPath();
            //adds marker to end of path
            GMarkerGoogle newMarker = new GMarkerGoogle(pointsPath.Last<PointLatLng>(), GMarkerGoogleType.red);
            MarkerOverlay.Markers.Add(newMarker);
        }
        private void btnPathClear_Click(object sender, EventArgs e)
        {
            endPath();
            PathOverlay.Clear();
            pointsPath.Clear();
            MarkerOverlay.Clear();
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
            pointsPoly.Add(point);

            GMapPolygon poly = new GMapPolygon(pointsPoly, "Poly");
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
        }
        private void btnPolyBegin_Click(object sender, EventArgs e)
        {
            beginPoly();
        }
        private void btnPolyEnd_Click(object sender, EventArgs e)
        {
            endPoly();
        }
        private void btnPolyClear_Click(object sender, EventArgs e)
        {
            endPoly();
            PolyOverlay.Clear();
            pointsPoly.Clear();
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



    }
}
