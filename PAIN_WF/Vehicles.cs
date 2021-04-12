using System;
using System.Collections.Generic;

namespace PAIN_WF
{
    public class Vehicles
    {
        public List<Vehicle> VehiclesList { get; set; } = new List<Vehicle>();

        public event Action<Vehicle> AddVehicleEvent;
        public event Action<Vehicle> EditVehicleEvent;
        public event Action<Vehicle> RemoveVehicleEvent;

        public void AddVehicle(Vehicle vehicle)
        {
            VehiclesList.Add(vehicle);
            AddVehicleEvent?.Invoke(vehicle);
        }

        public void EditVehicle(Vehicle vehicle)
        {
            EditVehicleEvent?.Invoke(vehicle);
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            VehiclesList.Remove(vehicle);
            RemoveVehicleEvent?.Invoke(vehicle);
        }
    }
}
