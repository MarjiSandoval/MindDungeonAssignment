using MindDungeon_Lib.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindDungeon_Lib.Entities
{
    public class Wizzard :Warrior,IPlayable
    {
        public override void Attack()
        {
            Console.WriteLine("You used magic.");
        }
    }
}
