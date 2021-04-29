using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ElevatorControl.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuildingController : ControllerBase
    {
        [HttpPut]
        [Route("summontofloor/{floor:int}")]
        public void SummonElevator(int floor)
        {
            //  Someone is standing outside several elevators and pushes the button to summon any of them
            return;
        }
    }
}
