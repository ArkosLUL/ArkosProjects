using System;
using System.Collections.Generic;
using System.Text;

namespace AutobaseSystem
{
    class Dispatcher
    {
        public static void SetFlight( Driver driver, Flight flight, Car car)
        {
            if(flight.FlightState == FlightState.New && driver.canDrive == true && car.State == CarState.OK)
            {
                driver.Car = car;
                driver.Flight = flight;
                driver.canDrive = false;
                flight.FlightState = FlightState.Taken;
                Console.WriteLine($"Flight was taken by the {driver.name} driver on {driver.Car.Name} car");
            }
            else
            {
                Console.WriteLine("Driver can't take this flight");
            }
        }

        public static void RemoveFromWork(Driver driver)
        {
            driver.canDrive = false;
            Console.WriteLine($"Driver {driver.name} removed from work");
        }
    }
}
