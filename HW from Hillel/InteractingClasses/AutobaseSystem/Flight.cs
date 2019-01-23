using System;
using System.Collections.Generic;
using System.Text;

namespace AutobaseSystem
{
    class Flight
    {
        FlightState flightState;

        public Flight()
        {
            FlightState = FlightState.New;
        }

        public FlightState FlightState { get => flightState; set => flightState = value; }
    }

   public enum FlightState { New, Taken, Finished}
}
