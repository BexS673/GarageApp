using GarageApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GarageApp.Models.Size;
using static GarageApp.Models.VehicleType;

namespace GarageApp.Models
{
    public class Car : Vehicle
    {

        public override SizeType Size { get; }
        protected override VehicleTypes TypeOfVehicle { get; }
        public Car(string registration) : base (registration)
        {
            Size = SizeType.Medium;
            TypeOfVehicle= VehicleTypes.Car;
        }

        public override void PayForParking(Garage garage)
        {
            Console.WriteLine( $"Driver has paid £5.00 for parking here \r\n");
            garage.AddToPot(5.00);

        }

        

    }
}
