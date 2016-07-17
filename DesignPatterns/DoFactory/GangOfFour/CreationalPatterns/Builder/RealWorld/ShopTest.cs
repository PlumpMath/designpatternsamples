using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.CreationalPatterns.Builder.RealWorld
{
    public class ShopTest
    {
        public void Test()
        {
            Shop shop = new Shop();

            VehicleBuilder scooterBuilder = new ScooterBuilder();
            shop.Construct(scooterBuilder);
            scooterBuilder.Vehicle.Show();

            VehicleBuilder carBuilder = new CarBuilder();
            shop.Construct(carBuilder);
            carBuilder.Vehicle.Show();

            VehicleBuilder motorcycleBuilder = new MotorcycleBuilder();
            shop.Construct(motorcycleBuilder);
            motorcycleBuilder.Vehicle.Show();
        }
    }
}
