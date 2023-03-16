using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageApp.Models;

namespace GarageApp.Interfaces
{
    internal interface IPayPark
    {
        void PayForParking(Garage garage);
    }
}

//whats the point of this? Maybe a motorbike does not need to pay