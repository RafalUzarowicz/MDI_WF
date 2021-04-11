using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN_WF
{
    public enum VehicleType
    {
        Car = 0,
        Truck = 1,
        Bike = 2
    }
    public class Vehicle
    {
        public string Brand
        {
            get;
            set;
        }

        public long MaxSpeed
        {
            get;
            set;
        }

        public DateTime ProductionDate
        {
            get;
            set;
        }

        public VehicleType Type
        {
            get;
            set;
        }

        public Vehicle(string brand, long maxSpeed, DateTime productionDate, VehicleType vehicleType)
        {
            Brand = brand;
            MaxSpeed = maxSpeed;
            ProductionDate = productionDate;
            Type = vehicleType;
        }
    }
}
