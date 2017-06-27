using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinderBattleManager.Models
{
    public class Mob
    {
        public string Name { get; set; }
        public IEnumerable<Character> Characters { get; set; }
    }
}
