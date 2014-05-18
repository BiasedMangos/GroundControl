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
            return (p2x - p1x) * (p3y - p1y) - (p2y - p1y) * (p3x - p1x);
        }

        public double GetAngle(double p1x, double p1y, double p2x, double p2y, double p3x, double p3y)
        {
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

        public List<PointLatLng> ConvexHull(List<PointLatLng> lPoints)
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

            /*dCcw = ccw(lPoints[lPoints.Count - 2].Lng, lPoints[lPoints.Count - 2].Lat, lPoints[lPoints.Count - 1].Lng, lPoints[lPoints.Count - 1].Lat, lPoints[0].Lng, lPoints[0].Lat);
            if (dCcw < 0)   lPoints.RemoveAt(lPoints.Count - 1);

            dCcw = ccw(lPoints[lPoints.Count - 1].Lng, lPoints[lPoints.Count - 1].Lat, lPoints[0].Lng, lPoints[0].Lat, lPoints[1].Lng, lPoints[1].Lat);
            if (dCcw < 0) lPoints.RemoveAt(0);
            */
            return lPoints;
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
                //its magnitude also happens represents the area of the parallelogram enclosed by the vectors
                dArea += v1x * v2y - v1y * v2x;
            }
            return dArea/2;
        }


        bool PointOnLine(PointLatLng pointP, PointLatLng pointL1, PointLatLng pointL2)
        {
            double dFudge = 0.000001;       // This is used to avoid rounding errors causing false positives
            double dLngMax = Math.Max(pointL1.Lng, pointL2.Lng) - dFudge;
            double dLngMin = Math.Min(pointL1.Lng, pointL2.Lng) + dFudge;
            double dLatMax = Math.Max(pointL1.Lat, pointL2.Lat) - dFudge;
            double dLatMin = Math.Min(pointL1.Lat, pointL2.Lat) + dFudge;
            if (dLngMin < pointP.Lng && pointP.Lng < dLngMax && 
                dLatMin < pointP.Lat && pointP.Lat < dLatMax) return true;
    	    return(false);
        }


        int LineIntersect(PointLatLng point11, PointLatLng point12, PointLatLng point21, PointLatLng point22, ref PointLatLng pointInt)
        {
            double a1, b1, c1, a2, b2, c2;
            double d;
            bool bInside1, bInside2;

            /* CALC. LINE 1 COEpointpointS. */
            a1 = point12.Lat - point11.Lat;
            b1 = point11.Lng - point12.Lng;
            c1 = (point12.Lng * point11.Lat) -
                 (point11.Lng * point12.Lat);
            /* CALC. LINE 2 COEpointpointS. */
            a2 = point22.Lat - point21.Lat;
            b2 = point21.Lng - point22.Lng;
            c2 = ((double)point22.Lng * (double)point21.Lat) -
                 ((double)point21.Lng * (double)point22.Lat);

            /* CALC. SLOPE pointACTOR AND TEST pointOR PARALLEL LINES */
            d = (a1 * b2 - a2 * b1);
            if (d == 0.0) return (0);

            /* CALC. INTERSECTION */
            pointInt.Lng = ((b1 * c2 - b2 * c1) / d);
            pointInt.Lat = ((a2 * c1 - a1 * c2) / d);

            /* TEST pointOR INTERSECTION TYPE */
            bInside1 = PointOnLine(pointInt, point11, point12);
            bInside2 = PointOnLine(pointInt, point21, point22);

            if (bInside1 && bInside2)
                bInside1 = bInside1;

            return (1 + (bInside1 ? 1 : 0) + (bInside2 ? 2 : 0));
        }

        bool LineIntersectPoly(List<PointLatLng> lPoints, PointLatLng point1, PointLatLng point2)
        {
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
    }
}
