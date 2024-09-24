using System;
using System.Collections.Generic;
using System.Text;

namespace TrigonometryLibrary
{
    public class CalculateUsingTan : TrigonometryModel
    {
        public double SolveAngle()
        {
            var angle = Opposite / Adjacent;
            var radians = Math.Atan(angle);

            return Math.Round(radians * (180 / Math.PI), 2);
        }

        public double SolveOpposite()
        {
            return Math.Round(Math.Tan(Angle * (Math.PI / 180)) * Adjacent, 2);
        }

        public double SolveAdjacent()
        {
            return Math.Round(Opposite / Math.Tan(Angle * (Math.PI / 180)), 2);
        }
    }
}
