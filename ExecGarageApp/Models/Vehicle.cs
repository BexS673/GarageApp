using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GarageApp.Models.Size;
using static GarageApp.Models.VehicleType;

namespace GarageApp.Models
{
    public abstract class Vehicle //is this an abstract class??
    {
        protected virtual  VehicleTypes TypeOfVehicle { get; } 
        private readonly SizeType size;
        public virtual SizeType Size
        { get { return size; } }
        public string Registration { get; }
        private bool isVehicleParked;
        public bool IsVehicleParked { get; set; }
        public Vehicle(string registration)
        {
            Registration = registration;
            isVehicleParked = false;
            TypeOfVehicle = VehicleTypes.Unknown;
        }

        public virtual void PayForParking(Garage garage)
        {
            Console.WriteLine("Free parking \r\n");
        }

        internal Space FindAvailableSpaceOnFloor(Floor floor)
        {

            if (NumAvailableSpaces != 0)
            {

                foreach (Space availableSpace in floor.AvailableSpaces)
                {
                    if (availableSpace.Size == Size)
                    {
                        //Console.WriteLine($"Space {availableSpace.SpaceId} of size {availableSpace.Size} is available on floor {FloorID}.");

                        return availableSpace;
                    }
                }

                return null;
            } 
            else
            {              
                return null;
            }
        }
        public void ParkVehicle(Garage garage)
        {
            if (garage.NumFloorsWithSpace != 0)
            {
                Console.WriteLine($"{TypeOfVehicle} reg {Registration} is looking for a parking space... \r\n");
                        foreach (Floor garageFloor in garage.Floors)
                        {
                                Space availableSpace = garageFloor.FindAvailableSpaceOnFloor(garageFloor);
                                if (availableSpace != null)
                                {
                                    garageFloor.FillSpace(availableSpace);
                                    if (garageFloor.FloorFull)
                                        {
                                            garage.FloorFilled();
                                        }
                                    Console.WriteLine($"Space {availableSpace.SpaceId} of size {availableSpace.Size} has been filled by" +
                                        $" {TypeOfVehicle} with reg {Registration} on Floor {garageFloor.FloorID}.");
                                    PayForParking(garage);
                                    break;
                                }
                                else if (availableSpace == null && garageFloor != garage.Floors.Last())
                                {
                                    
                                    Console.WriteLine($"No available space on floor {garageFloor.FloorID}. Moving to next floor.");
                                }
                                else
                                {
                                    Console.WriteLine($"Cannot find parking space for {TypeOfVehicle}. \r\n");
                                }
                                                   
                        }

            }

        }
    }
}
