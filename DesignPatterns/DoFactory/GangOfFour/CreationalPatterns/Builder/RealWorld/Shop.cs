using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.CreationalPatterns.Builder.RealWorld
{
    public class Shop
    {
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }

    public abstract class VehicleBuilder
    {
        private Vehicle _vehicle;

        public Vehicle Vehicle
        {
            get
            {
                return _vehicle;
            }

            set
            {
                _vehicle = value;
            }
        }

        public abstract void BuildDoors();
        public abstract void BuildEngine();
        public abstract void BuildFrame();
        public abstract void BuildWheels();
    }

    public class MotorcycleBuilder : VehicleBuilder
    {
        public MotorcycleBuilder()
        {
            Vehicle = new Vehicle("Motorcycle");
        }

        public override void BuildDoors()
        {
            Vehicle["doors"] = "0";
        }

        public override void BuildEngine()
        {
            Vehicle["engine"] = "500 cc";
        }

        public override void BuildFrame()
        {
            Vehicle["frame"] = "Motorcycle Frame";
        }

        public override void BuildWheels()
        {
            Vehicle["wheels"] = "2";
        }
    }

    public class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            Vehicle = new Vehicle("Scooter");
        }

        public override void BuildDoors()
        {
            Vehicle["doors"] = "0";
        }

        public override void BuildEngine()
        {
            Vehicle["engine"] = "50 cc";
        }

        public override void BuildFrame()
        {
            Vehicle["frame"] = "Scooter Frame";
        }

        public override void BuildWheels()
        {
            Vehicle["wheels"] = "2";
        }
    }

    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            Vehicle = new Vehicle("Scooter");
        }

        public override void BuildDoors()
        {
            Vehicle["doors"] = "4";
        }

        public override void BuildEngine()
        {
            Vehicle["engine"] = "2500 cc";
        }

        public override void BuildFrame()
        {
            Vehicle["frame"] = "Car Frame";
        }

        public override void BuildWheels()
        {
            Vehicle["wheels"] = "4";
        }
    }

    public class Vehicle
    {
        private string _vehicleType;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public Vehicle(string vehicleType)
        {
            this._vehicleType = vehicleType;
        }

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", _vehicleType);
            Console.WriteLine(" Frame : {0}", _parts["frame"]);
            Console.WriteLine(" Engine : {0}", _parts["engine"]);
            Console.WriteLine(" #Wheels: {0}", _parts["wheels"]);
            Console.WriteLine(" #Doors : {0}", _parts["doors"]);
        }
    }
}
