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
        Geometry Geometry;
        public FlightPath()
        {
            Geometry = new Geometry();   
        }

        public void GenerateSurvey(List<PointLatLng> lPointsPoly, List<PointLatLng> lPointsConvexHull, List<PointLatLng> lPointsPath, double dPathSpacing, double dPointSpacing, double dAngle)
        {
            //checks that we have a valid survey polygon
            if (lPointsConvexHull.Count < 3)
                return;

            //path spacing will be input in metres but algorithm works in degrees
            //for now a fudge multip[lier will get it close when at the equator
            dPathSpacing = dPathSpacing * 0.00001;
            dPointSpacing = dPointSpacing * 0.00001;

            lPointsPath.Clear();
            RectLatLng rect = Geometry.GetBoundingBox(lPointsConvexHull);
            double dRadius = Math.Sqrt(Math.Pow((rect.Right - rect.Left), 2) + Math.Pow((rect.Top - rect.Bottom), 2))/2; //pythagoras

            PointLatLng point1 = new PointLatLng(rect.LocationMiddle.Lat + (dRadius * Math.Sin(dAngle)), rect.LocationMiddle.Lng + (dRadius * Math.Cos(dAngle)));
            PointLatLng point2 = new PointLatLng(rect.LocationMiddle.Lat - (dRadius * Math.Sin(dAngle)), rect.LocationMiddle.Lng - (dRadius * Math.Cos(dAngle)));

            PointLatLng pStart = new PointLatLng();
            PointLatLng pEnd = new PointLatLng();

            double dPathOffsetX = dPathSpacing * Math.Cos(dAngle + Math.PI/2);
            double dPathOffsetY = dPathSpacing * Math.Sin(dAngle + Math.PI/2);

            int iNumLines2 = (int)(dRadius / dPathSpacing);

            for (int i = -iNumLines2; i < iNumLines2; i++)
            {
                pStart.Lat = point1.Lat + i * dPathOffsetY;
                pStart.Lng = point1.Lng + i * dPathOffsetX;
                pEnd.Lat = point2.Lat + i * dPathOffsetY;
                pEnd.Lng = point2.Lng + i * dPathOffsetX;
                if (ClipLineToPoly(lPointsPoly, ref pStart, ref pEnd) == 1)
                {
                    if ((i % 2) == 0) //  reverses direction of every second pass of the flight path to create a zig zag pattern
                    {
                        fillSegment(pStart, pEnd, dPointSpacing, lPointsPath);
                        //lPointsPath.Add(pStart);
                        lPointsPath.Add(pEnd);
                    }
                    else
                    {
                        fillSegment(pEnd, pStart, dPointSpacing, lPointsPath);
                        //lPointsPath.Add(pEnd);
                        lPointsPath.Add(pStart);
                    }
                }
            }

            //test stub designed to display output of bounding box algorithm
            /*lPointsPath.Add(rect.LocationTopLeft);
            lPointsPath.Add(rect.LocationRightBottom);
            lPointsPath.Add(rect.LocationMiddle);
            lPointsPath.Add(new PointLatLng(rect.LocationMiddle.Lat + dRadius, rect.LocationMiddle.Lng));
            */

            //test stub designed to easily display output of convex hull algorithm (no longer used)
            /*foreach (PointLatLng point in lPointsConvexHull)
            {
                lPointsPath.Add(point);
            }*/
        }
        public int ClipLineToPoly(List<PointLatLng> lPoints, ref PointLatLng point1, ref PointLatLng point2)
        {
            PointLatLng pointInt = new PointLatLng();
            List<PointLatLng> lIntersections = new List<PointLatLng>();
            for (int i = 0; i < lPoints.Count; i++)
            {
                int i1 = i;
                int i2 = (i + 1) % lPoints.Count;
                if (Geometry.LineIntersect(lPoints[i1], lPoints[i2], point1, point2, ref pointInt) == 4)
                    lIntersections.Add(pointInt);
            }

            if (lIntersections.Count < 2)
                return 0;
            else
            {
                if (point1.Lat != point2.Lat)
                {
                    lIntersections.Sort(
                        delegate(PointLatLng p1, PointLatLng p2)
                        {
                            return p1.Lat.CompareTo(p2.Lat);
                        }
                    );
                    point1 = lIntersections[0];
                    point2 = lIntersections[lIntersections.Count - 1];
                    return 1;
                }
                else
                {
                    lIntersections.Sort(
                        delegate(PointLatLng p1, PointLatLng p2)
                        {
                            return p1.Lng.CompareTo(p2.Lng);
                        }
                    );
                    point1 = lIntersections[0];
                    point2 = lIntersections[lIntersections.Count - 1];
                    return 1;
                }
            }
        }

        public double getDistanceFromLatLonInKm(double dLat1, double dLon1, double dLat2, double dLon2) 
        {
            var R = 6367444; // average Radius of the earth in metres, will give a close enough approximation for our purpose
            var dLat = deg2rad(dLat2 - dLat1);  // deg2rad below
            var dLon = deg2rad(dLon2 - dLon1); 
            var a = 
                Math.Sin(dLat/2) * Math.Sin(dLat/2) +
                Math.Cos(deg2rad(dLat1)) * Math.Cos(deg2rad(dLat2)) * 
                Math.Sin(dLon/2) * Math.Sin(dLon/2); 
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1-a)); 
            double d = R * c; // Distance in km
            return d;
        }
        public double deg2rad(double dDeg) 
        {
            return dDeg * (Math.PI/180);
        }

        public void fillSegment( PointLatLng pStart, PointLatLng pEnd, double dPointSpacing, List<PointLatLng> lPointsPath)
        {
            double dAngle = Math.Atan2(pEnd.Lat - pStart.Lat, pEnd.Lng - pStart.Lng);

            double dPointOffsetLat = dPointSpacing * Math.Sin(dAngle);
            double dPointOffsetLng = dPointSpacing * Math.Cos(dAngle);
            for (int i = 0; i < 10; i++)
            {
                lPointsPath.Add(new PointLatLng(pStart.Lat + i * dPointOffsetLat, pStart.Lng + i * dPointOffsetLng));
            }
        }


        public void ImportFromText(string sFile)
        {
            //currently placeholder, not certain if this is a necessary functino
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
