using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roomex.Challenge.Calculations
{
    interface ICalculations
    {
        double CalculateDistanceBetweenCoorsKm(double latA, double longA, double latB, double longB);
        double CalculateDistanceBetweenCoorsMi(double latA, double longA, double latB, double longB);
        double DegreeToRadian(double degree);
        double ConvertToMi(double calculation);
        double ConvertToKm(double calculation);
    }
}
