using System;
using System.Collections.Generic;
using System.Text;

namespace ElevatorControl.Models
{
    public class Building
    {
        public int BasementLevelCount { get; set; }

        public bool[] FloorStops { get; set; }
    }
}
