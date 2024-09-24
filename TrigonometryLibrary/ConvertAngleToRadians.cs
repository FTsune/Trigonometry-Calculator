using System;
using System.Collections.Generic;
using System.Text;

namespace TrigonometryLibrary
{
    public class ConvertAngleToRadians
    {
        public double ConvertToRadians(double angle)
        {
            return Math.Round(angle * (Math.PI / 180), 4);
        }
    }
}
