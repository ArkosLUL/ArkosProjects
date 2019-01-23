using System;
using System.Collections.Generic;
using System.Text;

namespace AutobaseSystem
{
    class Car
    {
        string name;
        CarState state;

        public string Name { get => name;}
        public CarState State { get => state; set => state = value; }

        public Car(string name, CarState state)
        {
            this.name = name;
            this.state = state;
        }
    }
   public enum CarState { OK, Broken}
}
