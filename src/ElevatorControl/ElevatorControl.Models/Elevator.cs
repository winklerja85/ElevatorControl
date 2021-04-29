using System;

namespace ElevatorControl.Models
{
    public class Elevator
    {
        public decimal CurrentFloor { get; set; }

        public bool GoingUp { get; set; }

        public int FirstSupportedFloor { get; set; }
    }
}
