using System;

namespace CalculatingArea
{
    public class Area
    {

        public double Circle_area(double R)
        {
            double S= Math.PI * Math.Pow(R,2) ;
            return S;
        }

        public double Triangle_area (double a, double b, double c)
        {
            double p=(a+b+c)/2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }

    }
}
