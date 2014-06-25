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
        public double ccw(double p1x, double p1y, double p2x, double p2y, double p3x, double p3y)
        {
            //uses similar algorithm to calculate area function (cross product)
            //as cross product will return positive direction if 
            return (p2x - p1x) * (p3y - p1y) - (p2y - p1y) * (p3x - p1x);
        }

        public double GetAngle(double p1x, double p1y, double p2x, double p2y, double p3x, double p3y)
        {
            //not actually used in program as creates errors when measuring angles that cross the boundary conditions

            //finds the angle between 3 points by finding the slope of each set of 2 points
            //with p2 as the common centre point
            //then calculating the difference in slope
            double deltaX12 = p2x - p1x;
            double deltaY12 = p2y - p1y;
            double dSlope12 = Math.Atan2(deltaY12, deltaX12);

            double deltaX23 = p3x - p2x;
            double deltaY23 = p3y - p2y;
            double dSlope23 = Math.Atan2(deltaY23, deltaX23);

            // Zone the angles
            if (dSlope12 < 0) dSlope12 += 2*Math.PI;
            if (dSlope23 < 0) dSlope23 += 2 * Math.PI;
            return Math.PI - (dSlope23 - dSlope12);
        }

        public bool PointInPoly(PointLatLng pTest, List<PointLatLng> lPoints)
        {
            // Experimental check this danielslslsllllllllllllllllllllllllllllllllllllllllllllllllllllllllllll
            int i1;
            int i2;
            double dNetAngle = 0;

            for (int i = 0; i < lPoints.Count; i++)
            {
                i1 = i;
                i2 = (i + 1) % lPoints.Count;

                dNetAngle += GetAngle(lPoints[i1].Lng, lPoints[i1].Lat, pTest.Lng, pTest.Lat, lPoints[i2].Lng, lPoints[i2].Lat);
            }

            return (dNetAngle != 0);

        }
        public void ConvexHull(List<PointLatLng> lPoints)
        {
            //any polygons drawn willautomatically be edited so that they progress in an anticlockwise direction
            //otherwise this convex hull function would be measuring the outside angles
            //and this would cause it to remove all the wrong points.
            if (CalculateArea(lPoints) < 0)
            {
                ReverseList(ref lPoints);
            }

            double dCcw;
            bool bDone;

            int iLoopCount = 0;

            do
            {
                
                bDone = true;
                for (int i = 0; i < lPoints.Count; i++)
                {
                    int i1 = i;
                    int i2 = (i + 1) % lPoints.Count;
                    int i3 = (i + 2) % lPoints.Count;
                    dCcw = ccw(lPoints[i1].Lng, lPoints[i1].Lat, lPoints[i2].Lng, lPoints[i2].Lat, lPoints[i3].Lng, lPoints[i3].Lat);
                    if (dCcw < 0)
                    {
                        if (!LineIntersectPoly(lPoints, lPoints[i1], lPoints[i3]))
                        {
                            lPoints.RemoveAt(i2);
                            i -= 2;
                            if (i < 0) i = 0;
                        }
                        else
                            bDone = false; 
                    }
                }
            } while (!bDone && ++iLoopCount <4);

            //return lPoints;
        }
        public void ReverseList(ref List<PointLatLng> lPoints)
        {
            PointLatLng pTemp;
            for (int i = 0, j = lPoints.Count - 1; i < (lPoints.Count/2); i++, j--)
            {
                //loops through half list swapping 1st and last, then 2nd and 2nd last etc.
                pTemp = lPoints[i];
                lPoints[i] = lPoints[j];
                lPoints[j] = pTemp;
            }
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
                //its magnitude also happens to represent the area of the parallelogram enclosed by the vectors
                dArea += v1x * v2y - v1y * v2x;
            }
            return dArea/2;
        }


        public bool PointOnLine(PointLatLng pointP, PointLatLng pointL1, PointLatLng pointL2)
        {
            //used as a test for if an intersection point is on a line
            //actually returns wether or not the point is within the rectangle created by the line

            double dFudge = -0.000001;       // This is used to avoid rounding errors causing false positives
            double dLngMax = Math.Max(pointL1.Lng, pointL2.Lng) - dFudge;
            double dLngMin = Math.Min(pointL1.Lng, pointL2.Lng) + dFudge;
            double dLatMax = Math.Max(pointL1.Lat, pointL2.Lat) - dFudge;
            double dLatMin = Math.Min(pointL1.Lat, pointL2.Lat) + dFudge;
            if (dLngMin <= pointP.Lng && pointP.Lng <= dLngMax && 
                dLatMin <= pointP.Lat && pointP.Lat <= dLatMax) return true;
    	    return(false);
        }


        public int LineIntersect(PointLatLng point11, PointLatLng point12, PointLatLng point21, PointLatLng point22, ref PointLatLng pointInt)
        {
            //function intersects two line segments.
            // return 0 - no intersection (parallel)
            //        1 - intersect not on either segment
            //        2 - intersects only on segment 1 (points 11 and 12)
            //        3 - intersects only on segment 2 (points 21 and 22)
            //        4 - intersects on both segments

            
            double a1, b1, c1, a2, b2, c2;
            double d;
            bool bInside1, bInside2;

            // Calculate LINE 1 coefficients
            a1 = point12.Lat - point11.Lat;
            b1 = point11.Lng - point12.Lng;
            c1 = (point12.Lng * point11.Lat) -
                 (point11.Lng * point12.Lat);

            // Calculate LINE 2 coefficients
            a2 = point22.Lat - point21.Lat;
            b2 = point21.Lng - point22.Lng;
            c2 = ((double)point22.Lng * (double)point21.Lat) -
                 ((double)point21.Lng * (double)point22.Lat);

            // Calculate SLOPE factor and test for parallel lines
            d = (a1 * b2 - a2 * b1);
            if (d == 0.0) return (0);

            // Calculate intersection point
            pointInt.Lng = ((b1 * c2 - b2 * c1) / d);
            pointInt.Lat = ((a2 * c1 - a1 * c2) / d);

            // Test for intersection type
            bInside1 = PointOnLine(pointInt, point11, point12);
            bInside2 = PointOnLine(pointInt, point21, point22);

            return (1 + (bInside1 ? 1 : 0) + (bInside2 ? 2 : 0));
        }

        public bool LineIntersectPoly(List<PointLatLng> lPoints, PointLatLng point1, PointLatLng point2)
        {
            //loops through all the lines in a polygon, 
            //checking if the line to be tested intersects with any of them
            PointLatLng pointInt = new PointLatLng();
            for (int i = 0; i < lPoints.Count; i++)
            {
                int i1 = i;
                int i2 = (i + 1) % lPoints.Count;
                if (LineIntersect(lPoints[i1], lPoints[i2], point1, point2, ref pointInt) == 4)
                    return true;
            }
            return false;
        }
        public RectLatLng GetBoundingBox(List<PointLatLng> lPoints)
        {
            //returns a rectangle that represents the X and Y (LLng and Lat) limits of a set of points
            double dYMax = lPoints[0].Lat, dYMin = lPoints[0].Lat, dXMax = lPoints[0].Lng, dXMin = lPoints[0].Lng;
            
            foreach (PointLatLng point in lPoints)
            {
                dYMax = Math.Max(dYMax, point.Lat);
                dYMin = Math.Min(dYMin, point.Lat);
                dXMax = Math.Max(dXMax, point.Lng);
                dXMin = Math.Min(dXMin, point.Lng);
            }

            RectLatLng rect = new RectLatLng(dYMax, dXMin, dXMax - dXMin, dYMax - dYMin);
            return rect;
            
        }
    }
}
