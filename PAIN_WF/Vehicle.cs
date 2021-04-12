using System;

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

        #region Data
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

        #endregion

        public Vehicle(string brand, long maxSpeed, DateTime productionDate, VehicleType vehicleType)
        {
            Brand = brand;
            MaxSpeed = maxSpeed;
            ProductionDate = productionDate;
            Type = vehicleType;
        }
    }
}
