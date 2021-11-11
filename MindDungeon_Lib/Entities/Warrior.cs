using MindDungeon_Lib.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindDungeon_Lib.Entities
{
    public class Warrior:IPlayable
    {

        public virtual void Attack()
        {
            Console.WriteLine("You swung an axe;");
        }
    }
}
