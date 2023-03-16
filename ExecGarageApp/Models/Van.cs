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
    public class Van : Vehicle
    {

        public override SizeType Size { get; }
        protected override VehicleTypes TypeOfVehicle { get; }
        public Van(string registration) : base(registration)
        {
            Size = SizeType.Large;
            TypeOfVehicle = VehicleTypes.Van;
        }

        public override void PayForParking(Garage garage)
        {
            Console.WriteLine($"Driver has paid £15.00 for parking here \r\n");
            garage.AddToPot(15.00);
        }



    }
    
}
