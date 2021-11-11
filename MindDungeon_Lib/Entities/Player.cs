using MindDungeon_Lib.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindDungeon_Lib.Entities
{
    public class Player:IPlayable
    {
        public IPlayable SelectedCharacter { get; set; }
        public string Name { get; set; }
    }
}
