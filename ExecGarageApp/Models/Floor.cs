using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GarageApp.Models.Size;

namespace GarageApp.Models
{
    public class Floor
    {
        public static int FloorCount = 0;
        public int NumAvailableSpaces;
        public bool FloorFull { get; private set; }
        public int FloorID { get; }
        public List<Space> Spaces { get; private set; }
        public List<Space> AvailableSpaces { get; private set; }
        public Floor(List<Space> spaces)
        {
            FloorCount++;
            FloorID = FloorCount;
            NumAvailableSpaces = spaces.Count;
            FloorFull = false;
            Spaces = spaces;
            AvailableSpaces = Spaces;
        }

        public void FillSpace(Space space)
        {
            NumAvailableSpaces--;
            AvailableSpaces.Remove(space);
            space.Occupy(); //maybe don't need this field for space if part of a floor;
            if (NumAvailableSpaces== 0 )
            {
                FloorFull = true;
            }
        }
             
    }
}
