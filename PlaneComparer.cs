﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsPlanes
{
    class PlaneComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is Hydroplane && y is Hydroplane)
            {
                return ComparerHydroplane((Hydroplane)x, (Hydroplane)y);
            }
            if (x is Hydroplane && y is Plane)
            {
                return -1;
            }
            if (x is Plane && y is Hydroplane)
            {
                return 1;
            }
            if (x is Plane && y is Plane)
            {
                return ComparerPlane((Plane)x, (Plane)y);
            }
            return 0;
        }
        private int ComparerPlane(Plane x, Plane y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerHydroplane(Hydroplane x, Hydroplane y)
        {
            int res = ComparerPlane(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.FrontFloat != y.FrontFloat)
            {
                return x.FrontFloat.CompareTo(y.FrontFloat);
            }
            if (x.SideFloat != y.SideFloat)
            {
                return x.SideFloat.CompareTo(y.SideFloat);
            }
            if (x.BackFloat != y.BackFloat)
            {
                return x.BackFloat.CompareTo(y.BackFloat);
            }
            return 0;
        }
    }
}
