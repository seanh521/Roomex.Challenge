using Roomex.Challenge.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Roomex.Challenge.Calculations;

namespace Roomex.API.Controllers
{
    [Route("api/coordinates")]
    [ApiController]
    public class CoordinatesController : ControllerBase
    {
        private HaversineCalculation haversineCalculation = new HaversineCalculation();

        //POST api/coordinates
        [HttpPost]
        public async Task<IActionResult> Post(Coordinates coors)
        {
            double distanceKm = haversineCalculation.CalculateDistanceBetweenCoorsKm(coors.LatA, coors.LongA, coors.LatB, coors.LongB); //Calculating the Haversine Distance
            Console.WriteLine($"\n=========================\nDistance in KM: {distanceKm}\n=========================\n");
            return await Task.FromResult(Ok());
        }
    }
}
