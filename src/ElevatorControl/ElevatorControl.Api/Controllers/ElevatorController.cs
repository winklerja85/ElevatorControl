using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElevatorControl.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ElevatorControl.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElevatorController : ControllerBase
    {
        private readonly ILogger<ElevatorController> _logger;

        public ElevatorController(ILogger<ElevatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("{id:int}")]
        public Elevator Get(int id)
        {
            return new Elevator() 
            { 
                CurrentFloor = 1.5M,
                GoingUp = true,
                FirstSupportedFloor = 1
            };
        }

        [HttpGet]
        [Route("{id:int}/floors")]
        public bool[] Floors(int id)
        {
            // The highlighted buttons in a specific elevator
            // This is missing the first supported floor, but an elevator would know how to shift the numbers for itself

            return new bool[] { true, false, false, false, true, false, true };
        }

        [HttpGet]
        [Route("{id:int}/nextfloor")]
        public int NextFloor(int id)
        {
            // The logic behind this would actually be complicated, because a car doesn't make a decision to stop 
            // until moments before it arrives at the floor.  If two cars are descending, at the same time, only one
            // should stop.  Some other services would need to determine whether a particular car should stop.

            return 5;
        }

        [HttpPut]
        [Route("{id:int}/stops/{floor:int}")]
        public void AddStop(int id, int floor)
        {
            // A person inside a specific elevator presses a button

            return;
        }
    }
}
