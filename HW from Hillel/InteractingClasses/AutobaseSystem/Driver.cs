using System;
using System.Collections.Generic;
using System.Text;

namespace AutobaseSystem
{
    class Driver
    {
        public readonly string name;
        Car car;
        Flight flight;
        public bool canDrive = true;

        internal Car Car { get => car; set => car = value; }
        internal Flight Flight { get => flight; set => flight = value; }

        public Driver(string name)
        {
            this.name = name;
        }

        public void SetDriver(Car car, Flight flight)
        {
            if (car.State == CarState.OK && flight.FlightState == FlightState.New)
            {
                this.Car = car;
                this.Flight = flight;
                canDrive = false;
                Console.WriteLine($"Now driver {name}, doing a flight on {car.Name}");
            }
        }

        public void RepairRequest()
        {
            canDrive = true;
            Car.State = CarState.Broken;
            Flight.FlightState = FlightState.Finished;
            Console.WriteLine($"Some trouble happens with car {Car.Name}, hurry, need to fix it");
        }

        public void SetCompletitionMark()
        {
            Flight.FlightState = FlightState.Finished;
            canDrive = true;
            Console.WriteLine($"Uhhh... Long flight was finished, now driver {name} can take another one");
        }

        public void SetCarStateMark()
        {
            Console.WriteLine($"The car state of {name} car {Car.Name} is {Car.State}");
        }
    }
}
