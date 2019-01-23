using System;

namespace AutobaseSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver1 = new Driver("Jojo");
            Car car1 = new Car("Devyatka", CarState.OK);
            Dispatcher.SetFlight(driver1, new Flight(), car1);
            Dispatcher.SetFlight(new Driver("Killua"), new Flight(), new Car("Shesterka", CarState.Broken));
            driver1.RepairRequest();
            driver1.SetCompletitionMark();
            driver1.SetCarStateMark();
            Dispatcher.RemoveFromWork(driver1);
            Console.ReadLine();
        }
    }
}
