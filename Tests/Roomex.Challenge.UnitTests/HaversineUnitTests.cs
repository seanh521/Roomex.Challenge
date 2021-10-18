using Roomex.Challenge.Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roomex.Challenge.Tests.Roomex.Challenge.UnitTests
{
    public class HaversineUnitTests
    {
        //[Fact]
        public void IsCalculationCorrectInKm_GivenSpecificInput_ReturnsTrue()
        {
            //Arrange
            HaversineCalculation haversineCalculation = new HaversineCalculation();
            double givenLatA = 53.297975;
            double givenLongA = -6.372663;
            double givenLatB = 41.385101;
            double givenLongB = -81.440440;
            double expectedResult = 5536.34;

            //Act
            double result = haversineCalculation.CalculateDistanceBetweenCoorsKm(givenLatA, givenLongA, givenLatB, givenLongB);

            //Assert
            //Assert.Equal(expectedResult, result);
        }
    }
}
