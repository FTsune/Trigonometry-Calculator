using System;
using System.Collections.Generic;
using System.Text;

namespace TrigonometryLibrary
{
    public class CalculateUsingCos : TrigonometryModel
    {
        public double SolveAngle()
        {
            var angle = Adjacent / Hypotenuse;
            var radians = Math.Acos(angle);

            return Math.Round(radians * (180 / Math.PI), 2);
        }
        public double SolveAdjacent()
        {
            return Math.Round(Math.Cos(Angle * (Math.PI / 180)) * Hypotenuse, 2);
        }
        public double SolveHypotenuse()
        {
            return Math.Round(Adjacent / Math.Cos(Angle * (Math.PI / 180)), 2);
        }
    }
}
