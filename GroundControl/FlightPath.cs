using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using GMap.NET;


//class that contains algorithms and functions for creating and manipulating. flight paths
namespace GroundControl
{
    class FlightPath
    {
        public FlightPath()
        {
            
        }

        public void ExportToText(List<PointLatLng> lPoints, string sFile)
        {
            //exports flight plan to format suitable for use with telemtry radio program.
            //Format:
            //QGC WPL <VERSION> - 1st line
            //<INDEX> <CURRENT WP> <COORD FRAME> <COMMAND> <PARAM1> <PARAM2> <PARAM3> <PARAM4> <PARAM5/X/LONGITUDE> <PARAM6/Y/LATITUDE> <PARAM7/Z/ALTITUDE> <AUTOCONTINUE> - all other lines

            //Open File for creating
            using (StreamWriter file = new StreamWriter(sFile))
            {
                file.WriteLine("QGC WPL 110");
                
                for (int i = 0; i < lPoints.Count; i++)
                {
                    file.WriteLine(String.Format("{0}\t0\t0\t16\t0\t0\t0\t0\t{1}\t{2}\t{3}\t1", 
                                                    i.ToString(), 
                                                    lPoints[i].Lat.ToString(), 
                                                    lPoints[i].Lng.ToString(), 
                                                    "0"));
                }
            }
        }
        public void ExportToCSV(List<PointLatLng> lPoints, string sFile)
        {

        }
    }
}
