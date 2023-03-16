using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Models
{
    public class Garage
    {
        public List<Floor> Floors {get; }
        private int numFloorsWithSpace;
        
        public int NumFloorsWithSpace 
        { 
            get
                { return numFloorsWithSpace; }

            set { numFloorsWithSpace = value; }
        }

        public double MoneyMade { get; private set; }   

        public Garage(List<Floor> floors)
        {
            Floors = floors;
            NumFloorsWithSpace = floors.Count();
            MoneyMade = 0.00;
        }

        public void FloorFilled()
        {
            numFloorsWithSpace --;

        }

        public void AddToPot(double payment)
        {
            MoneyMade += payment;
        }

       
    }
}
