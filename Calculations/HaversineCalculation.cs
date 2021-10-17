using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roomex.Challenge.Calculations
{
    public class HaversineCalculation : ICalculations
    {
        private const int EarthRadiusKm = 6371;

        //Performing Haversine Formula on Latitude and Longitude in Radians
        private double HaverCal(double latA, double longA, double latB, double longB)
        {
            double differenceLat = latB - latA;
            double differenceLong = longB - longA;

            double firstCal = Math.Pow(Math.Sin(differenceLat / 2), 2) + Math.Cos(latA) * Math.Cos(latB) * Math.Pow(Math.Sin(differenceLong / 2), 2);
            double finalCal = 2 * Math.Asin(Math.Sqrt(firstCal));
            return finalCal;
        }

        //Calculating the distance between the coordinates in KM
        public double CalculateDistanceBetweenCoorsKm(double latA, double longA, double latB, double longB)
        {
            latA = DegreeToRadian(latA);
            longA = DegreeToRadian(longA);
            latB = DegreeToRadian(latB);
            longB = DegreeToRadian(longB);

            double haverCal = HaverCal(latA, longA, latB, longB);
            double distance = ConvertToKm(haverCal);

            return Math.Round((distance), 2); //Rounded to 2 decimal places 
        }

        //Converting degrees to radians
        public double DegreeToRadian(double degree)
        {
            double oneDegree = Math.PI / 180; //Calculating one degree
            double degreeToRadian = oneDegree * degree;

            return degreeToRadian;
        }

        //Converting the Haversine calculation to KM
        public double ConvertToKm(double calculation)
        {
            double distanceKm = calculation * EarthRadiusKm;
            return distanceKm;
        }

        //Converting the Haversine calculation to Miles
        public double ConvertToMi(double calculation)
        {
            throw new NotImplementedException();
        }

        //Calculating the distance between the coordinates in Miles
        public double CalculateDistanceBetweenCoorsMi(double latA, double longA, double latB, double longB)
        {
            throw new NotImplementedException();
        }
    }
}
