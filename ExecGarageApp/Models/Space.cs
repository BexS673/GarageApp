using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GarageApp.Models.Size;

namespace GarageApp.Models
{
    public class Space
    {

        public static int SpaceCount = 0;
        public int SpaceId { get; }
        public SizeType Size { get; }
        private bool isOccupied;
        public bool IsOccupied { get; private set; }


        public Space(SizeType size)
        {
            SpaceCount++;
            Size = size;
            isOccupied = false;
            SpaceId = SpaceCount;
        }

        public void Occupy()
        {
            isOccupied = true;
            
        }
    }
}
