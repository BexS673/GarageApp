using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GarageApp.Interfaces;
using GarageApp.Models;
using static GarageApp.Models.Size;

namespace ExecuteGarageApp
{
    public class Program
    {
        public static void Main()
        {
            static void Print(Garage garageInfo)
            {
                if (garageInfo.NumFloorsWithSpace != 0)
                {
                    Console.WriteLine("Garage info:");
                    foreach (Floor floor in garageInfo.Floors)
                    {
                        Console.WriteLine($"Floor {floor.FloorID}: {floor.NumAvailableSpaces} available spaces");

                        foreach (Space availableSpace in floor.AvailableSpaces)
                        {
                            Console.WriteLine($"Space {availableSpace.SpaceId}: {availableSpace.Size}");
                            
                        }
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine("There are no available spaces left in this garage.");
                }
            }


            List<Space> spaces1 = new List<Space>
            {
                new Space(SizeType.Medium),
                new Space(SizeType.Small),
            };

            List<Space> spaces2 = new List<Space>
            {
                new Space(SizeType.Medium),
                new Space(SizeType.Large),
            };

            List<Floor> floors = new List<Floor>
            {
                new Floor(spaces1),
                new Floor(spaces2),
            };

            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car("AXY1 WRX"),
                new Car("RY74 LYZ"),
                new Van("FGYZ 45X"),
                new Bike("FP2F DD0"),
                new Van("DG3D X9L")
                
            };

            Garage garage = new(floors);

            Console.WriteLine("Welcome to Bristol Garage \r\n");
            Print(garage);
            Console.WriteLine("");

            foreach (Vehicle vehicleToPark in vehicles)
            {
                vehicleToPark.ParkVehicle(garage);
                //pay if implements IPayPark interface
                if (garage.NumFloorsWithSpace == 0)
                {
                    Console.WriteLine("Garage full.");
                    break;
                }
        

                Print(garage);
                Console.WriteLine("");
            }

            Console.WriteLine($"Bristol garage has made £{garage.MoneyMade} today!");
            


        }
    }
}
