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

namespace GroundControl
{
    public partial class frmMain : Form
    {
        int iMaxZoom = 20;
        int iMinZoom = 3;
        int istartZoom = 13;


        public frmMain()
        {
            InitializeComponent();

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
            trBarZoom.Value = istartZoom;
            gMapMain.Zoom = istartZoom;
            
            
        }

        private void trBarZoom_Scroll(object sender, EventArgs e)
        {
            gMapMain.Zoom = trBarZoom.Value;
        }
        private void gma
    }
}
