using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GarageApp.Models.Size;
using static GarageApp.Models.VehicleType;

namespace GarageApp.Models
{
    public class Bike : Vehicle
    {

        public override SizeType Size { get; }
        protected override VehicleTypes TypeOfVehicle { get; }
        public Bike(string registration) : base(registration)
        {
            Size = SizeType.Small;
            TypeOfVehicle = VehicleTypes.Bike;
        }
    }
}
