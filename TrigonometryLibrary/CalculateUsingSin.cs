using System;

namespace TrigonometryLibrary
{
    public class CalculateUsingSin : TrigonometryModel
    {
        public double SolveAngle()
        {
            var angle = Opposite / Hypotenuse;
            var radians = Math.Asin(angle);

            return Math.Round(radians * (180 / Math.PI), 2);
        }

        public double SolveOpposite()
        {
            return Math.Round(Math.Sin(Angle * (Math.PI / 180)) * Hypotenuse, 2);
        }

        public double SolveHypotenuse()
        {
            return Math.Round(Opposite / Math.Sin(Angle * (Math.PI / 180)), 2);
        }

        public double FindRadians()
        {
            var angle = Opposite / Hypotenuse;

            return Math.Round(Math.Asin(angle), 2);
        }
    }

}
