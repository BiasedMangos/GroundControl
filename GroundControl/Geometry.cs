using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GMap.NET;


//class that contains all geometric algorithms necessary for flight path to class 
//to create flight paths e.g. intersecting lines, checking if a point is in a polygon
namespace GroundControl
{
    class Geometry
    {
        public double GetAngle(double p1x, double p1y, double p2x, double p2y, double p3x, double p3y)
        {
            //finds the angle between 3 points by finding the slope of each set of 2 points
            //with p2 as the common centre point
            //then calculating the difference in slope
            double deltaX12 = p2x - p1x;
            double deltaY12 = p2y - p1y;
            double dSlope12 = Math.Atan2(deltaY12, deltaX12);

            double deltaX23 = p2x - p1x;
            double deltaY23 = p2y - p1y;
            double dSlope23 = Math.Atan2(deltaY23, deltaX23);

            return dSlope23 - dSlope12;
        }

        public List<PointLatLng> ConvexHull(List<PointLatLng> lPoints)
        {
            //any polygons drawn willautomatically be edited so that they progress in an anticlockwise direction
            //otherwise this convex hull function would be measuring the outside angles
            //and this would cause it to remove all the wrong points.

            int iDirectionTest;
            iDirectionTest = (CalculateArea(lPoints) > 0 ? 1 :  -1);

            double dAngle;

            for (int i = 0; i < lPoints.Count - 2; i++)
            {
                dAngle = GetAngle(lPoints[i].Lng, lPoints[i].Lat, 
                                  lPoints[i + 1].Lng, lPoints[i + 1].Lat, 
                                  lPoints[i + 2].Lng, lPoints[i + 2].Lat);
                if (dAngle > Math.PI)
                {
                    lPoints.RemoveAt(i + 1);
                    i -= 2;
                }
            }
            return lPoints;
        }

        public double CalculateArea(List<PointLatLng> lPoints)
        {
            double dArea = 0;

            for (int i = 1; i < lPoints.Count - 1; i++)
            {
                //turns a set of three points into two vectors so that the cross product can be used
                //iterates through each point taking it and the next point as two of the points for the vector
                //the third point is arbitrary for this algorithm so the first point is used for simplicity
                double v1x = lPoints[0].Lng - lPoints[i].Lng;
                double v1y = lPoints[0].Lat - lPoints[i].Lat;
                double v2x = lPoints[0].Lng - lPoints[i+1].Lng;
                double v2y = lPoints[0].Lat - lPoints[i+1].Lat;

                //the vector cross product is applied to the vectors
                //the cross product usually creates another vector perpendicular to both initial vectors
                //its magnitude also happens represents the area of the parallelogram enclosed by the vectors
                dArea += v1x * v2y - v1y * v2x;
            }

            return dArea/2;
        }
    }
}
