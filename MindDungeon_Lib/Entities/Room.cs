using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindDungeon_Lib.Entities
{
   public  class Room
    {
        List<string> Doors = new List<string>();
        public Room(List<string> doors)
        {
            Doors = doors;
        }
    }
}
